using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.DataLayer;
using QUANLYHOSONHANVIEN.Controller;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmThemChucVu : DevComponents.DotNetBar.Office2007Form
    {
        public frmThemChucVu()
        {
            InitializeComponent();
        }
        ChucVuCtr ctr = new ChucVuCtr();
        ChucVuData data = new ChucVuData();
        private void frmThemChucVu_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiChucVuDataGridview(dataGridViewChucVu);
            if (dataGridViewChucVu.Rows.Count > 0)
            {
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            long ma = ThamSo.TaoMaChucVu;
            ThamSo.TaoMaChucVu = ma + 1;
            string maso = "CV" + ma.ToString();
            txtma.Text = maso;
            txtten.Text = "";
            txtphucap.Text = "";
            btnThemMoi.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemChucvu(txtma.Text, txtten.Text.ToString(), txtphucap.Text.ToString());
                loaddata();
                btnThemMoi.Enabled = false;
            }
        }
        private bool kiemtra()
        {
            if (txtten.Text == "")
            {
                txtten.BackColor = Color.White;
                txtten.Focus();
                return false;
            }
            if (txtphucap.Text == "")
            {
                txtphucap.Text = "0";
                //txtphucap.Focus();
                //return false;
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewChucVu.CurrentRow;
            string macv = row.Cells["colmacv"].Value.ToString();
            if (kiemtra())
            {
                data.UpdateChucvu(txtten.Text, txtphucap.Text, macv);
                loaddata();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewChucVu.CurrentRow;
            string macv = row.Cells["colmacv"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá Chức vụ này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteChucvu(macv);
                loaddata();
            }
        }

        private void txtphucap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Bạn phải nhập số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void dataGridViewChucVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewChucVu.Rows[e.RowIndex];
            //Thong tin chính
            txtma.Text = row.Cells["colmacv"].Value.ToString();
            txtten.Text = row.Cells["coltencv"].Value.ToString();
            txtphucap.Text = row.Cells["colphucap"].Value.ToString();
        }
    }
}

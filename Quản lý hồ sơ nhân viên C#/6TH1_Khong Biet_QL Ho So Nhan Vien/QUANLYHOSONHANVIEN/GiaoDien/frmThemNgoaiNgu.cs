using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.DataLayer ;
using QUANLYHOSONHANVIEN.Controller;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmThemNgoaiNgu : DevComponents .DotNetBar .Office2007Form
    {
        public frmThemNgoaiNgu()
        {
            InitializeComponent();
        }
        NgoaiNguData data = new NgoaiNguData();
        NgoaiNguCtr ctr = new NgoaiNguCtr();
        private void frmThemNgoaiNgu_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiNGOAINGUDataGridview(dataGridViewNgoaingu);
            if (dataGridViewNgoaingu.Rows.Count > 0)
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
            long ma = ThamSo.TaoMaNGOAINGU;
            ThamSo.TaoMaNGOAINGU = ma + 1;
            string maso = "NN" + ma.ToString();
            txtmangoai.Text = maso;
            txttenngoai.Text = "";            
            btnThemMoi.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNgoaingu.CurrentRow;
            string mann = row.Cells["colmann"].Value.ToString();
            if (MessageBox.Show("Bạn muốn xoá ngoại ngữ này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteNGOAINGU(mann);
                loadData();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewNgoaingu.CurrentRow;
            string mann = row.Cells["colmann"].Value.ToString();
            if (kiemtra())
            {
                data.UpdateNGOAINGU(txttenngoai.Text, mann);
                loadData();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                data.ThemNGOAINGU(txtmangoai.Text, txttenngoai.Text.ToString());
                loadData();
                btnThemMoi.Enabled = false;
            }
        }
        private bool kiemtra()
        {
            if (txttenngoai.Text == "")
            {
                txttenngoai.BackColor = Color.White;
                txttenngoai.Focus();
                return false;
            }
            return true;
        }

        private void dataGridViewNgoaingu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNgoaingu.Rows[e.RowIndex];
            //Thong tin chính
            txtmangoai.Text = row.Cells["colmann"].Value.ToString();
            txttenngoai.Text = row.Cells["coltennn"].Value.ToString();
            
        }
    }
}

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
    public partial class frmThemChuyenNganh : DevComponents .DotNetBar .Office2007Form
    {
        public frmThemChuyenNganh()
        {
            InitializeComponent();
        }
        ChuyenNganhCtr ctr = new ChuyenNganhCtr();
        ChuyenNganhData data = new ChuyenNganhData();

        private void frmThemChuyenNganh_Load(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = false;
            ctr.HienthiNganhDaoTaoDataGridview(dataGridViewChuyenNganh);
            if (dataGridViewChuyenNganh.Rows.Count == 0)
            {
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = true;
            txtNganhdaotao.Text = "";
            txtHedaotao.Text = "";
            txtGhichu.Text = "";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string str = "" + txtNganhdaotao.Text.ToString() + txtHedaotao.Text.ToString() + txtGhichu.Text.ToString();
            MessageBox.Show(str);
            if(kiemtra())
            {
                data.ThemChuyenNganh(txtNganhdaotao.Text.ToString(), txtHedaotao.Text.ToString(), txtGhichu.Text.ToString());
                ctr.HienthiNganhDaoTaoDataGridview(dataGridViewChuyenNganh);
            }
        }

        private bool kiemtra()
        {
            if (txtNganhdaotao.Text == "")
            {
                txtNganhdaotao.BackColor = Color.Yellow;
                txtNganhdaotao.Focus();
                return false;
            }
            if (txtHedaotao.Text == "")
            {
                txtHedaotao.BackColor = Color.Yellow;
                txtHedaotao.Focus();
                return false;
            }
            if (txtGhichu.Text == "")
            {
                txtGhichu.Text = "Chưa có";
            }
            return true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                DataGridViewRow row = dataGridViewChuyenNganh.CurrentRow;
                string maCN = row.Cells["colmacm"].Value.ToString();
                data.UpdateChuyenNganh(txtNganhdaotao.Text.ToString(), txtHedaotao.Text.ToString(), txtGhichu.Text.ToString(), maCN.ToString());
                ctr.HienthiNganhDaoTaoDataGridview(dataGridViewChuyenNganh);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewChuyenNganh.CurrentRow;
            string maCN = row.Cells["colmacm"].Value.ToString();
            //MessageBox.Show(row.Cells["colmacm"].Value.ToString());
            if (MessageBox.Show("Bạn muốn xoá chuyên môn này ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                data.DeleteChuyenNganh(maCN.ToString());
                ctr.HienthiNganhDaoTaoDataGridview(dataGridViewChuyenNganh);
            }
        }

        private void dataGridViewChuyenNganh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewChuyenNganh.Rows[e.RowIndex];

            txtNganhdaotao.Text = row.Cells["colnganhdaotao"].Value.ToString();
            txtHedaotao.Text = row.Cells["colhedaotao"].Value.ToString();
            txtGhichu.Text = row.Cells["colghichu"].Value.ToString();
        }
    }
}

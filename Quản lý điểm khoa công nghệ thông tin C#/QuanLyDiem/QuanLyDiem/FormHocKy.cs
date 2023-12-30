using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BLL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormHocKy : Form
    {
        public FormHocKy()
        {
            InitializeComponent();
        }
        ClassBLL business = new ClassBLL();
        private void FormHocKy_Load(object sender, EventArgs e)
        {
            dgvHocKy.DataSource = business.ShowData("HocKy");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int dong;
        private void dgvHocKy_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtMaHocKy.Text = dgvHocKy.Rows[dong].Cells[0].Value.ToString();
            txtTenHocKy.Text = dgvHocKy.Rows[dong].Cells[1].Value.ToString();
            txtNamHoc.Text = dgvHocKy.Rows[dong].Cells[2].Value.ToString();
            dtpBatDau.Text = dgvHocKy.Rows[dong].Cells[3].Value.ToString();
            dtpKetThuc.Text = dgvHocKy.Rows[dong].Cells[4].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?","Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "MaHK='" + txtMaHocKy.Text + "'";
                business.Delete("HocKy", sql);
                FormHocKy_Load(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHocKy.Text!="")
            {
                if (business.Proc_Insert("Insert_HocKy", txtMaHocKy.Text))
                {
                    string sql = "'" + txtMaHocKy.Text + "','" + txtTenHocKy.Text + "','" + txtNamHoc.Text + "','" + dtpBatDau.Text + "','" + dtpKetThuc.Text + "'";
                    business.Insert("HocKy", sql);
                    FormHocKy_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã Học Kỳ đã tồn tại");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "TenHK='" + txtTenHocKy.Text + "',NamHoc='" + txtNamHoc.Text + "',TGBatDau='" + dtpBatDau.Text + "',TGKetThuc='" + dtpKetThuc.Text + "' where MaHK='"+txtMaHocKy.Text+"'";
            business.Update("HocKy",sql);
            FormHocKy_Load(sender,e);
        }

        private void txtMaHocKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

    }
}

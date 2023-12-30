using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using BLL;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormPhanQuyen : Form
    {
        public FormPhanQuyen()
        {
            InitializeComponent();
        }
        BLL.ClassBLL business = new ClassBLL();
        private void FormPhanQuyen_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = business.ShowData("Users");
        }
        int dong;
        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            txtTenDangNhap.Text = dgvUsers.Rows[dong].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvUsers.Rows[dong].Cells[1].Value.ToString();
            if (dgvUsers.Rows[dong].Cells[2].Value.ToString() == "admin")
            {
                cmbQuyen.SelectedIndex = 1;
            }
            else
            {
                cmbQuyen.SelectedIndex = 0;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if(txtTenDangNhap.Text!="")
            {
                if(business.Proc_Insert("Insert_Users",txtTenDangNhap.Text))
                {
                    string sql = "'" + txtTenDangNhap.Text + "','" + txtMatKhau.Text + "','" + cmbQuyen.SelectedItem.ToString() + "'";
                    business.Insert("Users",sql);
                    FormPhanQuyen_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Username này đã tồn tại");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?","Hệ Thống", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string sql = "Username='" + txtTenDangNhap.Text + "'";
                business.Delete("Users", sql);
                FormPhanQuyen_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Password='" + txtMatKhau.Text + "',Quyen='" + cmbQuyen.SelectedItem.ToString() + "' where Username='"+txtTenDangNhap.Text+"'";
            business.Update("Users",sql);
            FormPhanQuyen_Load(sender, e);
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
   
    }
}

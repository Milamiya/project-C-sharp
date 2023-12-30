using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyDiem
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        BLL.ClassBLL business = new BLL.ClassBLL();
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int quyen=business.CheckLogin(txtTenDangNhap.Text, txtMatKhau.Text);
            if (quyen != -1)
            {
                Form9.quyen = quyen;
                Form9 f = (Form9)this.MdiParent;
                f.PhanQuyenMenu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Mật Khẩu !!");
            }
        }
    }
}

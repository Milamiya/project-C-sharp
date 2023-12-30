using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace QuanLyXeVaXe
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static TextBox tb = new TextBox();

        
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            switch (comboBox1.Text)
            {
                case "Khách hàng":
                    frmMain f = new frmMain(3);
                    f.Show();
                    this.Hide();
                    break;
                case "Nhân viên":
                    if (db.CheckLogin(txtUser.Text, txtPass.Text) != "")
                    {
                        if (db.CheckLogin(txtUser.Text, txtPass.Text) == "nhanvien")
                        {
                            tb.Text = "nhanvien";
                            frmMain f1 = new frmMain(2);
                            f1.Show();
                            this.Hide();
                            MessageBox.Show("Chúc mừng nhân viên đăng nhập thành công", "HaNoi Transerco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại", "HaNoi Transerco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case "Admin":
                    if (db.CheckLogin(txtUser.Text, txtPass.Text) != "")
                    {
                        if (db.CheckLogin(txtUser.Text, txtPass.Text) == "admin")
                        {
                            tb.Text = "admin";
                            frmMain f2 = new frmMain(1);
                            f2.Show();
                            this.Hide();
                            MessageBox.Show("Chúc mừng Admin đăng nhập thành công", "HaNoi Transerco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại", "HaNoi Transerco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmDangKyTaiKhoan f = new frmDangKyTaiKhoan();
            f.Show();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

//DBAccess db = new DBAccess();
//if (db.CheckLogin(txtUser.Text, txtPass.Text) != "")
//{
//    if (db.CheckLogin(txtUser.Text, txtPass.Text) == "admin")
//    {
//        tb.Text = "admin";
//        main f = new main();
//        f.Show();
//        this.Hide();
//        MessageBox.Show("Chúc mừng admin đăng nhập thành công", "HaNoi Transerco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

//    }


//    else
//    {
//        MessageBox.Show("Dang nhap that bai", "loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//    }
//}
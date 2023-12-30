using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmDangNhap : Form
    {
        public frmMain mainForm;
        public frmDangNhap(frmMain fm)
        {
            InitializeComponent();
            mainForm = fm;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matkhau = txtMatKhau.Text.Trim();
            try
            {
                if (tenDN == "")
                {
                    MessageBox.Show("Thiếu tên đăng nhập!", "Chú ý!");
                    txtTenDangNhap.Select();
                    return;
                }
                if(matkhau=="")
                {
                    MessageBox.Show("Hãy nhập mật khẩu!", "Chú ý!");
                    txtMatKhau.Select();
                    return;
                }
                string select = "SELECT * FROM tblDangNhap";
                SqlDataReader dr = DataConn.ThucHienReader(select);
                Boolean kt = false;
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == tenDN && dr.GetString(1) == matkhau)
                        {
                            kt = true;
                            mainForm.DisplayAll();
                            MessageBox.Show("Đăng nhập thành công!");
                            this.Close();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();

                if (kt == false)
                    MessageBox.Show("Bạn nhập sai tên đăng nhập hoặc mật khẩu!");
            }
            catch (NotEnoughInfoException)
            {
                MessageBox.Show("Bạn hãy nhập tên đăng nhập và mật khẩu!");
            }
        }

        public void btnThoatDN_Click(object sender, EventArgs e)
        {
            mainForm.NotDisplayAll();
            MessageBox.Show("Đăng xuất thành công!");
            this.Close();
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            frmDoiPass doipass = new frmDoiPass();
            doipass.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Enities;
using Lop2_BUS;

namespace Lop1_GUI
{
    public partial class frm4Admin : Form
    {
        public frm4Admin()
        {
            InitializeComponent();
            tbAD = OBJAD.gettb_ADMIN();
           
            
        }
        B_Admin OBJAD = new B_Admin();
        DataTable tbAD;
//         public static string TenDangNhap;
//         public static string MatKhau;

        private void Login()
        {
                B_Admin us = new B_Admin(txtTenDangNhap.Text, txtMatKhau.Text);
                if (us.Log_In() == true)
                {

                  
                    frm3ChinhSuaDuLieu f = new frm3ChinhSuaDuLieu();
                    f.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Sai Tên Đăng Nhập Hoặc Passwords /nVui Lòng Kiểm Tra Lại");
            
        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text.Equals("ĐĂNG KÝ"))
            {
                this.Size = new System.Drawing.Size(798, 389);
                this.Location = new Point(this.Location.X, this.Location.Y - 40);
                btnDangKi.Text = "HỦY";
            }
            else
            {
                this.Size = new System.Drawing.Size(405, 389);
                this.Location = new Point(this.Location.X, this.Location.Y + 40);
                btnDangKi.Text = "ĐĂNG KÝ";
            }

        }
        private void btnXemChuoi_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.UseSystemPasswordChar == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                return;
            }
            if (txtMatKhau.UseSystemPasswordChar == false)
            {
                txtMatKhau.UseSystemPasswordChar = true;
                return;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Nhập Tên Đăng Nhập !!!");
            }
           else if(txtMatKhau.Text=="")
            {
                MessageBox.Show("Nhập Mật Khẩu !!!");
            }
          
            else
              Login();
            
            
        }

        private void picHuy_Click(object sender, EventArgs e)
        {
            frm2HienThiChinh f = new frm2HienThiChinh();
            f.Show();
            this.Close();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(405, 389);
            this.Location = new Point(this.Location.X, this.Location.Y + 40);
          
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(txtTenDanNhapDK.Text==""||txtPassDK.Text==""||txtHo.Text==""||txtTen.Text==""||txtDiaChi.Text==""||txtCMND.Text==""||txtChuoiSoBiMat.Text=="")
            {
                MessageBox.Show("Nhập Thiếu Thông Tin!");
            }
            else
            {

            
            DataRow r = tbAD.NewRow();
            r[0] = txtTenDanNhapDK.Text;
            r[1] = txtPassDK.Text;
            r[2] = txtHo.Text;
            r[3] = txtTen.Text;
            r[4] = txtDiaChi.Text;
            r[5] = txtCMND.Text;
            r[6] = txtChuoiSoBiMat.Text;
            if (txtPassDK.Text != txtNhapLaiPASS.Text)
            {
                MessageBox.Show("Password Xác Nhận Không Giống Password,Kiểm tra lại !!");
                txtPassDK.Text = "";
                txtNhapLaiPASS.Text = "";
                txtPassDK.Focus();
            }
            else
            {
                tbAD.Rows.Add(r);
                MessageBox.Show("ĐĂNG KÍ THÀNH CÔNG !");
                OBJAD.DangKi_Admin(tbAD);
            }
            }
        }

        private void frm4Admin_Load(object sender, EventArgs e)
        {
            txtPassDK.UseSystemPasswordChar = true;
            txtNhapLaiPASS.UseSystemPasswordChar = true;
        }

        private void txtNhapLaiPASS_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtHo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void chkHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienPass.Checked == true)
            {
                txtNhapLaiPASS.UseSystemPasswordChar = false;
            }
            else
                txtNhapLaiPASS.UseSystemPasswordChar = true;
        }
          
        }

  
    }


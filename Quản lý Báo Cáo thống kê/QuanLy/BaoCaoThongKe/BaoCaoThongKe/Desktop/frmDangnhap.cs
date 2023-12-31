using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class frmDangnhap : Form
    {
        public frmDangnhap()
        {
            InitializeComponent();
        }
        public static bool dn = false;
        DataService cn = new DataService();

        bool kiemtra = false;
        Dangnhap_Ctrl ctrl = new Dangnhap_Ctrl();
        int dem = 0;
        public int sosanh = 0;

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtTenDangNhap.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = txtTenDangNhap.Text = "";
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DataService.str_db_server = txtServer.Text;
            DataService.str_db_user = txtUser.Text;
            DataService.str_db_password = txtPass.Text;
            cn = new DataService();
            if (dn == true)
            {
                if (ctrl.KiemTra(txtTenDangNhap, txtMatKhau))
                {
                    if (ctrl.DangNhap(txtTenDangNhap, txtMatKhau))
                    {
                        if (ctrl.quyen == "Admin")
                        {
                            MessageBox.Show("admin");
                            txtTenDangNhap.Text = txtMatKhau.Text = "";
                            sosanh = 1;
                            this.Close();
                        }
                        if (ctrl.quyen == "Quản lý")
                        {
                            MessageBox.Show("quản lý");
                            txtTenDangNhap.Text = txtMatKhau.Text = "";
                            sosanh = 2;
                            this.Close();
                        }
                        if (ctrl.quyen == "Nhập liệu")
                        {
                            MessageBox.Show("nhập liệu");
                            txtTenDangNhap.Text = txtMatKhau.Text = "";
                            sosanh = 3;
                            this.Close();
                        }
                        kiemtra = true;
                    }
                    else
                    {
                        dem++;
                        if (dem >= 3)
                        {
                            MessageBox.Show("Bạn đăng nhập " + dem + " lần không thành công !", "Đăng Nhập");
                            txtMatKhau.Text = txtTenDangNhap.Text = "";
                            DialogResult = DialogResult.Cancel;
                            sosanh = 0;
                            kiemtra = false;
                        }
                        else
                        {
                            MessageBox.Show("Bạn đăng nhập không thành công !", "Đăng Nhập");
                            sosanh = 0;
                            kiemtra = false;
                        }
                    }
                }
                else
                {
                    //lỗi
                }
            }
            else
            {
                MessageBox.Show("Không thể kết nối với Server!  Xin chọn lại Srever");
            }
        }

        private void txtTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btn_ok_Click(sender, e);
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_ok_Click(sender, e);
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                btn_ok_Click(sender, e);
        }

        private void ckbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbServer.Checked == true)
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
                txtServer.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtPass.Enabled = false;
                txtServer.Enabled = false;
            }
        }

        private void frmDangnhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();
        }

        private void btn_cancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btn_ok_Click(sender, e);
        }


        
        
    }

}
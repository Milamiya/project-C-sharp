using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.Controller;
using QUANLYHOSONHANVIEN.DataLayer;
using QUANLYHOSONHANVIEN.BusinessObject ;

namespace QUANLYHOSONHANVIEN
{
    public partial class frmDangNhap : DevComponents.DotNetBar.Office2007Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        public bool status = false;
        //public DangNhapInfo thongtindn;
        public static  string TenDangNhap = "";

        DangNhapCtr ctr = new DangNhapCtr();
        DangNhapData data= new DangNhapData();
        private void butDangnhap_Click(object sender, EventArgs e)
        {
            //ctr.SetPassWord(texUsername.Text.Trim(), texPassword.Text.Trim());
            if (texUsername.Text == "" || texPassword.Text == "")
            {
                texUsername.Focus();
            }
            else
            {
                loadData();
            }
        }

        public void loadData()
        {
            DataTable dta = data.DangNhap(texUsername.Text.Trim(), texPassword.Text.Trim());
            if (dta.Rows.Count == 0)
            {
                status = false;
                MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu Không đúng ...");
            }
            else
            {                
                status = true;
                TenDangNhap = texUsername.Text.Trim();
                //MessageBox.Show(TenDangNhap);
                tutuClose();
            }
        }

        private void tutuClose()
        {
            timer1.Enabled = true;
            
        }
        private void butHuy_Click(object sender, EventArgs e)
        {
            tutuClose();
            this.Close();
        }

        private void texUsername_Click(object sender, EventArgs e)
        {
            texUsername.Text = "";
        }

        public void texPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadData();
            }
        }

        private void texPassword_Click(object sender, EventArgs e)
        {
            texPassword.Text = "";
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this .Opacity -= 0.05;
            if (this.Opacity == 0)
            {
                this.Close();
            }
        }
    }
}

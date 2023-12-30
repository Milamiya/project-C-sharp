using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.DataLayer ;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmDoiMatKhau : DevComponents .DotNetBar .Office2007Form 
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        DangNhapData data_dangnhap = new DangNhapData();
        NguoiDungData data = new NguoiDungData();
        string ten = "";

        public frmDoiMatKhau(string str)
            : this()
        {
            ten = str;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            if (ten != "")
            {
                txtUsername.Text = ten;
            }
        }

        private bool kiemtra()
        {
            if (txtUsername.Text == "")
            {
                txtUsername.BackColor = Color.Yellow;
                txtUsername.Focus();
                return false;
            }
            if (txtPass1.Text == "")
            {
                txtPass1.BackColor = Color.Yellow;
                txtPass1.Focus();
                return false;
            }
            if (txtpass2.Text == "")
            {
                txtpass2.BackColor = Color.Yellow;
                txtpass2.Focus();
                return false;
            }
            if (txtPass1.Text != txtpass2.Text)
            {
                txtpass2.BackColor = Color.Yellow;
                pictureBox1.Visible = true;
                return false;
            }
            else
            {
                pictureBox1.Visible = false;
                return true;
            }
            return true;
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
            txtPass1.BackColor = Color.White;
            txtpass2.BackColor = Color.White;
        }

        private void txtpass2_Leave(object sender, EventArgs e)
        {
            kiemtra();
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                if (data_dangnhap.isExitUserName(txtUsername.Text.Trim()))
                {
                    data.DoiMatKhau(txtUsername.Text.Trim(), txtPass1.Text );
                    MessageBox.Show("Thành Công");
                    this.Close();
                }
                else {
                    MessageBox.Show("Không tồn tại Username này !");
                    txtUsername.Focus();
                }
            }
        }
    }
}

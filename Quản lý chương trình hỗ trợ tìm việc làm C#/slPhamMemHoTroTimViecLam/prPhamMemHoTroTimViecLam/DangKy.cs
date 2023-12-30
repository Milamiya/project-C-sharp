using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Tier;
using Entities;

namespace prPhamMemHoTroTimViecLam
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
        private void kiemtra()
        {
            if (txtTenDangnhap.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập");
            }
            else if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else if (txtnhaplaiMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lai mật khẩu");
            }
        }
        private void txtMatkhau_TextChanged(object sender, EventArgs e)
        {
            if (txtnhaplaiMK.Text == txtMatkhau.Text && txtnhaplaiMK.Text != "" && txtMatkhau.Text != "")
            {
                lblHienthongbao.Visible = true;
            }
            else
            {
                lblHienthongbao.Visible = false;
            }
        }

        private void txtnhaplaiMK_TextChanged(object sender, EventArgs e)
        {
            if (txtnhaplaiMK.Text == txtMatkhau.Text && txtnhaplaiMK.Text != "" && txtMatkhau.Text != "")
            {
                lblHienthongbao.Visible = true;
            }
            else
            {
                lblHienthongbao.Visible = false;
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            kiemtra();
            B_DangKy obj = new B_DangKy();
            E_DangKy dk = new E_DangKy(txtTenDangnhap.Text, txtMatkhau.Text);
            int loi = obj.Dangkytaikhoan(dk);
            if (loi == 0)
            {
                MessageBox.Show("Chúc mừng bạn đăng ký thành công");
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại mời đăng ký lại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }
    }
}

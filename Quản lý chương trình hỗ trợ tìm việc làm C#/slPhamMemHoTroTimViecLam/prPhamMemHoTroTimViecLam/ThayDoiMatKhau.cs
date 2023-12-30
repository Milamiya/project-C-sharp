using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities;
using Business_Tier;

namespace prPhamMemHoTroTimViecLam
{
    public partial class ThayDoiMatKhau : Form
    {
        public ThayDoiMatKhau()
        {
            InitializeComponent();
        }
        B_DangKy obj = new B_DangKy();
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMatkhauMoi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else if (txtNhaplaiMK.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu");
            }
            else if (txtMatkhauMoi.Text != txtNhaplaiMK.Text)
            {
                MessageBox.Show("Mật khẩu khôn trùng khớp");

            }
            else
            {
                E_DangKy objDK = new E_DangKy(txtTenDN.Text, txtMatkhauMoi.Text);

                int loi = obj.CapnhatTK(objDK);
                if (loi == 0)
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công");
                    txtMatkhauMoi.Text = "";
                    txtNhaplaiMK.Text = "";
                    txtMatkhauMoi.Focus();
                }
                else if (loi == 2)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại");
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không? ", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                Close();
        }

        private void ThayDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = DangNhap.tendangnhap;
            txtTenDN.Enabled = false;
        }

        private void txtMatkhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (txtMatkhauMoi.Text == txtNhaplaiMK.Text && txtMatkhauMoi.Text != "" && txtNhaplaiMK.Text != "")
            {
                lblHienthi.Visible = true;
            }
            else
                lblHienthi.Visible = false;
        }

        private void txtNhaplaiMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMatkhauMoi.Text == txtNhaplaiMK.Text && txtMatkhauMoi.Text != "" && txtNhaplaiMK.Text != "")
            {
                lblHienthi.Visible = true;
            }
            else
                lblHienthi.Visible = false;
        }

        private void btnLamRong_Click(object sender, EventArgs e)
        {
            txtMatkhauMoi.Text = "";
            txtNhaplaiMK.Text = "";
        }
    }
}

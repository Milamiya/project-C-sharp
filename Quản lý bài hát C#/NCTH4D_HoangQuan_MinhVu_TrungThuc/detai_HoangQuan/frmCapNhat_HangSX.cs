using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_Tier;

namespace detai_HoangQuan
{
    public partial class frmCapNhat_HangSX : Form
    {
        public frmCapNhat_HangSX()
        {
            InitializeComponent();
        }
        public string ma, ten, thongtin;
        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenHangSX.Text = txtThongTin.Text = "";
            txtTenHangSX.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NhaSanXuat_BUS objHangSX;
            try
            {
                objHangSX = new NhaSanXuat_BUS(txtMaHangSX.Text, txtTenHangSX.Text, txtThongTin.Text);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                {
                    txtMaHangSX.Focus();
                    return;
                }
                else if (loi.Contains("tên"))
                {
                    txtTenHangSX.Focus();
                    return;
                }
                else
                    txtThongTin.Text = "Chưa có thông tin cho hãng sản xuất !! == > bấm [Đồng ý] lần nữa để lưu hãng sản xuất này !";
                return;
            }
            NhaSanXuat_BUS a = new NhaSanXuat_BUS(txtMaHangSX.Text, txtTenHangSX.Text, txtThongTin.Text);
            int resutl = a.capnhapHangSX();
            if (resutl == 0)
                MessageBox.Show("Cập nhật thành công hãng sản xuất [" + txtTenHangSX.Text + "] với mã hãng sản xuất là [" + txtMaHangSX.Text + "]");
            else
                MessageBox.Show("That bai");

            this.DialogResult = DialogResult.OK;
        }

        private void frmCapNhat_HangSX_Load(object sender, EventArgs e)
        {
            txtMaHangSX.Text = ma;
            txtTenHangSX.Text = ten;
            txtThongTin.Text = thongtin;
            this.Text = "Cập nhật HÃNG SẢN XUẤT [" + ten + "]";
            txtTenHangSX.SelectAll(); txtTenHangSX.Focus();
        }
    }
}

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
    public partial class frmThem_NhaSanXuat : Form
    {
        public frmThem_NhaSanXuat()
        {
            InitializeComponent();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaHangSX.Text = txtTenHangSX.Text = txtThongTin.Text = "";
            txtMaHangSX.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            NhaSanXuat_BUS objNhaSX;
            try
            {
                objNhaSX = new NhaSanXuat_BUS(txtMaHangSX.Text, txtTenHangSX.Text, txtThongTin.Text);
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
            int resutl = a.themNhaSX();
            if (resutl == 0)
                MessageBox.Show("Thêm thành công hãng sản xuất [" + txtTenHangSX.Text + "] với mã hãng sản xuất là [" + txtMaHangSX.Text + "]");
            else
                MessageBox.Show("Thất bại rồi ! mã [" + txtMaHangSX.Text + "] đã tồn tại");
            this.DialogResult = DialogResult.OK;
        }
    }
}

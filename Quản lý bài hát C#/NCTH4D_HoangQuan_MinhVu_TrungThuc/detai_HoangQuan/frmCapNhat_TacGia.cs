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
    public partial class frmCapNhat_TacGia : Form
    {
        public frmCapNhat_TacGia()
        {
            InitializeComponent();
        }
        public string ma, ten, thongtin;
        private void frmCapNhat_TacGia_Load(object sender, EventArgs e)
        {
            txtMaTacGia.Text = ma;
            txtTenTacGia.Text = ten;
            txtThongTin.Text = thongtin;
            this.Text = "Cập nhập TÁC GIẢ [" + ten + "]";
            txtTenTacGia.SelectAll(); txtTenTacGia.Focus();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenTacGia.SelectAll(); txtTenTacGia.Focus(); txtThongTin.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TacGia_BUS objTacGia;
            try
            {
                objTacGia = new TacGia_BUS(txtMaTacGia.Text, txtTenTacGia.Text, txtThongTin.Text);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                {
                    txtMaTacGia.Focus();
                    return;
                }
                else if (loi.Contains("tên"))
                {
                    txtTenTacGia.Focus();
                    return;
                }
                else
                    txtThongTin.Text = "Chưa có thông tin cho tác giả !! == > bấm [Đồng ý] lần nữa để lưu tác giả này !";
                return;
            }
            TacGia_BUS a = new TacGia_BUS(txtMaTacGia.Text, txtTenTacGia.Text, txtThongTin.Text);
            int resutl = a.capnhapCaSi();
            if (resutl == 0)
                MessageBox.Show("Cập nhật thành công tác giả [" + txtTenTacGia.Text + "] với mã tác giả là [" + txtMaTacGia.Text + "]");
            else
                MessageBox.Show("That bai");

            this.DialogResult = DialogResult.OK;
        }
    }
}

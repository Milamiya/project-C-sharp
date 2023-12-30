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
    public partial class frmCapnhat_Casi : Form
    {
        public frmCapnhat_Casi()
        {
            InitializeComponent();
        }
        public string ma, ten, thongtin;
        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenCasi.SelectAll(); txtTenCasi.Focus(); txtThongTin.Clear();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CaSi_BUS objCasi;
            try
            {
                objCasi = new CaSi_BUS(txtMaCasi.Text, txtTenCasi.Text,txtThongTin.Text);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                {
                    txtMaCasi.Focus();
                    return;
                }
                else if (loi.Contains("tên"))
                {
                    txtTenCasi.Focus();
                    return;
                }
                else
                    txtThongTin.Text = "Chưa có thông tin cho ca sĩ !! == > bấm [Đồng ý] lần nữa để lưu ca sĩ này !";
                return;
            }
            CaSi_BUS a = new CaSi_BUS(txtMaCasi.Text, txtTenCasi.Text, txtThongTin.Text);
            int resutl = a.capnhapCaSi();
            if (resutl == 0)
                MessageBox.Show("Cập nhật thành công ca sĩ [" + txtTenCasi.Text + "] với mã ca sĩ là [" + txtMaCasi.Text + "]");
            else
                MessageBox.Show("That bai");

            this.DialogResult = DialogResult.OK;
        }

        private void frmCapnhat_Casi_Load(object sender, EventArgs e)
        {
            txtMaCasi.Text = ma;
            txtTenCasi.Text = ten;
            txtThongTin.Text = thongtin;
            this.Text = "Cập nhập CA SĨ [" + ten + "]";
            txtTenCasi.SelectAll(); txtTenCasi.Focus();
        }
    }
}

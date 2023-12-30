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
    public partial class frmThem_Casi : Form
    {
        public frmThem_Casi()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CaSi_BUS objCasi;
            try
            {
                objCasi = new CaSi_BUS(txtMaCasi.Text, txtTenCasi.Text, txtThongTin.Text);
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
            int resutl = a.themCaSi();
            if (resutl == 0)
                MessageBox.Show("Thêm thành công ca sĩ [" + txtTenCasi.Text + "] với mã ca sĩ là [" + txtMaCasi.Text + "]");
            else
                MessageBox.Show("Thất bại rồi ! mã ["+txtMaCasi.Text+"] đã tồn tại");
            this.DialogResult = DialogResult.OK;
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaCasi.Text = txtTenCasi.Text = txtThongTin.Text = "";
            txtMaCasi.Focus();
        }
    }
}

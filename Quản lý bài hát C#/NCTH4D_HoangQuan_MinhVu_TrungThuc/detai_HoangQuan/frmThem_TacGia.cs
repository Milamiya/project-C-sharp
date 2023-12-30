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
    public partial class frmThem_TacGia : Form
    {
        public frmThem_TacGia()
        {
            InitializeComponent();
        }

        private void frmThem_TacGia_Load(object sender, EventArgs e)
        {

        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMatacGia.Text = txtTenTacGia.Text = txtThongTin.Text = "";
            txtMatacGia.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TacGia_BUS objTacGia;
            try
            {
                objTacGia = new TacGia_BUS(txtMatacGia.Text, txtTenTacGia.Text, txtThongTin.Text);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                {
                    txtMatacGia.Focus();
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

            TacGia_BUS a = new TacGia_BUS(txtMatacGia.Text, txtTenTacGia.Text, txtThongTin.Text);
            int resutl = a.themTacGia();
            if (resutl == 0)
                MessageBox.Show("Thêm thành công ca sĩ [" + txtTenTacGia.Text + "] với mã ca sĩ là [" + txtMatacGia.Text + "]");
            else
                MessageBox.Show("Thất bại rồi ! mã [" + txtMatacGia.Text + "] đã tồn tại");
            this.DialogResult = DialogResult.OK;
        }
    }
}

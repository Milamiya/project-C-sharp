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
    public partial class frmThem_TheLoai : Form
    {
        public frmThem_TheLoai()
        {
            InitializeComponent();
        }

        private void frmThem_TheLoai_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheLoai_BUS objTheLoai;
            try
            {
                objTheLoai = new TheLoai_BUS(txtMaTheLoai.Text, txtTenTheLoai.Text);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                    txtMaTheLoai.Focus();
                else if (loi.Contains("tên"))
                    txtTenTheLoai.Focus();
                
                return;
            }
            TheLoai_BUS tl = new TheLoai_BUS(txtMaTheLoai.Text, txtTenTheLoai.Text);
            int resutl = tl.themTheLoai();
            if (resutl == 0)
                MessageBox.Show("Thêm thành công thể loại [" + txtTenTheLoai.Text + "] với mã thể loại là [" + txtMaTheLoai.Text + "]");
            else
                MessageBox.Show("That bai");
            this.DialogResult = DialogResult.OK;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Text = txtTenTheLoai.Text = "";
            txtMaTheLoai.Focus();
        }
    }
}

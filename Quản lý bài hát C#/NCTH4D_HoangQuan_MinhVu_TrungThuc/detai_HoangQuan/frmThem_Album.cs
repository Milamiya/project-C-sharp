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
    public partial class frmThem_Album : Form
    {
        public frmThem_Album()
        {
            InitializeComponent();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaAlbum.Text = txtTenAlbum.Text = "";
            txtMaAlbum.Focus();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            Album_BUS objAbum;
            try
            {
                objAbum = new Album_BUS(txtMaAlbum.Text, txtTenAlbum.Text, txtnamphathanh.Text);
            }
            catch (Exception ex)
            {
                string loi = ex.Message;
                MessageBox.Show(loi, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (loi.Contains("mã"))
                    txtMaAlbum.Focus();
                else if (loi.Contains("tên"))
                    txtTenAlbum.Focus();
                else txtnamphathanh.Focus();
                return;
            }
            Album_BUS a = new Album_BUS(txtMaAlbum.Text, txtTenAlbum.Text, txtnamphathanh.Text);
            int resutl= a.themAlbum();
            if (resutl==0)
                MessageBox.Show("Thêm thành công album ["+txtTenAlbum.Text+"] với mã album là ["+txtMaAlbum.Text+"]");
            else
                MessageBox.Show("That bai");
            this.DialogResult = DialogResult.OK;
        }

        private void frmThem_Album_Load(object sender, EventArgs e)
        {

        }
    }
}

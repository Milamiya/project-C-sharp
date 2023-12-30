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
    public partial class frmCapNhat_Album : Form
    {
        public frmCapNhat_Album()
        {
            InitializeComponent();
        }
        public string ma, ten, namphathanh;
        private void frmCapNhat_Album_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật ALBUMM [" + ten + "]";
            txtMaAlbum.Text = ma;
            txtTenAlbum.Text = ten;
            txtnamphathanh.Text = namphathanh;
            txtTenAlbum.SelectAll(); txtTenAlbum.Focus();
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
            int resutl = a.capnhatalbum();
            if (resutl == 0)
                MessageBox.Show("Cập nhật thành công album [" + txtTenAlbum.Text + "] với mã album là [" + txtMaAlbum.Text + "]");
            else
                MessageBox.Show("That bai");
            
            this.DialogResult = DialogResult.OK;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtnamphathanh.Text = "";
            txtTenAlbum.Clear(); txtTenAlbum.Focus();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

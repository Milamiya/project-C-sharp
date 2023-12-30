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
    public partial class frmCapNhatTheLoai : Form
    {
        public frmCapNhatTheLoai()
        {
            InitializeComponent();
        }
        public string matheloai, tentheloai;
        private void frmCapNhatTheLoai_Load(object sender, EventArgs e)
        {
            txtMaTheLoai.Text = matheloai;
            txtTenTheLoai.Text = tentheloai;
            this.Text = "Cập nhật Thể Loại [" + tentheloai + "]";
            txtTenTheLoai.SelectAll(); txtTenTheLoai.Focus();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtTenTheLoai.Text = ""; txtTenTheLoai.Focus();
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
            TheLoai_BUS a = new TheLoai_BUS(txtMaTheLoai.Text, txtTenTheLoai.Text);
            int resutl = a.capnhatTheLoai();
            if (resutl == 0)
                MessageBox.Show("Cập nhật thành công thể loai [" + txtTenTheLoai.Text + "] với mã thể loại là [" + txtMaTheLoai.Text + "]");
            else
                MessageBox.Show("That bai");

            this.DialogResult = DialogResult.OK;
        }


    }
}

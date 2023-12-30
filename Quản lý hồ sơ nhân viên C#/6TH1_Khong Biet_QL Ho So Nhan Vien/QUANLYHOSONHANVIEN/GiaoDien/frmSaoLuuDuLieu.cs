using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QUANLYHOSONHANVIEN.Controller;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmSaoLuuDuLieu : DevComponents .DotNetBar.Office2007Form
    {
        public frmSaoLuuDuLieu()
        {
            InitializeComponent();
        }

        CoSoDuLieuCtr ctr = new CoSoDuLieuCtr();

        private void frmSaoLuuDuLieu_Load(object sender, EventArgs e)
        {
            txtDuongDan.Text = "C:\\bkdbQLHSNS" + ".db";
            txtDuongDan.Focus();
        }

        private void btnDuongdan_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "File database|*.db";
            saveFileDialog1.Title = "Sao Luu CSDL";
            DialogResult r = saveFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
                this.txtDuongDan.Text = saveFileDialog1.FileName;
            if (txtDuongDan.Text == "")
            {
                MessageBoxEx.Show("Bạn phải nhập đường dẫn!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuongDan.Text = "C:\\bkdbQLHSNS" + ".db";
            }
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (ctr.SaoLuuDuLieu(txtDuongDan.Text))
                this.Close();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.Controller;
using DevComponents.DotNetBar;

namespace QUANLYHOSONHANVIEN.GiaoDien
{
    public partial class frmPhucHoiDuLieu : DevComponents.DotNetBar .Office2007Form
    {
        public frmPhucHoiDuLieu()
        {
            InitializeComponent();
        }

        CoSoDuLieuCtr ctr = new CoSoDuLieuCtr();

        private void frmPhucHoiDuLieu_Load(object sender, EventArgs e)
        {

        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if (ctr.PhucHoiDuLieu(txtDuongDan.Text))
                this.Close();
        }

        private void btnHuybo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuongdan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "File database|*.db";
            openFileDialog1.Title = "Phuc Hoi CSDL";
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
                this.txtDuongDan.Text = openFileDialog1.FileName;
            if (txtDuongDan.Text == "")
            {
                MessageBoxEx.Show("Bạn phải nhập đường dẫn!", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuongDan.Text = "C:\\bkdbQLHSNS" + ".db";
            }
        }
    }
}

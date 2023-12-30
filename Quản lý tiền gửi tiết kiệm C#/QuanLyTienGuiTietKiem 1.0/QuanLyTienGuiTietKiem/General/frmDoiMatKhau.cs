using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Controller;

namespace QuanLyTienGuiTietKiem.General
{
    public partial class frmDoiMatKhau : Office2007Form
    {
        PhanQuyenCtrl m_PhanQuyenCtrl = new PhanQuyenCtrl();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            txtMatKhauMoi.Focus();
            this.DialogResult = DialogResult.OK;
        }
    }
}
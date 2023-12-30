using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyHoSoCongChuc
{
    public partial class FrmDoiMatKhau : Office2007Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
 
            private void btnDongY_Click(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }   
       
    }
}
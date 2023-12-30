using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        //Download source code tại Sharecode.vn
        private void button1_Click(object sender, EventArgs e)
        {
            frmReTatCaXe f = new frmReTatCaXe();
            f.Show();
        }
    }
}

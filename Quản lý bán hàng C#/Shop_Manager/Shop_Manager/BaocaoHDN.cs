using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmBaocaoHDN : Form
    {
        public frmBaocaoHDN()
        {
            InitializeComponent();
        }

        private void frmBaocaoHDN_Load(object sender, EventArgs e)
        {
            HDNReport hdnrp = new HDNReport();
            rptHDN.ReportSource = hdnrp;
        }
    }
}
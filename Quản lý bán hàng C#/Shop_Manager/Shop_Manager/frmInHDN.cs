using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmInHDN : Form
    {
        string mahd = "";
        public frmInHDN()
        {
            InitializeComponent();
        }

        public frmInHDN(string MaHD)
        {
            InitializeComponent();
            mahd = MaHD;
        }

        private void frmInHDN_Load(object sender, EventArgs e)
        {
            InHdnReport inhdn = new InHdnReport();
            string select = "SELECT* FROM vInHDN WHERE MaHD='"+mahd+"'";
            DataSet ds = DataConn.GrdSource(select);
            inhdn.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = inhdn;
        }
    }
}
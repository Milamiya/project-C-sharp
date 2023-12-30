using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmInHDX : Form
    {
        public frmInHDX()
        {
            InitializeComponent();
        }

        string mahd = "";
        public frmInHDX(string MAHD)
        {
            InitializeComponent();
            mahd = MAHD;
        }

        private void frmInHDX_Load(object sender, EventArgs e)
        {
            InHdxReport inhdx = new InHdxReport();
            string select = "SELECT* FROM vInHDX WHERE MaHD='"+mahd+"'";
            inhdx.SetDataSource(DataConn.GrdSource(select).Tables[0]);
            crystalReportViewer1.ReportSource = inhdx;
        }

    }
}
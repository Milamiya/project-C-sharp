using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmInPhieu : Form
    {
        public frmInPhieu()
        {
            InitializeComponent();
        }

        string maphieu = "";
        public frmInPhieu(string MAPHIEU)
        {
            InitializeComponent();
            maphieu = MAPHIEU;
        }

        private void frmInPhieu_Load(object sender, EventArgs e)
        {
            InPhieuReport inphieu = new InPhieuReport();
            string select = "SELECT* FROM vInPhieu WHERE MaPhieu='"+maphieu+"'";
            inphieu.SetDataSource(DataConn.GrdSource(select).Tables[0]);
            crystalReportViewer1.ReportSource = inphieu;
        }
    }
}
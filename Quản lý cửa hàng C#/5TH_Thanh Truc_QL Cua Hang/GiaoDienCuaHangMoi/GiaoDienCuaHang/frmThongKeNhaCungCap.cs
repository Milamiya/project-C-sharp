using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmThongKeNhaCungCap : Form
    {
        public frmThongKeNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmThongKeNhaCungCap_Shown(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.NhaCungCapData ncc = new GiaoDienCuaHang.DataLayer.NhaCungCapData();
            DataTable TBL = ncc.LayDSNhaCungCap();
            CrystalReportNhaCungCap report = new CrystalReportNhaCungCap();
            report.SetDataSource(TBL);
            crystalReportViewer1.ReportSource = report;
        }

      
    }
}
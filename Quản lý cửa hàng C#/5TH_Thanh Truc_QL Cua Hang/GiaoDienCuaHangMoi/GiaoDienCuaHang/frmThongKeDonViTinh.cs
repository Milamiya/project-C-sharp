using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmThongKeDonViTinh : Form
    {
        public frmThongKeDonViTinh()
        {
            InitializeComponent();
        }

        private void frmThongKeDonViTinh_Shown(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.DonViTinhData dvt = new GiaoDienCuaHang.DataLayer.DonViTinhData();
            DataTable tbl = dvt.LayDSDonViTinh();
            CrystalReportDonviTinh report = new CrystalReportDonviTinh();
            report.SetDataSource(tbl);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
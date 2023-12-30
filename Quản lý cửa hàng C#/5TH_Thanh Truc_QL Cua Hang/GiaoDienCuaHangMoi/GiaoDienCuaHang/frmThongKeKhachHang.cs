using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmThongKeKhachHang : Form
    {
        public frmThongKeKhachHang()
        {
            InitializeComponent();
        }

      

        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void frmThongKeKhachHang_Shown(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.KhachHangData kh = new GiaoDienCuaHang.DataLayer.KhachHangData();
            DataTable tbl = kh.LayDSKhachHang();
            CrystalReportKhachHang report = new CrystalReportKhachHang();
            report.SetDataSource(tbl);
            crystalReportViewer1.ReportSource = report;
        }
    }
}
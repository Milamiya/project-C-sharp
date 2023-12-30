using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormReportKhachHang : Form
    {
        public FormReportKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLThUOC.DataLayer.KhachHangDATA kh = new QLThUOC.DataLayer.KhachHangDATA();
            DataTable tbl = kh.LayDSKhachHang();
            rptKhachHang report = new rptKhachHang();
            report.SetDataSource(tbl);

            CrystalReportViewerKhachHang.ReportSource = report;
        }
    }
}
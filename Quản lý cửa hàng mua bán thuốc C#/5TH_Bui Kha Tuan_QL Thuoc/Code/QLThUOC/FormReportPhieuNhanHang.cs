using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormReportPhieuNhanHang : Form
    {
        public FormReportPhieuNhanHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLThUOC.DataLayer.LapPhieuNhanHangDATA nh = new QLThUOC.DataLayer.LapPhieuNhanHangDATA();
            DataTable tbl = nh.DSPhieuNhanHang();
            rptPhieuNhanHang report = new rptPhieuNhanHang();
            report.SetDataSource(tbl);

            CrystalReportViewerPhieuNhanHang.ReportSource = report;
        }
    }
}
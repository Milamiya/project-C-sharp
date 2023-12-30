using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormReportPhieuNhapKho : Form
    {
        public FormReportPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLThUOC.DataLayer.LapPhieuNhapKhoDATA nk = new QLThUOC.DataLayer.LapPhieuNhapKhoDATA();
            DataTable tbl = nk.DSPhieuNhapKho();
            rptPhieuNhapKho report = new rptPhieuNhapKho();
            report.SetDataSource(tbl);

            CrystalReportViewerPhieuNhapKho.ReportSource = report;
        }
    }
}
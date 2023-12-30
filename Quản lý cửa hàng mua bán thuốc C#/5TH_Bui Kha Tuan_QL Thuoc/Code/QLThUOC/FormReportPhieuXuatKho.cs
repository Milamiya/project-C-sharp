using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormReportPhieuXuatKho : Form
    {
        public FormReportPhieuXuatKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLThUOC.DataLayer.LapPhieuXuatKhoDATA xk = new QLThUOC.DataLayer.LapPhieuXuatKhoDATA();
            DataTable tbl = xk.DSPhieuXuatKho();
            rptPhieuXuatKho report = new rptPhieuXuatKho();
            report.SetDataSource(tbl);

            CrystalReportViewerPhieuXK.ReportSource = report;
        }
    }
}
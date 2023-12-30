using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormReportThuoc : Form
    {
        public FormReportThuoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLThUOC.DataLayer.ThuocDATA t = new QLThUOC.DataLayer.ThuocDATA();
            DataTable tbl = t.DSThuoc();
            rptThuoc report = new rptThuoc();
            report.SetDataSource(tbl);

            CrystalReportViewerThuoc.ReportSource = report;
        }
    }
}
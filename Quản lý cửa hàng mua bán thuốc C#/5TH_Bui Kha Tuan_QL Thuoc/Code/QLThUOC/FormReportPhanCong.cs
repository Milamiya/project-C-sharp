using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormReportPhanCong : Form
    {
        public FormReportPhanCong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLThUOC.DataLayer.PhanCongDATA pc = new QLThUOC.DataLayer.PhanCongDATA();
            DataTable tbl = pc.DSPhanCong();
            rptPhanCong report = new rptPhanCong();
            report.SetDataSource(tbl);

            CrystalReportViewerPhanCong.ReportSource = report;
        }
    }
}
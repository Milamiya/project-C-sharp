using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormReportNhaCC : Form
    {
        public FormReportNhaCC()
        {
            InitializeComponent();
        }

        private void ButtonXem_Click(object sender, EventArgs e)
        {
            QLThUOC.DataLayer.NhaCungCapDATA ncc = new QLThUOC.DataLayer.NhaCungCapDATA();
            DataTable tb1 = ncc.LayDSNhaCungCap();
            rptNhaCungCap report = new rptNhaCungCap();
            report.SetDataSource(tb1);

            CrystalReportViewerNhaCungCap.ReportSource = report;

        }
    }
}
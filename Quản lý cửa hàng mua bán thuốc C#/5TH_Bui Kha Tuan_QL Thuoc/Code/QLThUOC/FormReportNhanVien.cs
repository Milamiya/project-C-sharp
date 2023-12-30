using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLThUOC
{
    public partial class FormReportNhanVien : Form
    {
        public FormReportNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLThUOC.DataLayer.NhanVienDATA nv = new QLThUOC.DataLayer.NhanVienDATA();
            DataTable tbl = nv.LayDSNhanVien();
            rptNhanVien report = new rptNhanVien();
            report.SetDataSource(tbl);

           CrystalReportViewerNhanVien.ReportSource = report;
        }
    }
}
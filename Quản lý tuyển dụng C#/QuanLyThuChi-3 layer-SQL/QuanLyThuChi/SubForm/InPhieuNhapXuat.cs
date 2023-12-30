using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DTO;
using BUS;

namespace QuanLyThuChi.SubForm
{
    public partial class InPhieuNhapXuat : Form
    {
        public InPhieuNhapXuat()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PHIEUNHAPXUAT_DTO ptc = new PHIEUNHAPXUAT_DTO();
            ptc.SoPhieu = txt1.Text;
            this.reportViewer1.RefreshReport();
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuChi.Report.Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource newds = new ReportDataSource("DataSet1_tblnhapxuat", PHIEUNHAPXUAT_BUS.In1PhieuNhapXuat(ptc));
            reportViewer1.LocalReport.DataSources.Add(newds);
            reportViewer1.RefreshReport();
        }
    }
}

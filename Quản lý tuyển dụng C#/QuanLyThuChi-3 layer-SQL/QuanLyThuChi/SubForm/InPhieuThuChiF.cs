using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
namespace QuanLyThuChi.SubForm
{
    public partial class InPhieuThuChiF : Form
    {
        public InPhieuThuChiF()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void InPhieuThuChiF_Load(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
            this.reportViewer1.RefreshReport();
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuChi.Report.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource newds = new ReportDataSource("DataSet1_tblthuchi", PHIEUTHUCHI_BUS.In1PhieuThuChi(txt1.Text));
            reportViewer1.LocalReport.DataSources.Add(newds);
            reportViewer1.RefreshReport();
        }
    }
}

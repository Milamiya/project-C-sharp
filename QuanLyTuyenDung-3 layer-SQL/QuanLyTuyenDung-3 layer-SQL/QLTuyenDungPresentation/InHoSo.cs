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
namespace QLTuyenDungPresentation
{
    public partial class InHoSo : Form
    {
        public InHoSo()
        {
            InitializeComponent();
        }

        private void InHoSo_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLTuyenDungPresentation.rpthoso.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource newds = new ReportDataSource("DataSet1",TimUngVien.dtin);
            reportViewer1.LocalReport.DataSources.Add(newds);
            reportViewer1.RefreshReport();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

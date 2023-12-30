using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.Report
{
    public partial class frmPhieuThu_PhieuGui : Office2007Form
    {
        InPhieuThuCtrl ctrl = new InPhieuThuCtrl();
        public frmPhieuThu_PhieuGui()
        {
            InitializeComponent();

            ReportViewerInPhieuThu.LocalReport.ExecuteReportInCurrentAppDomain(System.Reflection.Assembly.GetExecutingAssembly().Evidence);
            this.ReportViewerInPhieuThu.LocalReport.SubreportProcessing += new Microsoft.Reporting.WinForms.SubreportProcessingEventHandler(LocalReport_SubreportProcessing);
        }

        void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            e.DataSources.Clear();
            e.DataSources.Add(new ReportDataSource("", ctrl.LayMaSo()));
        }

        private void frmPhieuThu_PhieuGui_Load(object sender, EventArgs e)
        {
            IList<InPhieuThuInfo> ketqua = InPhieuThuCtrl.LayDsSoTietKiemTheoMa();

            Num2Str num = new Num2Str();
            string soTien = InPhieuThuCtrl.LaySoTienTheoMa(ctrl.LayMaSo());

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("BangChu", num.NumberToString(soTien)));
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));

            this.ReportViewerInPhieuThu.LocalReport.SetParameters(param);

            this.InPhieuThuInfoBindingSource.DataSource = ketqua;
            this.ReportViewerInPhieuThu.RefreshReport();
        }
    }
}
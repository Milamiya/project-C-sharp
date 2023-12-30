using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Controller;

namespace QuanLyTienGuiTietKiem.Report
{
    public partial class frmInPhieuChi : Office2007Form
    {
        InPhieuChiInfo SoTien = new InPhieuChiInfo();
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        public frmInPhieuChi()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmInPhieuChi_Load(object sender, EventArgs e)
        {
            m_SoTietKiemCtrl.HienThiComboBox(cmbMaSo);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {
            IList<InPhieuChiInfo> ketqua = InPhieuChiRutLaiCtrl.LayDsSoTietKiemTheoMa(cmbMaSo.SelectedValue.ToString());

            Num2Str num = new Num2Str();
            string soTien = InPhieuChiRutLaiCtrl.LaySoTienTheoMa(cmbMaSo.SelectedValue.ToString());

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("BangChu", num.NumberToString(soTien)));
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));

            this.ReportViewerInPhieuChi.LocalReport.SetParameters(param);
            this.InPhieuChiInfoBindingSource.DataSource = ketqua;
            this.ReportViewerInPhieuChi.RefreshReport();
        }
    }
}
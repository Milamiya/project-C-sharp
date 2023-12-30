using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.Bussiness;



namespace QuanLyTienGuiTietKiem.Report
{
    public partial class frmInPhieuLuuTienGui : Office2007Form
    {
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        public frmInPhieuLuuTienGui()
        {
            InitializeComponent();

            DataService.OpenConnection();
        }

        private void frmInPhieuLuuTienGui_Load(object sender, EventArgs e)
        {

            m_SoTietKiemCtrl.HienThiComboBox(cmbMaSo);
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {
            IList<InPhieuLuuTienGuiInfo> ketqua = InPhieuLuuTienGuiCtrl.LayPhieuLuuTietKiemTheoMaSo(cmbMaSo.SelectedValue.ToString());

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.ReportViewerInPhieuLuuTienGui.LocalReport.SetParameters(param);


            this.InPhieuLuuTienGuiInfoBindingSource.DataSource = ketqua;
            this.ReportViewerInPhieuLuuTienGui.RefreshReport();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
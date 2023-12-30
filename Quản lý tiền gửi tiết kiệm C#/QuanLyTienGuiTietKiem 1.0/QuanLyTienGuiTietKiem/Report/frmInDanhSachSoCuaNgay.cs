using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Controller;


namespace QuanLyTienGuiTietKiem.Report
{
    public partial class frmInDanhSachSoCuaNgay : Office2007Form
    {
        NgayGiaoDichCtrl m_NgayGiaoDichCtl = new NgayGiaoDichCtrl();
        public frmInDanhSachSoCuaNgay()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmInDanhSachSoCuaNgay_Load(object sender, EventArgs e)
        {
            m_NgayGiaoDichCtl.HienThiComboBox(cmbNgayGiaoDich);
            cmbNgayGiaoDich.SelectedValueChanged +=new EventHandler(cmbNgayGiaoDich_SelectedValueChanged);
           
        }

        void cmbNgayGiaoDich_SelectedValueChanged(object sender, EventArgs e)
        {
            IList<InPhieuLuuTienGuiInfo> ketqua = InDanhSachSoCuaNgayCtrl.LayPhieuLuuTietKiemTheoMaSo(cmbNgayGiaoDich.SelectedValue.ToString());

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.ReportViewerDanhSachSoCuaNgay.LocalReport.SetParameters(param);

            this.InPhieuLuuTienGuiInfoBindingSource.DataSource = ketqua;
            this.ReportViewerDanhSachSoCuaNgay.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
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
    public partial class frmInDanhSachNhanVien : Office2007Form
    {
        public frmInDanhSachNhanVien()
        {
            InitializeComponent();

            DataService.OpenConnection();
        }

        private void frmInDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            IList<NhanVienInfo> ketqua = NhanVienCtrl.LayDsNhanVien();

            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.ReportViewerDanhSachNhanVien.LocalReport.SetParameters(param);

            this.NhanVienInfoBindingSource.DataSource = ketqua;

            this.ReportViewerDanhSachNhanVien.RefreshReport();
        }
    }
}
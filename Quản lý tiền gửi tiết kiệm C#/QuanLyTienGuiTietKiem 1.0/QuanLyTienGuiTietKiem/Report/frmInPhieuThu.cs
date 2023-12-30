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
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Controller;

namespace QuanLyTienGuiTietKiem.Report
{
    public partial class frmInPhieuThu : Office2007Form
    {
        InPhieuThuInfo m_SoTien = new InPhieuThuInfo();
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        public frmInPhieuThu()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmInPhieuThu_Load(object sender, EventArgs e)
        {
            m_SoTietKiemCtrl.HienThiComboBox(cmbMaSo);
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {
            IList<InPhieuThuInfo> ketqua = InPhieuThuCtrl.LayDsSoTietKiemTheoMa(cmbMaSo.SelectedValue.ToString());

            Num2Str num = new Num2Str();
            string soTien = InPhieuThuCtrl.LaySoTienTheoMa(cmbMaSo.SelectedValue.ToString());
            
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("BangChu", num.NumberToString(soTien)));
            param.Add(new ReportParameter("Ngay", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));

            this.ReportViewerInPhieuThu.LocalReport.SetParameters(param);
            this.InPhieuThuInfoBindingSource.DataSource = ketqua;
            this.ReportViewerInPhieuThu.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
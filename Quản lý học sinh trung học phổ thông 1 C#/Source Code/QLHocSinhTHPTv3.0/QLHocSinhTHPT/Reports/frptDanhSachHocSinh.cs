using System;
using System.Text;
using System.Drawing;
using QLHocSinhTHPT.Bussiness;
using QLHocSinhTHPT.Component;
using QLHocSinhTHPT.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace QLHocSinhTHPT.Reports
{
    public partial class frptDanhSachHocSinh : Office2007Form
    {
        #region Constructor
        public frptDanhSachHocSinh()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frptDanhSachHocSinh_Load(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            QuyDinhInfo m_ThongTinTruong = QuyDinh.LayThongTinTruong();
            param.Add(new ReportParameter("TenTruong", m_ThongTinTruong.TenTruong));
            param.Add(new ReportParameter("DiaChiTruong", m_ThongTinTruong.DiaChiTruong));
            param.Add(new ReportParameter("NgayLap", DateTime.Today.Day + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year));
            this.reportViewerDSHS.LocalReport.SetParameters(param);

            IList<HocSinhInfo> hocsinh = HocSinhCtrl.LayDsHocSinh();
            this.bSDSHocSinh.DataSource = hocsinh;

            this.reportViewerDSHS.RefreshReport();
        }
        #endregion
    }
}
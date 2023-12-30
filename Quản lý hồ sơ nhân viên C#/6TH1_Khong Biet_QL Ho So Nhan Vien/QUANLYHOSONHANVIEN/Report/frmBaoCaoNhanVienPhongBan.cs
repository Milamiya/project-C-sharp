using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYHOSONHANVIEN.BusinessObject;

namespace QUANLYHOSONHANVIEN.Report
{
    public partial class frmBaoCaoNhanVienPhongBan : DevComponents.DotNetBar.Office2007Form
    {
        public frmBaoCaoNhanVienPhongBan()
        {
            InitializeComponent();
        }
        string maPB;
        CRNhanVienPhongBan rpt = new CRNhanVienPhongBan();
        public frmBaoCaoNhanVienPhongBan(string str)
            : this()
        {
            maPB = str;
        }

        private void frmBaoCaoNhanVienPhongBan_Load(object sender, EventArgs e)
        {
            ThongTinCongTyInfo congty = ThamSo.LayTTCongTy();
            Connect();
            rpt.SetParameterValue("paraMaPB", maPB);

            rpt.SetParameterValue("paraTenCT", congty.TenCT);
            rpt.SetParameterValue("paraDiaChi", congty.DiaChi);
            rpt.SetParameterValue("paraDienThoai", congty.DiaThoai);
            rpt.SetParameterValue("paraThuDienTu", congty.ThuDienTu);
            rpt.SetParameterValue("paraWebSite", congty.SebSite);
            crystalReportViewer1.ReportSource = rpt;
        }
        public void Connect()
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in rpt.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = QUANLYHOSONHANVIEN.Properties.Settings.Default.servername;
                tliCurrent.ConnectionInfo.UserID = QUANLYHOSONHANVIEN.Properties.Settings.Default.user;
                tliCurrent.ConnectionInfo.Password = QUANLYHOSONHANVIEN.Properties.Settings.Default.pass;
                tliCurrent.ConnectionInfo.DatabaseName = QUANLYHOSONHANVIEN.Properties.Settings.Default.databaseName;
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }
            crystalReportViewer1.ReportSource = rpt;

            crystalReportViewer1.Refresh();
        }
    }
}

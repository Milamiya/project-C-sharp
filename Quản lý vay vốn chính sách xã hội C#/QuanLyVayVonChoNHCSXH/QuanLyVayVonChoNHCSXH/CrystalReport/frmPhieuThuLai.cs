using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.CrystalReport
{
    public partial class frmPhieuThuLai : Form
    {
        public frmPhieuThuLai()
        {
            InitializeComponent();
        }

        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            PhieuThuLai rpt = new PhieuThuLai();
            CrystalDecisions.CrystalReports.Engine.Table tblCurrent;
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = new CrystalDecisions.Shared.TableLogOnInfo();
            DataService InfoSQL = new DataService();
            try
            {
                for (int i = 0; i < rpt.Database.Tables.Count; i++)
                {
                    tblCurrent = rpt.Database.Tables[i];
                    tliCurrent.ConnectionInfo.ServerName = InfoSQL.servername;
                    tliCurrent.ConnectionInfo.UserID = InfoSQL.username;
                    tliCurrent.ConnectionInfo.Password = InfoSQL.password;
                    tliCurrent.ConnectionInfo.DatabaseName = InfoSQL.database;
                    //if(InfoSQL.security.Equals("True"))
                    tliCurrent.ConnectionInfo.IntegratedSecurity = Convert.ToBoolean(InfoSQL.security);
                    tblCurrent.ApplyLogOnInfo(tliCurrent);
                }
            }
            catch { }

            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
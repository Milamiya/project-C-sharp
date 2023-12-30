using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Controller;


namespace QuanLyTienGuiTietKiem.Report
{
    public partial class frmInSoCoKH : Office2007Form
    {
        public frmInSoCoKH()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }

        private void frmInSoCoKH_Load(object sender, EventArgs e)
        {
            IList<SoTietKiemInfo> ketqua = InSoTietKiemCtrl.LayDsSoTKCoKyHan();

            this.SoTietKiemInfoBindingSource.DataSource = ketqua;
            this.ReportViewerInSoCoKyHan.RefreshReport();
        }


    }
}
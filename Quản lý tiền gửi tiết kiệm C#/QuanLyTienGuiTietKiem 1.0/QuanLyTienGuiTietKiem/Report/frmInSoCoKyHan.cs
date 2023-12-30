using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Bussiness;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.Report
{
    public partial class frmInSoCoKyHan : Office2007Form
    {
        public frmInSoCoKyHan()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        private void InSoCoKyHan_Load(object sender, EventArgs e)
        {

            m_SoTietKiemCtrl.HienThiComboBox(cmbMaSoTK);
        }

        private void btnTruyXuat_Click(object sender, EventArgs e)
        {

            IList<SoTietKiemInfo> ketqua = InSoTietKiemCtrl.LayDsSoTKCoKyHan(cmbMaSoTK.SelectedValue.ToString());

            this.SoTietKiemInfoBindingSource.DataSource = ketqua;
            this.ReportViewerInSoCoKyHan.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
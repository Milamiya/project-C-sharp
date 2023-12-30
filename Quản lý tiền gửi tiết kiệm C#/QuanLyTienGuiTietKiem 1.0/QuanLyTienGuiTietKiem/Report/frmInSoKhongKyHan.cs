using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using QuanLyTienGuiTietKiem.Controller;
using QuanLyTienGuiTietKiem.General;
using QuanLyTienGuiTietKiem.Bussiness;

namespace QuanLyTienGuiTietKiem.Report
{
    public partial class frmInSoKhongKyHan : Office2007Form
    {
        public frmInSoKhongKyHan()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        SoTietKiemCtrl m_SoTietKiemCtrl = new SoTietKiemCtrl();
        private void InSoKhongKyHan_Load(object sender, EventArgs e)
        {
            m_SoTietKiemCtrl.HienThiComboBox(txtMaLoaiTK.Text,cmbMaSoTK);
        }

        private void btnTruySuat_Click(object sender, EventArgs e)
        {

            IList<SoTietKiemInfo> ketqua = InSoTietKiemCtrl.LayDsSoTietKiemTheoMa(cmbMaSoTK.SelectedValue.ToString());

            this.SoTietKiemInfoBindingSource.DataSource = ketqua;
            this.ReportViewerInSoKhongKyHan.RefreshReport();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
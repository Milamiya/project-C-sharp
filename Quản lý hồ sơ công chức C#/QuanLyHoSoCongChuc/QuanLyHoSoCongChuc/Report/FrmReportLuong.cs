using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;
using System.Windows.Forms;
using Microsoft.ReportingServices.Rendering.ImageRenderer;
using Microsoft.Reporting.WinForms;
using DevComponents.DotNetBar;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;


namespace QuanLyHoSoCongChuc.Report
{
    public partial class FrmReportLuong :  DockContent
    {
        NhanVienControl m_NhanVienCtrl = new NhanVienControl();
        public FrmReportLuong()
        {
            DataService.OpenConnection();
            InitializeComponent();
        }

        private void FrmReportLuong_Load(object sender, EventArgs e)
        {          
        }

        private void btnNangLuong_Click(object sender, EventArgs e)
        {
            this.bindingSourceLuong.DataSource = NhanVienControl.LayDsLuongNhanVien(dtngaynangluong.Value.ToShortDateString());
            this.reportViewerLuong.RefreshReport();
            m_NhanVienCtrl.CapNhatCanSu(dtngaynangluong.Value.ToShortDateString());
            m_NhanVienCtrl.CapNhatChuyenVien(dtngaynangluong.Value.ToShortDateString());
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
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
    public partial class FrmReportNhanVien :DockContent
    {
        DonViControl m_DonViCtrl = new DonViControl();
        ChucVuControl m_ChucVuCtrl = new ChucVuControl();
        NhanVienControl m_NhanVienCtrl = new NhanVienControl(); 
        public FrmReportNhanVien()
        {
            DataService.OpenConnection();
            InitializeComponent();
        }

        private void FrmReportNhanVien_Load(object sender, EventArgs e)
        {
            m_DonViCtrl.HienThiComboBox1(cmbPhong);
            m_DonViCtrl.HienThiComboBox1(cmbphong1);
            m_ChucVuCtrl.HienThiComboBox(comboBoxEx1);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.bindingSourceNhanVien.DataSource = m_NhanVienCtrl.LayDsNhanVien(cmbPhong.SelectedValue.ToString(), comboBoxEx1.SelectedValue.ToString());
            this.reportViewerNhanVien.RefreshReport();
        }

        private void btnxemtheophong_Click(object sender, EventArgs e)
        {
            this.bindingSourceNhanVien.DataSource = m_NhanVienCtrl.LayDsNhanVienphong(cmbPhong.SelectedValue.ToString());
            this.reportViewerNhanVien.RefreshReport();
        }

       
    }
}
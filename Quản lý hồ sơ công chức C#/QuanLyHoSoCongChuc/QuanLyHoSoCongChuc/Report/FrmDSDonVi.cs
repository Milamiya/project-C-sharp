using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using WeifenLuo.WinFormsUI.Docking;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;


namespace QuanLyHoSoCongChuc.Report
{
    public partial class FrmDSDonVi : DockContent
    {
        LoaiDonViControl m_LoaiDonViCtrl = new LoaiDonViControl();
        public FrmDSDonVi()
        {
            DataService.OpenConnection();
            InitializeComponent();
        }

        private void FrmDSDonVi_Load(object sender, EventArgs e)
        {
            m_LoaiDonViCtrl.HienThiComBoBox(cmbphong);
            //IList<DonViInfo> donvi = DonViControl.LayDsDonVi();
            //this.bindingSourceDonVi.DataSource = donvi;
            //this.reportViewerDonVi.RefreshReport();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            bindingSourceDonVi.DataSource = DonViControl.LayDsDonVi(cmbphong.SelectedValue.ToString());
            this.reportViewerDonVi.RefreshReport();
        }
    }
}
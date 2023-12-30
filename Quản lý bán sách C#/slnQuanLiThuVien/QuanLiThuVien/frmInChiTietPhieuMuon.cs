using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace QuanLiThuVien
{
    public partial class frmInChiTietPhieuMuon : Form
    {
        public frmInChiTietPhieuMuon()
        {
            InitializeComponent();
        }

        MuonBLL objMuon = new MuonBLL();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tbMuon = objMuon.truyXuatDuLieuBang_Muon();
            CrystalReport6 obj = new CrystalReport6();
            obj.SetDataSource(tbMuon);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Refresh();
        }
    }
}

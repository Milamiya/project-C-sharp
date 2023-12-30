using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using CrystalDecisions.Shared;
namespace QuanLyThuVien
{
    public partial class frmInPhieuMuon : DevComponents.DotNetBar.Office2007Form
    {
        public frmInPhieuMuon()
        {
            InitializeComponent();
        }

        public string tenDG { get; set; }

        public string maThe { get; set; }

        public string tenSach { get; set; }
        public string maSach { get; set; }
        public string ngayMuon { get; set; }
        public string ngayTra { get; set; }
        private void frmInPhieuMuon_Load(object sender, EventArgs e)
        {
            rptInPhieuMuon rpt = new rptInPhieuMuon();
            rpt.SetParameterValue("txtTenDG", tenDG.ToString());

            rpt.SetParameterValue("txtMaThe", maThe.ToString());

            rpt.SetParameterValue("txtTenSach", tenSach.ToString());

            rpt.SetParameterValue("txtMaSach", maSach.ToString());

            rpt.SetParameterValue("txtNgayMuon", ngayMuon.ToString());

            rpt.SetParameterValue("txtNgayTra", ngayTra.ToString());

            crpt1.ReportSource = rpt;
        }
    }
}

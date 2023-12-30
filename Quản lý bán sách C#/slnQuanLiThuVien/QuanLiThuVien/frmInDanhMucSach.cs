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
    public partial class frmInDanhMucSach : Form
    {
        public frmInDanhMucSach()
        {
            InitializeComponent();
        }

        CuonSachBLL objCuonsach = new CuonSachBLL();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //DataTable tbcuonsach = objCuonsach.truyXuatDuLieuBang_CuonSach();
            //CrystalReport2 obj = new CrystalReport2();
            //obj.SetDataSource(tbcuonsach);
            //crystalReportViewer1.ReportSource = obj;
            //crystalReportViewer1.Refresh();
        }
    }
}

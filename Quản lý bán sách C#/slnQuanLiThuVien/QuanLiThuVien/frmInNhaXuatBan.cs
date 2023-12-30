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
    public partial class frmInNhaXuatBan : Form
    {
        public frmInNhaXuatBan()
        {
            InitializeComponent();
        }

        NhaXuatBanBLL objNXB = new NhaXuatBanBLL();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tbNXB = objNXB.truyXuatDuLieuBang_NhaXuatBan();
            CrystalReport5 obj = new CrystalReport5();
            obj.SetDataSource(tbNXB);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Refresh();
        }
    }
}

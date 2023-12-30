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
    public partial class frmInTacGia : Form
    {
        public frmInTacGia()
        {
            InitializeComponent();
        }

        TacGiaBLL objTacgia = new TacGiaBLL();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            DataTable tbTacgia = objTacgia.truyXuatDuLieuBang_TacGia();
            CrystalReport4 obj = new CrystalReport4();
            obj.SetDataSource(tbTacgia);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Refresh();
        }
    }
}

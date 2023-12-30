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
    public partial class frmInDocGia : Form
    {
        public frmInDocGia()
        {
            InitializeComponent();
        }

        DocGiaBLL objDocgia = new DocGiaBLL();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tbDocgia = objDocgia.truyXuatDuLieuBang_DocGia();
            CrystalReport1 obj = new CrystalReport1();
            obj.SetDataSource(tbDocgia);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Refresh();
            
        }
    }
}

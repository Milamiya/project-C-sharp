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
    public partial class frmInTheLoai : Form
    {
        public frmInTheLoai()
        {
            InitializeComponent();
        }

        TheLoaiBLL objTheLoai = new TheLoaiBLL();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tbTheLoai = objTheLoai.truyXuatDuLieuBang_TheLoai();
            CrystalReport3 obj = new CrystalReport3();
            obj.SetDataSource(tbTheLoai);
            crystalReportViewer1.ReportSource = obj;
            crystalReportViewer1.Refresh();
        }
    }
}

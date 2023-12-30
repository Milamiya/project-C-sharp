using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTX.Day
{
    public partial class frmThongKeSinhVienThuocDay : Form
    {
        public frmThongKeSinhVienThuocDay()
        {
            InitializeComponent();
        }

        private void rptSinhVienThuocDay1_InitReport(object sender, EventArgs e)
        {

        }

        private void frmThongKeSinhVienThuocDay_Load(object sender, EventArgs e)
        {

        }
        public void ThongKe_ThuocDay(string ten)
        {
            DataService ser = new DataService();
            SqlCommand com = new SqlCommand("SELECT S.MAKTX,S.HOTEN,P.MAPHG,P.TENPHG,D.MADAY,D.TENDAY,K.KTX,K.TENKTX FROM SINHVIEN S, PHONG P, [DAY] D, KTX K, DSSINHVIEN_PHONG DS WHERE S.MAKTX=DS.MAKTX AND P.MAPHG=DS.MAPHG AND P.MADAY=D.MADAY AND D.KTX=K.KTX and D.TENDAY=N'" + ten + "'");
            rptSinhVienThuocDay rpt = new rptSinhVienThuocDay();
            ser.Load(com);
            rpt.SetDataSource(new DataTable());
            rpt.SetDataSource((DataTable)ser);
            this.crystalReportViewer1.ReportSource = rpt;



        }
    }
}
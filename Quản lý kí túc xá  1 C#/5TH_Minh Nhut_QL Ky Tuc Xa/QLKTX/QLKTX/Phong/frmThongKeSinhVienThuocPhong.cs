using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLKTX.Controller;
namespace QLKTX.Phong
{
    public partial class frmThongKeSinhVienThuocPhong : Form
    {
        public frmThongKeSinhVienThuocPhong()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmThongKeSinhVienThuocPhong_Load(object sender, EventArgs e)
        {
            PhongCtrl PHGctrl = new PhongCtrl();
            PHGctrl.LayDuLieuLenComboBox(cmbPhong);
        }
        public void ThongKe_ThuocPhong(string ten)
        {
            DataService ser=new  DataService();
            SqlCommand com =new SqlCommand("SELECT S.MAKTX,S.HOTEN,P.MAPHG,P.TENPHG,D.MADAY,D.TENDAY,K.KTX,K.TENKTX FROM SINHVIEN S, PHONG P, [DAY] D, KTX K, DSSINHVIEN_PHONG DS WHERE S.MAKTX=DS.MAKTX AND P.MAPHG=DS.MAPHG AND P.MADAY=D.MADAY AND D.KTX=K.KTX and P.TENPHG=N'"+ten+"'");
            rptSinhVienThuocPhong rpt=new rptSinhVienThuocPhong();
            ser.Load(com);
            rpt.SetDataSource(new DataTable());
            rpt.SetDataSource((DataTable)ser);
            this.crystalReportViewer1.ReportSource = rpt;
                


        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        string thang = "";
        string nam = "";
        public frmDoanhThu(string THANG, string NAM)
        {
            InitializeComponent();
            thang = THANG;
            nam = NAM;
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            DoanhthuReport dt = new DoanhthuReport();
            string select = "";
            if (thang != "" && nam != "")
            {
                select = "SELECT * FROM v_doanhthu WHERE Tháng='" + thang + "' AND Năm='" + nam + "'";
                dt.SetDataSource(DataConn.GrdSource(select).Tables[0]);
                crystalReportViewer1.ReportSource = dt;
            }
            else if (thang != "" && nam == "")
            {
                //MessageBox.Show("Thang!= va nam== ");
                select = "SELECT * FROM v_doanhthu WHERE Tháng='" + thang + "'";
                dt.SetDataSource(DataConn.GrdSource(select).Tables[0]);
                crystalReportViewer1.ReportSource = dt;
            }
            else if (thang == "" && nam != "")
            {
                select = "SELECT * FROM v_doanhthu WHERE Năm='" + nam + "'";
                dt.SetDataSource(DataConn.GrdSource(select).Tables[0]);
                crystalReportViewer1.ReportSource = dt;
            }
            else 
            {
                select = "SELECT * FROM v_doanhthu";
                dt.SetDataSource(DataConn.GrdSource(select).Tables[0]);
                crystalReportViewer1.ReportSource = dt;
            }
            
        }


    }
}
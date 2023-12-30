using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmThongKeHangHoatheoDVT : Form
    {
        public frmThongKeHangHoatheoDVT()
        {
            InitializeComponent();
        }

        private void buttonchon_Click_1(object sender, EventArgs e)
        {
            String dvt = comboBox1.SelectedValue.ToString();
            GiaoDienCuaHang.DataLayer.HangHoaData hh = new GiaoDienCuaHang.DataLayer.HangHoaData();
            CrystalReportChonhanghoa report = new CrystalReportChonhanghoa();

            report.SetDataSource(hh.LayDSHangHoa(dvt));
            report.SetParameterValue("donvitinh", comboBox1.Text);


            crystalReportViewer1.ReportSource = report;
        }

        private void frmThongKeHangHoatheoDVT_Load_1(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.DonViTinhData dvtdata = new GiaoDienCuaHang.DataLayer.DonViTinhData();
            comboBox1.DataSource = dvtdata.LayDSDonViTinh();
            comboBox1.DisplayMember = "TENDVT";
            comboBox1.ValueMember = "MADVT";
        }
    }
}
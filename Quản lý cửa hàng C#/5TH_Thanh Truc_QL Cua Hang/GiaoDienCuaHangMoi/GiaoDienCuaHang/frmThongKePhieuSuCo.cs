using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmThongKePhieuSuCo : Form
    {
        public frmThongKePhieuSuCo()
        {
            InitializeComponent();
        }

        private void buttonchon_Click(object sender, EventArgs e)
        {
            String hh = comboBox1.SelectedValue.ToString();
            GiaoDienCuaHang.DataLayer.PhieuSuCoData psc = new GiaoDienCuaHang.DataLayer.PhieuSuCoData();
            CrystalReportPhieuSuCo parameter = new CrystalReportPhieuSuCo();
            parameter.SetDataSource(psc.LayDS_PhieuSuCo(hh));
            parameter.SetParameterValue("tenhh", comboBox1.Text);
            crystalReportViewer1.ReportSource = parameter; 
        }

        private void frmThongKePhieuSuCo_Load(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.HangHoaData hhdata = new GiaoDienCuaHang.DataLayer.HangHoaData();
            comboBox1.DataSource = hhdata.LayDSHangHoa();
            comboBox1.DisplayMember = "TENHH";
            comboBox1.ValueMember = "MAHH";
           
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmThongKeTonKho : Form
    {
        public frmThongKeTonKho()
        {
            InitializeComponent();
        }

        private void buttonhienthi_Click(object sender, EventArgs e)
        {
            String hh = comboBox1.SelectedValue.ToString();
            GiaoDienCuaHang.DataLayer.TonKhoData tk = new GiaoDienCuaHang.DataLayer.TonKhoData();
            CrystalReportTonKho parameter = new CrystalReportTonKho();
            parameter.SetDataSource(tk.LayDS_TonKho(hh));
            parameter.SetParameterValue("tenhh", comboBox1.Text);
            crystalReportViewer1.ReportSource = parameter; 
        }

        private void frmThongKeTonKho_Load(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.HangHoaData hhdata = new GiaoDienCuaHang.DataLayer.HangHoaData();
            comboBox1.DataSource = hhdata.LayDSHangHoa();
            comboBox1.DisplayMember = "TENHH";
            comboBox1.ValueMember = "MAHH";
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmThongKePhieuBanHang : Form
    {
        public frmThongKePhieuBanHang()
        {
            InitializeComponent();
        }

        private void buttonHT_Click(object sender, EventArgs e)
        {
            String kh = comboBox1.SelectedValue.ToString();
            GiaoDienCuaHang.DataLayer.PhieuBanHangData pbh = new GiaoDienCuaHang.DataLayer.PhieuBanHangData();
            CrystalReportPhieuBanHang parameter = new CrystalReportPhieuBanHang();
            parameter.SetDataSource(pbh.LayDSPhieuBanHang(kh));
            parameter.SetParameterValue("tenkh", comboBox1.Text);
            crystalReportViewer1.ReportSource = parameter;
        }

        private void frmThongKePhieuBanHang_Load(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.KhachHangData khdata = new GiaoDienCuaHang.DataLayer.KhachHangData();
            comboBox1.DataSource = khdata.LayDSKhachHang();
            comboBox1.DisplayMember = "HOTEN";
            comboBox1.ValueMember = "MAKH";
            
            
        }

       
    }
}
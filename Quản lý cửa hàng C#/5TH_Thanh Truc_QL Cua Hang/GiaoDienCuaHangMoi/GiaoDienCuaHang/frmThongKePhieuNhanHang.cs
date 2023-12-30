using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmThongKePhieuNhanHang : Form
    {
        public frmThongKePhieuNhanHang()
        {
            InitializeComponent();
        }

        private void buttonchon_Click(object sender, EventArgs e)
        {
            String nv = comboBox1.SelectedValue.ToString();
            GiaoDienCuaHang.DataLayer.PhieuNhanHangData pnh = new GiaoDienCuaHang.DataLayer.PhieuNhanHangData();
            CrystalReportPhieuNhanHang parameter = new CrystalReportPhieuNhanHang();
            parameter.SetDataSource(pnh.LayDS_PhieuNhanHang(nv));
            parameter.SetParameterValue("tennv", comboBox1.Text);
            crystalReportViewer1.ReportSource = parameter;   
        }

        private void frmThongKePhieuNhanHang_Load(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.NhanVienData nvdata = new GiaoDienCuaHang.DataLayer.NhanVienData();
            comboBox1.DataSource = nvdata.LayDSNhanVien();
            comboBox1.DisplayMember = "HOTEN";
            comboBox1.ValueMember = "MANV";
            
        }
    }
}
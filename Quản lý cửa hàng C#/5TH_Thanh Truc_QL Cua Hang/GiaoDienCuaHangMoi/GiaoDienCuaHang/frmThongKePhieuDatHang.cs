using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace GiaoDienCuaHang
{
    public partial class frmThongKePhieuDatHang : Form
    {
        public frmThongKePhieuDatHang()
        {
            InitializeComponent();
        }

        //private void buttonhienthi_Click(object sender, EventArgs e)
        //{
        //    String nv = comboBox1.SelectedValue.ToString();
        //    GiaoDienCuaHang.DataLayer.PhieuDatHangData pdh1 = new GiaoDienCuaHang.DataLayer.PhieuDatHangData();
        //    CrystalReportPhieudathang report = new CrystalReportPhieudathang();

        //    report.SetDataSource(pdh1.LayDS_PDH(nv));
        //    report.SetParameterValue("tennv", comboBox1.Text);

            
        //    crystalReportViewer1.ReportSource = report;
        //}

        private void frmThongKePhieuDatHang_Load(object sender, EventArgs e)
        {
            GiaoDienCuaHang.DataLayer.NhaCungCapData nccdata = new GiaoDienCuaHang.DataLayer.NhaCungCapData();
            comboBox1.DataSource = nccdata.LayDSNhaCungCap();
            comboBox1.DisplayMember = "TENNCC";
            comboBox1.ValueMember = "MANCC";
            
        }

        private void buttonhienthi_Click(object sender, EventArgs e)
        {
            String cc = comboBox1.SelectedValue.ToString();
            GiaoDienCuaHang.DataLayer.PhieuDatHangData pdh1=new GiaoDienCuaHang.DataLayer.PhieuDatHangData();
            CrystalReportPhieuDatHang parameter = new CrystalReportPhieuDatHang();
            parameter.SetDataSource(pdh1.LayDS_PDH(cc));
            parameter.SetParameterValue("tenncc", comboBox1.Text);
            crystalReportViewer1.ReportSource = parameter;            
        }
    }
}
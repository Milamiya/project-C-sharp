using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using GiaoDienCuaHang.Controller;

namespace GiaoDienCuaHang
{
    public partial class frmTimKiemPhieuDatHang : Form
    {
        PhieuDatHangController ctrl = new PhieuDatHangController();   
        public frmTimKiemPhieuDatHang()
        {
            InitializeComponent();
        }

        private void buttontim_Click(object sender, EventArgs e)
        {
            ctrl.TimKiemPDH(comboBox1, comboBox2, comboBox4, comboBox3, dateTimePicker1, dateTimePicker2,dataGridView1);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemPhieuDatHang_Load(object sender, EventArgs e)
        {
            this.comboBox2.Text = "NONE";
            this.comboBox3.Text = "NONE";
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            this.comboBox1.Text = "";
            this.comboBox2.Text = "NONE";
            this.comboBox3.Text = "NONE";
            this.comboBox4.Text = "";
        }
    }
}
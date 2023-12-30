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
    public partial class frmTimKiemPhieuNhanHang : Form
    {
        PhieuNhanHangController ctrl = new PhieuNhanHangController();
        public frmTimKiemPhieuNhanHang()
        {
            InitializeComponent();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            ctrl.TimKiemPNH(comboBox1, comboBox2, comboBox3, comboBox4, dateTimePicker1, dateTimePicker2, dataGridView1);
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            this.comboBox1.Text = "";
            this.comboBox2.Text = "NONE";
            this.comboBox3.Text = "";
            this.comboBox4.Text = "NONE";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemPhieuNhanHang_Load(object sender, EventArgs e)
        {
            this.comboBox2.Text = "NONE";
            this.comboBox4.Text = "NONE";
        }
    }
}
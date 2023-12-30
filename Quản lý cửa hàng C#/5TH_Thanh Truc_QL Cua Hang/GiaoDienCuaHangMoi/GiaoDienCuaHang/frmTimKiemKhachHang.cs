using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using GiaoDienCuaHang.Controller;
using System.Windows.Forms;

namespace GiaoDienCuaHang
{
    public partial class frmTimKiemKhachHang : Form
    {
        KhachHangContronller Ctrl = new KhachHangContronller();
        public frmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            Ctrl.TimKiemKH(textBoxTEN, comboBoxchondiachi, textBoxDIACHI, comboBoxCHONDIENTHOAI, textBoxDIENTHOAI, dataGridView1);
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            this.textBoxTEN.Clear();
            this.textBoxDIACHI.Clear();
            this.textBoxDIENTHOAI.Clear();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            this.comboBoxchondiachi.Text = "NONE";
            this.comboBoxCHONDIENTHOAI.Text = "NONE";

        }

       

        
    }
}
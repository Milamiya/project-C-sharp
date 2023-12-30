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
    public partial class frmTimKiemNhaCungCap : Form
    {
        NhaCungCapController Ctrller = new NhaCungCapController();
        public frmTimKiemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            Ctrller.TimKiemNhaCungCap(textBoxTENNCC, comboBoxCHONDC, textBoxDIACHI, comboBoxCHONDT, textBoxDIENTHOAI, dataGridView2);  
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            this.textBoxTENNCC.Clear();
            this.textBoxDIACHI.Clear();
            this.textBoxDIENTHOAI.Clear();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemNhaCungCap_Load(object sender, EventArgs e)
        {
            this.comboBoxCHONDC.Text = "NONE";
            this.comboBoxCHONDT.Text = "NONE";
        }
    }
}
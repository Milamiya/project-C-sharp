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

    public partial class frmTimKiemDVT : Form
    {
        DonViTinhController CTRL = new DonViTinhController();
        public frmTimKiemDVT()
        {
            InitializeComponent();
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            CTRL.TK(txtenDVT, dataGridView1);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            this.txtenDVT.Clear();
        }

        

       

    }
}
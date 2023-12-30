using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shop_Manager
{
    public partial class frmHoTroThongBaoDoanhThu : Form
    {
        public frmHoTroThongBaoDoanhThu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoanhThu dt = new frmDoanhThu(txtThang.Text, txtNam.Text);
            dt.ShowDialog();
        }
    }
}
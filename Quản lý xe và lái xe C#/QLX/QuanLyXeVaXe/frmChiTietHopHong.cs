using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmChiTietHopHong : Form
    {
        public frmChiTietHopHong()
        {
            InitializeComponent();
        }

        private void frmChiTietHopHong_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = frmThemHopDong.tb1.Text;
        }
    }
}

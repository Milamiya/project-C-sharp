using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmLapHopDong : Form
    {
        public frmLapHopDong()
        {
            InitializeComponent();
        }

        private void rbCoLaiXe_CheckedChanged(object sender, EventArgs e)
        {
            if ((rbCoLaiXe.Checked) == true)
            {
                frmQuanLyHopDong f = new frmQuanLyHopDong();
                f.TopLevel = false;
                f.Show();
                pnLapHD.Controls.Clear();
                pnLapHD.Controls.Add(f);
            }
            if ((rbKhongLaiXe.Checked) == true)
            {
                
            }
        }
    }
}

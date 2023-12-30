using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHeThong.Text = lbHeThong.Text.Substring(1,lbHeThong.Text.Length-1)+lbHeThong.Text.Substring(0,1);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        
        }
    }
}

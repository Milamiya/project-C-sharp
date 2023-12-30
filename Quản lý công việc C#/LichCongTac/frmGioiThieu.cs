using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LichCongTac
{
    public partial class frmGioiThieu : Form
    {
        public frmGioiThieu()
        {
            InitializeComponent();
        }
        int index = -1;
        private void frmGioiThieu_Load(object sender, EventArgs e)
        {
            timerGt1.Enabled = true;
            timerLabel.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hiển thị hình ảnh liên tục trong picturebox
            if (index < imageListGt.Images.Count - 1) index++;
            timerGt1.Enabled = false;
            timerGt1.Interval = 1200;
            picBoxGioiThieu.Image = imageListGt.Images[index];
            timerGt1.Enabled = true;

            //Hiển thị Form chính sau 7 giây
            if (index == 4)
            {
                timerGt1.Stop();
                this.Hide();
                frmMain frmM = new frmMain();
                frmM.ShowDialog();
            }
        }

        private void timerLabel_Tick(object sender, EventArgs e)
        {
            timerLabel.Interval = 150;
            label2.Left += 10; 
        }
    }
}
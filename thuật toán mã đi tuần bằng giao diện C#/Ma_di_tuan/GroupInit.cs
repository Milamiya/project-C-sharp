using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Ma_di_tuan
{
    public partial class GroupInit : UserControl
    {
        bool doi = false;
        public GroupInit()
        {
            InitializeComponent();
            
            cboTG_Cho.Items.Add("0.5");
            for (int i = 1; i <= 5; i++)
                cboTG_Cho.Items.Add(i);
            cboTG_Cho.Text = "1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (doi)
            {
                doi = false;
                pictureBox3.Image = global::Ma_di_tuan.Properties.Resources.Ngua_do;
            }
            else
            {
                doi = true;
                pictureBox3.Image = null;
            }
        }

        private void btnInit_Click(object sender, EventArgs e)
        {

        }
    }
}

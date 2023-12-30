using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace detai_HoangQuan
{
    public partial class frmFlash : Form
    {
        public frmFlash()
        {
            InitializeComponent();
        }

        private void time_Flash_Tick(object sender, EventArgs e)
        {
            lblLoading.Visible = false;
            if (progressBar1.Value < progressBar1.Maximum)
            {
                lblLoading.Visible = true;
                progressBar1.Value += 10;
                lblFlash.Text = progressBar1.Value + " %";
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                time_Flash.Enabled = true;
            }
        }
    }
}

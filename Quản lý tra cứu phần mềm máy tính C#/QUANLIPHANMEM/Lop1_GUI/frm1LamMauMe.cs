using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lop1_GUI
{
    public partial class frm1LamMauMe : Form
    {
        public frm1LamMauMe()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            timer1.Enabled = false;
        }
    }
}

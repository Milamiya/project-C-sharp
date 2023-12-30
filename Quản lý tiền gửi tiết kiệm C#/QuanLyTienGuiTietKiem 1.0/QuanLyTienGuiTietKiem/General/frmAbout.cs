using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QuanLyTienGuiTietKiem.General
{
    public partial class frmAbout : Office2007Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void lblThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
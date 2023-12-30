using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmXemanh : Form
    {
        public frmXemanh()
        {
            InitializeComponent();
        }

        private void frmXemanh_Load(object sender, EventArgs e)
        {
            string tenanh = frmMain.Tenanhpic;
            picAnh.ImageLocation = Application.StartupPath + @"\Picture\" + tenanh;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

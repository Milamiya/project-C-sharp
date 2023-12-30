using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chess_Usercontrol
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }
        public static bool ShowMessage = true;
        string mess = "";
        public frmMessageBox(string Message)
        {
            InitializeComponent();
            mess = Message;           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ShowMessage = !checkBox1.Checked;
            this.Close();
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            lblResult.Text = mess;           
        }       


    }
}
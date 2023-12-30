using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyVayVonChoNHCSXH.Controller;

namespace QuanLyVayVonChoNHCSXH.UserInterface
{
    public partial class frmLogIn : Form
    {
        DangNhapController DNctrl = new DangNhapController();

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                this.DialogResult = DialogResult.OK;
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }

        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmQexpD : Form
    {
        public frmQexpD()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmExpDetail frm_ExpD = new frmExpDetail();


            frm_ExpD.str = "Adding";
            this.Close();
            frm_ExpD.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmExpDetail frm_ExpD = new frmExpDetail();


            frm_ExpD.str = "Modifying";
            this.Close();
            frm_ExpD.Show();
        }
    }
}
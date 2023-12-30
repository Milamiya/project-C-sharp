using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmQexp : Form
    {
        public frmQexp()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            _forms.frmExp frm_Exp = new frmExp();

            frm_Exp.str = "Adding";
            this.Close();
            frm_Exp.Show();

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            
            _forms.frmExp frm_Exp = new frmExp();

            frm_Exp.str = "Modifying";
            this.Close();
            frm_Exp.Show();
        }
    }
}
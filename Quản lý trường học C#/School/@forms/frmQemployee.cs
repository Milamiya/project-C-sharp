using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmQemployee : Form
    {
        public frmQemployee()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmEmployee frm_Emp = new frmEmployee();


            frm_Emp.str = "Adding";
            this.Close();
            frm_Emp.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmEmployee frm_Emp = new frmEmployee();


            frm_Emp.str = "Modifying";
            this.Close();
            frm_Emp.Show();
        }
    }
}
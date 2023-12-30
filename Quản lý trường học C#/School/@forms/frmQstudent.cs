using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmQstudent : Form
    {
        public frmQstudent()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmStudent frm_Student = new frmStudent();


            frm_Student.str = "Modifying";
            this.Close();
            frm_Student.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmStudent frm_Student = new frmStudent();


            frm_Student.str = "Adding";
            this.Close();
            frm_Student.Show();
        }
    }
}
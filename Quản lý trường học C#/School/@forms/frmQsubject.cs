using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmQsubject : Form
    {
        public frmQsubject()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmSubject frm_Subject = new frmSubject();

            frm_Subject.str = "Adding";
            this.Close();
            frm_Subject.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            frmSubject frm_Subject = new frmSubject();
            frm_Subject.str = "Modifying";
            this.Close();
            frm_Subject.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmQaEmp : Form
    {
        public frmQaEmp()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmAttEmp frm_AttEmp = new frmAttEmp();
            frm_AttEmp.str = "Adding";
            this.Close();
            frm_AttEmp.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            frmAttEmp frm_AttEmp = new frmAttEmp();
            frm_AttEmp.str = "Modifying";
            this.Close();
            frm_AttEmp.Show();
        }
    }
}
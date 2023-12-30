using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmQclass : Form
    {
        public frmQclass()
        {
            InitializeComponent();
        }

        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _forms.frmClass frm_Class = new frmClass();


            frm_Class.str="Adding";
            this.Close();        
            frm_Class.Show();

        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            _forms.frmClass frm_Class = new frmClass();
            frm_Class.str="Modifying";
            this.Close();
            frm_Class.Show();
            
        }
    }
}
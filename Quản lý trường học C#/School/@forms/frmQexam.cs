using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmQexam : Form
    {
        public frmQexam()
        {
            InitializeComponent();
        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmExam frm_Exam = new frmExam();
            frm_Exam.str = "Adding";
            this.Close();
            frm_Exam.Show();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            frmExam frm_Exam = new frmExam();
            frm_Exam.str = "Modifying";
            this.Close();
            frm_Exam.Show();
        }
    }
}
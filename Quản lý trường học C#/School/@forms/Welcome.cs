using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        int z;//Variable for Progressbar Value
        frm_login frmlogin = new frm_login();
        private void Welcome_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            z += 2;

            if (z > 100)
            {
                this.Hide();
               
                //MessageBox.Show ("Load Form 2");
                this.timer1.Enabled = false;

              //  this.Close();
                    frmlogin.Show ();
                     return;

            }
            this.progressBar1.Value = z;


        }
        }

        
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class giaithua : Form
    {
        public giaithua()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();//Download source code tại Sharecode.vn
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnhap.Text = "";
            lblkq.Text = "";
            txtnhap.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n, gt = 1;
            if (txtnhap.Text == "")
                lblkq.Text = "Nhap he so!";
            else
            {  
                n = Convert.ToDouble(txtnhap.Text);
                if (n >= 0)
                {
                    for (int i = 1; i <= n; i++)
                        gt = gt * i;
                    lblkq.Text = gt.ToString();
                }
                else
                    lblkq.Text = "error";
                //lblkq.Text = "";
            }
        }
    }
}
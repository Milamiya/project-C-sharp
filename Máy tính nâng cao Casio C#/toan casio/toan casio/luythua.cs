using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class luythua : Form
    {
        public luythua()
        {
            InitializeComponent();
        }
        double a1, a2, n;
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txt2.Clear();
            txt3.Clear();
            txtkq.Clear();
            txtn.Clear();
            txtnhap1.Clear();
            txtx.Clear();
            lblkq.Text = "";
            txtnhap1.Focus();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mong cac ban dong gop them de chuong trinh hoan thien\n\t\t MrH_DeathMaskNT");
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtnhap1.Text != "")
            {
                a1 = Convert.ToDouble(txtnhap1.Text);
                a1 = Math.Abs(a1);
                a1 = a1 * a1;
                txt2.Text = a1.ToString(); 
            }
            else txt2.Text = "nhap co so";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtnhap1.Text != "")
            {
                a1 = Convert.ToDouble(txtnhap1.Text);
                a1 = a1 * a1 * a1;
                txt3.Text = a1.ToString();
            }
            else txt3.Text = "nhap co so";
        }

        private void btnn_Click(object sender, EventArgs e)
        {
            if (txtx.Text != "")
            {
                if (txtn.Text != "")
                {

                    a2 = Convert.ToDouble(txtx.Text);
                    n = Convert.ToDouble(txtn.Text);
                    a2 = (Math.Pow(a2, n));
                    txtkq.Text = a2.ToString();
                }
                else txtn.Text = "nhap so mu";
            }
            else txtx.Text = "nhap co so";
        }


        private void txtx_TextChanged(object sender, EventArgs e)
        {
            lblkq.Text=txtx.Text+"^"+txtn.Text+" = "+txtkq.Text;
        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {
            lblkq.Text = txtx.Text + "^" + txtn.Text + " = " + txtkq.Text;
        }

        private void txtkq_TextChanged(object sender, EventArgs e)
        {
            lblkq.Text = txtx.Text + "^" + txtn.Text + " = " + txtkq.Text;
        }

    }
}
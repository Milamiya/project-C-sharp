using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class luonggiac : Form
    {
        public luonggiac()
        {
            InitializeComponent();
        }
      double rad,doo;
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt1cos.Clear();
            txt1cotan.Clear();
            txt1tan.Clear();
            txt1sin.Clear();

            txt2.Clear();
            txt2cos.Clear();
            txt2cotan.Clear();
            txt2sin.Clear();
            txt2tan.Clear();

            txt1.Focus();
        }



        private void btn1sin_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                rad = Convert.ToDouble(txt1.Text);
                rad = Math.Sin(rad);
                txt1sin.Text = rad.ToString();
            }
            else txt1sin.Text = "nhap so";
        }

        private void btn1cos_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                rad = Convert.ToDouble(txt1.Text);
                rad = Math.Cos(rad);
                txt1cos.Text = rad.ToString();
            }
            else txt1cos.Text = "nhap so";
        }

        private void btn1tan_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                rad = Convert.ToDouble(txt1.Text);
                rad = Math.Tan(rad);
                txt1tan.Text = rad.ToString();
            }
            else txt1tan.Text = "nhap so";
        }

        private void btn1cotan_Click(object sender, EventArgs e)
        {

        }



        private void btn2sin_Click(object sender, EventArgs e)
        {

        }

        private void btn2cos_Click(object sender, EventArgs e)
        {

        }

        private void btn2tan_Click(object sender, EventArgs e)
        {

        }

        private void btn2cotan_Click(object sender, EventArgs e)
        {

        }


    }
}
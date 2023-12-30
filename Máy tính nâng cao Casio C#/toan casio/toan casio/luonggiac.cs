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
      double rad;
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();//Download source code tại Sharecode.vn
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
            lblnhap2.Text = "";

            txt1.Focus();
        }


        private void btn1sin_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txt1sin.Text = "chua xong";
            // double   doo = Convert.ToDouble(txt1.Text);
             //    doo = Math.Sin((doo * 180) /(Math.PI));
             //   txt1sin.Text = doo.ToString();
            }
            else txt1.Text = "nhap so";
        }

        private void btn1cos_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txt1cos.Text = "chua xong";
                //rad = Convert.ToDouble(txt1.Text);
                //rad = Math.Cos(rad);
                //txt1cos.Text = rad.ToString();
            }
            else txt1cos.Text = "nhap so";
        }

        private void btn1tan_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txt1tan.Text = "chua xong";
                //rad = Convert.ToDouble(txt1.Text);
                //rad = Math.Tan(rad);
                //txt1tan.Text = rad.ToString();
            }
            else txt1tan.Text = "nhap so";
        }

        private void btn1cotan_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {
                txt1cotan.Text = "chua xong";
                //rad = Convert.ToDouble(txt1.Text);
                //rad = Math.Tan(rad);
                //txt1cotan.Text = rad.ToString();
            }
            else txt1cotan.Text = "nhap so";
        }



        private void btn2sin_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                rad = Convert.ToDouble(txt2.Text);
                rad = (Math.Sin(Math.PI * rad / 180));
                txt2sin.Text = rad.ToString();
            }
            else txt2sin.Text = "nhap so";
        }

        private void btn2cos_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                rad = Convert.ToDouble(txt2.Text);
                rad = (Math.Cos(Math.PI * rad / 180));
                txt2cos.Text = rad.ToString();
            }
            else txt2cos.Text = "nhap so";
        }

        private void btn2tan_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                rad = Convert.ToDouble(txt2.Text);
                rad = ((Math.Sin(Math.PI * rad / 180)) / (Math.Cos(Math.PI * rad / 180)));
                txt2tan.Text = rad.ToString();
            }
            else txt2tan.Text = "nhap so";
        }

        private void btn2cotan_Click(object sender, EventArgs e)
        {
            if (txt2.Text != "")
            {
                rad = Convert.ToDouble(txt2.Text);
                rad = ((Math.Cos(Math.PI * rad / 180)) / (Math.Sin(Math.PI * rad / 180)));
                txt2cotan.Text = rad.ToString();
            }
            else txt2cotan.Text = "nhap so";
        }


        private void txt2_TextChanged(object sender, EventArgs e)
        {
lblnhap2.Text = txt2.Text + "°";
        }

        


    }
}
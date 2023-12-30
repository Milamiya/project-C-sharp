using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class khaican : Form
    {
        public khaican()
        {
            InitializeComponent();
        }
        double  a2,n;   
        private void btxoa_Click(object sender, EventArgs e)
        {
            txtnhap1.Text = "";
            txtnhapn.Text = "";
            txtnhap2.Text = "";
            txtb2.Text = "";
            txtb3.Text = "";
            txtbn.Text = "";
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnhap1.Text != "")
            {
               double a1 = Convert.ToDouble(txtnhap1.Text);
                if (a1 > 0)
                {
                    
                    a1 = Math.Sqrt(a1);
                    txtb2.Text = a1.ToString();
                }
                else txtb2.Text = "Error";
            }
            else txtb2.Text = "nhap co so";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnhap1.Text != "")
            {
               double a1 = Convert.ToDouble(txtnhap1.Text);
                if (a1 < 0)
                {
                    a1 = Math.Abs(a1);
                    a1 = (Math.Pow(a1, Convert.ToDouble(1) / 3));
                    txtb3.Text = "-" + a1.ToString();
                }
                else
                {
                    a1 = (Math.Pow(a1, Convert.ToDouble(1) / 3));
                    txtb3.Text =a1.ToString();
                }

            }
            else txtb3.Text = "nhap co so";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtnhap2.Text != "")
            {
                if (txtnhapn.Text != "")
                {
                    a2 = Convert.ToDouble(txtnhap2.Text);
                    n = Convert.ToDouble(txtnhapn.Text);
                    if (a2 < 0)
                    {
                        a2 = Math.Abs(a2);

                        if ((n % 2) != 0)
                        {

                            a2 = (Math.Pow(a2, Convert.ToDouble(1) / n));
                            txtbn.Text = "-" + a2.ToString();
                        }
                        else txtbn.Text = "Error";
                    }
                    else
                    {
                        a2 = (Math.Pow(a2, Convert.ToDouble(1) / n));
                        txtbn.Text = a2.ToString();
                    }
                }
                else txtbn.Text = "nhap can";
            }
            else txtbn.Text = "nhap so";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mong cac ban dong gop them de chuong trinh hoan thien\n\t\t MrH_DeathMaskNT");
        }
    }
}
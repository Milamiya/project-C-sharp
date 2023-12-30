using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class ptbac2 : Form
    {
        public ptbac2()
        {
            InitializeComponent();
        }
        double a, b, c, de,x1,x2,x;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_a.Clear();
            txt_b.Clear();
            txt_c.Clear();
            lbl_kq.Text = "";
            lbl_pt.Text = "";
            txt_a.Focus();
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x² + " + txt_b.Text + "x + " + txt_c.Text + " = 0";
        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x² + " + txt_b.Text + "x + " + txt_c.Text + " = 0";

        }

        private void txt_c_TextChanged(object sender, EventArgs e)
        {
            lbl_pt.Text = txt_a.Text + "x² + " + txt_b.Text + "x + " + txt_c.Text + " = 0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txt_a.Text);
            b = Convert.ToDouble(txt_b.Text);
            c = Convert.ToDouble(txt_c.Text);
            x = (-c) / b;
            de = b * b - 4 * a * c;
            x1 = ((-b) + Math.Sqrt(de)) / (2 * a);
            x2 = ((-b) - Math.Sqrt(de)) / (2 * a);

            if (txt_a.Text == "" || txt_b.Text == "" || txt_c.Text == "")
                lbl_kq.Text = "nhap he so! \n neu khong thi nhap so 0";
            else          
                if (a == 0) lbl_kq.Text = "phuong trinh co 1 nghiem:\n x= "+x; 
                else
                        //if  (a!=0)
                        //((a == 0) && (b == 0)) 
                        //lbl_kq.Text = "Error"; else
                    {
                        de = b * b - 4 * a * c;
                        if (de < 0) lbl_kq.Text = "phuong trinh vo nghiem";
                        else 
                            if (de == 0) 
                            { 
                                x = (-b) / (2 * a); 
                                lbl_kq.Text = "phuong trinh co nghiem kep:\n x1=x2= " + x; 
                            }
                        else
                        {
                            lbl_kq.Text = "phuong trinh co 2 nghiem phan biet:\nx1= " + x1 + "\nx2=" + x2;
                        }      
                    }

        }

    }
}

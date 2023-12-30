using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class he_ptb1_2an : Form
    {
        public he_ptb1_2an()
        {
            InitializeComponent();
        }
        double a1, b1, c1, a2, b2, c2, d, d1, d2;
        private void btdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            ta1.Clear(); tb1.Clear(); tc1.Clear();
            ta2.Clear(); tb2.Clear(); tc2.Clear();
            lblkq.Text = "";
            lblpt1.Text = "";
            lblpt2.Text = "";
        }

        private void ta1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y =" + tc1.Text; 
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y = " + tc1.Text;
        }

        private void tc1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y = " + tc1.Text;
        }

        private void ta2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text  = ta2.Text + "x + " + tb2.Text + "y = " + tc2.Text;
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text  = ta2.Text + "x + " + tb2.Text + "y = " + tc2.Text;
        }

        private void tc2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text  = ta2.Text + "x + " + tb2.Text + "y = " + tc2.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(ta1.Text);
            b1 = Convert.ToDouble(tb1.Text);
            c1 = Convert.ToDouble(tc1.Text);
            a2 = Convert.ToDouble(ta2.Text);
            b2 = Convert.ToDouble(tb2.Text);
            c2 = Convert.ToDouble(tc2.Text);

            d = a1 * b2 - a2 * b1;
            d1 = c1 * b2 - c2 * b1;
            d2 = a1 * c2 - a2 * c1;

            if ((a1/a2)!=(b1/b2)) 
            lblkq.Text="he phuong trinh co nghiem :\n x = "+d1/d+"\n y = "+d2/d;
           else
            if (((a1 / a2) == (b1 / b2)) &&((b1 / b2)== (c1 / c2)))
            lblkq.Text = "\t he phuong trinh vo so nghiem.";
           else
                if (((a1 / a2) == (b1 / b2)) && ((b1 / b2)!= (c1 / c2)))
            lblkq.Text = "\t he phuong trinh vo nghiem.";
           
        }

    }
}
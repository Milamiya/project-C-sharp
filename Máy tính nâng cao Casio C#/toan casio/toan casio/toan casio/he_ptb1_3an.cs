using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class he_ptb1_3an : Form
    {
        public he_ptb1_3an()
        {
            InitializeComponent();
        }
        double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, d4, h, hx, hy, hz;

        private void btdong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            ta1.Clear(); tb1.Clear(); tc1.Clear(); td1.Clear();
            ta2.Clear(); tb2.Clear(); tc2.Clear(); td2.Clear();
            ta3.Clear(); tb3.Clear(); tc3.Clear(); td3.Clear();
            lblpt1.Text = "";
            lblpt2.Text = "";
            lblpt3.Text = ""; 
            lblkq.Text = "";
        }


        private void ta1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y + " + tc1.Text+"z = " + td1.Text;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y + " + tc1.Text + "z = " + td1.Text;

        }

        private void tc1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y + " + tc1.Text + "z = " + td1.Text;

        }

        private void td1_TextChanged(object sender, EventArgs e)
        {
            lblpt1.Text = ta1.Text + "x + " + tb1.Text + "y + " + tc1.Text + "z = " + td1.Text;

        }


        private void ta2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text = ta2.Text + "x + " + tb2.Text + "y + " + tc2.Text + "z = " + td2.Text;

        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text = ta2.Text + "x + " + tb2.Text + "y + " + tc2.Text + "z = " + td2.Text;
        }

        private void tc2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text = ta2.Text + "x + " + tb2.Text + "y + " + tc2.Text + "z = " + td2.Text;
        }

        private void td2_TextChanged(object sender, EventArgs e)
        {
            lblpt2.Text = ta2.Text + "x + " + tb2.Text + "y + " + tc2.Text + "z = " + td2.Text;
        }


        private void ta3_TextChanged(object sender, EventArgs e)
        {
            lblpt3.Text = ta3.Text + "x + " + tb3.Text + "y + " + tc3.Text + "z = " + td3.Text;
        }

        private void tb3_TextChanged(object sender, EventArgs e)
        {
            lblpt3.Text = ta3.Text + "x + " + tb3.Text + "y + " + tc3.Text + "z = " + td3.Text;

        }

        private void tc3_TextChanged(object sender, EventArgs e)
        {
            lblpt3.Text = ta3.Text + "x + " + tb3.Text + "y + " + tc3.Text + "z = " + td3.Text;

        }

        private void td3_TextChanged(object sender, EventArgs e)
        {
            lblpt3.Text = ta3.Text + "x + " + tb3.Text + "y + " + tc3.Text + "z = " + td3.Text;

        }

        private void btgiai_Click(object sender, EventArgs e)
        {
            a1 = Convert.ToDouble(ta1.Text);
            b1 = Convert.ToDouble(tb1.Text);
            c1 = Convert.ToDouble(tc1.Text);
            d1 = Convert.ToDouble(td1.Text);

            a2 = Convert.ToDouble(ta2.Text);
            b2 = Convert.ToDouble(tb2.Text);
            c2 = Convert.ToDouble(tc2.Text);
            d2 = Convert.ToDouble(td2.Text);

            a3 = Convert.ToDouble(ta3.Text);
            b3 = Convert.ToDouble(tb3.Text);
            c3 = Convert.ToDouble(tc3.Text);
            d3 = Convert.ToDouble(td3.Text);

            h = a1 * b2 * c3 - a1 * c2 * b3 + b1 * a2 * c3 - b1 * c2 * a3 + c1 * a2 * b3 - c1 * a3 * b2;
            hx = d1 * b2 * c3 - d1 * c2 * b3 + b1 * d2 * c3 - b1 * c2 * d3 + c1 * d2 * b3 - c1 * d3 * b2;
            hy = a1 * d2 * c3 - a1 * c2 * d3 + d1 * a2 * c3 - d1 * c2 * a3 + c1 * a2 * d3 - c1 * a3 * d2;
            hz = a1 * b2 * d3 - a1 * d2 * b3 + b1 * a2 * d3 - b1 * d2 * a3 + d1 * a2 * b3 - d1 * a3 * b2;

            if (h == 0 && hx == 0 && hy == 0 && hz == 0)
                lblkq.Text = "he phuong trinh VO SO NGHIEM ! ";
            if (h == 0) if (hx != 0 || hy != 0 || hz != 0)
                    lblkq.Text = "He phuong trinh VO NGHIEM !";
            if (h != 0)
                lblkq.Text = "Nghiem cua he phuong trinh :\n x = "+hx/h+"\n y = "+hy/h+"\n z = "+hz/h;
        }

    }
}
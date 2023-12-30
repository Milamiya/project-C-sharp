using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class loglncs : Form
    {
        public loglncs()
        {
            InitializeComponent();
        }
        double log, mu ;
        const double E = 2.718281828;
        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();//Download source code tại Sharecode.vn
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txt10.Text = "";
            txte.Text="";
            txtln.Text="";
            txtlog.Text="";
            txtnlog.Text="";
            txtnmu.Text="";
            txtnlog.Focus();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            if (txtnlog.Text != "")
            {
                log =Convert.ToDouble(txtnlog.Text);
                if (log > 0)
                {
                    log = Math.Log10(log);
                    txtlog.Text = log.ToString();
                }
                else txtlog.Text = "Error";
            }
            else txtlog.Text  = "nhap co so";         
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            if (txtnlog.Text != "")
            {
                log =Convert.ToDouble(txtnlog.Text);
                if (log > 0)
                {
                log = Math.Log(log,E);
                txtln.Text = log.ToString();
                }
                else txtln.Text = "Error";
            }
            else txtlog.Text = "nhap co so"; 
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (txtnmu.Text != "")
            {
                mu = Convert.ToDouble(txtnmu.Text);
                mu = (Math.Pow(10, mu));
                txt10.Text = mu.ToString();
            }
            else txtnmu.Text = "nhap co so";
        }

        private void btne_Click(object sender, EventArgs e)
        {
            if (txtnmu.Text != "")
            {
                mu = Convert.ToDouble(txtnmu.Text);
                mu = (Math.Pow(E, mu));
                txte.Text = mu.ToString();
            }
            else txte.Text = "nhap co so";
        }

        private void txtnlog_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlog_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
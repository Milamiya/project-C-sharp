using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLPKT
{
    public partial class SA_Buy : Form
    {
        DataTable dt;

        public SA_Buy(DataTable dt1)
        {
            InitializeComponent();
            dt = dt1;
        }

        private void SA_Buy_Load(object sender, EventArgs e)
        {
            databuy.RowHeadersVisible = false;
            databuy.DataSource = dt.DefaultView;
        }

        public double get()
        {
            object sum = dt.Compute("sum(ThanhTien)", "SLMua>0");
            return double.Parse(sum.ToString());
        }
    }
}

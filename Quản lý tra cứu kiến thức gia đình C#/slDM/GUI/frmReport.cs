using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmReport : Form
    {
        private DataTable dt;

        public frmReport(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            crptMeoVat r = new crptMeoVat();
            
            r.SetDataSource(dt);
            crv.ReportSource = r;
        }
    }
}

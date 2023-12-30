using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlydoanvien
{
    public partial class frmInDP : DevComponents.DotNetBar.Office2007Form
    {
        public frmInDP()
        {
            InitializeComponent();
        }

        private void frmInDP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet3.DOANPHI' table. You can move, or remove it, as needed.
            this.DOANPHITableAdapter.Fill(this.DataSet3.DOANPHI);

            this.reportViewer1.RefreshReport();
        }
    }
}

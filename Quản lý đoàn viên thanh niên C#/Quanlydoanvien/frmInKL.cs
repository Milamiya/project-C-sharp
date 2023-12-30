using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlydoanvien
{
    public partial class frmInKL : DevComponents.DotNetBar.Office2007Form
    {
        public frmInKL()
        {
            InitializeComponent();
        }

        private void frmInKL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.KYLUAT' table. You can move, or remove it, as needed.
            this.KYLUATTableAdapter.Fill(this.DataSet2.KYLUAT);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlydoanvien
{
    public partial class frmInDVNu : DevComponents.DotNetBar.Office2007Form
    {
        public frmInDVNu()
        {
            InitializeComponent();
        }

        private void frmInDVNu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.DOANVIEN' table. You can move, or remove it, as needed.
            this.DOANVIENTableAdapter.Fill(this.DataSet1.DOANVIEN);

            this.reportViewer1.RefreshReport();
        }
    }
}

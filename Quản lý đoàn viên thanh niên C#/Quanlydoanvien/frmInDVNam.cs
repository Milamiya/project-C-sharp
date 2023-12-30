using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlydoanvien
{
    public partial class frmInDVNam : DevComponents.DotNetBar.Office2007Form
    {
        public frmInDVNam()
        {
            InitializeComponent();
        }

        private void frmInDVNam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet4.DOANVIEN' table. You can move, or remove it, as needed.
            this.DOANVIENTableAdapter.Fill(this.DataSet4.DOANVIEN);
            // TODO: This line of code loads data into the 'quanlydoanvienDataSet1.DOANVIEN' table. You can move, or remove it, as needed.
           

            this.reportViewer1.RefreshReport();
        }
    }
}

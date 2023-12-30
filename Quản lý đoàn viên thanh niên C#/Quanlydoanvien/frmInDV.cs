using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlydoanvien
{
    public partial class frmInDV : DevComponents.DotNetBar.Office2007Form
    {
        public frmInDV()
        {
            InitializeComponent();
        }

        private void frmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlydoanvienDataSet.DOANVIEN' table. You can move, or remove it, as needed.
            this.DOANVIENTableAdapter.Fill(this.quanlydoanvienDataSet.DOANVIEN);
            // TODO: This line of code loads data into the 'quanlydoanvienDataSet.DOANVIEN' table. You can move, or remove it, as needed.
           

            this.reportViewer1.RefreshReport();
        }
    }
}

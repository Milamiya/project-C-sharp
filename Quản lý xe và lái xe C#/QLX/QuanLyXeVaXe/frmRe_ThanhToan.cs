using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmRe_ThanhToan : Form
    {
        public frmRe_ThanhToan()
        {
            InitializeComponent();
        }
        public string a { get; set; }
        private void frmRe_ThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DTSThanhToan.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DTSThanhToan.DataTable1,a);

            this.reportViewer1.RefreshReport();
        }
    }
}

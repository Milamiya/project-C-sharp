using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmReKoLaiXe : Form
    {
        public frmReKoLaiXe()
        {
            InitializeComponent();
        }
        public string a { get; set; }
        private void frmReKoLaiXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DtdTraXeKhongNguoiLai.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DtdTraXeKhongNguoiLai.DataTable1, a);

            this.reportViewer1.RefreshReport();
        }
    }
}

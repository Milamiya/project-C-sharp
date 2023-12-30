using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmReTatCaXe : Form
    {
        public frmReTatCaXe()
        {
            InitializeComponent();
        }

        private void frmReTatCaXe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dts_TatCaXe.tb_LaiXe' table. You can move, or remove it, as needed.
            this.tb_LaiXeTableAdapter.Fill(this.Dts_TatCaXe.tb_LaiXe);

            this.reportViewer1.RefreshReport();
        }
    }
}

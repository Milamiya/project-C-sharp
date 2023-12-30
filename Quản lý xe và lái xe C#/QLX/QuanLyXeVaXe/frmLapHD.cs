using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmLapHD : Form
    {
        public frmLapHD()
        {
            InitializeComponent();
        }

        private void frmLapHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1_LapHD.tb_KhachHang' table. You can move, or remove it, as needed.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.tb_KhachHangTableAdapter.Fill(this.DataSet1_LapHD.tb_KhachHang, txtmakh.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frmReTraXeCoNguoiLai : Form
    {
        public frmReTraXeCoNguoiLai()
        {
            InitializeComponent();
        }
        public string a { get; set; }
        private void frmReTraXeCoNguoiLai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DTS_TraXeKoNguoilai.tb_ChiTietPhieuTra' table. You can move, or remove it, as needed.
            this.tb_ChiTietPhieuTraTableAdapter.Fill(this.DTS_TraXeKoNguoilai.tb_ChiTietPhieuTra,a);

            this.reportViewer1.RefreshReport();
        }
    }
}

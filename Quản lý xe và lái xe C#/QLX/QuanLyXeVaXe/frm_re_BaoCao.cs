using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyXeVaXe
{
    public partial class frm_re_BaoCao : Form
    {
        public frm_re_BaoCao()
        {
            InitializeComponent();
        }

        private void frm_re_BaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dts_kHthanhtoan.tb_HopDong' table. You can move, or remove it, as needed.
            this.tb_HopDongTableAdapter.Fill(this.dts_kHthanhtoan.tb_HopDong);
            // TODO: This line of code loads data into the 'Dts_TatCaNhanVien.tb_NhanVirn' table. You can move, or remove it, as needed.
            this.tb_NhanVirnTableAdapter.Fill(this.Dts_TatCaNhanVien.tb_NhanVirn);
            // TODO: This line of code loads data into the 'DTS_TatCaXe2.tb_Xe' table. You can move, or remove it, as needed.
            this.tb_XeTableAdapter.Fill(this.DTS_TatCaXe2.tb_Xe);
            // TODO: This line of code loads data into the 'Dts_TatCaXe.tb_LaiXe' table. You can move, or remove it, as needed.
            this.tb_LaiXeTableAdapter.Fill(this.Dts_TatCaXe.tb_LaiXe);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}

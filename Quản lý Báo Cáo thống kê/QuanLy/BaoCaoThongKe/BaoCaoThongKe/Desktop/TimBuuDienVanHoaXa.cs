using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BaoCaoThongKe.Controller;

namespace BaoCaoThongKe.Desktop
{
    public partial class TimBuuDienVanHoaXa : Office2007Form
    {
        DaiLyBuuDienVHX_Ctrl provhx = new DaiLyBuuDienVHX_Ctrl();

        public TimBuuDienVanHoaXa()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimBuuDienVanHoaXa_Load(object sender, EventArgs e)
        {
            //provhx.ListBuuDien_vhx1(gridControl1, bindingNavigator1);
        }

        private void txtTukhoa_TextChanged(object sender, EventArgs e)
        {
            //if (cmbLoai.Text == "Tên đại lý")
            //    provhx.Timvhx_Tendaily(txtTukhoa, gridControl1);
            //if (cmbLoai.Text == "Doanh nghiệp")
            //    provhx.Timvhx_Doanhnghiep(txtTukhoa, gridControl1);
            //if (cmbLoai.Text == "Huyện")
            //    provhx.Timvhx_Huyen(txtTukhoa, gridControl1);
            //if (cmbLoai.Text == "Xã")
            //    provhx.Timvhx_Xa(txtTukhoa, gridControl1);
        }

    }
}
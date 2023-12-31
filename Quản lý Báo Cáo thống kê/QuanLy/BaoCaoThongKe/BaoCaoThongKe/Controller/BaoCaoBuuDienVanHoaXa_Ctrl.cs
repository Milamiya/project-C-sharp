using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoBuuDienVanHoaXa_Ctrl
    {
        BaoCaoBuuDienVanHoaXa_Data dbbaocao = new BaoCaoBuuDienVanHoaXa_Data();

        public void ListBaoCao_vhx(string ma, DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbbaocao.ChiTietBaoCao_vhx(ma);
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public bool CheckInput(TextBoxX dienthoai)
        {
            if (dienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập điện thoai !", "Chú ý", MessageBoxButtons.OK);
                dienthoai.Focus();
                return false;
            }

            return true;
        }

        public void Them_vhx(BaoCaoDaiLyBuuDienVHX_InFo baocao)
        {
            dbbaocao.Them(baocao);
        }

        public void Xoa_vhx(BaoCaoDaiLyBuuDienVHX_InFo baocao)
        {
            dbbaocao.Xoa(baocao);
        }

        public void Sua_vhx(BaoCaoDaiLyBuuDienVHX_InFo baocao)
        {
            dbbaocao.Sua(baocao);
        }

        public void XoaToanBo_vhx(string ma)
        {
            dbbaocao.XoaToanBo(ma);
        }
    }
}

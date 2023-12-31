using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;
using DevComponents.DotNetBar.Controls;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoDaiLyBuuDien_Ctrl
    {
        BaoCaoDaiLyBuuDien_Data dbbaocao = new BaoCaoDaiLyBuuDien_Data();

        public void ListBaoCao(string ma, DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbbaocao.ChiTietBaoCao(ma);
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

        public void Them(BaoCaoDaiLyBuuDien_InFo baocao)
        {
            dbbaocao.Them(baocao);
        }

        public void Xoa(BaoCaoDaiLyBuuDien_InFo baocao)
        {
            dbbaocao.Xoa(baocao);
        }

        public void Sua(BaoCaoDaiLyBuuDien_InFo baocao)
        {
            dbbaocao.Sua(baocao);
        }

        public void XoaToanBo(string ma)
        {
            dbbaocao.XoaToanBo(ma);
        }
    }
}

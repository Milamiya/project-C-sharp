using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoDaiLyInternet_Ctrl
    {
        BaoCaoDaiLyInternet_Data dbbaocaoInt = new BaoCaoDaiLyInternet_Data();


        public void ListBaoCao_Int(string maInt, DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbbaocaoInt.ChiTietBaoCao_Int(maInt);
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

        public void Them_Int(BaoCaoDaiLyInternet_InFo baocaoInt)
        {
            dbbaocaoInt.Them_Int(baocaoInt);
        }

        public void Xoa_Int(BaoCaoDaiLyInternet_InFo baocaoInt)
        {
            dbbaocaoInt.Xoa_Int(baocaoInt);
        }

        public void Sua_Int(BaoCaoDaiLyInternet_InFo baocaoInt)
        {
            dbbaocaoInt.Sua_Int(baocaoInt);
        }

        public void XoaToanBo_Int(string maInt)
        {
            dbbaocaoInt.XoaToanBo_Int(maInt);
        }

    }
}

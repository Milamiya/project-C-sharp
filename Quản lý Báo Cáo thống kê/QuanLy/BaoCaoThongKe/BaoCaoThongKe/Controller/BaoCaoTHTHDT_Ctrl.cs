using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.BusinessObject;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoTHTHDT_Ctrl
    {
        BaoCaoTHTHDT_Data dbbaocao = new BaoCaoTHTHDT_Data();

        public void ListBaoCao(string ma, DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbbaocao.ChiTietBaoCao(ma);
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public bool CheckInput(TextBoxX von, TextBoxX luyke)
        {
            if (von.Text == "")
            {
                MessageBox.Show("Chưa nhập mức vốn đầu tư thực hiện !", "Chú ý", MessageBoxButtons.OK);
                von.Focus();
                return false;
            }

            if (luyke.Text == "")
            {
                MessageBox.Show("Chưa nhập lũy kế vốn đầu tư thực hiện từ khi khởi công đến cuối quý báo cáo!", "Chú ý", MessageBoxButtons.OK);
                luyke.Focus();
                return false;
            }

            return true;
        }

        public void Them(BaoCaoTHTHDT_InFo baocao)
        {
            dbbaocao.Them(baocao);
        }

        public void Xoa(BaoCaoTHTHDT_InFo baocao)
        {
            dbbaocao.Xoa(baocao);
        }

        public void Sua(BaoCaoTHTHDT_InFo baocao)
        {
            dbbaocao.Sua(baocao);
        }

        public void XoaToanBo(string ma)
        {
            dbbaocao.XoaToanBo(ma);
        }
    }
}

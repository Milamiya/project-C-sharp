using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.BusinessObject;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoTHTHCLDV_Ctrl
    {
        BaoCaoTHTHCLDV_Data dbbaocao = new BaoCaoTHTHCLDV_Data();

        public void ListBaoCao(string ma, DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbbaocao.ChiTietBaoCao(ma);
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public bool CheckInput(TextBoxX vanban, TextBoxX doanhnghiep)
        {
            if (vanban.Text == "")
            {
                MessageBox.Show("Chưa nhập tên văn bản công bố !", "Chú ý", MessageBoxButtons.OK);
                vanban.Focus();
                return false;
            }

            if (doanhnghiep.Text == "")
            {
                MessageBox.Show("Chưa nhập tên doanh nghiệp ban hành văn bản công bố!", "Chú ý", MessageBoxButtons.OK);
                doanhnghiep.Focus();
                return false;
            }

            return true;
        }

        public void Them(BaoCaoTHTHCLDV_InFo baocao)
        {
            dbbaocao.Them(baocao);
        }
        public void Xoa(BaoCaoTHTHCLDV_InFo baocao)
        {
            dbbaocao.Xoa(baocao);
        }
        public void Sua(BaoCaoTHTHCLDV_InFo baocao)
        {
            dbbaocao.Sua(baocao);
        }
        public void XoaToanBo(string ma)
        {
            dbbaocao.XoaToanBo(ma);
        }
    }
}

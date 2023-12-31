using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Controller
{
    public class BaoCaoChiTietCTVT_Ctrl
    {
        BaoCaoChiTietCTVT_Data dbbaocao = new BaoCaoChiTietCTVT_Data();

        public void ListBaoCao(string mabaocao, string macongtrinh, DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbbaocao.ChiTietBaoCao(mabaocao, macongtrinh);
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public int LayMaMax()
        {
            BaoCaoChiTietCTVT_Data dbbaocao = new BaoCaoChiTietCTVT_Data();
            DataTable table = dbbaocao.LayMaMax();
            try
            {
                int i = Convert.ToInt32(table.Rows[0][0].ToString());
                return ++i;
            }
            catch (Exception e)
            {
                e.ToString();
                return 1;
            }
        }

        public bool CheckInput(TextBoxX diachi, TextBoxX daitanso)
        {
            if (diachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ công trình !", "Chú ý", MessageBoxButtons.OK);
                diachi.Focus();
                return false;
            }
            if (daitanso.Text == "")
            {
                MessageBox.Show("Chưa nhập dải tần số và công suất máy phát vô tuyến của công trình !", "Chú ý", MessageBoxButtons.OK);
                daitanso.Focus();
                return false;
            }
            return true;
        }

        public void Them(BaoCaoChiTietCTVT_InFo baocao)
        {
            dbbaocao.Them(baocao);
        }

        public void Xoa(BaoCaoChiTietCTVT_InFo baocao)
        {
            dbbaocao.Xoa(baocao);
        }

        public void Sua(BaoCaoChiTietCTVT_InFo baocao)
        {
            dbbaocao.Sua(baocao);
        }

        public void XoaToanBo(string mabaocao, string macongtrinh)
        {
            dbbaocao.XoaToanBo(mabaocao, macongtrinh);
        }
    }
}

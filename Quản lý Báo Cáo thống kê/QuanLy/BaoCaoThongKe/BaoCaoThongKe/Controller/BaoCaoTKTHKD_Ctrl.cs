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
    public class BaoCaoTKTHKD_Ctrl
    {
        DataService DT_SV = new DataService();
        BaoCaoTKTHKD_Data dbbaocao = new BaoCaoTKTHKD_Data();

        public void ListBaoCao(string ma, DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbbaocao.ChiTietBaoCao(ma);
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public bool CheckInput(TextBoxX soluong)
        {
            if (soluong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng của công trình !", "Chú ý", MessageBoxButtons.OK);
                soluong.Focus();
                return false;
            }

            return true;
        }
        public void Update()
        {
            DT_SV.Update();
        }
        //

        public void Them(BaoCaoTKTHKD_InFo baocao)
        {
            dbbaocao.Them(baocao);
        }

        public void Xoa(BaoCaoTKTHKD_InFo baocao)
        {
            dbbaocao.Xoa(baocao);
        }

        public void Sua(BaoCaoTKTHKD_InFo baocao)
        {
            dbbaocao.Sua(baocao);
        }

        public void XoaToanBo(string ma)
        {
            dbbaocao.XoaToanBo(ma);
        }
    }
}

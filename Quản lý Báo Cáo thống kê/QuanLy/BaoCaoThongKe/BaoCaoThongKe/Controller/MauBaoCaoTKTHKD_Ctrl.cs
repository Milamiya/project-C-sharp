using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Controller
{
    public class MauBaoCaoTKTHKD_Ctrl
    {
        MauBaoCaoTKTHKD_Data dbmaubaocao = new MauBaoCaoTKTHKD_Data();

        public void ListMauBaoCao(DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbmaubaocao.ChiTietMauBaoCao();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public int LayMaMax()
        {
            DataTable table = dbmaubaocao.LayMaMax();
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

        public bool CheckInput(TextBoxX tenmaubaocao)
        {
            if (tenmaubaocao.Text == "")
            {
                MessageBox.Show("Chưa nhập tên mẫu báo cáo !", "Chú ý", MessageBoxButtons.OK);
                tenmaubaocao.Focus();
                return false;
            }
            else
            {
                if (tenmaubaocao.Text.Length > 200)
                {
                    MessageBox.Show("Nhập tên mẫu báo cáo không quá 200 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    tenmaubaocao.Focus();
                    return false;
                }
            }
            return true;
        }

        public void Them(MauBaoCaoTKTHKD_InFo maubaocao)
        {
            dbmaubaocao.Them(maubaocao);
        }

        public void Xoa(MauBaoCaoTKTHKD_InFo maubaocao)
        {
            dbmaubaocao.Xoa(maubaocao);
        }

        public void Sua(MauBaoCaoTKTHKD_InFo maubaocao)
        {
            dbmaubaocao.Sua(maubaocao);
        }
    }
}

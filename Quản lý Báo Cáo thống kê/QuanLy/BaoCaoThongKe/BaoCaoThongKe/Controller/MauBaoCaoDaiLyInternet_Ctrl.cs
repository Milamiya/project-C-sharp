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
    public class MauBaoCaoDaiLyInternet_Ctrl
    {
        MauBaoCaoDaiLyInternet_Data dbmaubaocaoInt = new MauBaoCaoDaiLyInternet_Data();

        public void ListMauBaoCao_Int(DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbmaubaocaoInt.ChiTietMauBaoCao_Int();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public int LayMaMax()
        {
            DataTable table = dbmaubaocaoInt.LayMaMax();
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

        public bool CheckInput(TextBoxX tenmaubaocaoInt)
        {
            if (tenmaubaocaoInt.Text == "")
            {
                MessageBox.Show("Chưa nhập tên mẫu báo cáo !", "Chú ý", MessageBoxButtons.OK);
                tenmaubaocaoInt.Focus();
                return false;
            }
            else
            {
                if (tenmaubaocaoInt.Text.Length > 200)
                {
                    MessageBox.Show("Nhập tên mẫu báo cáo không quá 200 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    tenmaubaocaoInt.Focus();
                    return false;
                }
            }
            return true;
        }

        public void Them_Int(MauBaoCaoDaiLyInternet_InFo maubaocaoInt)
        {
            dbmaubaocaoInt.Them_Int(maubaocaoInt);
        }
        public void Xoa_Int(MauBaoCaoDaiLyInternet_InFo maubaocaoInt)
        {
            dbmaubaocaoInt.Xoa_Int(maubaocaoInt);
        }
        public void Sua_Int(MauBaoCaoDaiLyInternet_InFo maubaocaoInt)
        {
            dbmaubaocaoInt.Sua_Int(maubaocaoInt);
        }
    }
}

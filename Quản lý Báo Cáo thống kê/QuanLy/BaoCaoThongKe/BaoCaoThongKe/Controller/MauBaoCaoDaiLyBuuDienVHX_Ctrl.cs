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
    public class MauBaoCaoDaiLyBuuDienVHX_Ctrl
    {
        MauBaoCaoDaiLyBuuDienVHX_Data dbmaubaocao_vhx = new MauBaoCaoDaiLyBuuDienVHX_Data();
        
        public void ListMauBaoCao_vhx(DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dbmaubaocao_vhx.ChiTietMauBaoCao_vhx();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public int LayMaMax()
        {
            DataTable table = dbmaubaocao_vhx.LayMaMax();
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
        //
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
        public void Them_vhx(MauBaoCaoDaiLyBuuDienVHX_InFo maubaocao)
        {
            dbmaubaocao_vhx.Them_vhx(maubaocao);
        }
        public void Xoa_vhx(MauBaoCaoDaiLyBuuDienVHX_InFo maubaocao)
        {
            dbmaubaocao_vhx.Xoa_vhx(maubaocao);
        }
        public void Sua_vhx(MauBaoCaoDaiLyBuuDienVHX_InFo maubaocao)
        {
            dbmaubaocao_vhx.Sua_vhx(maubaocao);
        }
    }
}

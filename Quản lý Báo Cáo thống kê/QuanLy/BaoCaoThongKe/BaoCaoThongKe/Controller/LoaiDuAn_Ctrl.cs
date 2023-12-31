using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;

using BaoCaoThongKe.DataLayer;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.Controller
{

    public class LoaiDuAn_Ctrl
    {
        LoaiDuAn_Data DATA = new LoaiDuAn_Data();

        public void Show_DSS_LoaiDuAn(BindingNavigator bdn, GridControl dgv)
        {
            BindingSource BD_S = new BindingSource();
            DataTable D_TT = DATA.Show_DS_LoaiDuAn();
            BD_S.DataSource = D_TT;
            bdn.BindingSource = BD_S;
            dgv.DataSource = BD_S;
        }
        public void Update()
        {
            DATA.Update();
        }
        //bao cao

        public void ListLoaiDuAn(DataGridViewX dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DATA.Show_DS_LoaiDuAn();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public int LayMaMax()
        {
            LoaiDuAn_Data loaiduan = new LoaiDuAn_Data();
            DataTable table = loaiduan.LayMaMax();
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

        public void Load_Combobox_Loaiduan(ComboBox cb)
        {
            cb.DataSource = DATA.Show_DS_LoaiDuAn();

            cb.DisplayMember = "TenLoaiDuAn";
            cb.ValueMember = "MaLoaiDuAn";
        }

        public bool CheckInput(TextBoxX tenloaiduan)
        {
            if (tenloaiduan.Text == "")
            {
                MessageBox.Show("Chưa nhập Loại dự án !", "Chú ý", MessageBoxButtons.OK);
                tenloaiduan.Focus();
                return false;
            }
            else
            {
                if (tenloaiduan.Text.Length > 50)
                {
                    MessageBox.Show("Nhập tên loại dự án không quá 50 ký tự ", "Chú ý", MessageBoxButtons.OK);
                    tenloaiduan.Focus();
                    return false;
                }
            }
            return true;
        }

        public void Them(LoaiDuAn_InFo loaiduan)
        {
            DATA.Them(loaiduan);
        }

        public void Xoa(LoaiDuAn_InFo loaiduan)
        {
            DATA.Xoa(loaiduan);
        }

        public void Sua(LoaiDuAn_InFo loaiduan)
        {
            DATA.Sua(loaiduan);
        }
        //
        public int GetLastID()
        {
            if (this.DATA == null)
            {
                this.DATA = new LoaiDuAn_Data();
            }
            return Convert.ToInt32(this.DATA.GetLastID());
        }

    }
}

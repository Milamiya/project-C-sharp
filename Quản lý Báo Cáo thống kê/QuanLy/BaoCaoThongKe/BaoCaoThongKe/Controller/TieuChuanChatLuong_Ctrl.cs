using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using BaoCaoThongKe.DataLayer;
namespace BaoCaoThongKe.Controller
{
    public class TieuChuanChatLuong_Ctrl
    {
        TieuChuanChatLuong_Data DATA = new TieuChuanChatLuong_Data();
        public void Show_DS_TieuChuan(BindingNavigator bdn, GridControl dgv)
        {
            DataTable DTT = DATA.HienThi_DS_TieuChuan();
            BindingSource BD_S = new BindingSource();            
            BD_S.DataSource = DTT;
            bdn.BindingSource = BD_S;
            dgv.DataSource = BD_S;
        }
        public void Update()
        {
            DATA.Update();
        }
        //bao cao
        public void Load_ComboBox_TieuchuanCL(ComboBox cb)
        {
            cb.DataSource = DATA.HienThi_DS_TieuChuan();
            cb.DisplayMember = "TenTieuChuanCL";
            cb.ValueMember = "MaTieuChuanCL";
        }
        //
        public int GetLastID()
        {
            if (this.DATA == null)
            {
                this.DATA = new TieuChuanChatLuong_Data();
            }
            return Convert.ToInt32(this.DATA.GetLastID());
        }
    }
}

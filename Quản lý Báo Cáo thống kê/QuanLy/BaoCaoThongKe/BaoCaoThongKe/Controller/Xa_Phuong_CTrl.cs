using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;

using BaoCaoThongKe.BusinessObject;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Controller
{
    public class Xa_Phuong_CTrl
    {
        DataService DT_SV = new DataService();
        Xa_Phuong_Data DATA = new Xa_Phuong_Data();

        public void Show_DS_Xa_Phuong(BindingNavigator BDN,GridControl DNG)
        {
            BindingSource BD_S = new BindingSource();
            DataTable D_TT = DATA.DanhSach_Xa_Phuong();
            BD_S.DataSource = D_TT;
            BDN.BindingSource = BD_S;
            DNG.DataSource = BD_S;
 
        }
        //
        public int GetLastID()
        {
            if (this.DATA == null)
            {
                this.DATA = new Xa_Phuong_Data();
            }
            return Convert.ToInt32(this.DATA.GetLastID());
        }
        public void Update()
        {
            DT_SV.Update();
        }
        public void ComboBoxXa(ComboBoxEx cmbXa)
        {
            cmbXa.DataSource = DATA.DanhSach_Xa_Phuong();
            cmbXa.DisplayMember = "TenXa";
            cmbXa.ValueMember = "MaXa";
        }
        public void ListXa(ComboBoxEx cmb, int maHuyen)
        {
            cmb.DataSource = DATA.ChiTietXa(maHuyen);
            cmb.DisplayMember = "TenXa";
            cmb.ValueMember = "MaXa";
        }
        public string LayMaHuyen(string MaXa)
        {
            return DATA.LayMaHuyen(MaXa);
        }
    }
}

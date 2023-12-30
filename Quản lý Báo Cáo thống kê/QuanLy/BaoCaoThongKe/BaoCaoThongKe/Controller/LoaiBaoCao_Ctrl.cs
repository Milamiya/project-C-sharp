using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Controller
{
    public class LoaiBaoCao_Ctrl
    {
        LoaiBaoCao_Data DATA = new LoaiBaoCao_Data();
        
        public void Show_LoaiBaoCao(BindingNavigator bdn, GridControl dgv)
        {
            BindingSource BD_S = new BindingSource();
            BD_S.DataSource = DATA.Show_Ds_LoaiBaoCao();
            bdn.BindingSource = BD_S;
            dgv.DataSource = BD_S;
        }
        //bao cao
        public void Combobox_Loaibaocao(ComboBox cb)
        {
            cb.DataSource = DATA.Show_Ds_LoaiBaoCao();
            cb.DisplayMember = "TenLoaiBaoCao";
            cb.ValueMember = "MaLoaiBaoCao";
        }
        public void Update()
        {
            DATA.Update();
        }
        public int GetLastID()
        {
            if (this.DATA == null)
            {
                this.DATA = new LoaiBaoCao_Data();
            }
            return Convert.ToInt32(this.DATA.GetLastID());
        }

    }
}

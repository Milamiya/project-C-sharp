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
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.DataLayer;

namespace BaoCaoThongKe.Controller
{
    public class DonViTinh_Ctrl
    {
        DonViTinh_Data data = new DonViTinh_Data();
        public void DanhsachDonViTinh(GridControl dg, BindingNavigator bn)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = data.Show_DVTinh();
            bn.BindingSource = bs;
            dg.DataSource = bs;
        }

        public void Update()
        {
            data.Update();
        }
        //
        public int GetLastID()
        {
            if (this.data == null)
            {
                this.data = new DonViTinh_Data();
            }
            return Convert.ToInt32(this.data.GetLastID());
        }
    }
}

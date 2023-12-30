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

    public class Huyen_Thi_Ctrl
    {
        DataService DT_SV = new DataService();
        Huyen_Thi_Data DATA = new Huyen_Thi_Data();

        public void HienThiDanhSach_Huyen_Thi(BindingNavigator bdn, GridControl dgv)
        {
            BindingSource BD_S = new BindingSource();
            BD_S.DataSource = DATA.HienThiDanhSachHuyen();
            bdn.BindingSource = BD_S;
            dgv.DataSource = BD_S;

        }
        public void ComboBoxHuyen(ComboBoxEx cmbHuyen)
        {
            cmbHuyen.DataSource = DATA.HienThiDanhSachHuyen();
            cmbHuyen.DisplayMember = "TenHuyen";
            cmbHuyen.ValueMember = "MaHuyen";
        }

        public void Update()
        {
            DATA.Update();
        }
        //
        public int GetLastID()
        {
            if (this.DATA == null)
            {
                this.DATA = new Huyen_Thi_Data();
            }
            return Convert.ToInt32(this.DATA.GetLastID());
        }

    }

}     
   



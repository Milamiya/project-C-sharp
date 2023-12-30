using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraGrid;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class QL_DoanhNghiep_Data
    {
        QL_DoanhNghiep_InFo info = new QL_DoanhNghiep_InFo(); 
        DataService DT_SV = new DataService();
        public DataTable Show_DoanhNghiep()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DoanhNghiep");
            DT_SV.Load(cmd);
            return DT_SV;
        }

        public void Update()
        {
            DT_SV.Update();
        }
        //
        public DataTable Timdoanhnghiep_baocao(string tendn)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "select * from DoanhNghiep where TenDoanhNghiep = @tendn ";
            cmd.Parameters.Add("@tendn", SqlDbType.NVarChar, 255).Value = tendn;
            cmd.CommandText = sql;
            DT_SV.Load(cmd);

            return DT_SV;
        }
        //
        public object GetLastID()
        {
            if (this.DT_SV == null)
            {
                this.DT_SV = new DataService();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM DoanhNghiep ORDER BY MaDoanhNghiep DESC");
            return DT_SV.ExecuteScalar(cmd);
        }
    }
}

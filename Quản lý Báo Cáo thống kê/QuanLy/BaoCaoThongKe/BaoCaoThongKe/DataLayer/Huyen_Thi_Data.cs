using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
     public class Huyen_Thi_Data
    {
         DataService DT_SV = new DataService();

         public DataTable HienThiDanhSachHuyen()
         {
             SqlCommand cmd = new SqlCommand("SELECT * FROM Huyen");
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
             SqlCommand cmd = new SqlCommand("SELECT * FROM Huyen ORDER BY MaHuyen DESC");
             return DT_SV.ExecuteScalar(cmd);
         }

         public void Update()
         {
             DT_SV.Update();
         }

    }
}

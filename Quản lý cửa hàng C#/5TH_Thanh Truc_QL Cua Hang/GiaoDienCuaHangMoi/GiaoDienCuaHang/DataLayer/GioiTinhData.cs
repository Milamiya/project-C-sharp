using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class GioiTinhData
    {
       DataService ds = new DataService();
       public DataTable LayDSGioiTinh()
       {
           SqlCommand cmd = new SqlCommand("select * from GIOITINH");
           ds.Load(cmd);
           return ds;
       }
       public void Update()
       {
           ds.Update();
       }
    }
}

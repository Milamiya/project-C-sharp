using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace GiaoDienCuaHang.DataLayer
{
   public class LoaiNhanVienData
    {
       DataService ds = new DataService();
       public DataTable LayDSLoaiNhanVien()
       {
           SqlCommand cmd = new SqlCommand("select * from LOAINHANVIEN");
           ds.Load(cmd);
           return ds;
       }
       public void Update()
       {
           ds.Update();
       }
    }
}

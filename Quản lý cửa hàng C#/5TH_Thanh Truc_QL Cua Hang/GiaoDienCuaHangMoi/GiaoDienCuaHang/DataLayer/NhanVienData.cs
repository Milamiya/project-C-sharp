using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class NhanVienData
    {
       DataService ds = new DataService();
       public DataTable LayDSNhanVien()
       {
           SqlCommand cmd = new SqlCommand("select * from NHANVIEN");
           ds.Load(cmd);
           return ds;   
       }
       public DataTable LayNhanvien(String username)
       {
           String sql = "SELECT * FROM NHANVIEN WHERE USERNAME = @ten";
           SqlCommand cd = new SqlCommand(sql);
           cd.Parameters.Add("ten", SqlDbType.VarChar).Value = username;
           ds.Load(cd);

           return ds;

       }
       public void Update()
       {
           ds.Update();
       }
       
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class NhaCungCapData
    {
       DataService ds = new DataService();
       public DataTable LayDSNhaCungCap()
       {
           SqlCommand cmd = new SqlCommand("select * from NHACUNGCAP");
           ds.Load(cmd);
           return ds;
       }
       public DataTable LayNhaCungCap(String username)
       {
           String sql = "SELECT * FROM NHANVIEN WHERE USERNAME = @ten";
           SqlCommand cd = new SqlCommand(sql);
           cd.Parameters.Add("ten", SqlDbType.VarChar).Value = username;
           ds.Load(cd);

           return ds;

       }
       public DataTable TKNhaCungCap(String TenNCC, String chondchi, String dchi, String chondthoai, String dthoai)
       {

           SqlCommand cmd = new SqlCommand();
           String SQL = "SELECT * FROM NHACUNGCAP WHERE TENNCC LIKE '%' + @tNCC + '%' ";

           cmd.Parameters.Add("tNCC", SqlDbType.NVarChar).Value = TenNCC; 
           if (chondchi != "NONE")
           {
               SQL += chondchi + " DIACHI LIKE '%' + @dc  + '%' ";
               cmd.Parameters.Add("dc", SqlDbType.NVarChar).Value = dchi;

           }

           if (chondthoai != "NONE")
           {
               SQL += chondthoai + " DIENTHOAI LIKE '%' + @dt  + '%' ";
               cmd.Parameters.Add("dt", SqlDbType.VarChar).Value = dthoai;
           }

           cmd.CommandText = SQL;

           ds.Load(cmd);

           return ds;


       }
       public void Update()
       {
           ds.Update();
       }
    }
}

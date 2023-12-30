using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace GiaoDienCuaHang.DataLayer
{
   public class DonViTinhData
    {
       DataService ds = new DataService();
       public DataTable LayDSDonViTinh()
       {
           SqlCommand cmd = new SqlCommand("select * from DONVITINH");
           ds.Load(cmd);
           return ds;
       }
       public DataTable TimKiemDVT(String ten)
       {
          
           
           SqlCommand cmd = new SqlCommand();
           String SQL = "SELECT * FROM DONVITINH WHERE TENDVT LIKE '%' + @ht + '%' ";

           cmd.Parameters.Add("ht", SqlDbType.VarChar).Value = ten;

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

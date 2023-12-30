using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class KhachHangData
    {
       DataService ds = new DataService();
       public DataTable LayDSKhachHang()
       {
           SqlCommand cmd = new SqlCommand("select * from KHACHHANG");
           ds.Load(cmd);
           return ds;
       }
       public DataTable TKKhachHang(String tenkhachhang, String chondchi, String dchi, String chondthoai, String dthoai)
       {

           SqlCommand cmd = new SqlCommand();
           String SQL = "SELECT * FROM KHACHHANG WHERE HOTEN LIKE '%' + @tKH + '%' ";

           cmd.Parameters.Add("tKH", SqlDbType.NVarChar).Value = tenkhachhang;

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

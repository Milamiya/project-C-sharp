using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class ChiTietPhieuNhanHangData
    {
       DataService ds = new DataService();
       public DataTable LayDSChiTietPNH()
       {
           SqlCommand cmd = new SqlCommand("select * from CHITIETPHIEUNHANHANG");
           ds.Load(cmd);
           return ds;
       }
       public DataTable LayDS_CT_PNH(string strMaPhieu)
       {
           String Sql="select * from CHITIETPHIEUNHANHANG where MAPHIEU='"+strMaPhieu+"'";
           SqlCommand cmd = new SqlCommand(Sql);
           ds.Load(cmd);
           return ds;
       }
    }
}

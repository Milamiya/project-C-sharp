using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class ChiTietPhieuBanHangData
    {
       DataService ds = new DataService();
       public DataTable LayDSCTPBH()
       {
           SqlCommand cmd = new SqlCommand("select * from CHITIETPHIEUBANHANG");
           ds.Load(cmd);
           return ds;
       }
       public DataTable LayDS_CT_PBH(string strMAPHIEU)
       {
           String sql="select * from CHITIETPHIEUBANHANG where MAPHIEU='" +strMAPHIEU+ "' ";
           SqlCommand cmd = new SqlCommand(sql);
           ds.Load(cmd);
           return ds;
       }
       public void Update()
       {
           ds.Update();
       }
    }
}

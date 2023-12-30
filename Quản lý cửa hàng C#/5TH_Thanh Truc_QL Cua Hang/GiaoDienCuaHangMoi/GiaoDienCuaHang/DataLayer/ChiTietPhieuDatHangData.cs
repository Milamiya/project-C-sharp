using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class ChiTietPhieuDatHangData
    {
       DataService ds = new DataService();
       public DataTable LayDSCTPDH()
       {
           SqlCommand cmd = new SqlCommand("select * from CHITIETPHIEUDATHANG");
           ds.Load(cmd);
           return ds;
       }
       public DataTable LayDS_CT_PDH(string strMaPDH)
       {
           String Sql="select * from CHITIETPHIEUDATHANG where MAPHIEUDATHANG='"+strMaPDH+"' ";
           SqlCommand cmd = new SqlCommand(Sql);
           ds.Load(cmd);
           return ds;
       }
       public void Update()
       {
           ds.Update();
       }
    }
}

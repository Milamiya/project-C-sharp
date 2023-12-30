using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class PhieuNhanHangData
    {
      
       DataService ds = new DataService();
       public DataTable LayDSPNH()
       {
           SqlCommand cmd = new SqlCommand("select * from PHIEUNHANHANG");
           ds.Load(cmd);
           return ds;
       }
       public DataTable LayDS_CT_PNH()
       {
           SqlCommand cmd = new SqlCommand("select * from CHITIETPHIEUNHANHANG");
           ds.Load(cmd);
           return ds;
       }
       public DataTable LayDS_PhieuNhanHang(String pnh)
       {
           SqlCommand cmd = new SqlCommand("select * from PHIEUNHANHANG where MANV=@v");

           cmd.Parameters.Add("v", SqlDbType.VarChar).Value = pnh;
           ds.Load(cmd);
           return ds;
       }
       public DataRow NewRow()
       {
           return ds.NewRow();
       }
       public void Add(DataRow r)
       {
           ds.Rows.Add(r);
       }
       public DataTable TimKiemPhieuNhanHang(String MaNCC, String chonMaNV, String MaNV, String chonNgayLap, DateTime TuNgay, DateTime DenNgay)
       {

           SqlCommand cmd = new SqlCommand();
           String SQL = "SELECT * FROM PHIEUNHANHANG WHERE MANCC LIKE '%' + @Mancc + '%' ";

           cmd.Parameters.Add("Mancc", SqlDbType.VarChar).Value = MaNCC;

           if (chonMaNV != "NONE")
           {
               SQL += chonMaNV + " MANV= @Manv ";
               cmd.Parameters.Add("Manv", SqlDbType.VarChar).Value = MaNV;

           }

           if (chonNgayLap != "NONE")
           {
               SQL += chonNgayLap + " (NGAYLAP BETWEEN @tn AND @dn) ";
               cmd.Parameters.Add("tn", SqlDbType.DateTime).Value = TuNgay;
               cmd.Parameters.Add("dn", SqlDbType.DateTime).Value = DenNgay;
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

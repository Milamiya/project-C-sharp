using System;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class PhieuDatHangData
    {
        DataService ds = new DataService();
        public DataTable LayPDH()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUDATHANG");
            ds.Load(cmd);
            return ds;
        }
       public DataTable LayDS_PDH(String pdh)
       {
           SqlCommand cmd = new SqlCommand("select * from PHIEUDATHANG where MANCC=@ncc");

           cmd.Parameters.Add("ncc", SqlDbType.VarChar).Value = pdh;
           ds.Load(cmd);
           return ds;
       }
       public DataTable LayCT_PDH()
       {
           SqlCommand cmd = new SqlCommand("select * from CHITIETPHIEUDATHANG");
           ds.Load(cmd);
           return ds;
       }
       public DataTable TimKiemPhieuDatHang(String MaNCC, String chonMaNV, String MaNV, String chonNgayLap, DateTime TuNgay, DateTime DenNgay)
       {

           SqlCommand cmd = new SqlCommand();
           String SQL = "SELECT * FROM PHIEUDATHANG WHERE MANCC LIKE '%' + @Mancc + '%' ";

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

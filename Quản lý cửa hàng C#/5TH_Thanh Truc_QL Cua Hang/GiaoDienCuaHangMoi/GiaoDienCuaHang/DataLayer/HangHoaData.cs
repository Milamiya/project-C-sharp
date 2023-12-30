using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GiaoDienCuaHang.DataLayer
{
   public class HangHoaData
    {
       DataService ds = new DataService();
       public DataTable LayDSHangHoa()
       {
           
           ds.Load(new SqlCommand("select * from HANGHOA"));
           return ds;
       }
       public DataTable LayDSHHsaphethan()
       {
           SqlCommand cmd = new SqlCommand("SELECT *, Cast(NGAYHETHAN - GetDate() as int) "
                + " FROM HANGHOA WHERE Cast(NGAYHETHAN - GetDate() as int) <= 10 AND Cast(NGAYHETHAN - GetDate() as int) >= 0");

           ds.Load(cmd);
           return ds;
       }
       public DataTable LayDSHangHoa(String hh)
       {
           SqlCommand cmd = new SqlCommand("select * from HANGHOA where MADVT=@d");
           
           cmd.Parameters.Add("d", SqlDbType.VarChar).Value = hh;
           ds.Load(cmd);
           return ds;
       }
       public DataTable TimKiemHangHoa(String ten,String chonMaDVT,String MaDVT,String chonSL,String Soluong,String chonSLG,String SLGiam,String chonTLG,String TLGiam)
       {

           SqlCommand cmd = new SqlCommand();
           String SQL = "SELECT * FROM HANGHOA WHERE TENHH LIKE '%' + @tHH + '%' ";

           cmd.Parameters.Add("tHH", SqlDbType.VarChar).Value = ten;
           
               if (chonMaDVT != "NONE")
               {
                   SQL += chonMaDVT + " MADVT= @Madvt ";
                   cmd.Parameters.Add("Madvt", SqlDbType.VarChar).Value = MaDVT;

               }

               if (chonSL != "NONE")
               {
                   SQL += chonSL + " SOLUONG= @soluong ";
                   cmd.Parameters.Add("soluong", SqlDbType.Int).Value = Soluong;
               }

               if (chonSLG != "NONE")
               {
                   SQL += chonSLG + " SOLUONGGIAM = @soluonggiam ";
                   cmd.Parameters.Add("soluonggiam", SqlDbType.Int).Value = SLGiam;
               }
               if (chonTLG != "NONE")
               {
                   SQL += chonTLG + " TILEGIAM = @TILEGIAM ";
                   cmd.Parameters.Add("TILEGIAM", SqlDbType.Int).Value = TLGiam;
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

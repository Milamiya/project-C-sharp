using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKTX.DataLayer
{
    public class NhapKWDienData
    {
        DataService ser = new DataService();
        public void ThemPhieuKWDien(string maphg, string manamhoc ,string thang)
        {
            SqlCommand com = new SqlCommand("insert into danhgiaphong(maphg,manamhoc,thang,KWDien) values(@maphg, @manamhoc, @thang,0)");
            com.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maphg;
            com.Parameters.Add("@manamhoc", SqlDbType.VarChar, 5).Value = manamhoc;
            com.Parameters.Add("@thang", SqlDbType.NVarChar,8).Value = thang;            
            ser.Load(com);
            
        }
        public DataTable layPhieuKWDien(string maphg,string manamhoc, string thang)
        {
            SqlCommand com = new SqlCommand("select * from danhgiaphong where maphg=@maphg and manamhoc=@manamhoc and thang = @thang");
            com.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maphg;
            com.Parameters.Add("@manamhoc", SqlDbType.VarChar, 5).Value = manamhoc;
            com.Parameters.Add("@thang", SqlDbType.NVarChar,8).Value = thang;            
            ser.Clear();
            ser.Load(com);
            return ser;
        }
        public void CapNhatPhieuKWDien(string maphg, string manamhoc, string thang, string KWDien)
        {
            SqlCommand com = new SqlCommand("update danhgiaphong set KWDien=@KWDien where maphg=@maphg and manamhoc=@manamhoc and thang=@thang");
            com.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maphg;
            com.Parameters.Add("@manamhoc", SqlDbType.VarChar, 5).Value = manamhoc;
            com.Parameters.Add("@thang", SqlDbType.NVarChar, 8).Value = thang;
            com.Parameters.Add("@KWDien", SqlDbType.Int).Value = KWDien;
            ser.Load(com);

        }
        public DataTable layDSPhieuKWDien()
        {
            SqlCommand com = new SqlCommand("select dg.maphg,dg.manamhoc,dg.KWDien,dg.thang,k.tenktx,p.tenphg,d.tenday,n.tennamhoc from danhgiaphong dg,phong p, day d, KTX k, namhoc n where KWDien=0 and dg.maphg=p.maphg and p.maday=d.maday and d.ktx=k.ktx and dg.manamhoc=n.manamhoc");            
            ser.Clear();
            ser.Load(com);
            return ser;
        }
        public DataTable layDSPhieuKWDienSua()
        {
            SqlCommand com = new SqlCommand("select dg.maphg,dg.manamhoc,dg.KWDien,dg.thang,k.tenktx,p.tenphg,d.tenday,n.tennamhoc from danhgiaphong dg,phong p, day d, KTX k, namhoc n where dg.maphg=p.maphg and p.maday=d.maday and d.ktx=k.ktx and dg.manamhoc=n.manamhoc");
            ser.Clear();
            ser.Load(com);
            return ser;
        }
    }
}

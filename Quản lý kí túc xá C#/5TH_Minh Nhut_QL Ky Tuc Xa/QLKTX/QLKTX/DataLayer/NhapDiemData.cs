using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKTX.DataLayer
{
    public class NhapDiemData
    {
        DataService ser = new DataService();
        public void ThemPhieuDiem(string maphg, string manamhoc ,string thang)
        {
            SqlCommand com = new SqlCommand("insert into danhgiaphong(maphg,manamhoc,thang,diem) values(@maphg, @manamhoc, @thang,0)");
            com.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maphg;
            com.Parameters.Add("@manamhoc", SqlDbType.VarChar, 5).Value = manamhoc;
            com.Parameters.Add("@thang", SqlDbType.NVarChar,8).Value = thang;            
            ser.Load(com);
            
        }
        public DataTable layPhieuDiem(string maphg,string manamhoc, string thang)
        {
            SqlCommand com = new SqlCommand("select * from danhgiaphong where maphg=@maphg and manamhoc=@manamhoc and thang = @thang");
            com.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maphg;
            com.Parameters.Add("@manamhoc", SqlDbType.VarChar, 5).Value = manamhoc;
            com.Parameters.Add("@thang", SqlDbType.NVarChar,8).Value = thang;            
            ser.Clear();
            ser.Load(com);
            return ser;
        }
        public void CapNhatPhieuDiem(string maphg, string manamhoc, string thang, string diem)
        {
            SqlCommand com = new SqlCommand("update danhgiaphong set diem=@diem where maphg=@maphg and manamhoc=@manamhoc and thang=@thang");
            com.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = maphg;
            com.Parameters.Add("@manamhoc", SqlDbType.VarChar, 5).Value = manamhoc;
            com.Parameters.Add("@thang", SqlDbType.NVarChar, 8).Value = thang;
            com.Parameters.Add("@diem", SqlDbType.Int).Value = diem;
            ser.Load(com);

        }
        public DataTable layDSPhieuDiem()
        {
            SqlCommand com = new SqlCommand("select dg.maphg,dg.manamhoc,dg.diem,dg.thang,k.tenktx,p.tenphg,d.tenday,n.tennamhoc from danhgiaphong dg,phong p, day d, KTX k, namhoc n where diem=0 and dg.maphg=p.maphg and p.maday=d.maday and d.ktx=k.ktx and dg.manamhoc=n.manamhoc");            
            ser.Clear();
            ser.Load(com);
            return ser;
        }
        public DataTable layDSPhieuDiemSua()
        {
            SqlCommand com = new SqlCommand("select dg.maphg,dg.manamhoc,dg.diem,dg.thang,k.tenktx,p.tenphg,d.tenday,n.tennamhoc from danhgiaphong dg,phong p, day d, KTX k, namhoc n where dg.maphg=p.maphg and p.maday=d.maday and d.ktx=k.ktx and dg.manamhoc=n.manamhoc");
            ser.Clear();
            ser.Load(com);
            return ser;
        }
    }
}

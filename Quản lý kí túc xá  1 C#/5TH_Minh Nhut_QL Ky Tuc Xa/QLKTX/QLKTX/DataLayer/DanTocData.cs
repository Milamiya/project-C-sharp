using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKTX.DataLayer
{
    public class DanTocData
    {
        DataService ser = new DataService();
        public DataTable LayDSDanToc()
        {
            SqlCommand s = new SqlCommand("select * from DanToc");
            ser.Load(s);
            return ser;
        }
        public void Update()
        {
            ser.Update();
        }
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MADanToc) from DanToc");
            ser.Load(s);
            return ser;
        }
        public void Them(QLKTX.BusinessObject.DanTocInfo dt)
        {
            SqlCommand s = new SqlCommand("INSERT INTO DANTOC(MADANTOC,TENDANTOC) VALUES(@ma,@ten)");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = dt.TenDanToc;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = dt.MaDanToc;
            ser.Load(s);
        }
        public void Xoa(QLKTX.BusinessObject.DanTocInfo dt)
        {
            SqlCommand s = new SqlCommand("Delete DANTOC where MADANTOC=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = dt.MaDanToc;
            ser.Load(s);
        }
        public void Sua(QLKTX.BusinessObject.DanTocInfo dt)
        {
            SqlCommand s = new SqlCommand("Update DANTOC set TENDANTOC = @ten where MADANTOC= @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = dt.TenDanToc;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = dt.MaDanToc;
            ser.Load(s);
        }
    }
}

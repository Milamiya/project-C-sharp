using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKTX.DataLayer
{
    public class KyLuatData
    {
        DataService ser = new DataService();
        public DataTable LayDSKyLuat()
        {
            SqlCommand s = new SqlCommand("select * from KyLuat");
            ser.Load(s);
            return ser;
        }
        public void Update()
        {
            ser.Update();
        }
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MaKyLuat) from KyLuat");
            ser.Load(s);
            return ser;
        }
        public void Them(QLKTX.BusinessObject.KyLuatInfo tg)
        {
            SqlCommand s = new SqlCommand("INSERT INTO KyLuat(MAKyLuat,TENKyLuat) VALUES(@ma,@ten)");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = tg.TenKyLuat;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaKyLuat;
            ser.Load(s);
        }
        public void Xoa(QLKTX.BusinessObject.KyLuatInfo tg)
        {
            SqlCommand s = new SqlCommand("Delete KyLuat where MAKyLuat=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaKyLuat;
            ser.Load(s);
        }
        public void Sua(QLKTX.BusinessObject.KyLuatInfo tg)
        {
            SqlCommand s = new SqlCommand("Update KyLuat set TENKyLuat = @ten where MAKyLuat= @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = tg.TenKyLuat;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaKyLuat;
            ser.Load(s);
        }


    }
}

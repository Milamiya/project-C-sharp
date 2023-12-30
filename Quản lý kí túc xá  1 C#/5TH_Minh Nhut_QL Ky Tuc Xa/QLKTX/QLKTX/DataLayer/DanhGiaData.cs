using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKTX.DataLayer
{
    public class DanhGiaData
    {
        DataService ser = new DataService();
        public DataTable LayDSDanhGia()
        {
            SqlCommand s = new SqlCommand("select * from DanhGia");
            ser.Load(s);
            return ser;
        }
        public void Update()
        {
            ser.Update();
        }
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MaDanhGia) from DanhGia");
            ser.Load(s);
            return ser;
        }
        public void Them(QLKTX.BusinessObject.DanhGiaInfo tg)
        {
            SqlCommand s = new SqlCommand("INSERT INTO DanhGia(MADanhGia,TENDanhGia) VALUES(@ma,@ten)");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = tg.TenDanhGia;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaDanhGia;
            
            ser.Load(s);
        }
        public void Xoa(QLKTX.BusinessObject.DanhGiaInfo tg)
        {
            SqlCommand s = new SqlCommand("Delete DanhGia where MADanhGia=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaDanhGia;
            ser.Load(s);
        }
        public void Sua(QLKTX.BusinessObject.DanhGiaInfo tg)
        {
            SqlCommand s = new SqlCommand("Update DanhGia set TENDanhGia = @ten where MADanhGia= @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = tg.TenDanhGia;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaDanhGia;
            ser.Load(s);
        }


    }
}

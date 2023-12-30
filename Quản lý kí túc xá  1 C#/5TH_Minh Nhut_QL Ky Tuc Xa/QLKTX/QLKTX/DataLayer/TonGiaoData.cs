using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKTX.DataLayer
{
    public class TonGiaoData
    {
        DataService ser = new DataService();
        public DataTable LayDSTonGiao()
        {
            SqlCommand s = new SqlCommand("select * from TonGiao");
            ser.Load(s);
            return ser;
        }
        public void Update()
        {
            ser.Update();
        }
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MaTonGiao) from TonGiao");
            ser.Load(s);
            return ser;
        }
        public void Them(QLKTX.BusinessObject.TonGiaoInfo tg)
        {
            SqlCommand s = new SqlCommand("INSERT INTO TONGIAO(MATONGIAO,TENTONGIAO) VALUES(@ma,@ten)");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = tg.TenTonGiao;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaTonGiao;
            ser.Load(s);
        }
        public void Xoa(QLKTX.BusinessObject.TonGiaoInfo tg)
        {
            SqlCommand s = new SqlCommand("Delete TONGIAO where MATONGIAO=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaTonGiao;
            ser.Load(s);
        }
        public void Sua(QLKTX.BusinessObject.TonGiaoInfo tg)
        {
            SqlCommand s = new SqlCommand("Update TONGIAO set TENTONGIAO = @ten where MATONGIAO= @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = tg.TenTonGiao;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = tg.MaTonGiao;
            ser.Load(s);
        }


    }
}

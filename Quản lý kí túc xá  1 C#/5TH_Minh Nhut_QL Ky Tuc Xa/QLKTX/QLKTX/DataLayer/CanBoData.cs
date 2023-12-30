
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKTX.DataLayer
{
    public class CanBoData
    {
        DataService ser = new DataService();
        public CanBoData()
        {
        }
        public DataTable LayDSCanBo()
        {
            SqlCommand com = new SqlCommand("Select * from CANBO");
            ser.Load(com);
            return ser;
        }
        public void Update()
        {
            ser.Update();
        }
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MaCBQL) from CANBO");
            ser.Load(s);
            return ser;
        }
        public void Them(QLKTX.BusinessObject.CanBoInfo cb)
        {
            SqlCommand s = new SqlCommand("INSERT INTO CANBO(MACBQL,TENCBQL,DIACHI) VALUES(@ma,@ten,@diachi)");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = cb.Ten;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = cb.MaSo;
            s.Parameters.Add("@diachi", SqlDbType.NVarChar,100).Value = cb.DiaChi;
            ser.Load(s);
        }
        public void Xoa(QLKTX.BusinessObject.CanBoInfo cb)
        {
            SqlCommand s = new SqlCommand("Delete CANBO where MACBQL=@ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = cb.MaSo;
            ser.Load(s);
        }
        public void Sua(QLKTX.BusinessObject.CanBoInfo cb)
        {
            SqlCommand s = new SqlCommand("Update CANBO set TENCBQL = @ten, DIACHI=@diachi where MACBQL= @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = cb.Ten;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = cb.MaSo;
            s.Parameters.Add("@diachi", SqlDbType.NVarChar, 100).Value = cb.DiaChi;
            ser.Load(s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace QLKTX.DataLayer
{
    public class QuocTichData
    {
        DataService ser = new DataService();
        public DataTable LayDSQuocTich()
        {
            SqlCommand s = new SqlCommand("select * from quoctich");
            ser.Load(s);
            return ser;
        }
        public void Update()
        {
            ser.Update();           
        }
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MAQUOCTICH) from quoctich");
            ser.Load(s);
            return ser;
        }
        public void Them(QLKTX.BusinessObject.QuocTichInfo qt)
        {
            SqlCommand s = new SqlCommand("INSERT INTO QUOCTICH(MAQUOCTICH,TENQUOCTICH) VALUES(@ma,@ten)");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = qt.TenQuocTich;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = qt.MaQuocTich;
            ser.Load(s);
        }
        public void Xoa(QLKTX.BusinessObject.QuocTichInfo qt)
        {
            SqlCommand s = new SqlCommand("Delete QUOCTICH where MAQuocTich=@ma");            
            s.Parameters.Add("@ma", SqlDbType.Int).Value = qt.MaQuocTich;
            ser.Load(s);
        }
        public void Sua(QLKTX.BusinessObject.QuocTichInfo qt)
        {
            SqlCommand s = new SqlCommand("Update QUOCTICH set TENQUOCTICH = @ten where MAQuocTich= @ma");
            s.Parameters.Add("@ten",SqlDbType.NVarChar,30).Value = qt.TenQuocTich;
            s.Parameters.Add("@ma",SqlDbType.Int).Value = qt.MaQuocTich;
            ser.Load(s);
        }

       
    }
}

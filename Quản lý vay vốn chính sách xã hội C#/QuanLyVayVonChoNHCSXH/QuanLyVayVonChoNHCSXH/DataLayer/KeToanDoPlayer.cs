using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class KeToanDoPlayer
    {

        DataService m_Ds = new DataService();

        public DataTable DanhSachKeToanDo()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KeToanDo");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayKeToanDo(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KeToanDo WHERE MaCap = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimKeToanDoTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM KeToanDo WHERE TenCap LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimKeToanDoTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM KeToanDo WHERE MaCap LIKE '%' + @ma +'%' ");
            cmd.Parameters.Add("ma", SqlDbType.NVarChar, 50).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataRow NewRow()
        {
            return m_Ds.NewRow();
        }

        public void Add(DataRow row)
        {
            m_Ds.Rows.Add(row);
        }

        public bool Save()
        {
            return (m_Ds.ExecuteNoneQuery() > 0);
        }
    }
}

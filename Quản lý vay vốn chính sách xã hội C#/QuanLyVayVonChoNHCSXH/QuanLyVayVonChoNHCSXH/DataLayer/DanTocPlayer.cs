using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class DanTocPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachDanToc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DanToc");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayDanToc(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DanToc WHERE MaDanToc = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimDanTocTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DanToc WHERE TenDanToc LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimDanTocTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DanToc WHERE MaDanToc LIKE '%' + @ma +'%' ");
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

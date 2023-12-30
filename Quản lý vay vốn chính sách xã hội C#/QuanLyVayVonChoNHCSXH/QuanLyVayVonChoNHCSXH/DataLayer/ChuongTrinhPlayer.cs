using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class ChuongTrinhPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachChuongTrinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChuongTrinh");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayChuongTrinh(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChuongTrinh WHERE MaChuongTrinh = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimChuongTrinhTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ChuongTrinh WHERE TenChuongTrinh LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimChuongTrinhTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ChuongTrinh WHERE MaChuongTrinh LIKE '%' + @ma +'%' ");
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

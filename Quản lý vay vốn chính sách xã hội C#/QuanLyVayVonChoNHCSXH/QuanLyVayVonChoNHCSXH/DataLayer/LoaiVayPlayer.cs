using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class LoaiVayPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachLoaiVay()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiVay");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayLoaiVay(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiVay WHERE MaLoaiVay = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimLoaiVayTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiVay WHERE TenLoaiVay LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimLoaiVayTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiVay WHERE MaLoaiVay LIKE '%' + @ma +'%' ");
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

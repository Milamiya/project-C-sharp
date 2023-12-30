using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class LoaiDoiTacPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachLoaiDoiTac()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiDoiTac");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayLoaiDoiTac(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiDoiTac WHERE MaLoaiDoiTac = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimLoaiDoiTacTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiDoiTac WHERE TenLoaiDoiTac LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimLoaiDoiTacTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiDoiTac WHERE MaLoaiDoiTac LIKE '%' + @ma +'%' ");
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

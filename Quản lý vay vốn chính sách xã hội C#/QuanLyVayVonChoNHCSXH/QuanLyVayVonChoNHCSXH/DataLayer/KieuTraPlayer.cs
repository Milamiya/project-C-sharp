using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class KieuTraPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachKieuTra()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KieuTra");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayKieuTra(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KieuTra WHERE MaKieuTra = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimKieuTraTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM KieuTra WHERE TenKieuTra LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimKieuTraTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM KieuTra WHERE MaKieuTra LIKE '%' + @ma +'%' ");
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

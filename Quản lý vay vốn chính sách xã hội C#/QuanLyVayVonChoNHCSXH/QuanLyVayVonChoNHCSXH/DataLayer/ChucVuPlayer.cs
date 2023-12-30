using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class ChucVuPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachChucVu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChucVu");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayChucVu(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ChucVu WHERE MaChucVu = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimChucVuTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ChucVu WHERE TenChucVu LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimChucVuTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ChucVu WHERE MaChucVu LIKE '%' + @ma +'%' ");
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

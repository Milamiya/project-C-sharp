using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class TaiKhoanPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachTaiKhoan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayTaiKhoan(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE MaTaiKhoan = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimTaiKhoanTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenTaiKhoan LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimTaiKhoanTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE MaTaiKhoan LIKE '%' + @ma +'%' ");
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

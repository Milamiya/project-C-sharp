using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class LoaiHinhPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachLoaiHinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiHinh");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayLoaiHinh(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiHinh WHERE MaLoaiHinh = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimLoaiHinhTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiHinh WHERE TenLoaiHinh LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimLoaiHinhTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiHinh WHERE MaLoaiHinh LIKE '%' + @ma +'%' ");
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

using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class PhongBanPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachPhongBan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhongBan");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayPhongBan(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PhongBan WHERE MaPhongBan = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimPhongBanTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM PhongBan WHERE TenPhongBan LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimPhongBanTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM PhongBan WHERE MaPhongBan LIKE '%' + @ma +'%' ");
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

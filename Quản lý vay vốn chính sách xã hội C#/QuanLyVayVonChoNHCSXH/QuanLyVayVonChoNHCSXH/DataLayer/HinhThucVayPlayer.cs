using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class HinhThucVayPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachHinhThucVay()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HinhThucVay");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayHinhThucVay(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HinhThucVay WHERE MaHTVay = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimHinhThucVayTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM HinhThucVay WHERE TenHTVay LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimHinhThucVayTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM HinhThucVay WHERE MaHTVay LIKE '%' + @ma +'%' ");
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

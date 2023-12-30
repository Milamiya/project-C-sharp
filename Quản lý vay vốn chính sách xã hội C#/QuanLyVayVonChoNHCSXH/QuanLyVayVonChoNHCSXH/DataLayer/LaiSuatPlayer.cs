using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class LaiSuatPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachLaiSuat()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LaiSuat");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayLaiSuat(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LaiSuat WHERE MaLaiSuat = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimLaiSuatTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LaiSuat WHERE LaiSuat LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimLaiSuatTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LaiSuat WHERE MaLaiSuat LIKE '%' + @ma +'%' ");
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

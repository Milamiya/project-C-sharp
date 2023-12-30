using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class TinhPlayer
    {

        DataService m_Ds = new DataService();

        public DataTable DanhSachTinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSTinh");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayTinh(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSTinh WHERE MaTinh = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimTinhTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DSTinh WHERE TenTinh LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimTinhTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DSTinh WHERE MaTinh LIKE '%' + @ma +'%' ");
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

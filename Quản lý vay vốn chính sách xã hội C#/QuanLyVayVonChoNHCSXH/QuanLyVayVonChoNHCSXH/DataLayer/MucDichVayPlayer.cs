using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class MucDichVayPlayer
    {

        DataService m_Ds = new DataService();

        public DataTable DanhSachMucDichVay()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MucDichVay");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayMucDichVay(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MucDichVay WHERE MaMucDichVay = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimMucDichVayTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM MucDichVay WHERE TenMucDichVay LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimMucDichVayTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM MucDichVay WHERE MaMucDichVay LIKE '%' + @ma +'%' ");
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

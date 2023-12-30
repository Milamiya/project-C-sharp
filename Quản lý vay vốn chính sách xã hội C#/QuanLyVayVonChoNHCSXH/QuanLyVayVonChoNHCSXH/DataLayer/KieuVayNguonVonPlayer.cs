using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class KieuVayNguonVonPlayer
    {

        DataService m_Ds = new DataService();

        public DataTable DanhSachKieuVayNguonVon()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KieuVayNguonVon");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayKieuVayNguonVon(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KieuVayNguonVon WHERE MaKVNV = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimKieuVayNguonVonTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM KieuVayNguonVon WHERE TenKVNV LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimKieuVayNguonVonTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM KieuVayNguonVon WHERE MaKVNV LIKE '%' + @ma +'%' ");
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

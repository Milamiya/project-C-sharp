using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class ThuVonPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachThuVon()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThuVon");
            m_Ds.Load(cmd);

            return m_Ds;
        }

       public DataTable LayThuVon(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ThuVon WHERE MaTV = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


       public DataTable TimThuVonTheoMaSoKU(String masoku)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ThuVon WHERE MaSoKU LIKE '%' + @masoku +'%' ");
            cmd.Parameters.Add("masoku", SqlDbType.NVarChar, 50).Value = masoku;

            m_Ds.Load(cmd);

            return m_Ds;
        }

       public DataTable TimThuVonTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM ThuVon WHERE MaTV LIKE '%' + @ma +'%' ");
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

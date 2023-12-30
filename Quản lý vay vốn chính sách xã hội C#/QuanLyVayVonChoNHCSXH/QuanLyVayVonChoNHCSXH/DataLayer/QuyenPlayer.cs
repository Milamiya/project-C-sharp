using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class QuyenPlayer
    {

        DataService m_Ds = new DataService();

        public DataTable DanhSachQuyen()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Quyen");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayQuyen(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Quyen WHERE MaQuyen = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimQuyenTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM Quyen WHERE TenQuyen LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimQuyenTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM Quyen WHERE MaQuyen LIKE '%' + @ma +'%' ");
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

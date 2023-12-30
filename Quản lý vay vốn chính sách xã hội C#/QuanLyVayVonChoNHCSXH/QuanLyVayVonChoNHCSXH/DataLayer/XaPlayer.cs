using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class XaPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachXa()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSXa");
            m_Ds.Load(cmd);

            return m_Ds;
        }


       public DataTable DanhSachXa(String MaHuyen)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM DSXa WHERE MaHuyen = @MaHuyen");
           cmd.Parameters.Add("MaHuyen", SqlDbType.Char, 5).Value = MaHuyen;
           m_Ds.Load(cmd);

           return m_Ds;
       }
        public DataTable LayXa(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSXa WHERE MaXa = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }

       
        public DataTable TimXaTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DSXa WHERE TenXa LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimXaTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DSXa WHERE MaXa LIKE '%' + @ma +'%' ");
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

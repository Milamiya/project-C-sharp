using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class DonViUyThacPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachDonViUyThac()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonViUyThac");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayDonViUyThac(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DonViUyThac WHERE MaDVUyThac = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimDonViUyThacTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DonViUyThac WHERE TenDVUyThac LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimDonViUyThacTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DonViUyThac WHERE MaDVUyThac LIKE '%' + @ma +'%' ");
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

using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataPlayer
{
   public class DoiTacPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachDoiTac()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DoiTac");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayDoiTac(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DoiTac WHERE MaDoiTac = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }

    
        public DataTable TimDoiTacTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DoiTac WHERE HoTenDT LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimDoiTacTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DoiTac WHERE MaDoiTac LIKE '%' + @ma +'%' ");
            cmd.Parameters.Add("ma", SqlDbType.NVarChar, 50).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }

       public DataTable TimDoiTacTheoMaLoai(String maloai)
       {

           SqlCommand cmd = new SqlCommand("SELECT * FROM DoiTac WHERE MaLoaiDoiTac LIKE '%' + @maloai +'%' ");
           cmd.Parameters.Add("maloai", SqlDbType.NVarChar, 50).Value = maloai;

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

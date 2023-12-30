using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;


namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class HuyenPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachHuyen()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSHuyen");
            m_Ds.Load(cmd);

            return m_Ds;
        }

       public DataTable DanhSachHuyen(String MaTinh)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM DSHuyen WHERE MaTinh = @MaTinh");
           cmd.Parameters.Add("MaTinh", SqlDbType.Char, 5).Value = MaTinh;
           m_Ds.Load(cmd);

           return m_Ds;
       }

       public DataTable DanhSachHuyenTheoTinh(String matinh)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM DSHuyen WHERE MaTinh = @matinh");
            cmd.Parameters.Add("matinh", SqlDbType.Char, 10).Value = matinh;
           m_Ds.Load(cmd);

           return m_Ds;
       }

        public DataTable LayHuyen(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DSHuyen WHERE MaHuyen = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }

       public DataTable LayHuyenTheoTinhDaChon(String ma)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM DSHuyen WHERE MaTinh = ");
           cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

           m_Ds.Load(cmd);

           return m_Ds;
       }


        public DataTable TimHuyenTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DSHuyen WHERE TenHuyen LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimHuyenTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM DSHuyen WHERE MaHuyen LIKE '%' + @ma +'%' ");
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

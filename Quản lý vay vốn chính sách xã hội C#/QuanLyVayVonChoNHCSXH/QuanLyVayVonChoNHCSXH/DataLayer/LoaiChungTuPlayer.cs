using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
   public class LoaiChungTuPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachLoaiChungTu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiChungTu");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayLoaiChungTu(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiChungTu WHERE MaLoaiChungTu = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimLoaiChungTuTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiChungTu WHERE TenLoaiChungTu LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimLoaiChungTuTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiChungTu WHERE MaLoaiChungTu LIKE '%' + @ma +'%' ");
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

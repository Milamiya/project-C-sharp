using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataLayer
{
    public class VungLayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachVung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM VungChoVay");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable LayVung(String ma)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM VungChoVay WHERE MaVung = @ma");
            cmd.Parameters.Add("ma", SqlDbType.Char, 10).Value = ma;

            m_Ds.Load(cmd);

            return m_Ds;
        }


        public DataTable TimVungTheoTen(String ten)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM VungChoVay WHERE TenVung LIKE '%' + @ten +'%' ");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar, 50).Value = ten;

            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable TimVungTheoMa(String ma)
        {

            SqlCommand cmd = new SqlCommand("SELECT * FROM VungChoVay WHERE MaVung LIKE '%' + @ma +'%' ");
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

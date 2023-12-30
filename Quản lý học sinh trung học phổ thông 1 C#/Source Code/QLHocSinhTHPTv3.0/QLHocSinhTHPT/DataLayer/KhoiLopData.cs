using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class KhoiLopData
    {
        DataService m_KhoiLopData = new DataService();

        public DataTable LayDsKhoiLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHOILOP");
            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataTable LayDsKhoiLop(String khoiLopCu)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM KHOILOP WHERE MaKhoiLop = @khoiLopCu ";
            cmd.Parameters.Add("khoiLopCu", SqlDbType.VarChar).Value = khoiLopCu;
            
            if (khoiLopCu == "KHOI10")
                sql += "OR MaKhoiLop = 'KHOI11'";
            
            else if (khoiLopCu == "KHOI11")
                sql += "OR MaKhoiLop = 'KHOI12'";

            cmd.CommandText = sql;

            m_KhoiLopData.Load(cmd);
            return m_KhoiLopData;
        }

        public DataRow ThemDongMoi()
        {
            return m_KhoiLopData.NewRow();
        }

        public void ThemKhoiLop(DataRow m_Row)
        {
            m_KhoiLopData.Rows.Add(m_Row);
        }

        public bool LuuKhoiLop()
        {
            return m_KhoiLopData.ExecuteNoneQuery() > 0;
        }
    }
}

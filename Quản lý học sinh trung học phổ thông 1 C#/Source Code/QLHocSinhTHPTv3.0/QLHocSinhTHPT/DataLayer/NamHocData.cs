using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class NamHocData
    {
        DataService m_NamHocData = new DataService();

        public DataTable LayDsNamHoc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NAMHOC");
            m_NamHocData.Load(cmd);
            return m_NamHocData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NamHocData.NewRow();
        }

        public void ThemNamHoc(DataRow m_Row)
        {
            m_NamHocData.Rows.Add(m_Row);
        }

        public bool LuuNamHoc()
        {
            return m_NamHocData.ExecuteNoneQuery() > 0;
        }
    }
}

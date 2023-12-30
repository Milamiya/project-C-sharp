using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class HocLucData
    {
        DataService m_HocLucData = new DataService();

        public DataTable LayDsHocLuc()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCLUC");
            m_HocLucData.Load(cmd);
            return m_HocLucData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocLucData.NewRow();
        }

        public void ThemHocLuc(DataRow m_Row)
        {
            m_HocLucData.Rows.Add(m_Row);
        }

        public bool LuuHocLuc()
        {
            return m_HocLucData.ExecuteNoneQuery() > 0;
        }
    }
}

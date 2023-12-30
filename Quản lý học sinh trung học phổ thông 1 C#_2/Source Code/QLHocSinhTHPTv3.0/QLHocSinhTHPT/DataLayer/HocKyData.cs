using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class HocKyData
    {
        DataService m_HocKyData = new DataService();

        public DataTable LayDsHocKy()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCKY");
            m_HocKyData.Load(cmd);
            return m_HocKyData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocKyData.NewRow();
        }

        public void ThemHocKy(DataRow m_Row)
        {
            m_HocKyData.Rows.Add(m_Row);
        }

        public bool LuuHocKy()
        {
            return m_HocKyData.ExecuteNoneQuery() > 0;
        }
    }
}

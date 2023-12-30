using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class HanhKiemData
    {
        DataService m_HanhKiemData = new DataService();

        public DataTable LayDsHanhKiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HANHKIEM");
            m_HanhKiemData.Load(cmd);
            return m_HanhKiemData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HanhKiemData.NewRow();
        }

        public void ThemHanhKiem(DataRow m_Row)
        {
            m_HanhKiemData.Rows.Add(m_Row);
        }

        public bool LuuHanhKiem()
        {
            return m_HanhKiemData.ExecuteNoneQuery() > 0;
        }
    }
}

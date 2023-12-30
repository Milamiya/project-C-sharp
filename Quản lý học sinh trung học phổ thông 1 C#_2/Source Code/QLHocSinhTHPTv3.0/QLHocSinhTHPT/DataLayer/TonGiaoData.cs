using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class TonGiaoData
    {
        DataService m_TonGiaoData = new DataService();

        public DataTable LayDsTonGiao()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TONGIAO");
            m_TonGiaoData.Load(cmd);
            return m_TonGiaoData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TonGiaoData.NewRow();
        }

        public void ThemTonGiao(DataRow m_Row)
        {
            m_TonGiaoData.Rows.Add(m_Row);
        }

        public bool LuuTonGiao()
        {
            return m_TonGiaoData.ExecuteNoneQuery() > 0;
        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class NgheNghiepData
    {
        DataService m_NgheNghiepData = new DataService();

        public DataTable LayDsNgheNghiep()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGHENGHIEP");
            m_NgheNghiepData.Load(cmd);
            return m_NgheNghiepData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NgheNghiepData.NewRow();
        }

        public void ThemNgheNghiep(DataRow m_Row)
        {
            m_NgheNghiepData.Rows.Add(m_Row);
        }

        public bool LuuNgheNghiep()
        {
            return m_NgheNghiepData.ExecuteNoneQuery() > 0;
        }
    }
}

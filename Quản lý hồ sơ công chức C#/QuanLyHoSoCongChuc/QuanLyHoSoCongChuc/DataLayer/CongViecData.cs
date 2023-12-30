using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class CongViecData
    {
        DataService m_CongViecData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsCongViec()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CongViec");
            m_CongViecData.Load(cmd);
            return m_CongViecData;
        }

        public DataRow ThemDongMoi()
        {
            return m_CongViecData.NewRow();
        }

        public void ThemCongViec(DataRow m_Row)
        {
            m_CongViecData.Rows.Add(m_Row);
        }

        public bool LuuCongViec()
        {
            return m_CongViecData.ExecuteNoneQuery() > 0;
        }

    }
}

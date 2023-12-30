using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace QuanLyHoSoCongChuc.DataLayer
{
    public class DienUuTienBanThanData
    {
        DataService m_DienUuTienBanThanData = new DataService();
        // DataService ds = new DataService();
        public DataTable LayDsDienUuTienBanThan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DienUuTienBanThan");
            m_DienUuTienBanThanData.Load(cmd);
            return m_DienUuTienBanThanData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DienUuTienBanThanData.NewRow();
        }

        public void ThemDienUuTienBanThan(DataRow m_Row)
        {
            m_DienUuTienBanThanData.Rows.Add(m_Row);
        }

        public bool LuuDienUuTienBanThan()
        {
            return m_DienUuTienBanThanData.ExecuteNoneQuery() > 0;
        }

    }
}

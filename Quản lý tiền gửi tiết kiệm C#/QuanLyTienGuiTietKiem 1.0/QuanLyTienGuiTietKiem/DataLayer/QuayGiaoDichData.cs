using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class QuayGiaoDichData
    {
        DataService m_QuayGiaoDichData = new DataService();

        public DataTable LayQuayGiaoDich()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QUAY_GIAO_DICH");
            m_QuayGiaoDichData.Load(cmd);
            return m_QuayGiaoDichData;
        }

        public DataRow ThemDongMoi()
        {
            return m_QuayGiaoDichData.NewRow();
        }

        public void ThemQuayGiaoDich(DataRow m_Row)
        {
            m_QuayGiaoDichData.Rows.Add(m_Row);
        }

        public bool LuuQuayGiaoDich()
        {
            return m_QuayGiaoDichData.ExecuteNoneQuery() > 0;
        }
    }
}

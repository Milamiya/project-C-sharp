using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class QuyenData
    {
        DataService m_QuyenData = new DataService();

        public DataTable LayQuyen()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM QUYEN");
            m_QuyenData.Load(cmd);
            return m_QuyenData;
        }

        public DataRow ThemDongMoi()
        {
            return m_QuyenData.NewRow();
        }

        public void ThemQuyen(DataRow m_Row)
        {
            m_QuyenData.Rows.Add(m_Row);
        }

        public bool LuuQuyen()
        {
            return m_QuyenData.ExecuteNoneQuery() > 0;
        }

    }
}

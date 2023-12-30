using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class DMLoaiTienData
    {
        DataService m_DMLoaiTienData = new DataService();

        public DataTable LayDMLoaiTien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DM_LOAI_TIEN");
            m_DMLoaiTienData.Load(cmd);
            return m_DMLoaiTienData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DMLoaiTienData.NewRow();
        }

        public void ThemDMLoaiTien(DataRow m_Row)
        {
            m_DMLoaiTienData.Rows.Add(m_Row);
        }

        public bool LuuDMLoaiTien()
        {
            return m_DMLoaiTienData.ExecuteNoneQuery() > 0;
        }

    }
}

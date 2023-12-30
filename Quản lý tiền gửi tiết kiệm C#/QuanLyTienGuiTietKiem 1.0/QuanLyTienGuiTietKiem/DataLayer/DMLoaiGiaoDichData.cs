using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class DMLoaiGiaoDichData
    {
        DataService m_DMLoaiGiaoDichData = new DataService();

        public DataTable LayDMLoaiGiaoDich()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DM_LOAI_GIAO_DICH");
            m_DMLoaiGiaoDichData.Load(cmd);
            return m_DMLoaiGiaoDichData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DMLoaiGiaoDichData.NewRow();
        }

        public void ThemDMLoaiGiaoDich(DataRow m_Row)
        {
            m_DMLoaiGiaoDichData.Rows.Add(m_Row);
        }

        public bool LuuDMLoaiGiaoDich()
        {
            return m_DMLoaiGiaoDichData.ExecuteNoneQuery() > 0;
        }

    }
}

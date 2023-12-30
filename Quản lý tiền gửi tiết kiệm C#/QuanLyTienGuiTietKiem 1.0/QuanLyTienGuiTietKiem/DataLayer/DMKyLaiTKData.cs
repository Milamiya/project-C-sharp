using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class DMKyLaiTKData
    {
        DataService m_DMKyLaiTKData = new DataService();

        public DataTable LayDMKyLaiTK()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DM_KY_LAI_TIET_KIEM");
            m_DMKyLaiTKData.Load(cmd);
            return m_DMKyLaiTKData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DMKyLaiTKData.NewRow();
        }

        public void ThemDMKyLaiTK(DataRow m_Row)
        {
            m_DMKyLaiTKData.Rows.Add(m_Row);
        }

        public bool LuuDMKyLaiTK()
        {
            return m_DMKyLaiTKData.ExecuteNoneQuery() > 0;
        }

    }
}

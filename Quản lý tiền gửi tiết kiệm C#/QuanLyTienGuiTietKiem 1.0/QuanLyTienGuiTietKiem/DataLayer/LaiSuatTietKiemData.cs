using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class LaiSuatTietKiemData
    {
        DataService m_LaiSuatTietKiemData = new DataService();

        public DataTable LayLaiSuatTietKiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LAI_SUAT_TIET_KIEM");
            m_LaiSuatTietKiemData.Load(cmd);
            return m_LaiSuatTietKiemData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LaiSuatTietKiemData.NewRow();
        }

        public void ThemLaiSuatTietKiem(DataRow m_Row)
        {
            m_LaiSuatTietKiemData.Rows.Add(m_Row);
        }

        public bool LuuLaiSuatTietKiem()
        {
            return m_LaiSuatTietKiemData.ExecuteNoneQuery() > 0;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class DMTaiKhoanData
    {
        DataService m_DMTaiKhoanData = new DataService();

        public DataTable LayDMTaiKhoan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DM_TAI_KHOAN");
            m_DMTaiKhoanData.Load(cmd);
            return m_DMTaiKhoanData;
        }

        public DataRow ThemDongMoi()
        {
            return m_DMTaiKhoanData.NewRow();
        }

        public void ThemDMTaiKhoan(DataRow m_Row)
        {
            m_DMTaiKhoanData.Rows.Add(m_Row);
        }

        public bool LuuDMTaiKhoan()
        {
            return m_DMTaiKhoanData.ExecuteNoneQuery() > 0;
        }

    }
}

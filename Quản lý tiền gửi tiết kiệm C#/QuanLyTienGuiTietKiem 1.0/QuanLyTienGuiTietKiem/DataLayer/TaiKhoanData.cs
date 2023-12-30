using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class TaiKhoanData
    {
        DataService m_TaiKhoanData = new DataService();

        public DataTable LayTaiKhoan()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM TAI_KHOAN");
            m_TaiKhoanData.Load(cmd);
            return m_TaiKhoanData;
        }

        public DataRow ThemDongMoi()
        {
            return m_TaiKhoanData.NewRow();
        }

        public void ThemTaiKhoan(DataRow m_Row)
        {
            m_TaiKhoanData.Rows.Add(m_Row);
        }

        public bool LuuTaiKhoan()
        {
            return m_TaiKhoanData.ExecuteNoneQuery() > 0;
        }

    }
}

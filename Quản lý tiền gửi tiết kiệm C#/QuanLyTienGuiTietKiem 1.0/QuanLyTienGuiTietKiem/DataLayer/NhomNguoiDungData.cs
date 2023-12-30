using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class NhomNguoiDungData
    {
        DataService m_NguoiDung = new DataService();

        public DataTable LayNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHOM_NGUOI_DUNG");
            m_NguoiDung.Load(cmd);
            return m_NguoiDung;
        }

        public DataRow ThemDongMoi()
        {
            return m_NguoiDung.NewRow();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDung.Rows.Add(m_Row);
        }

        public bool LuuNguoiDung()
        {
            return m_NguoiDung.ExecuteNoneQuery() > 0;
        }

    }
}

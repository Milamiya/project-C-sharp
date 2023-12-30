using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class PhanNhomNguoiDungData
    {
        DataService m_PhanNhomNguoiDungData = new DataService();

        public DataTable LayPhanNhomNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHAN_NHOM");
            m_PhanNhomNguoiDungData.Load(cmd);
            return m_PhanNhomNguoiDungData;
        }

        public DataRow ThemDongMoi()
        {
            return m_PhanNhomNguoiDungData.NewRow();
        }

        public void ThemPhanNhomNguoiDung(DataRow m_Row)
        {
            m_PhanNhomNguoiDungData.Rows.Add(m_Row);
        }

        public bool LuuPhanNhomNguoiDung()
        {
            return m_PhanNhomNguoiDungData.ExecuteNoneQuery() > 0;
        }

    }
}

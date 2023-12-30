using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class GiaoDichVienData
    {
        DataService m_GiaoDichVienData = new DataService();

        public DataTable GetGiaoDichVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAO_DICH_VIEN");
            m_GiaoDichVienData.Load(cmd);
            return m_GiaoDichVienData;
        }

        public DataTable GetGiaoDichVienTen()
        {
            SqlCommand cmd = new SqlCommand("SELECT HoTen, GD.MaNV FROM NHAN_VIEN AS NV INNER JOIN GIAO_DICH_VIEN AS GD ON GD.MaNV = NV.MaNV");

            m_GiaoDichVienData.Load(cmd);
            return m_GiaoDichVienData;
        }

        public DataRow ThemDongMoi()
        {
            return m_GiaoDichVienData.NewRow();
        }

        public void ThemGiaoDichVien(DataRow m_Row)
        {
            m_GiaoDichVienData.Rows.Add(m_Row);
        }

        public bool LuuGiaoDichVien()
        {
            return m_GiaoDichVienData.ExecuteNoneQuery() > 0;
        }
    }
}

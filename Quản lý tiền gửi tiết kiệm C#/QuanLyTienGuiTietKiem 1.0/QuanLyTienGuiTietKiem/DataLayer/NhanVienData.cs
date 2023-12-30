using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class NhanVienData
    {
        DataService m_NhanVienData = new DataService();

        public DataTable LayNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHAN_VIEN");
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }
        public DataTable LayDSNhanVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHAN_VIEN NV INNER JOIN PHONG_GIAO_DICH PGD ON NV.MaPhongGiaoDich = PGD.MaPhongGiaoDich");
            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }
        public DataTable LayMaNV(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHAN_VIEN WHERE MaSoTietKiem LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public DataTable LayTenNV(String ButToan)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHAN_VIEN WHERE SoButToan LIKE '%' + @ButToan + '%'");
            cmd.Parameters.Add("ButToan", SqlDbType.VarChar).Value = ButToan;

            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NhanVienData.NewRow();
        }

        public void ThemNhanVien(DataRow m_Row)
        {
            m_NhanVienData.Rows.Add(m_Row);
        }

        public bool LuuNhanVien()
        {
            return m_NhanVienData.ExecuteNoneQuery() > 0;
        }

        #region tim kiem
        public DataTable TimKiemTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHAN_VIEN WHERE MaNV LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

        public DataTable TimKiemTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NHAN_VIEN WHERE HoTen LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_NhanVienData.Load(cmd);
            return m_NhanVienData;
        }

       

        #endregion
    }
}

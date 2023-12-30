using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class PhongGiaoDichData
    {
        DataService m_PhongGiaoDichData = new DataService();

        public DataTable LayPhongGiaoDich()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHONG_GIAO_DICH");
            m_PhongGiaoDichData.Load(cmd);
            return m_PhongGiaoDichData;
        }

        public DataRow ThemDongMoi()
        {
            return m_PhongGiaoDichData.NewRow();
        }

        public void ThemPhongGiaoDich(DataRow m_Row)
        {
            m_PhongGiaoDichData.Rows.Add(m_Row);
        }

        public bool LuuPhongGiaoDich()
        {
            return m_PhongGiaoDichData.ExecuteNoneQuery() > 0;
        }

        public DataTable TimKiemTheoTenPhongGD(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHONG_GIAO_DICH WHERE TenPhong LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_PhongGiaoDichData.Load(cmd);
            return m_PhongGiaoDichData;
        }

        public DataTable TimKiemTheoMaPhongGD(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PHONG_GIAO_DICH WHERE MaPhongGiaoDich LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.NVarChar).Value = id;

            m_PhongGiaoDichData.Load(cmd);
            return m_PhongGiaoDichData;
        }


    }
}

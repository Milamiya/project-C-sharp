using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class ChiTietPhatSinhGDData
    {
        DataService m_ChiTietPhatSinhGD = new DataService();

        public DataTable LayChiTietPhatSinhGD()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CHI_TIET_PSGD");
            m_ChiTietPhatSinhGD.Load(cmd);
            return m_ChiTietPhatSinhGD;
        }

        public DataTable LayDSSoButToan(String buttoan)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CHI_TIET_PSGD WHERE SoButToan LIKE '%' + @buttoan + '%'");
            cmd.Parameters.Add("buttoan", SqlDbType.VarChar).Value = buttoan;

            m_ChiTietPhatSinhGD.Load(cmd);
            return m_ChiTietPhatSinhGD;
        }

        public DataTable LayDSSoGD(String Gd)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM CHI_TIET_PSGD WHERE SoGiaoDich LIKE '%' + @Gd + '%'");
            cmd.Parameters.Add("Gd", SqlDbType.NVarChar).Value = Gd;

            m_ChiTietPhatSinhGD.Load(cmd);
            return m_ChiTietPhatSinhGD;
        }

        public void LuuChiTietPSGD(String SoGiaoDich, String SoButToan, DateTime NgayGiaoDich, String SoHieuTaiKhoanNo,String SoHieuTaiKhoanCo, float SoTien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO CHI_TIET_PSGD VALUES(@SoGiaoDich, @SoButToan, @NgayGiaoDich, @SoHieuTaiKhoanNo, @SoHieuTaiKhoanCo, @SoTien)");
            cmd.Parameters.Add("SoGiaoDich", SqlDbType.VarChar).Value = SoGiaoDich;
            cmd.Parameters.Add("SoButToan", SqlDbType.VarChar).Value = SoButToan;
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = NgayGiaoDich;
            cmd.Parameters.Add("SoHieuTaiKhoanNo", SqlDbType.VarChar).Value = SoHieuTaiKhoanNo;
            cmd.Parameters.Add("SoHieuTaiKhoanCo", SqlDbType.VarChar).Value = SoHieuTaiKhoanCo;
            cmd.Parameters.Add("SoTien", SqlDbType.VarChar).Value = SoTien;

            m_ChiTietPhatSinhGD.Load(cmd);
        }

        public void XoaChiTietPSGD(String SoGiaoDich, String SoButToan, DateTime NgayGiaoDich, String SoHieuTaiKhoanNo, String SoHieuTaiKhoanCo, float SoTien)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CHI_TIET_PSGD WHERE SoGiaoDich = @SoGiaoDich AMD SoButToan =  @SoButToan AMD NgayGiaoDich = @NgayGiaoDich AMD SoHieuTaiKhoanNo = @SoHieuTaiKhoanNo AMD SoHieuTaiKhoanCo =  @SoHieuTaiKhoanCo AMD SoTien = @SoTien)");

            cmd.Parameters.Add("SoGiaoDich", SqlDbType.VarChar).Value = SoGiaoDich;
            cmd.Parameters.Add("SoButToan", SqlDbType.VarChar).Value = SoButToan;
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = NgayGiaoDich;
            cmd.Parameters.Add("SoHieuTaiKhoanNo", SqlDbType.VarChar).Value = SoHieuTaiKhoanNo;
            cmd.Parameters.Add("SoHieuTaiKhoanCo", SqlDbType.VarChar).Value = SoHieuTaiKhoanCo;
            cmd.Parameters.Add("SoTien", SqlDbType.VarChar).Value = SoTien;

            m_ChiTietPhatSinhGD.Load(cmd);
        }
        public DataRow ThemDongMoi()
        {
            return m_ChiTietPhatSinhGD.NewRow();
        }

        public void ThemChiTietPhatSinhGD(DataRow m_Row)
        {
            m_ChiTietPhatSinhGD.Rows.Add(m_Row);
        }

        public bool LuuChiTietPhatSinhGD()
        {
            return m_ChiTietPhatSinhGD.ExecuteNoneQuery() > 0;
        }

    }
}

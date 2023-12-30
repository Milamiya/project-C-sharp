using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class PhatSinhTietKiemData
    {
        DataService m_PhatSinhTietKiemData = new DataService();

        public DataTable LayPhatSinhTietKiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PS_TIET_KIEM");

            m_PhatSinhTietKiemData.Load(cmd);
            return m_PhatSinhTietKiemData;
        }

        public DataTable LayMaPS(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PS_TIET_KIEM WHERE MaSoTietKiem LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_PhatSinhTietKiemData.Load(cmd);
            return m_PhatSinhTietKiemData;
        }

        public DataTable LayTenPS(String ButToan)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PS_TIET_KIEM WHERE SoButToan LIKE '%' + @ButToan + '%'");
            cmd.Parameters.Add("ButToan", SqlDbType.VarChar).Value = ButToan;

            m_PhatSinhTietKiemData.Load(cmd);
            return m_PhatSinhTietKiemData;
        }
        public DataTable LayTheoMaNV(String MaNV)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM PS_TIET_KIEM WHERE MaNV = @MaNV");
            cmd.Parameters.Add("MaMV", SqlDbType.VarChar).Value = MaNV;

            m_PhatSinhTietKiemData.Load(cmd);
            return m_PhatSinhTietKiemData;
        }
        public void LuuPSTK(String SoButToan,DateTime NgayGiaoDich, Boolean DaDuyet, String MaSoTietKiem, String LoaiGiaoDich, String MaQuayGD, String MaPhongGD,String MaNV)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PS_TIET_KIEM VALUES(@SoButToan, @NgayGiaoDich, @DaDuyet, @MaSoTietKiem, @LoaiGiaoDich, @MaQuayGD, @MaPhongGD, @MaNV)");

            cmd.Parameters.Add("SoButToan", SqlDbType.VarChar).Value = SoButToan;

            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = NgayGiaoDich;
            cmd.Parameters.Add("DaDuyet", SqlDbType.Bit).Value = DaDuyet;

            cmd.Parameters.Add("MaSoTietKiem", SqlDbType.VarChar).Value = MaSoTietKiem;
            cmd.Parameters.Add("LoaiGiaoDich", SqlDbType.VarChar).Value = LoaiGiaoDich;
            cmd.Parameters.Add("MaQuayGD", SqlDbType.VarChar).Value = MaQuayGD;
            cmd.Parameters.Add("MaPhongGD", SqlDbType.VarChar).Value = MaPhongGD;
            cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = MaNV;

            m_PhatSinhTietKiemData.Load(cmd);
        }

        public void XoaPSTK(String SoButToan, DateTime NgayGiaoDich, Boolean DaDuyet, String MaSoTietKiem, String LoaiGiaoDich, String MaQuayGD, String MaPhongGD, String MaNV)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM PS_TIET_KIEM WHERE SoButToan = @SoButToan AND NgayGiaoDich = @NgayGiaoDich AND DaDuyet =  @DaDuyet AND MaSoTietKiem = @MaSoTietKiem AND LoaiGiaoDich = @LoaiGiaoDich AND MaQuayGiaoDich =  @MaQuayGD AND MaPhongGiaoDich = @MaPhongGD AND MaNV = @MaNV)");

            cmd.Parameters.Add("SoButToan", SqlDbType.VarChar).Value = SoButToan;

            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = NgayGiaoDich;
            cmd.Parameters.Add("DaDuyet", SqlDbType.Bit).Value = DaDuyet;

            cmd.Parameters.Add("MaSoTietKiem", SqlDbType.VarChar).Value = MaSoTietKiem;
            cmd.Parameters.Add("LoaiGiaoDich", SqlDbType.VarChar).Value = LoaiGiaoDich;
            cmd.Parameters.Add("MaQuayGD", SqlDbType.VarChar).Value = MaQuayGD;
            cmd.Parameters.Add("MaPhongGD", SqlDbType.VarChar).Value = MaPhongGD;
            cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = MaNV;

            m_PhatSinhTietKiemData.Load(cmd);
        }
        public DataRow ThemDongMoi()
        {
            return m_PhatSinhTietKiemData.NewRow();
        }

        public void ThemPhatSinhTietKiem(DataRow m_Row)
        {
            m_PhatSinhTietKiemData.Rows.Add(m_Row);
        }

        public bool LuuPhatSinhTietKiem()
        {
            return m_PhatSinhTietKiemData.ExecuteNoneQuery() > 0;
        }

       
    }
}

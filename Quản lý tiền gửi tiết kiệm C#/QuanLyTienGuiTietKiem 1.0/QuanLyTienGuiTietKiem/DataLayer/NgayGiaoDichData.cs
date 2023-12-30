using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class NgayGiaoDichData
    {
        DataService m_NgayGiaoDichData = new DataService();

        public DataTable LayNgayGiaoDich()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGAY_GIAO_DICH");
            m_NgayGiaoDichData.Load(cmd);
            return m_NgayGiaoDichData;
        }

        public DataTable LayNgayGiaoDichTheoNgay(String NgayGiaoDich)
        {
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, DMLT.LoaiTien, CTGD.SoTien, S.MaSoTietKiem, LTK.TenLoaiTietKiem FROM KHACH_HANG AS KH INNER JOIN SO_TIET_KIEM AS S ON S.MaKH = KH.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTGD ON CTGD.SoButToan = PSTK.SoButToan INNER JOIN DM_TAI_KHOAN DMTK ON DMTK.SoHieuTaiKhoan = CTGD.SoHieuTaiKhoanCo INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = S.MaLoaiTietKiem INNER JOIN DM_LOAI_TIEN DMLT ON DMLT.MaLoaiTien = LTK.MaLoaiTien INNER JOIN NGAY_GIAO_DICH NGD ON NGD.NgayGiaoDich = PSTK.NgayGiaoDich WHERE PSTK.NgayGiaoDich = @NgayGiaoDich");
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = NgayGiaoDich;

            m_NgayGiaoDichData.Load(cmd);
            return m_NgayGiaoDichData;
        }

        public void LuuNgayGD(DateTime NgayGiaoDich, bool NgatGiaoDich)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO NGAY_GIAO_DICH VALUES(@NgayGiaoDich,@NgatGiaoDich)");
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = NgayGiaoDich;
            cmd.Parameters.Add("NgatGiaoDich", SqlDbType.Bit).Value = NgatGiaoDich;

            m_NgayGiaoDichData.Load(cmd);
        }

        public DataRow ThemDongMoi()
        {
            return m_NgayGiaoDichData.NewRow();
        }

        public void ThemNgayGiaoDich(DataRow m_Row)
        {
            m_NgayGiaoDichData.Rows.Add(m_Row);
        }

        public bool LuuNgayGiaoDich()
        {
            return m_NgayGiaoDichData.ExecuteNoneQuery() > 0;
        }

    }
}

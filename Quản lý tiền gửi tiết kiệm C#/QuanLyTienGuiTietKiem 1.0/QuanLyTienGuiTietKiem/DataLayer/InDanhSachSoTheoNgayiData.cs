using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class InDanhSachSoTheoNgayData
    {
        DataService m_InPhieuLuuTienGuiData = new DataService();

        public DataTable LaySoTheoNgayGD(String NgayGiaoDich)
        {
            SqlCommand cmd = new SqlCommand("SELECT S.MaSoTietKiem, LTK.TenLoaiTietKiem, LS.MucLaiSuat, KH.HoTen, KH.DiaChi, KH.CMND, KH.NgayCap, S.NgayHieuLuc, CTGD.SoTien, SD.SoDu, DMLT.LoaiTien FROM KHACH_HANG KH INNER JOIN SO_TIET_KIEM S ON S.MaKH = KH.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTGD ON CTGD.SoButToan = PSTK.SoButToan INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = S.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LS ON LS.MaLoaiTietKiem = LTK.MaLoaiTietKiem INNER JOIN SO_DU_TIET_KIEM SD ON S.MaSoTietKiem = SD.MaSoTietKiem INNER JOIN DM_LOAI_TIEN DMLT ON DMLT.MaLoaiTien = LTK.MaLoaiTien INNER JOIN NGAY_GIAO_DICH NGD ON NGD.NgayGiaoDich = PSTK.NgayGiaoDich WHERE NGD.NgayGiaoDich = @NgayGiaoDich");
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.VarChar).Value = NgayGiaoDich;

            m_InPhieuLuuTienGuiData.Load(cmd);
            return m_InPhieuLuuTienGuiData;
        }

        
    }
}

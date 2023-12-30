using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class InPhieuThuData
    {
        DataService m_InPhieuThuData = new DataService();

        public DataTable LaySoTheoMa(String MaSo)
        {
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, DMLT.LoaiTien, DMTK.TenTaiKhoan,KH.MaKH, KH.CMND, KH.DiaChi, CTGD.SoHieuTaiKhoanCo, CTGD.SoTien, S.MaSoTietKiem, LTK.KyHan FROM KHACH_HANG AS KH INNER JOIN SO_TIET_KIEM AS S ON S.MaKH = KH.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTGD ON CTGD.SoButToan = PSTK.SoButToan INNER JOIN DM_TAI_KHOAN DMTK ON DMTK.SoHieuTaiKhoan = CTGD.SoHieuTaiKhoanCo INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = S.MaLoaiTietKiem INNER JOIN DM_LOAI_TIEN DMLT ON DMLT.MaLoaiTien = LTK.MaLoaiTien WHERE S.MaSoTietKiem =@MaSo");
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            m_InPhieuThuData.Load(cmd);
            return m_InPhieuThuData;
        }

        public DataTable LaySoTheoMa()
        {
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, DMLT.LoaiTien, DMTK.TenTaiKhoan,KH.MaKH, KH.CMND, KH.DiaChi, CTGD.SoHieuTaiKhoanCo, CTGD.SoTien, S.MaSoTietKiem, LTK.KyHan FROM KHACH_HANG AS KH INNER JOIN SO_TIET_KIEM AS S ON S.MaKH = KH.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTGD ON CTGD.SoButToan = PSTK.SoButToan INNER JOIN DM_TAI_KHOAN DMTK ON DMTK.SoHieuTaiKhoan = CTGD.SoHieuTaiKhoanCo INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = S.MaLoaiTietKiem INNER JOIN DM_LOAI_TIEN DMLT ON DMLT.MaLoaiTien = LTK.MaLoaiTien");

            m_InPhieuThuData.Load(cmd);
            return m_InPhieuThuData;
        }
    }
}

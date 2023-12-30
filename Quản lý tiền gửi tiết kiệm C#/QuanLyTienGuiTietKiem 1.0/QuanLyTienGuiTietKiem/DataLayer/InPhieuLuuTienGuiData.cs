using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class InPhieuLuuTienGuiData
    {
        DataService m_InPhieuLuuTienGuiData = new DataService();

        public DataTable LaySoTheoMa(String MaSo)
        {
            SqlCommand cmd = new SqlCommand("SELECT S.MaSoTietKiem, LTK.TenLoaiTietKiem, LS.MucLaiSuat, KH.HoTen, KH.DiaChi, KH.CMND, KH.NgayCap, S.NgayHieuLuc, CTGD.SoTien, SD.SoDu FROM KHACH_HANG AS KH INNER JOIN SO_TIET_KIEM AS S ON S.MaKH = KH.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTGD ON CTGD.SoButToan = PSTK.SoButToan INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = S.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LS ON LS.MaLoaiTietKiem = LTK.MaLoaiTietKiem INNER JOIN SO_DU_TIET_KIEM SD ON S.MaSoTietKiem = SD.MaSoTietKiem WHERE S.MaSoTietKiem =@MaSo");
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            m_InPhieuLuuTienGuiData.Load(cmd);
            return m_InPhieuLuuTienGuiData;
        }

        
    }
}

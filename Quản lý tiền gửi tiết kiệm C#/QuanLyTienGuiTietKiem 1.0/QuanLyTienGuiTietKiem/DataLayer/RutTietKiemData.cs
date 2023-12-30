using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QuanLyTienGuiTietKiem.General;
using System.Data.SqlClient;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class RutTietKiemData
    {
        DataService m_RutTietKiemData = new DataService();

        public DataTable LayDSSo(String MaSo)
        {
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, KH.MaKH , DMLT.LoaiTien, S.MaSoTietKiem ,CTGD.SoTien , SDTK.SoDu,LTK.KyHan, PSTK.SoButToan, LTK.MaLoaiTietKiem, LTK.TenLoaiTietKiem, S.NgayHieuLuc, S.NgayDenHan,S.PhongToa, LSTK.MucLaiSuat FROM KHACH_HANG AS KH INNER JOIN SO_TIET_KIEM AS S ON S.MaKH = KH.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTGD ON CTGD.SoButToan = PSTK.SoButToan INNER JOIN DM_TAI_KHOAN DMTK ON DMTK.SoHieuTaiKhoan = CTGD.SoHieuTaiKhoanCo INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = S.MaLoaiTietKiem INNER JOIN DM_LOAI_TIEN DMLT ON DMLT.MaLoaiTien = LTK.MaLoaiTien INNER JOIN SO_DU_TIET_KIEM SDTK ON LTK.MaLoaiTietKiem = SDTK.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LSTK ON LSTK.MaLoaiTietKiem = LTK.MaLoaiTietKiem WHERE S.MaSoTietKiem =@MaSo");
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            m_RutTietKiemData.Load(cmd);
            return m_RutTietKiemData;
        }

        public void LuuSoDu(String MaSo, float SoDu)
        {
            DataService data = new DataService();
            SqlCommand cmd = new SqlCommand("UPDATE SO_DU_TIET_KIEM SET SoDu = @SoDu WHERE MaSoTietKiem = @MaSo");
            cmd.Parameters.Add("SoDu", SqlDbType.Float).Value = SoDu;
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            data.Load(cmd);
        }
        public void LuuTatToan(String MaSo, DateTime NgayTatToan, bool PhongToa)
        {
            DataService data1 = new DataService();

            SqlCommand cmd = new SqlCommand("UPDATE SO_TIET_KIEM SET PhongToa = @PhongToa, NgayTatToan = @NgayTatToan WHERE MaSoTietKiem = @MaSo");
            cmd.Parameters.Add("PhongToa", SqlDbType.Bit).Value = PhongToa;
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;
            cmd.Parameters.Add("NgayTatToan", SqlDbType.DateTime).Value = NgayTatToan;

            data1.Load(cmd);
        }

        public void LuuThayDoiSTK_RutLai(String MaSo, DateTime NgayTinhLaiGanNhat, String LaiDaTra)
        {
            DataService dataSTK = new DataService();

            SqlCommand cmd = new SqlCommand("UPDATE SO_TIET_KIEM SET NgayTinhLaiGanNhat = @NgayTinhLaiGanNhat, LaiDaTra = @LaiDaTra WHERE MaSoTietKiem = @MaSo");
            cmd.Parameters.Add("NgayTinhLaiGanNhat", SqlDbType.DateTime).Value = NgayTinhLaiGanNhat;
            cmd.Parameters.Add("LaiDaTra", SqlDbType.Float).Value = LaiDaTra;
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            dataSTK.Load(cmd);

        }
    }
}

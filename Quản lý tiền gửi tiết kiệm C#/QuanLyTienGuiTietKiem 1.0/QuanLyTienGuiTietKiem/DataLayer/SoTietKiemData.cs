using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class SoTietKiemData
    {
        DataService m_SoTietKiemData = new DataService();
        
	    public DataTable LaySoTietKiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT MaLoaiTietKiem, MaSoTietKiem, NgayMoSo,	NgayHieuLuc, NgayDenHan,NgayTinhLaiGanNhat,	NgayTaiKyGui, LaiDaTra, LaiNhapVon, NgayNhapVon, PhongToa, NgayTatToan, MaKH FROM SO_TIET_KIEM");
            m_SoTietKiemData.Load(cmd);
            return m_SoTietKiemData;
        }
        //Theo ngay den han
        public DataTable LayTheoHetHan(DateTime NgayDenHan)
        {
            DataService Data = new DataService();
            DateTime t = new DateTime();
            t = DateTime.Today;
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, NGD.NgayGiaoDich, S.MaSoTietKiem, S.NgayHieuLuc, S.NgayNhapVon, S.NgayDenHan, CTPS.SoTien, LTK.TenLoaiTietKiem,LTK.MaLoaiTietKiem,LTK.KyHan,DMLT.LoaiTien, SD.SoDu FROM SO_TIET_KIEM S INNER JOIN SO_DU_TIET_KIEM SD ON S.MaSoTietKiem = SD.MaSoTietKiem INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = SD.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LSTK ON LSTK.MaLoaiTietKiem = LTK.MaLoaiTietKiem INNER JOIN KHACH_HANG KH ON KH.MaKH = S.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTPS ON CTPS.SoButToan = PSTK.SoButToan INNER JOIN NGAY_GIAO_DICH NGD ON PSTK.NgayGiaoDich = NGD.NgayGiaoDich INNER JOIN DM_LOAI_TIEN DMLT ON DMLT.MaLoaiTien = LTK.MaLoaiTien WHERE NGD.NgayGiaoDich = @NgayGiaoDich and S.NgayDenHan<@NgayHienTai");
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = NgayDenHan;
            cmd.Parameters.Add("NgayHienTai", SqlDbType.DateTime).Value = t;
            Data.Load(cmd);
            return Data;
        }
        public DataTable LayTheoNgayDH(DateTime NgayGiaoDich)
        {
            DataService Data = new DataService();
            
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, NGD.NgayGiaoDich, S.MaSoTietKiem, S.NgayHieuLuc, S.NgayNhapVon, S.NgayDenHan, CTPS.SoTien, LTK.TenLoaiTietKiem,LTK.MaLoaiTietKiem,LTK.KyHan,DMLT.LoaiTien, SD.SoDu FROM SO_TIET_KIEM S INNER JOIN SO_DU_TIET_KIEM SD ON S.MaSoTietKiem = SD.MaSoTietKiem INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = SD.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LSTK ON LSTK.MaLoaiTietKiem = LTK.MaLoaiTietKiem INNER JOIN KHACH_HANG KH ON KH.MaKH = S.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTPS ON CTPS.SoButToan = PSTK.SoButToan INNER JOIN NGAY_GIAO_DICH NGD ON PSTK.NgayGiaoDich = NGD.NgayGiaoDich INNER JOIN DM_LOAI_TIEN DMLT ON DMLT.MaLoaiTien = LTK.MaLoaiTien WHERE NGD.NgayGiaoDich = @NgayGiaoDich");
            cmd.Parameters.Add("NgayGiaoDich", SqlDbType.DateTime).Value = NgayGiaoDich;
            Data.Load(cmd);
            return Data;
        }
        public DataTable LayTheoNgayDH()
        {
            DataService Data1 = new DataService();
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, KH.DiaChi, KH.CMND, KH. NgayCap, KH.NoiCap, S.MaSoTietKiem, S.NgayHieuLuc,S.NgayDenHan, LSTK.MucLaiSuat, CTPS.SoTien, LTK.MaLoaiTietKiem,LTK.TenLoaiTietKiem, SD.SoDu, NGD.NgayGiaoDich FROM SO_TIET_KIEM S INNER JOIN SO_DU_TIET_KIEM SD ON S.MaSoTietKiem = SD.MaSoTietKiem INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = SD.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LSTK ON LSTK.MaLoaiTietKiem = LTK.MaLoaiTietKiem INNER JOIN KHACH_HANG KH ON KH.MaKH = S.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTPS ON CTPS.SoButToan = PSTK.SoButToan INNER JOIN NGAY_GIAO_DICH NGD ON PSTK.NgayGiaoDich = NGD.NgayGiaoDich");

            Data1.Load(cmd);
            return Data1;
        }
        //
        public DataTable LayTheoMaLoai(String MaLoaiSo)
        {
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, KH.DiaChi, KH.CMND, KH. NgayCap, KH.NoiCap, S.MaSoTietKiem, S.NgayHieuLuc, LSTK.MucLaiSuat, CTPS.SoTien, LTK.MaLoaiTietKiem, SD.SoDu FROM SO_TIET_KIEM S INNER JOIN SO_DU_TIET_KIEM SD ON S.MaSoTietKiem = SD.MaSoTietKiem INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = SD.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LSTK ON LSTK.MaLoaiTietKiem = LTK.MaLoaiTietKiem INNER JOIN KHACH_HANG KH ON KH.MaKH = S.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTPS ON CTPS.SoButToan = PSTK.SoButToan WHERE LTK.MaLoaiTietKiem = 'TK423100'");
            cmd.Parameters.Add("TK423100", SqlDbType.VarChar).Value = MaLoaiSo;

            m_SoTietKiemData.Load(cmd);
            return m_SoTietKiemData;
        }
       

        //in so
        public DataTable LaySoTheoMa(String MaSo)
        {
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, KH.DiaChi, KH.CMND, KH. NgayCap, KH.NoiCap, S.MaSoTietKiem, S.NgayHieuLuc,S.NgayDenHan, LSTK.MucLaiSuat, CTPS.SoTien, LTK.MaLoaiTietKiem, SD.SoDu, PGD.MaPhongGiaoDich, LTK.KyHan, DMKL.LoaiKyTinhLai FROM SO_TIET_KIEM S INNER JOIN SO_DU_TIET_KIEM SD ON S.MaSoTietKiem = SD.MaSoTietKiem INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = SD.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LSTK ON LSTK.MaLoaiTietKiem = LTK.MaLoaiTietKiem INNER JOIN KHACH_HANG KH ON KH.MaKH = S.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTPS ON CTPS.SoButToan = PSTK.SoButToan INNER JOIN PHONG_GIAO_DICH PGD ON PGD.MaPhongGiaoDich = PSTK.MaPhongGiaoDich INNER JOIN DM_KY_LAI_TIET_KIEM DMKL ON DMKL.MaKyTinhLai = LTK.MaKyTinhLai WHERE S.MaSoTietKiem = @MaSo");
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            m_SoTietKiemData.Load(cmd);
            return m_SoTietKiemData;
        }

        public DataTable LaySoTheoMa()
        {
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen, KH.DiaChi, KH.CMND, KH. NgayCap, KH.NoiCap, S.MaSoTietKiem, S.NgayHieuLuc,S.NgayDenHan, LSTK.MucLaiSuat, CTPS.SoTien, LTK.MaLoaiTietKiem, SD.SoDu, PGD.MaPhongGiaoDich, LTK.KyHan, DMKL.LoaiKyTinhLai FROM SO_TIET_KIEM S INNER JOIN SO_DU_TIET_KIEM SD ON S.MaSoTietKiem = SD.MaSoTietKiem INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = SD.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LSTK ON LSTK.MaLoaiTietKiem = LTK.MaLoaiTietKiem INNER JOIN KHACH_HANG KH ON KH.MaKH = S.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTPS ON CTPS.SoButToan = PSTK.SoButToan INNER JOIN PHONG_GIAO_DICH PGD ON PGD.MaPhongGiaoDich = PSTK.MaPhongGiaoDich INNER JOIN DM_KY_LAI_TIET_KIEM DMKL ON DMKL.MaKyTinhLai = LTK.MaKyTinhLai");
            m_SoTietKiemData.Load(cmd);
            return m_SoTietKiemData;
        }

        public DataTable LayTenKH(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM KHACH_HANG kh, SO_TIET_KIEM soTK WHERE kh.MaKH = soTK.MaKH and HoTen LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = ten;

            m_SoTietKiemData.Load(cmd);
            return m_SoTietKiemData;
        }
        
        public DataTable LayMaSo(String MaSo)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SO_TIET_KIEM WHERE MaSoTietKiem LIKE '%' + @MaSo + '%'");
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            m_SoTietKiemData.Load(cmd);
            return m_SoTietKiemData;
        }

       
        public DataTable ThemSoKKH(String MaSo)
        {
            SqlCommand cmd = new SqlCommand("SELECT KH.HoTen,S.MaSoTietKiem,CTPSGD.SoTien,CTPSGD.SoHieuTaiKhoanCo,SDTK.SoDu,PSTK.SoButToan,LTK.MaLoaiTietKiem, LTK.TenLoaiTietKiem,S.NgayDenHan,LSTK.MucLaiSuat,DMTK.SoHieuTaiKhoan FROM KHACH_HANG AS KH INNER JOIN SO_TIET_KIEM AS S ON S.MaKH = KH.MaKH INNER JOIN PS_TIET_KIEM PSTK ON PSTK.MaSoTietKiem = S.MaSoTietKiem INNER JOIN CHI_TIET_PSGD CTPSGD ON CTPSGD.SoButToan = PSTK.SoButToan INNER JOIN DM_TAI_KHOAN DMTK ON DMTK.SoHieuTaiKhoan = CTPSGD.SoHieuTaiKhoanCo INNER JOIN LOAI_TIET_KIEM LTK ON LTK.MaLoaiTietKiem = S.MaLoaiTietKiem INNER JOIN SO_DU_TIET_KIEM SDTK ON LTK.MaLoaiTietKiem = SDTK.MaLoaiTietKiem INNER JOIN LAI_SUAT_TIET_KIEM LSTK ON LSTK.MaLoaiTietKiem = LTK.MaLoaiTietKiem WHERE S.MaSoTietKiem=@MaSo");
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            
            m_SoTietKiemData.Load(cmd);
            return m_SoTietKiemData;
        }

        public void LuuSoTK(String MaLoaiTK, String MaSoTK, DateTime NgayMoSo, DateTime NgayHieuLuc, DateTime NgayDenHan, DateTime NgayTinhLaiGanNhat, DateTime NgayTaiKyGui, float LaiDatra, float LaiNhapVon, DateTime NgayNhapVon, Boolean PhongToa, DateTime NgayTatToan, String MaKH)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SO_TIET_KIEM VALUES(@MaLoaiTK, @MaSoTK, @NgayMoSo, @NgayHieuLuc, @NgayDenHan, @NgayTinhLaiGanNhat, @NgayTaiKyGui, @LaiDatra, @LaiNhapVon,@NgayNhapVon, @PhongToa, @NgayTatToan, @MaKH)");
            cmd.Parameters.Add("MaLoaiTK", SqlDbType.VarChar).Value = MaLoaiTK;
            cmd.Parameters.Add("MaSoTK", SqlDbType.VarChar).Value = MaSoTK;

            cmd.Parameters.Add("NgayMoSo", SqlDbType.DateTime).Value = NgayMoSo;
            cmd.Parameters.Add("NgayHieuLuc", SqlDbType.DateTime).Value = NgayHieuLuc;
            cmd.Parameters.Add("NgayDenHan", SqlDbType.DateTime).Value = NgayDenHan;
            cmd.Parameters.Add("NgayTinhLaiGanNhat", SqlDbType.DateTime).Value = NgayTinhLaiGanNhat;
            cmd.Parameters.Add("NgayTaiKyGui", SqlDbType.DateTime).Value = NgayTaiKyGui;

            cmd.Parameters.Add("LaiDatra", SqlDbType.Float).Value = LaiDatra;
            cmd.Parameters.Add("LaiNhapVon", SqlDbType.Float).Value = LaiNhapVon;

            cmd.Parameters.Add("NgayNhapVon", SqlDbType.DateTime).Value = NgayNhapVon;

            cmd.Parameters.Add("PhongToa", SqlDbType.Bit).Value = PhongToa;
            cmd.Parameters.Add("NgayTatToan", SqlDbType.DateTime).Value = NgayTatToan;
            cmd.Parameters.Add("MaKH", SqlDbType.VarChar).Value = MaKH;

            m_SoTietKiemData.Load(cmd);
        }
        public void XoaSoTK(String MaLoaiTK, String MaSoTK, DateTime NgayMoSo, DateTime NgayHieuLuc, DateTime NgayDenHan, DateTime NgayTinhLaiGanNhat, DateTime NgayTaiKyGui, float LaiDatra, float LaiNhapVon, DateTime NgayNhapVon, Boolean PhongToa, DateTime NgayTatToan, String MaKH)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM SO_TIET_KIEM WHERE MaLoaiTietKiem = @MaLoaiTK AMD MaSoTietKiem = @MaSoTK AMD NgayMoSo = @NgayMoSo AMD NgayHieuLuc = @NgayHieuLuc AMD NgayDenHan = @NgayDenHan AMD @NgayTinhLaiGanNhat AMD NgayTaiKyGui = @NgayTaiKyGui AMD LaiDaTra = @LaiDatra AMD LaiNhapVon = @LaiNhapVon AMD NgayNhapVon = @NgayNhapVon AMD PhongToa = @PhongToa AMD NgayTatToan = @NgayTatToan AMD MaKH = @MaKH)");
            cmd.Parameters.Add("MaLoaiTK", SqlDbType.VarChar).Value = MaLoaiTK;
            cmd.Parameters.Add("MaSoTK", SqlDbType.VarChar).Value = MaSoTK;

            cmd.Parameters.Add("NgayMoSo", SqlDbType.DateTime).Value = NgayMoSo;
            cmd.Parameters.Add("NgayHieuLuc", SqlDbType.DateTime).Value = NgayHieuLuc;
            cmd.Parameters.Add("NgayDenHan", SqlDbType.DateTime).Value = NgayDenHan;
            cmd.Parameters.Add("NgayTinhLaiGanNhat", SqlDbType.DateTime).Value = NgayTinhLaiGanNhat;
            cmd.Parameters.Add("NgayTaiKyGui", SqlDbType.DateTime).Value = NgayTaiKyGui;

            cmd.Parameters.Add("LaiDatra", SqlDbType.Float).Value = LaiDatra;
            cmd.Parameters.Add("LaiNhapVon", SqlDbType.Float).Value = LaiNhapVon;

            cmd.Parameters.Add("NgayNhapVon", SqlDbType.DateTime).Value = NgayNhapVon;

            cmd.Parameters.Add("PhongToa", SqlDbType.Bit).Value = PhongToa;
            cmd.Parameters.Add("NgayTatToan", SqlDbType.DateTime).Value = NgayTatToan;
            cmd.Parameters.Add("MaKH", SqlDbType.VarChar).Value = MaKH;

            m_SoTietKiemData.Load(cmd);
        }

        //Update

        public void LuuThayDoi(String MaSo, DateTime NgayDenHan, DateTime NgayNhapVon, float LaiNhapVon)
        {
            DataService data = new DataService();
            SqlCommand cmd = new SqlCommand("UPDATE SO_TIET_KIEM SET NgayDenHan = @NgayDenHan, LaiNhapVon = @LaiNhapVon, NgayNhapVon = @NgayNhapVon WHERE MaSoTietKiem = @MaSo");

            cmd.Parameters.Add("NgayDenHan", SqlDbType.DateTime).Value = NgayDenHan;
            cmd.Parameters.Add("LaiNhapVon", SqlDbType.Float).Value = LaiNhapVon;
            cmd.Parameters.Add("NgayNhapVon", SqlDbType.DateTime).Value = NgayNhapVon;
            cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

            data.Load(cmd);
        }
        public DataRow ThemDongMoi()
        {
            return m_SoTietKiemData.NewRow();
        }
       
        public void ThemSoTietKiem(DataRow m_Row)
        {
            m_SoTietKiemData.Rows.Add(m_Row);
        }

        public bool LuuSoTietKiem()
        {
            return m_SoTietKiemData.ExecuteNoneQuery() > 0;
        }

        public String TruyVanChung()
        {
            return "SELECT S.MaSoTietKiem, KH.HoTen, KH.DiaChi, KH.CMND FROM SO_TIET_KIEM S INNER JOIN KHACH_HANG KH ON S.MaKH = KH.MaKH";
        }

        public DataTable TimSoTietKiem(String maSo, String theohoTen, String hoTen, String theoDChi, String diaChi, String theoCMND, String CMND)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE S.MaSoTietKiem LIKE '%' + @maSo + '%' ";
            cmd.Parameters.Add("maSo", SqlDbType.NVarChar).Value = maSo;

            if (theohoTen != "NONE")
            {
                sql += theohoTen + " KH.HoTen LIKE '%' + @hoTen + '%' ";
                cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;
            }
            if (theoDChi != "NONE")
            {
                sql += theoDChi + " KH.DiaChi LIKE '%' + @diaChi + '%' ";
                cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
            }

            if (theoCMND != "NONE")
            {
                sql += theoCMND + " KH.CMND = @CMND";
                cmd.Parameters.Add("CMND", SqlDbType.NVarChar).Value = CMND;
            }

            cmd.CommandText = sql;
            m_SoTietKiemData.Load(cmd);
            return m_SoTietKiemData;
        }
    }
}

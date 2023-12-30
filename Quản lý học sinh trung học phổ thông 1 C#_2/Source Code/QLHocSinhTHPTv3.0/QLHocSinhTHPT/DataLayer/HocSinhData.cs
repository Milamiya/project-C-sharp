using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class HocSinhData
    {
        DataService m_HocSinhData = new DataService();

        public DataTable LayDsHocSinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLop(String namHoc, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT PL.MaHocSinh, HS.HoTen " +
                                            "FROM HOCSINH HS INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh " +
                                            "INNER JOIN LOP L ON L.MaLop = PL.MaLop " +
                                            "WHERE PL.MaLop = @lop AND PL.MaNamHoc = @namHoc");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value      = lop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value   = namHoc;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoLop(String namHoc, String khoiLop, String lop)
        {
            SqlCommand cmd = new SqlCommand("SELECT PL.MaHocSinh, HS.HoTen, L.TenLop " +
                                            "FROM HOCSINH HS INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh " +
                                            "INNER JOIN LOP L ON L.MaLop = PL.MaLop " +
                                            "INNER JOIN KHOILOP KL ON KL.MaKhoiLop = PL.MaKhoiLop " +
                                            "WHERE PL.MaLop = @lop AND PL.MaNamHoc = @namHoc AND PL.MaKhoiLop = @khoiLop");
            cmd.Parameters.Add("lop", SqlDbType.VarChar).Value      = lop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value   = namHoc;
            cmd.Parameters.Add("khoiLop", SqlDbType.VarChar).Value  = khoiLop;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable LayDsHocSinhTheoNamHoc(String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT PL.MaHocSinh, HS.HoTen, L.TenLop " +
                                            "FROM HOCSINH HS INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh " +
                                            "INNER JOIN LOP L ON L.MaLop = PL.MaLop " +
                                            "WHERE PL.MaNamHoc = @namHoc");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public void LuuHSVaoBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO PHANLOP VALUES(@maNamHoc, @maKhoiLop, @maLop, @maHS)");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value    = maKhoiLop;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maHS", SqlDbType.VarChar).Value         = maHS;

            m_HocSinhData.Load(cmd);
        }

        public void XoaHSKhoiBangPhanLop(String maNamHoc, String maKhoiLop, String maLop, String maHS)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM PHANLOP WHERE MaNamHoc = @maNamHoc AND MaKhoiLop = @maKhoiLop AND MaLop = @maLop AND MaHocSinh = @maHS");
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value    = maKhoiLop;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maHS", SqlDbType.VarChar).Value         = maHS;

            m_HocSinhData.Load(cmd);
        }
        
        public DataTable LayDsHocSinhForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NGHENGHIEP NNC, NGHENGHIEP NNM, HOCSINH HS, DANTOC DT, TONGIAO TG WHERE HS.MaNNghiepCha = NNC.MaNghe AND HS.MaNNghiepMe = NNM.MaNghe AND HS.MaDanToc = DT.MaDanToc AND HS.MaTonGiao = TG.MaTonGiao");
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataRow ThemDongMoi()
        {
            return m_HocSinhData.NewRow();
        }

        public void ThemHocSinh(DataRow m_Row)
        {
            m_HocSinhData.Rows.Add(m_Row);
        }

        public bool LuuHocSinh()
        {
            return m_HocSinhData.ExecuteNoneQuery() > 0;
        }

        public void LuuHocSinh(String maHocSinh, String hoTen, bool gioiTinh, DateTime ngaySinh, String noiSinh, String maDanToc, String maTonGiao, String hoTenCha, String maNgheCha, String hoTenMe, String maNgheMe)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HOCSINH VALUES(@maHocSinh, @hoTen, @gioiTinh, @ngaySinh, @noiSinh, @maDanToc, @maTonGiao, @hoTenCha, @maNgheCha, @hoTenMe, @maNgheMe)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value       = hoTen;
            cmd.Parameters.Add("gioiTinh", SqlDbType.Bit).Value         = gioiTinh;
            cmd.Parameters.Add("ngaySinh", SqlDbType.DateTime).Value    = ngaySinh;
            cmd.Parameters.Add("noiSinh", SqlDbType.NVarChar).Value     = noiSinh;
            cmd.Parameters.Add("maDanToc", SqlDbType.VarChar).Value     = maDanToc;
            cmd.Parameters.Add("maTonGiao", SqlDbType.VarChar).Value    = maTonGiao;
            cmd.Parameters.Add("hoTenCha", SqlDbType.NVarChar).Value    = hoTenCha;
            cmd.Parameters.Add("maNgheCha", SqlDbType.VarChar).Value    = maNgheCha;
            cmd.Parameters.Add("hoTenMe", SqlDbType.NVarChar).Value     = hoTenMe;
            cmd.Parameters.Add("maNgheMe", SqlDbType.VarChar).Value     = maNgheMe;

            m_HocSinhData.Load(cmd);
        }

        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH WHERE MaHocSinh LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public DataTable TimTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM HOCSINH WHERE HoTen LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }

        public String TruyVanChung()
        {
            return "SELECT HS.MaHocSinh, HS.HoTen, HS.GioiTinh, HS.NgaySinh, HS.NoiSinh, DT.TenDanToc, TG.TenTonGiao FROM HOCSINH HS INNER JOIN DANTOC DT ON HS.MaDanToc = DT.MaDanToc INNER JOIN TONGIAO TG ON HS.MaTonGiao = TG.MaTonGiao";
        }

        public DataTable TimKiemHocSinh(String hoTen, String theoNSinh, String noiSinh, String theoDToc, String danToc, String theoTGiao, String tonGiao)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE HS.HoTen LIKE '%' + @hoTen + '%' ";
            cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;

            if (theoNSinh != "NONE")
            {
                sql += theoNSinh + " HS.NoiSinh LIKE '%' + @noiSinh + '%' ";
                cmd.Parameters.Add("noiSinh", SqlDbType.NVarChar).Value = noiSinh;
            }

            if (theoDToc != "NONE")
            {
                sql += theoDToc + " DT.TenDanToc = @danToc ";
                cmd.Parameters.Add("danToc", SqlDbType.NVarChar).Value = danToc;
            }

            if (theoTGiao != "NONE")
            {
                sql += theoTGiao + " TG.TenTonGiao = @tonGiao";
                cmd.Parameters.Add("tonGiao", SqlDbType.NVarChar).Value = tonGiao;
            }

            cmd.CommandText = sql;
            m_HocSinhData.Load(cmd);
            return m_HocSinhData;
        }
    }
}

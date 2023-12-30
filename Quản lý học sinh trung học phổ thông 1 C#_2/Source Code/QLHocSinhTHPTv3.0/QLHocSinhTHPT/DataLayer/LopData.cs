using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class LopData
    {
        DataService m_LopData = new DataService();

        public DataTable LayDsLop()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP");
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLop(String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaNamHoc = @namHoc");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLop(String khoiLop, String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaKhoiLop = @khoiLop AND MaNamHoc = @namHoc");
            cmd.Parameters.Add("khoiLop", SqlDbType.VarChar).Value = khoiLop;
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;

            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLopForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN GV INNER JOIN LOP L ON L.MaGiaoVien = GV.MaGiaoVien INNER JOIN KHOILOP KL ON L.MaKhoiLop = KL.MaKhoiLop INNER JOIN NAMHOC NH ON L.MaNamHoc = NH.MaNamHoc");
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable LayDsLopForReport(String namHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN GV INNER JOIN LOP L ON L.MaGiaoVien = GV.MaGiaoVien INNER JOIN KHOILOP KL ON L.MaKhoiLop = KL.MaKhoiLop INNER JOIN NAMHOC NH ON L.MaNamHoc = NH.MaNamHoc WHERE L.MaNamHoc = @namHoc");
            cmd.Parameters.Add("namHoc", SqlDbType.VarChar).Value = namHoc;
            
            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataRow ThemDongMoi()
        {
            return m_LopData.NewRow();
        }

        public void ThemLop(DataRow m_Row)
        {
            m_LopData.Rows.Add(m_Row);
        }

        public bool LuuLop()
        {
            return m_LopData.ExecuteNoneQuery() > 0;
        }

        public void LuuLop(String maLop, String tenLop, String maKhoiLop, String maNamHoc, int siSo, String maGiaoVien)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO LOP VALUES(@maLop, @tenLop, @maKhoiLop, @maNamHoc, @siSo, @maGiaoVien)");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("tenLop", SqlDbType.NVarChar).Value      = tenLop;
            cmd.Parameters.Add("maKhoiLop", SqlDbType.VarChar).Value    = maKhoiLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;
            cmd.Parameters.Add("siSo", SqlDbType.Int).Value             = siSo;
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value   = maGiaoVien;

            m_LopData.Load(cmd);
        }

        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE MaLop LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_LopData.Load(cmd);
            return m_LopData;
        }

        public DataTable TimTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOP WHERE TenLop LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_LopData.Load(cmd);
            return m_LopData;
        }
    }
}

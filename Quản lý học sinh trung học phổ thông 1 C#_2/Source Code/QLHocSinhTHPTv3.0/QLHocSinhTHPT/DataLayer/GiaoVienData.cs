using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class GiaoVienData
    {
        DataService m_GiaoVienData = new DataService();

        public DataTable LayDsGiaoVien()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN");
            m_GiaoVienData.Load(cmd);
            return m_GiaoVienData;
        }

        public DataTable LayDsGiaoVienForReport()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MONHOC M INNER JOIN GIAOVIEN G ON G.MaMonHoc = M.MaMonHoc");
            m_GiaoVienData.Load(cmd);
            return m_GiaoVienData;
        }

        public DataRow ThemDongMoi()
        {
            return m_GiaoVienData.NewRow();
        }

        public void ThemGiaoVien(DataRow m_Row)
        {
            m_GiaoVienData.Rows.Add(m_Row);
        }

        public bool LuuGiaoVien()
        {
            return m_GiaoVienData.ExecuteNoneQuery() > 0;
        }

        public void LuuGiaoVien(String maGiaoVien, String tenGiaoVien, String diaChi, String dienThoai, String chuyenMon)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO GIAOVIEN VALUES(@maGiaoVien, @tenGiaoVien, @diaChi, @dienThoai, @chuyenMon)");
            cmd.Parameters.Add("maGiaoVien", SqlDbType.VarChar).Value = maGiaoVien;
            cmd.Parameters.Add("tenGiaoVien", SqlDbType.NVarChar).Value = tenGiaoVien;
            cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
            cmd.Parameters.Add("dienThoai", SqlDbType.VarChar).Value = dienThoai;
            cmd.Parameters.Add("chuyenMon", SqlDbType.VarChar).Value = chuyenMon;

            m_GiaoVienData.Load(cmd);
        }

        public DataTable TimTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN WHERE MaGiaoVien LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_GiaoVienData.Load(cmd);
            return m_GiaoVienData;
        }

        public DataTable TimTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GIAOVIEN WHERE TenGiaoVien LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_GiaoVienData.Load(cmd);
            return m_GiaoVienData;
        }

        public String TruyVanChung()
        {
            return "SELECT G.MaGiaoVien, G.TenGiaoVien, G.DiaChi, G.DienThoai, H.TenMonHoc FROM GIAOVIEN G INNER JOIN MONHOC H ON G.MaMonHoc = H.MaMonHoc";
        }

        public DataTable TimKiemGiaoVien(String hoTen, String theoDChi, String diaChi, String theoCMon, String cMon)
        {
            SqlCommand cmd = new SqlCommand();

            String sql = TruyVanChung() + " WHERE G.TenGiaoVien LIKE '%' + @hoTen + '%' ";
            cmd.Parameters.Add("hoTen", SqlDbType.NVarChar).Value = hoTen;
            
            if (theoDChi != "NONE")
            {
                sql += theoDChi + " G.DiaChi LIKE '%' + @diaChi + '%' ";
                cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = diaChi;
            }

            if (theoCMon != "NONE")
            {
                sql += theoCMon + " H.TenMonHoc = @cMon";
                cmd.Parameters.Add("cMon", SqlDbType.NVarChar).Value = cMon;
            }

            cmd.CommandText = sql;
            m_GiaoVienData.Load(cmd);
            return m_GiaoVienData;
        }
    }
}

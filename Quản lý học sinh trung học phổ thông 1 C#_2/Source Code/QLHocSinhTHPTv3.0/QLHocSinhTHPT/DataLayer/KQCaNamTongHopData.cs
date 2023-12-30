using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class KQCaNamTongHopData
    {
        DataService m_KQCaNamTongHopData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maNamHoc, String maHocLuc, String maHanhKiem, float diemTBChungCacMonCN, String maKetQua)
        {
            DataService m_KQCNTHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_CA_NAM_TONG_HOP VALUES(@maHocSinh, @maLop, @maNamHoc, @maHocLuc, @maHanhKiem, @diemTBChungCacMonCN, @maKetQua)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value            = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value                = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value             = maNamHoc;
            cmd.Parameters.Add("maHocLuc", SqlDbType.VarChar).Value             = maHocLuc;
            cmd.Parameters.Add("maHanhKiem", SqlDbType.VarChar).Value           = maHanhKiem;
            cmd.Parameters.Add("diemTBChungCacMonCN", SqlDbType.Float).Value    = Math.Round(diemTBChungCacMonCN, 2);
            cmd.Parameters.Add("maKetQua", SqlDbType.VarChar).Value             = maKetQua;

            m_KQCNTHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maNamHoc)
        {
            DataService m_KQCNTHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_CA_NAM_TONG_HOP WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;

            m_KQCNTHData.Load(cmd);
        }

        public DataTable LayDsKQCaNamTongHopForReport(String maLop, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * " +
                                            "FROM HOCSINH HS INNER JOIN KQ_CA_NAM_TONG_HOP KQ ON KQ.MaHocSinh = HS.MaHocSinh " +
                                            "INNER JOIN LOP L ON KQ.MaLop = L.MaLop " +
                                            "INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc " +
                                            "INNER JOIN HOCLUC HL ON KQ.MaHocLuc = HL.MaHocLuc " +
                                            "INNER JOIN HANHKIEM HKIEM ON KQ.MaHanhKiem = HKIEM.MaHanhKiem " +
                                            "INNER JOIN KETQUA KQUA ON KQ.MaKetQua = KQUA.MaKetQua " +
                                            "WHERE KQ.MaLop = @maLop AND " +
                                            "KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value = maLop;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCaNamTongHopData.Load(cmd);
            return m_KQCaNamTongHopData;
        }
    }
}

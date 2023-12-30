using System;
using System.Data;
using System.Data.SqlClient;

namespace QLHocSinhTHPT.DataLayer
{
    public class KQCaNamMonHocData
    {
        DataService m_KQCaNamMonHocData = new DataService();

        public void LuuKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc, float diemThiLai, float diemTBMonCN)
        {
            DataService m_KQCNMHData = new DataService();

            SqlCommand cmd = new SqlCommand("INSERT INTO KQ_CA_NAM_MON_HOC VALUES(@maHocSinh, @maLop, @maMonHoc, @maNamHoc, @diemThiLai, @diemTBMonCN)");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value     = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;
            cmd.Parameters.Add("diemThiLai", SqlDbType.Float).Value     = Math.Round(diemThiLai, 2);
            cmd.Parameters.Add("diemTBMonCN", SqlDbType.Float).Value    = Math.Round(diemTBMonCN, 2);

            m_KQCNMHData.Load(cmd);
        }

        public void XoaKetQua(String maHocSinh, String maLop, String maMonHoc, String maNamHoc)
        {
            DataService m_KQCNMHData = new DataService();

            SqlCommand cmd = new SqlCommand("DELETE FROM KQ_CA_NAM_MON_HOC WHERE MaHocSinh = @maHocSinh AND MaLop = @maLop AND MaMonHoc = @maMonHoc AND MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maHocSinh", SqlDbType.VarChar).Value    = maHocSinh;
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value        = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value     = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value     = maNamHoc;

            m_KQCNMHData.Load(cmd);
        }

        public DataTable LayDsKQCaNamMonHocForReport(String maLop, String maMonHoc, String maNamHoc)
        {
            SqlCommand cmd = new SqlCommand("SELECT * " +
                                            "FROM HOCSINH HS INNER JOIN KQ_CA_NAM_MON_HOC KQ ON KQ.MaHocSinh = HS.MaHocSinh " +
                                            "INNER JOIN LOP L ON KQ.MaLop = L.MaLop " +
                                            "INNER JOIN MONHOC MH ON KQ.MaMonHoc = MH.MaMonHoc " +
                                            "INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc " +
                                            "WHERE KQ.MaLop = @maLop AND " +
                                            "KQ.MaMonHoc = @maMonHoc AND " +
                                            "KQ.MaNamHoc = @maNamHoc");
            cmd.Parameters.Add("maLop", SqlDbType.VarChar).Value    = maLop;
            cmd.Parameters.Add("maMonHoc", SqlDbType.VarChar).Value = maMonHoc;
            cmd.Parameters.Add("maNamHoc", SqlDbType.VarChar).Value = maNamHoc;

            m_KQCaNamMonHocData.Load(cmd);
            return m_KQCaNamMonHocData;
        }
    }
}

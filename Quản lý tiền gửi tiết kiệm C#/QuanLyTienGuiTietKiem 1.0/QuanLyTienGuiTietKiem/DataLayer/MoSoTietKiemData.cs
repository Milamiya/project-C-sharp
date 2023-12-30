using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class MoSoTietKiemData
    {
        DataService m_MoSoTK = new DataService();
        public DataTable LayLaiSuatTheoLoaiTK(String MaLoaiTK)
        {
            SqlCommand cmd = new SqlCommand("SELECT LTK.MaLoaiTietKiem, LS.MucLaiSuat,LTK.KyHan,LTK.TenLoaiTietKiem FROM LAI_SUAT_TIET_KIEM LS INNER JOIN LOAI_TIET_KIEM LTK ON LS.MaLoaiTietKiem = LTK.MaLoaiTietKiem WHERE LTK.MaLoaiTietKiem = @MaLoaiTK");
            cmd.Parameters.Add("MaLoaiTK", SqlDbType.VarChar).Value = MaLoaiTK;

            m_MoSoTK.Load(cmd);
            return m_MoSoTK;
        }
        public DataTable LayTheoMaNV(String MaNV)
        {
            SqlCommand cmd = new SqlCommand("SELECT GDV.MaNV, PGD.MaPhongGiaoDich, QGD.MaQuayGiaoDich FROM NHAN_VIEN NV INNER JOIN GIAO_DICH_VIEN GDV ON NV.MaNV = GDV.MaNV INNER JOIN PHONG_GIAO_DICH PGD ON NV.MaPhongGiaoDich = PGD.MaPhongGiaoDich INNER JOIN QUAY_GIAO_DICH QGD ON PGD.MaPhongGiaoDich = QGD.MaPhongGiaoDich WHERE GDV.MaNV = @MaNV");
            cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = MaNV;

            m_MoSoTK.Load(cmd);
            return m_MoSoTK;
        }

        //public DataTable LayTheoLoaiTK(String MaNV)
        //{
        //    SqlCommand cmd = new SqlCommand("");
        //    cmd.Parameters.Add("MaNV", SqlDbType.VarChar).Value = MaNV;

        //    m_MoSoTK.Load(cmd);
        //    return m_MoSoTK;
        //}

    }
}

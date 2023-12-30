using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class LoaiTietKiemData
    {
        DataService m_LoaiTietKiemData = new DataService();

        public DataTable LayLoaiTietKiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_TIET_KIEM");

            m_LoaiTietKiemData.Load(cmd);
            return m_LoaiTietKiemData;
        }
        public DataTable LayLoaiTietKiem(String idMaLoaiTK)
        {
            SqlCommand cmd = new SqlCommand("SELECT LTK.* FROM LOAI_TIET_KIEM LTK INNER JOIN DM_TAI_KHOAN DMTK ON LTK.SoHieuTaiKhoan=DMTK.SoHieuTaiKhoan WHERE LTK.MaLoaiTietKiem = @idMaLoaiTK");
            cmd.Parameters.Add("idMaLoaiTK", SqlDbType.VarChar, 10).Value = idMaLoaiTK;
            m_LoaiTietKiemData.Load(cmd);
            return m_LoaiTietKiemData;
        }
        public DataRow ThemDongMoi()
        {
            return m_LoaiTietKiemData.NewRow();
        }

        public void ThemLoaiTietKiem(DataRow m_Row)
        {
            m_LoaiTietKiemData.Rows.Add(m_Row);
        }

        public bool LuuLoaiTietKiem()
        {
            return m_LoaiTietKiemData.ExecuteNoneQuery() > 0;
        }

        public void LuuLoaiTietKiem(String maloaitk, String tenloaitk, int kyhan, bool danghuydong, String maloaitien, String makytinhlai, String sohieutaikhoan)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO LOAI_TIET_KIEM VALUES(@maloaitk, @tenloaitk, @kyhan, @danghuydong, @maloaitien, @makytinhlai, @sohieutaikhoan)");
            cmd.Parameters.Add("maloaitk", SqlDbType.VarChar).Value = maloaitk;
            cmd.Parameters.Add("tenloaitk", SqlDbType.NVarChar).Value = tenloaitk;
            cmd.Parameters.Add("kyhan", SqlDbType.Int).Value = kyhan;
            cmd.Parameters.Add("danghuydong", SqlDbType.Bit).Value = danghuydong;
            cmd.Parameters.Add("maloaitien", SqlDbType.VarChar).Value = maloaitien;
            cmd.Parameters.Add("makytinhlai", SqlDbType.VarChar).Value = makytinhlai;
            cmd.Parameters.Add("sohieutaikhoan", SqlDbType.VarChar).Value = sohieutaikhoan;

            m_LoaiTietKiemData.Load(cmd);
        }

        #region tim kiem
        public DataTable TimKiemTheoMa(String id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_TIET_KIEM WHERE MaLoaiTietKiem LIKE '%' + @id + '%'");
            cmd.Parameters.Add("id", SqlDbType.VarChar).Value = id;

            m_LoaiTietKiemData.Load(cmd);
            return m_LoaiTietKiemData;
        }

        public DataTable TimKiemTheoTen(String ten)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM LOAI_TIET_KIEM WHERE TenLoaiTietKiem LIKE '%' + @ten + '%'");
            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = ten;

            m_LoaiTietKiemData.Load(cmd);
            return m_LoaiTietKiemData;
        }
        #endregion
    }
}

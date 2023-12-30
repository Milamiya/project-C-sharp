using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QuanLyTienGuiTietKiem.General;

namespace QuanLyTienGuiTietKiem.DataLayer
{
    public class SoDuTietKiemData
    {
        DataService m_SoDuTietKiemData = new DataService();

        public DataTable LaySoDuTietKiem()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM SO_DU_TIET_KIEM");
            m_SoDuTietKiemData.Load(cmd);
            return m_SoDuTietKiemData;
        }

        public void LuuSoDuTK(String MaLoaiTK, String MaSoTK, DateTime NgayCapNhat, float SoDu)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SO_DU_TIET_KIEM VALUES(@MaLoaiTK, @MaSoTK, @NgayCapNhat, @SoDu)");

            cmd.Parameters.Add("MaLoaiTK", SqlDbType.VarChar).Value = MaLoaiTK;
            cmd.Parameters.Add("MaSoTK", SqlDbType.VarChar).Value = MaSoTK;
            cmd.Parameters.Add("NgayCapNhat", SqlDbType.DateTime).Value = NgayCapNhat;
            cmd.Parameters.Add("SoDu", SqlDbType.Float).Value = SoDu;
           

            m_SoDuTietKiemData.Load(cmd);
        }

        public void XoaSoDuTK(String MaLoaiTK, String MaSoTK, DateTime NgayCapNhat, float SoDu)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM SO_DU_TIET_KIEM WHERE MaLoaiTietKiem = @MaLoaiTK AND MaSoTietKiem =  @MaSoTK AND NgayCapNhat = @NgayCapNhat AND SoDu = @SoDu)");

            cmd.Parameters.Add("MaLoaiTK", SqlDbType.VarChar).Value = MaLoaiTK;
            cmd.Parameters.Add("MaSoTK", SqlDbType.VarChar).Value = MaSoTK;
            cmd.Parameters.Add("NgayCapNhat", SqlDbType.DateTime).Value = NgayCapNhat;
            cmd.Parameters.Add("SoDu", SqlDbType.Float).Value = SoDu;


            m_SoDuTietKiemData.Load(cmd);
        }

        //public void LuuSoDu(String MaSo, float SoDu)
        //{
        //    DataService data = new DataService();
        //    SqlCommand cmd = new SqlCommand("UPDATE SO_DU_TIET_KIEM SET SoDu = @SoDu WHERE MaSoTietKiem = @MaSo");
        //    cmd.Parameters.Add("SoDu", SqlDbType.Float).Value = SoDu;
        //    cmd.Parameters.Add("MaSo", SqlDbType.VarChar).Value = MaSo;

        //    data.Load(cmd);
        //}

        public DataRow ThemDongMoi()
        {
            return m_SoDuTietKiemData.NewRow();
        }

        public void ThemSoDuTietKiem(DataRow m_Row)
        {
            m_SoDuTietKiemData.Rows.Add(m_Row);
        }

        public bool LuuSoDuTietKiem()
        {
            return m_SoDuTietKiemData.ExecuteNoneQuery() > 0;
        }

    }
}

using System;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyHoSoCongChuc.DataLayer
{
    public class NguoiDungData
    {
        DataService m_NguoiDungData = new DataService();

        public DataTable LayDSNguoiDung()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung");
            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }

        public DataTable LayNguoiDung(String username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung WHERE TenDangNhap = @ten");
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = username;
            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }
        public DataTable LayPassWord(String username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung WHERE MatKhau = @ten");
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = username;
            m_NguoiDungData.Load(cmd);
            return m_NguoiDungData;
        }

        public DataRow ThemDongMoi()
        {
            return m_NguoiDungData.NewRow();
        }

        public void ThemNguoiDung(DataRow m_Row)
        {
            m_NguoiDungData.Rows.Add(m_Row);
        }

        public bool LuuNguoiDung()
        {
            return m_NguoiDungData.ExecuteNoneQuery() > 0;
        }
        public void ChangePassword(String userName, String newPassword)
        {
            m_NguoiDungData.ChangePassword(userName, newPassword);
        }
    }
}

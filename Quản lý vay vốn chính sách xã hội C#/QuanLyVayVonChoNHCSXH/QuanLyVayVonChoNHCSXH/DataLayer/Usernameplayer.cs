//using System;
//using System.Data;
//using System.Data.SqlClient;
//using QuanLyNhaHang.Setting;

//namespace QuanLyNhaHang.DataPlyer
//{
//    public class Usernameplayer
//    {
//        DataService m_Ds = new DataService();

//        public DataTable DanhSachUsername()
//        {
//            SqlCommand cmd = new SqlCommand("SELECT * FROM Username");
//            m_Ds.Load(cmd);

//            return m_Ds;
//        }

//        public DataTable LayUsername(String user)
//        {
//            SqlCommand cmd = new SqlCommand("SELECT * FROM Username WHERE Username = @user");
//            cmd.Parameters.Add("user", SqlDbType.VarChar, 50).Value = user;
//            m_Ds.Load(cmd);

//            return m_Ds;
//        }

//        public bool Save()
//        {
//            return (m_Ds.ExecuteNoneQuery() > 0);
//        }
//    }
//}

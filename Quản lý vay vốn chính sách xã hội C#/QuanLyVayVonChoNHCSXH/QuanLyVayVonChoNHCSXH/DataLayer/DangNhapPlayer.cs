using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyVayVonChoNHCSXH.Setting;

namespace QuanLyVayVonChoNHCSXH.DataPlayer
{
    public class DangNhapPlayer
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachUsername()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM DangNhap");
            m_Ds.Load(cmd);
            return m_Ds;
       }
       public DataTable LayUsername(String user)
       {
           SqlCommand cmd = new SqlCommand("SELECT * FROM DangNhap WHERE Username = @user");
           cmd.Parameters.Add("user", SqlDbType.VarChar, 30).Value = user;
           m_Ds.Load(cmd);
           return m_Ds;
       }

       public DataTable LayQuyenTruyCap(String user)
       {
           SqlCommand cmd = new SqlCommand("SELECT Quyen.TenQuyen FROM (SELECT DangNhap.MaQuyen FROM DangNhap WHERE Username = @user) as users, Quyen WHERE users.MaQuyen = Quyen.MaQuyen");

           cmd.Parameters.Add("user", SqlDbType.Char, 30).Value = user;
           m_Ds.Load(cmd);

           return m_Ds;
       }

       public DataRow NewRow()
       {
           return m_Ds.NewRow();
       }

       public void Add(DataRow row)
       {
           m_Ds.Rows.Add(row);
       }

       //public bool Save()
       //{
       //    return (m_Ds.ExecuteNoneQuery() > 0);
       //}

       public bool Save(String user, String pass, String quyen, String nv)
       {
           String strcmd = "INSERT INTO Username(\"Username\", \"Password\", \"MaQuyen\", \"MaNV\") values ('" + user + "','" + pass + "', '" + quyen + "' , '" + nv + "')";
           SqlCommand cmd = new SqlCommand(strcmd);

           int i = DanhSachUsername().Rows.Count;
           m_Ds.Load(cmd);

           if (DanhSachUsername().Rows.Count > i)
               return true;
           return false;
       }
    }
}

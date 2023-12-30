using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Security.Cryptography;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class DangNhapData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhSachUser()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM NGUOIDUNG");
            m_Ds.Load(cmd);

            return m_Ds;
        }

        public DataTable DangNhap(string username,string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();

            pass = md5.ComputeHash(encode.GetBytes(password));

            OleDbCommand cmd = new OleDbCommand("SELECT * from NGUOIDUNG where username = '" + username.Trim() + "' and password = '" + BitConverter.ToString(pass) + "'");
            m_Ds.Load(cmd);
            return m_Ds;
        }

        byte[] pass;
        public bool isExitUser(string p, System.Windows.Forms.TextBox txtpassold)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();

            pass = md5.ComputeHash(encode.GetBytes(txtpassold.Text.Trim()));

            //MessageBox.Show(BitConverter.ToString(pass));

            OleDbCommand cmd = new OleDbCommand("select * from NGUOIDUNG where username = '" + p.Trim() + "' and password = '" + BitConverter.ToString(pass) + "'");
            m_Ds.Load(cmd);
            return m_Ds.Rows.Count > 0;
        }

        public void SetPassWord(string user, string pass1)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();

            pass = md5.ComputeHash(encode.GetBytes(pass1));

            //MessageBox.Show(BitConverter.ToString(pass));

            string sqlUpdate = "UPDATE NGUOIDUNG set password = '" + BitConverter.ToString(pass) + "' where username = '" + user.Trim() + "'";
            OleDbCommand cmb = new OleDbCommand(sqlUpdate);

            //MessageBox.Show(sqlUpdate);
            m_Ds.ExecuteNoneQuery(cmb);
        }

        public void insertUser(object p, string txtusername, string txtpassword)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();

            pass = md5.ComputeHash(encode.GetBytes(txtpassword));
            long i = Convert.ToInt64(p);
            //MessageBox.Show(pass.ToString () );

            string sql = "INSERT INTO NGUOIDUNG VALUES('" + i + "', '" + txtusername + "', '" + BitConverter.ToString(pass) + "')";
            OleDbCommand cmb = new OleDbCommand(sql);

            m_Ds.ExecuteNoneQuery(cmb);
        }
        public bool isExitUserName(string p)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();

            OleDbCommand cmd = new OleDbCommand("select * from NGUOIDUNG where username = '" + p.Trim() + "'");
            m_Ds.Load(cmd);
            return m_Ds.Rows.Count > 0;
        }

        public void DelUser(string username)
        {
            string sql = "DELETE NGUOIDUNG WHERE username='" + username.Trim() + "'";
            OleDbCommand cmb = new OleDbCommand(sql);

            m_Ds.ExecuteNoneQuery(cmb);
        }
    }
}

using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using QuanLyVayVonChoNHCSXH.DataPlayer;

using System.Windows.Forms;

namespace QuanLyVayVonChoNHCSXH.Controller
{
    public class DangNhapController
    {
        DangNhapPlayer DNplayer = new DangNhapPlayer();

        public bool TestDuLieu(String user, String pass)
        {
            DataTable tbl = DNplayer.DanhSachUsername();

            String strPass = null;
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = md5.ComputeHash(bs);
            foreach (byte b in bs)
            {
                strPass += (b.ToString("x2").ToLower());
            }

            int i = 0;
            while (i < tbl.Rows.Count)
            {
                if ((Test(Convert.ToString(tbl.Rows[i]["Username"]).ToString(), user)) && (Test(Convert.ToString(tbl.Rows[i]["Password"]).ToString(), strPass)))
                    return true;
                i++;
            }
            return false;
        }

        public String LayQuyenTruyCap(String user)
        {
            DataTable tbl = DNplayer.LayQuyenTruyCap(user);
            if(tbl.Rows.Count > 0)
                return tbl.Rows[0]["TenQuyen"].ToString();
            else
                return null;
        }

        public bool Test(String str1, String str2)
        {
            if (str1.Length != str2.Length)
                return false;
            else
                for (int i = 0; i < str1.Length; i++)
                    if (str1[i] != str2[i])
                        return false;
            return true;
        }
    }
}

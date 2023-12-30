using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using QUANLYHOSONHANVIEN.DataLayer;
using System.Windows.Forms;

namespace QUANLYHOSONHANVIEN.DataLayer
{
    public class NguoiDungData
    {
        DataService m_Ds = new DataService();

        public DataTable DanhsachNguoiDung(string str)
        {
            //MessageBox.Show(str);
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM nguoidung where username != 'admin' or username !='" + str + "'");
            m_Ds.Load(cmd);

            return m_Ds;
        }
        PhongBanData data_phongban = new PhongBanData();
        public void HienThiX(ComboBox cmb)
        {
            DataTable tbl = data_phongban.Danhsach();
            cmb.DataSource = tbl;
            cmb.DisplayMember = "ten";
            cmb.ValueMember = "ma";
        }
        public DataRow NewRow()
        {
            return m_Ds.NewRow();
        }
        public void Add(DataRow row)
        {
            m_Ds.Rows.Add(row);
        }
        public bool Save()
        {
            return m_Ds.ExecuteNoneQuery() > 0;
        }
        public DataTable ThemNguoiDung(string txtusername, string txtpass, string quyen)
        {
            long ma = ThamSo.TaoMaNguoidung;
            ThamSo.TaoMaNguoidung = ma + 1;
            string maso = ma.ToString();

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();

            pass = md5.ComputeHash(encode.GetBytes(txtpass));

            OleDbCommand cmd = new OleDbCommand("INSERT INTO NGUOIDUNG(MASO,USERNAME,PASSWORD,QUYEN) values(N'" + maso + "',N'" + txtusername + "',N'" + BitConverter.ToString(pass) + "',N'" + quyen + "')");

            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        public DataTable UpdateNguoiDung(string username, string loaitk, string maso)
        {
            OleDbCommand cmd = new OleDbCommand("UPDATE NGUOIDUNG SET USERNAME=N'" + username  + "',QUYEN=N'" + loaitk + "' WHERe MASO = '" + maso + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

        public DataTable DeleteNguoiDung(string MASO)
        {
            OleDbCommand cmd = new OleDbCommand("DELETE FROM NGUOIDUNG WHERE MASO ='" + MASO + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }
        byte[] pass;
        public DataTable DoiMatKhau(string username,string PASS)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();

            pass = md5.ComputeHash(encode.GetBytes(PASS));
            OleDbCommand cmd = new OleDbCommand("UPDATE NGUOIDUNG SET PASSWORD=N'" + BitConverter.ToString(pass) + "' WHERe USERNAME = '" + username + "'");
            m_Ds.ExecuteNoneQuery(cmd);
            return m_Ds;
        }

    }
}

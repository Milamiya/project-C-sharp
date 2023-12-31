using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class Doimatkhau_Data
    {
        DataService ds = new DataService();
        public bool Sua(NguoiDung_InFo nguoidung)
        {
            SqlCommand s = new SqlCommand("Update NguoiDung set MatKhau = @pass where MaNguoiDung = @ma");
            s.Parameters.Add("@pass", SqlDbType.VarChar, 32).Value = nguoidung.MatKhau;
            s.Parameters.Add("@ma", SqlDbType.VarChar, 50).Value = nguoidung.MaNguoiDung;
            try
            {
                ds.Load(s);
                MsgDoiMK();
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        //
        public bool LayNguoiDung(string User, string pass)
        {
            SqlCommand s = new SqlCommand("select * from NguoiDung where MatKhau = @pass and TenDangNhap = @ma");
            s.Parameters.Add("@pass", SqlDbType.VarChar, 32).Value = pass;
            s.Parameters.Add("@ma", SqlDbType.VarChar, 32).Value = User;
            try
            {
                ds.Load(s);
                if (ds.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        //
        public string LayMaNguoiDung(string User, string pass)
        {
            SqlCommand s = new SqlCommand("select MaNguoiDung from NguoiDung where MatKhau = @pass and TenDangNhap = @ma");
            s.Parameters.Add("@pass", SqlDbType.VarChar, 32).Value = pass;
            s.Parameters.Add("@ma", SqlDbType.VarChar, 32).Value = User;
            try
            {
                ds.Load(s);
                if (ds.Rows.Count > 0)
                    return ds.Rows[0]["MaNguoiDung"].ToString();
                else
                    return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }
        //
        public void MsgDoiMK()
        {
            MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK);
        }
    }
}

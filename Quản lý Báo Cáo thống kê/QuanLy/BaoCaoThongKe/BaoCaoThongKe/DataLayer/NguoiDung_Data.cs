using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using BaoCaoThongKe.BusinessObject;

namespace BaoCaoThongKe.DataLayer
{
    public class NguoiDung_Data
    {

        DataService ds = new DataService();
        public DataTable ListNguoiDung()
        {
            SqlCommand s = new SqlCommand("select * from NguoiDung order by Hoten");
            ds.Load(s);
            return ds;
        }

        public DataTable LayMaMax()
        {
            SqlCommand cmd = new SqlCommand("select MAX(MaNguoiDung) from NguoiDung");
            ds.Load(cmd);
            return ds;
        }

        public bool Xoa(NguoiDung_InFo nguoidung)
        {
            SqlCommand s = new SqlCommand("Delete NguoiDung where MaNguoiDung = @ma");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = nguoidung.MaNguoiDung;
            try
            {
                ds.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }

        public bool Them(NguoiDung_InFo nguoidung)
        {
            SqlCommand s = new SqlCommand("INSERT INTO NguoiDung(MaNguoiDung, Hoten, TenDangNhap, MatKhau, Quyen) VALUES(@ma, @ten, @user, @pass, @quyen)");
            s.Parameters.Add("@ma", SqlDbType.Int).Value = nguoidung.MaNguoiDung;
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = nguoidung.HoTen;
            s.Parameters.Add("@user", SqlDbType.VarChar, 32).Value = nguoidung.TenDangNhap;
            s.Parameters.Add("@pass", SqlDbType.VarChar, 32).Value = nguoidung.MatKhau;
            s.Parameters.Add("@quyen", SqlDbType.NVarChar, 50).Value = nguoidung.Quyen;
            try
            {
                ds.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }

        public bool Sua(NguoiDung_InFo nguoidung)
        {
            SqlCommand s = new SqlCommand("Update NguoiDung set Hoten = @ten, TenDangNhap = @user, MatKhau = @pass, Quyen = @quyen where MaNguoiDung = @ma");
            s.Parameters.Add("@ten", SqlDbType.NVarChar, 50).Value = nguoidung.HoTen;
            s.Parameters.Add("@user", SqlDbType.VarChar, 32).Value = nguoidung.TenDangNhap;
            s.Parameters.Add("@pass", SqlDbType.VarChar, 32).Value = nguoidung.MatKhau;
            s.Parameters.Add("@quyen", SqlDbType.NVarChar, 50).Value = nguoidung.Quyen;
            s.Parameters.Add("@ma", SqlDbType.Int).Value = nguoidung.MaNguoiDung;
            try
            {
                ds.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
    }
}

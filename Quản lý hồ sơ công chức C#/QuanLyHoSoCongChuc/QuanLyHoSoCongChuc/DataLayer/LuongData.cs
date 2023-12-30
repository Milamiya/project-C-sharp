using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyHoSoCongChuc.BusinessObject;
using QuanLyHoSoCongChuc.Controller;
using QuanLyHoSoCongChuc.DataLayer;

namespace QuanLyHoSoCongChuc.DataLayer
{
    public class LuongData
    {
        DataService m_LuongData = new DataService();
        public DataTable LayDSNV(DateTime dt)
        {
            SqlCommand cmd = new SqlCommand("SELECT  HoTenNhanVien,MaNgach, MocTinhNangLuongLanSau, NgayNangLuong from NhanVien where DateDiff(dd,NgayNangLuong,'" + dt + "')>0");
            m_LuongData.Load(cmd);
            return m_LuongData;
        }
        public DataTable CapNhatCanSu(DateTime dt)
        {
            SqlCommand cmd = new SqlCommand("Update NhanVien set  MocTinhNangLuongLanSau = NgayNangLuong, NgayNangLuong = DateAdd(year,2,NgayNangLuong) Where NhanVien.MaNgach = 'MN001' and DateDiff(dd, NgayNangLuong, '" + dt + "')>0");
            //SqlCommand cmd = new SqlCommand("Update HoTenNhanVien, MaNgach, MocTinhNangLuongLanSau = NgayNangLuong, NgayNangLuong = DateAdd(year,2,NgayNangLuong) from NhanVien Where NhanVien.MaNgach = 'MN001' And DateDiff(dd,NgayNangLuong,'" + dt + "')>0");
            m_LuongData.Load(cmd);
            return m_LuongData;

        }
        public DataTable CapNhatChuyenVien(DateTime dt)
        {
            SqlCommand cmd = new SqlCommand("Update NhanVien set  MocTinhNangLuongLanSau = NgayNangLuong, NgayNangLuong = DateAdd(year,3,NgayNangLuong) Where NhanVien.MaNgach = 'MN002' And DateDiff(dd,NgayNangLuong,'" + dt + "')>0");
            m_LuongData.Load(cmd);
            return m_LuongData;
        }

    }
}

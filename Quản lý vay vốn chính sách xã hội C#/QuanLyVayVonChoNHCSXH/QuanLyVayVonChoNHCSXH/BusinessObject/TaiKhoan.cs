using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class TaiKhoan
    {
       public TaiKhoan() { }

       public TaiKhoan(String mataikhoan)
       {
           m_MaTaiKhoan = mataikhoan;
       }
       public TaiKhoan(String mataikhoan, String tentaikhoan)
       {
           m_MaTaiKhoan = mataikhoan;
           m_TenTaiKhoan = tentaikhoan;
       }

       private String m_MaTaiKhoan;

       public String mataikhoan
       {
           get { return m_MaTaiKhoan; }
           set { m_MaTaiKhoan = value; }
       }

       private String m_TenTaiKhoan;
       public String tentaikhoan
       {
           get { return m_TenTaiKhoan; }
           set { m_TenTaiKhoan = value; }
       }

       private String m_MaCap;
       public String macap
       {
           get { return m_MaCap; }
           set { m_MaCap = value; }
       }

       private String m_MaNV;
       public String manv
       {
           get { return m_MaNV; }
           set { m_MaNV = value; }
       }
    }
}

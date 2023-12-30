using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class DoiTac
    {
       public DoiTac() { }

       public DoiTac(String madoitac)
       {
           m_MaDoiTac = madoitac;
       }
       public DoiTac(String madoitac, String tendt)
       {
           m_MaDoiTac = madoitac;
           m_TenDT = tendt;
       }

       private String m_MaDoiTac;

       public String MADOITAC
       {
           get { return m_MaDoiTac; }
           set { m_MaDoiTac = value; }
       }

       private String m_TenDT;
       public String HOTENDT
       {
           get { return m_TenDT; }
           set { m_TenDT = value; }
       }

       private String m_GioiTinh;
       public String GIOITINH
       {
           get { return m_GioiTinh; }
           set { m_GioiTinh = value; }
       }

       private DateTime m_NgaySinh;
       public DateTime NGAYSINH
       {
           get { return m_NgaySinh; }
           set { m_NgaySinh = value; }
       }

       private String m_DiaChi;
       public String DIACHI
       {
           get { return m_DiaChi; }
           set { m_DiaChi = value; }
       }

       private String m_CMND;
       public String CMND
       {
           get { return m_CMND; }
           set { m_CMND = value; }
       }

       private DateTime m_NgayCap;
       public DateTime NGAYCAP
       {
           get { return m_NgayCap; }
           set { m_NgayCap = value; }
       }

       private String m_NoiCap;
       public String NOICAP
       {
           get { return m_NoiCap; }
           set { m_NoiCap = value; }
       }

       private String m_MaTinh;
       public String MATINH
       {
           get { return m_MaTinh; }
           set { m_MaTinh = value; }
       }

       private String m_MaHuyen;
       public String MAHUYEN
       {
           get { return m_MaHuyen; }
           set { m_MaHuyen = value; }
       }

       private String m_MaXa;
       public String MAXA
       {
           get { return m_MaXa; }
           set { m_MaXa = value; }
       }

       private String m_MaLoaiHinh;
       public String MALOAIHINH
       {
           get { return m_MaLoaiHinh; }
           set { m_MaLoaiHinh = value; }
       }

       private String m_MaLoaiDoiTac;
       public String MALOAIDOITAC
       {
           get { return m_MaLoaiDoiTac; }
           set { m_MaLoaiDoiTac = value; }
       }

       private String m_MaDanToc;
       public String MADANTOC
       {
           get { return m_MaDanToc; }
           set { m_MaDanToc = value; }
       }
    }
}

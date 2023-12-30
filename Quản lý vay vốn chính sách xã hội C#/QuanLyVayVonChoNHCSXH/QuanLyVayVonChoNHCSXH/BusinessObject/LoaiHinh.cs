using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class LoaiHinh
    {
       public LoaiHinh() { }

       public LoaiHinh(String maloaihinh)
       {
           m_MaLoaiHinh = maloaihinh;
       }
       public LoaiHinh(String maloaihinh, String tenloaihinh)
       {
           m_MaLoaiHinh = maloaihinh;
           m_TenLoaiHinh = tenloaihinh;
       }

       private String m_MaLoaiHinh;

       public String maloaihinh
       {
           get { return m_MaLoaiHinh; }
           set { m_MaLoaiHinh = value; }
       }

       private String m_TenLoaiHinh;
       public String tenloaihinh
       {
           get { return m_TenLoaiHinh; }
           set { m_TenLoaiHinh = value; }
       }
    }
}

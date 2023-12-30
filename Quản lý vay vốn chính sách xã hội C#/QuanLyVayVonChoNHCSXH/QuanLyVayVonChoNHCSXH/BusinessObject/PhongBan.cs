using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class PhongBan
    {
       public PhongBan() { }

       public PhongBan(String maphongban)
       {
           m_MaPhongBan = maphongban;
       }
       public PhongBan(String maphongban, String tenphongban)
       {
           m_MaPhongBan = maphongban;
           m_TenPhongBan = tenphongban;
       }

       private String m_MaPhongBan;

       public String maphongban
       {
           get { return m_MaPhongBan; }
           set { m_MaPhongBan = value; }
       }

       private String m_TenPhongBan;
       public String tenphongban
       {
           get { return m_TenPhongBan; }
           set { m_TenPhongBan = value; }
       }
    }
}

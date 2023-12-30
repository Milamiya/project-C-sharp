using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class Huyen
    {
       public Huyen() { }

       public Huyen(String mahuyen)
       {
           m_MaHuyen = mahuyen;
       }
       public Huyen(String mahuyen, String tenhuyen)
       {
           m_MaHuyen = mahuyen;
           m_TenHuyen = tenhuyen;
       }

       private String m_MaHuyen;

       public String mahuyen
       {
           get { return m_MaHuyen; }
           set { m_MaHuyen = value; }
       }

       private String m_TenHuyen;
       public String tenhuyen
       {
           get { return m_TenHuyen; }
           set { m_TenHuyen = value; }
       }
    }
}

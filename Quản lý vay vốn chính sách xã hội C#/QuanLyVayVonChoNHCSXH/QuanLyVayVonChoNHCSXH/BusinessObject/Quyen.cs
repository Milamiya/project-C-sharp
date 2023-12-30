using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class Quyen
    {
       public Quyen() { }

       public Quyen(String maquyen)
       {
           m_MaQuyen = maquyen;
       }
       public Quyen(String maquyen, String tenquyen)
       {
           m_MaQuyen = maquyen;
           m_TenQuyen = tenquyen;
       }

       private String m_MaQuyen;

       public String maquyen
       {
           get { return m_MaQuyen; }
           set { m_MaQuyen = value; }
       }

       private String m_TenQuyen;
       public String tenquyen
       {
           get { return m_TenQuyen; }
           set { m_TenQuyen = value; }
       }
    }
}

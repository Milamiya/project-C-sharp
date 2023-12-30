using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class Xa
    {
       public Xa() { }

       public Xa(String maxa)
       {
           m_MaXa = maxa;
       }
       public Xa(String maxa, String tenxa)
       {
           m_MaXa = maxa;
           m_TenXa = tenxa;
       }

       private String m_MaXa;

       public String maxa
       {
           get { return m_MaXa; }
           set { m_MaXa = value; }
       }

       private String m_TenXa;
       public String tenxa
       {
           get { return m_TenXa; }
           set { m_TenXa = value; }
       }
    }
}

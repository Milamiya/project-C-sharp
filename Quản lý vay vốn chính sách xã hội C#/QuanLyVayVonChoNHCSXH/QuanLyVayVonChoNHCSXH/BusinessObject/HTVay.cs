using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class HTVay
    {
       public HTVay() { }

       public HTVay(String mahtvay)
       {
           m_MaHTVay = mahtvay;
       }
       public HTVay(String mahtvay, String tenhtvay)
       {
           m_MaHTVay = mahtvay;
           m_TenHTVay = tenhtvay;
       }

       private String m_MaHTVay;

       public String mahtvay
       {
           get { return m_MaHTVay; }
           set { m_MaHTVay = value; }
       }

       private String m_TenHTVay;
       public String tenhtvay
       {
           get { return m_TenHTVay; }
           set { m_TenHTVay = value; }
       }
    }
}

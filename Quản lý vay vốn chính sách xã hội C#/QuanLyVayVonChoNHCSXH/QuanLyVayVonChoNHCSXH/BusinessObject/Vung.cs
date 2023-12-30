using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class Vung
    {
       public Vung() { }

       public Vung(String mavung)
       {
           m_MaVung = mavung;
       }
       public Vung(String mavung, String tenvung)
       {
           m_MaVung = mavung;
           m_TenVung = tenvung;
       }

       private String m_MaVung;

       public String mavung
       {
           get { return m_MaVung; }
           set { m_MaVung = value; }
       }

       private String m_TenVung;
       public String tenvung
       {
           get { return m_TenVung; }
           set { m_TenVung = value; }
       }
    }
}

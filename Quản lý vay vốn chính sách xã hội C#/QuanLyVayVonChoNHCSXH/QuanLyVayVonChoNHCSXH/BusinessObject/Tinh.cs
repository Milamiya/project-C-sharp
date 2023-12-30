using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class Tinh
    {
       public Tinh() { }

       public Tinh(String matinh)
       {
           m_MaTinh = matinh;
       }
       public Tinh(String matinh, String tentinh)
       {
           m_MaTinh = matinh;
           m_TenTinh = tentinh;
       }

       private String m_MaTinh;

       public String matinh
       {
           get { return m_MaTinh; }
           set { m_MaTinh = value; }
       }

       private String m_TenTinh;
       public String tentinh
       {
           get { return m_TenTinh; }
           set { m_TenTinh = value; }
       }
    }
}

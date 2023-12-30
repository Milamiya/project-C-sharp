using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class ThoiHanVay
    {
       public ThoiHanVay() { }

       public ThoiHanVay(String mathoihanvay)
       {
           m_MaThoiHanVay = mathoihanvay;
       }
       public ThoiHanVay(String mathoihanvay, String tenthoihanvay)
       {
           m_MaThoiHanVay = mathoihanvay;
           m_TenThoiHanVay = tenthoihanvay;
       }

       private String m_MaThoiHanVay;

       public String mathoihanvay
       {
           get { return m_MaThoiHanVay; }
           set { m_MaThoiHanVay = value; }
       }

       private String m_TenThoiHanVay;
       public String tenthoihanvay
       {
           get { return m_TenThoiHanVay; }
           set { m_TenThoiHanVay = value; }
       }
    }
}

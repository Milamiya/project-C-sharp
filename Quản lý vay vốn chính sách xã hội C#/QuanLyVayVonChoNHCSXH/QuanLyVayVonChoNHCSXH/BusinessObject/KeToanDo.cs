using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class KeToanDo
    {
       public KeToanDo() { }

       public KeToanDo(String macap)
       {
           m_MaCap = macap;
       }
       public KeToanDo(String macap, String tencap)
       {
           m_MaCap = macap;
           m_TenCap = tencap;
       }

       private String m_MaCap;

       public String macap
       {
           get { return m_MaCap; }
           set { m_MaCap = value; }
       }

       private String m_TenCap;
       public String tencap
       {
           get { return m_TenCap; }
           set { m_TenCap = value; }
       }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class DonViUyThac
    {
       public DonViUyThac() { }

       public DonViUyThac(String madvuythac)
       {
           m_MaDVUyThac = madvuythac;
       }
       public DonViUyThac(String madvuythac, String tendvuythac)
       {
           m_MaDVUyThac = madvuythac;
           m_TenDVUyThac = tendvuythac;
       }

       private String m_MaDVUyThac;

       public String madvuythac
       {
           get { return m_MaDVUyThac; }
           set { m_MaDVUyThac = value; }
       }

       private String m_TenDVUyThac;
       public String tendvuythac
       {
           get { return m_TenDVUyThac; }
           set { m_TenDVUyThac = value; }
       }
    }
}

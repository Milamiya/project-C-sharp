using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class DanToc
    {
        public DanToc() { }

       public DanToc(String madantoc)
       {
           m_MaDanToc = madantoc;
       }
       public DanToc(String madantoc, String tendantoc)
       {
           m_MaDanToc = madantoc;
           m_TenDanToc = tendantoc;
       }

       private String m_MaDanToc;

       public String madantoc
       {
           get { return m_MaDanToc; }
           set { m_MaDanToc = value; }
       }

       private String m_TenDanToc;
       public String tendantoc
       {
           get { return m_TenDanToc; }
           set { m_TenDanToc = value; }
       }
    }
}

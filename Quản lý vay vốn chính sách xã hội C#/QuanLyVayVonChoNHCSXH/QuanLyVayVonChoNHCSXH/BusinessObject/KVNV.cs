using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class KVNV
    {
       public KVNV() { }

       public KVNV(String makvnv)
       {
           m_MaKVNV = makvnv;
       }
       public KVNV(String makvnv, String tenkvnv)
       {
           m_MaKVNV = makvnv;
           m_TenKVNV = tenkvnv;
       }

       private String m_MaKVNV;

       public String makvnv
       {
           get { return m_MaKVNV; }
           set { m_MaKVNV = value; }
       }

       private String m_TenKVNV;
       public String tenkvnv
       {
           get { return m_TenKVNV; }
           set { m_TenKVNV = value; }
       }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class KieuTra
    {
       public KieuTra() { }

       public KieuTra(String makieutra)
       {
           m_MaKieuTra = makieutra;
       }
       public KieuTra(String makieutra, String tenkieutra)
       {
           m_MaKieuTra = makieutra;
           m_TenKieuTra = tenkieutra;
       }

       private String m_MaKieuTra;

       public String makieutra
       {
           get { return m_MaKieuTra; }
           set { m_MaKieuTra = value; }
       }

       private String m_TenKieuTra;
       public String tenkieutra
       {
           get { return m_TenKieuTra; }
           set { m_TenKieuTra = value; }
       }
    }
}

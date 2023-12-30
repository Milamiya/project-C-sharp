using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class ChucVu
    {
       public ChucVu() { }

       public ChucVu(String machucvu)
       {
           m_MaChucVu = machucvu;
       }
       public ChucVu(String machucvu, String tenchucvu)
       {
           m_MaChucVu = machucvu;
           m_TenChucVu = tenchucvu;
       }

       private String m_MaChucVu;

       public String machucvu
       {
           get { return m_MaChucVu; }
           set { m_MaChucVu = value; }
       }

       private String m_TenChucVu;
       public String tenchucvu
       {
           get { return m_TenChucVu; }
           set { m_TenChucVu = value; }
       }
    }
}

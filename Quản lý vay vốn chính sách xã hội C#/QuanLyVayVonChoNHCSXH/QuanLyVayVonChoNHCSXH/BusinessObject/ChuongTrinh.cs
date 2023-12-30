using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class ChuongTrinh
    {
        public ChuongTrinh() { }

       public ChuongTrinh(String machuongtrinh)
       {
           m_MaChuongTrinh = machuongtrinh;
       }
       public ChuongTrinh(String machuongtrinh, String tenchuongtrinh)
       {
           m_MaChuongTrinh = machuongtrinh;
           m_TenChuongTrinh = tenchuongtrinh;
       }

       private String m_MaChuongTrinh;

       public String machuongtrinh
       {
           get { return m_MaChuongTrinh; }
           set { m_MaChuongTrinh = value; }
       }

       private String m_TenChuongTrinh;
       public String tenchuongtrinh
       {
           get { return m_TenChuongTrinh; }
           set { m_TenChuongTrinh = value; }
       }
    }
}

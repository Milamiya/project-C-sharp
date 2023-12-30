using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class LoaiDoiTac
    {
       public LoaiDoiTac() { }

       public LoaiDoiTac(String maloaidoitac)
       {
           m_MaLoaiDoiTac = maloaidoitac;
       }
       public LoaiDoiTac(String maloaidoitac, String tenloaidoitac)
       {
           m_MaLoaiDoiTac = maloaidoitac;
           m_TenLoaiDoiTac = tenloaidoitac;
       }

       private String m_MaLoaiDoiTac;

       public String maloaidoitac
       {
           get { return m_MaLoaiDoiTac; }
           set { m_MaLoaiDoiTac = value; }
       }

       private String m_TenLoaiDoiTac;
       public String tenloaidoitac
       {
           get { return m_TenLoaiDoiTac; }
           set { m_TenLoaiDoiTac = value; }
       }
    }
}

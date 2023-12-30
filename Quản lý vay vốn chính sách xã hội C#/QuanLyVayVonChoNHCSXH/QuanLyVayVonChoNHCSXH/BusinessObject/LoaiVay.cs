using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class LoaiVay
    {
       public LoaiVay() { }

       public LoaiVay(String maloaivay)
       {
           m_MaLoaiVay = maloaivay;
       }
       public LoaiVay(String maloaivay, String tenloaivay)
       {
           m_MaLoaiVay = maloaivay;
           m_TenLoaiVay = tenloaivay;
       }

       private String m_MaLoaiVay;

       public String maloaivay
       {
           get { return m_MaLoaiVay; }
           set { m_MaLoaiVay = value; }
       }

       private String m_TenLoaiVay;
       public String tenloaivay
       {
           get { return m_TenLoaiVay; }
           set { m_TenLoaiVay = value; }
       }
    }
}

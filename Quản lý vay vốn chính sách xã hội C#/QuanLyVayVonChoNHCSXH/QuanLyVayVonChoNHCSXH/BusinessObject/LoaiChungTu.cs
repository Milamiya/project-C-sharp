using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class LoaiChungTu
    {
       public LoaiChungTu() { }

       public LoaiChungTu(String maloaichungtu)
       {
           m_MaLoaiChungTu = maloaichungtu;
       }
       public LoaiChungTu(String maloaichungtu, String tenloaichungtu)
       {
           m_MaLoaiChungTu = maloaichungtu;
           m_TenLoaiChungTu = tenloaichungtu;
       }

       private String m_MaLoaiChungTu;

       public String maloaichungtu
       {
           get { return m_MaLoaiChungTu; }
           set { m_MaLoaiChungTu = value; }
       }

       private String m_TenLoaiChungTu;
       public String tenloaichungtu
       {
           get { return m_TenLoaiChungTu; }
           set { m_TenLoaiChungTu = value; }
       }
    }
}

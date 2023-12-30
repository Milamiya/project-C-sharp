using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class MucDichVay
    {
       public MucDichVay() { }

       public MucDichVay(String mamucdichvay)
       {
           m_MaMucDichVay = mamucdichvay;
       }
       public MucDichVay(String mamucdichvay, String tenmucdichvay)
       {
           m_MaMucDichVay = mamucdichvay;
           m_TenMucDichVay = tenmucdichvay;
       }

       private String m_MaMucDichVay;

       public String mamucdichvay
       {
           get { return m_MaMucDichVay; }
           set { m_MaMucDichVay = value; }
       }

       private String m_TenMucDichVay;
       public String tenmucdichvay
       {
           get { return m_TenMucDichVay; }
           set { m_TenMucDichVay = value; }
       }
    }
}

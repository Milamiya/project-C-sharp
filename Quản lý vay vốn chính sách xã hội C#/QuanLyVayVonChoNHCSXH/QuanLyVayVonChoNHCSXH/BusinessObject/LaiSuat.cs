using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class LaiSuat
    {
       public LaiSuat() { }

       public LaiSuat(String malaisuat)
       {
           m_MaLaiSuat = malaisuat;
       }
       public LaiSuat(String malaisuat, float laisuat)
       {
           m_MaLaiSuat = malaisuat;
           m_LaiSuat = laisuat;
       }

       private String m_MaLaiSuat;

       public String MALAISUAT
       {
           get { return m_MaLaiSuat; }
           set { m_MaLaiSuat = value; }
       }

       private float m_LaiSuat;
       public float LAISUAT
       {
           get { return m_LaiSuat; }
           set { m_LaiSuat = value; }
       }

       private float m_LSQuaHan;
       public float LSQUAHAN
       {
           get { return m_LSQuaHan; }
           set { m_LSQuaHan = value; }
       }

       private String m_LSTren;
       public String LSTREN
       {
           get { return m_LSTren; }
           set { m_LSTren = value; }
       }

       private String m_TenLoaiLS;
       public String TENLOAILS
       {
           get { return m_TenLoaiLS; }
           set { m_TenLoaiLS = value; }
       }


    }
}

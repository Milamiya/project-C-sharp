using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
   public class DangNhap
    {
       public DangNhap() { }

       public DangNhap(String username)
       {
           m_Username = username;
       }
      
       private String m_Username;

       public String USERNAME
       {
           get { return m_Username; }
           set { m_Username = value; }
       }

       private String m_Password;
       public String PASSWORD
       {
           get { return m_Password; }
           set { m_Password = value; }
       }

       private String m_MaNV;
       public String MANV
       {
           get { return m_MaNV; }
           set { m_MaNV = value; }
       }
    }
}

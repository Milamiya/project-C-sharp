using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    class PhongBanInfo
    {
        public PhongBanInfo()
        {
 
        }

        //Ma phong
        private String m_MaPhong;
        public String MaPhong
        {
            get 
            {
                return m_MaPhong;
            }
            set
            {
                m_MaPhong = value;
            }
        }

        //Ten phong
        private String m_TenPhong;
        public String TenPhong
        {
            get
            {
                return m_TenPhong;
            }
            set
            {
                m_TenPhong = value;
            }
        }


    }
}




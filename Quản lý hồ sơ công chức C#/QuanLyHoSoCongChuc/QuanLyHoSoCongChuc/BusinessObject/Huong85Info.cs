using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class Huong85Info
    {
        public Huong85Info()
        {
        }
        private String m_MaHuong;
        public String MaHuong
        {
            get { return m_MaHuong; }
            set { m_MaHuong = value; }
        }

        private String m_GiatriHuong;
        public String GiatriHuong
        {
            get { return m_GiatriHuong; }
            set { m_GiatriHuong = value; }
        }

    }
}

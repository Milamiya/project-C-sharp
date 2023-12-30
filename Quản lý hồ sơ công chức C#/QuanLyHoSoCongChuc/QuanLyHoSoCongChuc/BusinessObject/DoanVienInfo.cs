using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class DoanVienInfo
    {
        public DoanVienInfo()
        {
        }
        private String m_Ma;
        public String Ma
        {
            get { return m_Ma; }
            set { m_Ma = value; }
        }

        private String m_GiaTri;
        public String GiaTri
        {
            get { return m_GiaTri; }
            set { m_GiaTri = value; }
        }
    }
}


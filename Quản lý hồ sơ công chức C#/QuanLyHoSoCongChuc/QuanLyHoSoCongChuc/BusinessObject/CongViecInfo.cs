using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class CongViecInfo
    {
        public CongViecInfo()
        { 
        }
        private String m_MaCongViec;
        public String MaCongViec
        {
            get { return m_MaCongViec; }
            set { m_MaCongViec = value; }
        }

        private String m_TenCongViec;
        public String TenCongViec
        {
            get { return m_TenCongViec; }
            set { m_TenCongViec = value; }
        }
    }
}

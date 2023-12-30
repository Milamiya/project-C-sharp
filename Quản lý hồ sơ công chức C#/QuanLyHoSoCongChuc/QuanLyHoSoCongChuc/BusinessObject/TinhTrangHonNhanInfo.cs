using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class TinhTrangHonNhanInfo
    {
        public TinhTrangHonNhanInfo()
        {
        }
        private String m_MaTinhTrangHonNhan;
        public String MaTinhTrangHonNhan
        {
            get { return m_MaTinhTrangHonNhan; }
            set { m_MaTinhTrangHonNhan = value; }
        }

        private String m_TenTinhTrangHonNhan;
        public String TenTinhTrangHonNhan
        {
            get { return m_TenTinhTrangHonNhan; }
            set { m_TenTinhTrangHonNhan = value; }
        }
    }
}


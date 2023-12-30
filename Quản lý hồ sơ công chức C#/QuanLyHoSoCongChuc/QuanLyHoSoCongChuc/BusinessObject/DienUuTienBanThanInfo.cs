using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class DienUuTienBanThanInfo
    {
        public DienUuTienBanThanInfo()
        {
        }
        private String m_MaDienUuTienBanThan;
        public String MaDienUuTienBanThan
        {
            get { return m_MaDienUuTienBanThan; }
            set { m_MaDienUuTienBanThan = value; }
        }

        private String m_TenDienUuTienBanThan;
        public String TenDienUuTienBanThan
        {
            get { return m_TenDienUuTienBanThan; }
            set { m_TenDienUuTienBanThan = value; }
        }
    }
}

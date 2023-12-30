using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class ThanhPhanXuatThanInfo
    {
        public ThanhPhanXuatThanInfo()
        {
        }
        private String m_MaThanhPhanXuatThan;
        public String MaThanhPhanXuatThan
        {
            get { return m_MaThanhPhanXuatThan; }
            set { m_MaThanhPhanXuatThan = value; }
        }

        private String m_TenThanhPhanXuatThan;
        public String TenThanhPhanXuatThan
        {
            get { return m_TenThanhPhanXuatThan; }
            set { m_TenThanhPhanXuatThan = value; }
        }
    }
}


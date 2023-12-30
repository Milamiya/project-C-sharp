using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class GioiTinhInfo
    {
        public GioiTinhInfo()
        {
        }
        private String m_MaGioiTinh;
        public String MaGioiTinh
        {
            get { return m_MaGioiTinh; }
            set { m_MaGioiTinh = value; }
        }

        private String m_TenGioiTinh;
        public String TenGioiTinh
        {
            get { return m_TenGioiTinh; }
            set { m_TenGioiTinh = value; }
        }
    }
}

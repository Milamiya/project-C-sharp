using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class ChucVuInfo
    {
        public ChucVuInfo()
        {
        }
        private String m_MaChucVu;
        public String MaChucVu
        {
            get { return m_MaChucVu; }
            set { m_MaChucVu = value; }
        }

        private String m_TenChucVu;
        public String TenChucVu
        {
            get { return m_TenChucVu; }
            set { m_TenChucVu = value; }
        }
    }
}

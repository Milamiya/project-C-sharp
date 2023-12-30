using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class DienUuTienGiaDinhInfo
    {
        public DienUuTienGiaDinhInfo()
        {
        }
        private String m_MaDienUuTienGiaDinh;
        public String MaDienUuTienGiaDinh
        {
            get { return m_MaDienUuTienGiaDinh; }
            set { m_MaDienUuTienGiaDinh = value; }
        }

        private String m_TenDienUuTienGiaDinh;
        public String TenDienUuTienGiaDinh
        {
            get { return m_TenDienUuTienGiaDinh; }
            set { m_TenDienUuTienGiaDinh = value; }
        }
    }
}

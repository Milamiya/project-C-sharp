using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class PhongBanInfo
    {
        public PhongBanInfo() { }
        public PhongBanInfo(string loai, string tenloai)
        {
            m_MaPHONG = loai;
            m_TenPHONG = tenloai;
        }

        private string m_MaPHONG;

        public string MaPHONG
        {
            get { return m_MaPHONG; }
            set { m_MaPHONG = value; }
        }

        private string  m_TenPHONG;

        public string  TenPHONG
        {
            get { return m_TenPHONGCHA; }
            set { m_TenPHONGCHA = value; }
        }

        private string m_TenPHONGCHA;

        public string TenPHONGCHA
        {
            get { return m_TenPHONGCHA; }
            set { m_TenPHONGCHA = value; }
        }
    }
}

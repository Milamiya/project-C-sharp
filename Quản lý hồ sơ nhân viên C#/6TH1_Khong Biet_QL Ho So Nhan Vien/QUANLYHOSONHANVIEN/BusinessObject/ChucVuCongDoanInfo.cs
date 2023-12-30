using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class ChucVuCongDoanInfo
    {
        public ChucVuCongDoanInfo() { }
        public ChucVuCongDoanInfo(string loai, string tenloai)
        {
            m_MaCVCONGDOAN = loai;
            m_TenCVCONGDOAN = tenloai;
        }

        private string m_MaCVCONGDOAN;

        public string MaCVCONGDOAN
        {
            get { return m_MaCVCONGDOAN; }
            set { m_MaCVCONGDOAN = value; }
        }

        private string m_TenCVCONGDOAN;

        public string  TenCVCONGDOAN
        {
            get { return m_TenCVCONGDOAN; }
            set { m_TenCVCONGDOAN = value; }
        }
    }
}

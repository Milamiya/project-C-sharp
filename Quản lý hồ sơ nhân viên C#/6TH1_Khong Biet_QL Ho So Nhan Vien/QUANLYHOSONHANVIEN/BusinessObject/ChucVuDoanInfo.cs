using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class ChucVuDoanInfo
    {
        public ChucVuDoanInfo() { }
        public ChucVuDoanInfo(string loai, string tenloai)
        {
            m_MaCVDOAN = loai;
            m_TenCVDOAN = tenloai;
        }

        private string m_MaCVDOAN;

        public string MaCVDOAN
        {
            get { return m_MaCVDOAN; }
            set { m_MaCVDOAN = value; }
        }

        private string  m_TenCVDOAN;

        public string  TenCVDOAN
        {
            get { return m_TenCVDOAN; }
            set { m_TenCVDOAN = value; }
        }
    }
}

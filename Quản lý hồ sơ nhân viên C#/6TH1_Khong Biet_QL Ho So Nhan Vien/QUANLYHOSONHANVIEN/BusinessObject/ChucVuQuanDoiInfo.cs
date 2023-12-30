using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class ChucVuQuanDoiInfo
    {
        public ChucVuQuanDoiInfo() { }
        public ChucVuQuanDoiInfo(string loai, string tenloai)
        {
            m_MaCVQUANDOI = loai;
            m_TenCVQUANDOI = tenloai;
        }

        private string m_MaCVQUANDOI;

        public string MaCVQUANDOI
        {
            get { return m_MaCVQUANDOI; }
            set { m_MaCVQUANDOI = value; }
        }

        private string  m_TenCVQUANDOI;

        public string  TenCVQUANDOI
        {
            get { return m_TenCVQUANDOI; }
            set { m_TenCVQUANDOI = value; }
        }
    }
}

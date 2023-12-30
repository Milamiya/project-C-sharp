using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class ChucVuDangInfo
    {
        public ChucVuDangInfo() { }
        public ChucVuDangInfo(string loai, string tenloai)
        {
            m_MaCVDANG = loai;
            m_TenCVDANG = tenloai;
        }

        private string m_MaCVDANG;

        public string MaCVDANG
        {
            get { return m_MaCVDANG; }
            set { m_MaCVDANG = value; }
        }

        private string  m_TenCVDANG;

        public string  TenDT
        {
            get { return m_TenCVDANG; }
            set { m_TenCVDANG = value; }
        }
    }
}

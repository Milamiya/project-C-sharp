using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class ChucVuInfo
    {
        public ChucVuInfo() { }
        public ChucVuInfo(string loai, string tenloai)
        {
            m_MaCV = loai;
            m_TenCV = tenloai;
        }

        private string m_MaCV;

        public string MaCV
        {
            get { return m_MaCV; }
            set { m_MaCV = value; }
        }

        private string  m_TenCV;

        public string  TenCV
        {
            get { return m_TenCV; }
            set { m_TenCV = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class DanTocInfo
    {
        public DanTocInfo() { }
        public DanTocInfo(string loai, string tenloai)
        {
            m_MaDT = loai;
            m_TenDT = tenloai;
        }

        private string m_MaDT;

        public string MaDT
        {
            get { return m_MaDT; }
            set { m_MaDT = value; }
        }

        private string  m_TenDT;

        public string  TenDT
        {
            get { return m_TenDT; }
            set { m_TenDT = value; }
        }
    }
}

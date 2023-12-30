using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QUANLYHOSONHANVIEN.BusinessObject
{
    public class TonGiaoInfo
    {
        public TonGiaoInfo() { }
        public TonGiaoInfo(string loai, string tenloai)
        {
            m_MaTG = loai;
            m_TenTG = tenloai;
        }

        private string m_MaTG;

        public string MaTG
        {
            get { return m_MaTG; }
            set { m_MaTG = value; }
        }

        private string  m_TenTG;

        public string  TenTG
        {
            get { return m_TenTG; }
            set { m_TenTG = value; }
        }
    }
}

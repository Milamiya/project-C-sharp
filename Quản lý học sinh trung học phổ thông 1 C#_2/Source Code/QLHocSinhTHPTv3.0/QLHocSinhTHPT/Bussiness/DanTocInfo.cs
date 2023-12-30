using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class DanTocInfo
    {
        public DanTocInfo()
        {

        }

        private String m_MaDanToc;
        public String MaDanToc
        {
            get { return m_MaDanToc; }
            set { m_MaDanToc = value; }
        }

        private String m_TenDanToc;
        public String TenDanToc
        {
            get { return m_TenDanToc; }
            set { m_TenDanToc = value; }
        }
    }
}

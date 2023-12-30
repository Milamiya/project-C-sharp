using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class QuanHeInfo
    {
        public QuanHeInfo()
        {
        }
        private String m_MaQuanHe;
        public String MaQuanHe
        {
            get { return m_MaQuanHe; }
            set { m_MaQuanHe = value; }
        }

        private String m_TenQuanHe;
        public String TenQuanHe
        {
            get { return m_TenQuanHe; }
            set { m_TenQuanHe = value; }
        }
    }
}

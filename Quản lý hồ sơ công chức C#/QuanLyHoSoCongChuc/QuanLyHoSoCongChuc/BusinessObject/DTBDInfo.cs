using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class DTBDInfo
    {
        public DTBDInfo()
        {

        }
        private String m_MaDTBD;
        public String MaDTBD
        {
            get { return m_MaDTBD; }
            set { m_MaDTBD = value; }
        }

        private String m_GiaTriDTBD;
        public String GiaTriDTBD
        {
            get { return m_GiaTriDTBD; }
            set { m_GiaTriDTBD = value; }
        }
    }
}

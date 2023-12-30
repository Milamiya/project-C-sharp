using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class TrinhDoChuyenMonInfo
    {
        public TrinhDoChuyenMonInfo()
        {
        }
        private String m_MaTrinhDoChuyenMon;
        public String MaTrinhDoChuyenMon
        {
            get { return m_MaTrinhDoChuyenMon; }
            set { m_MaTrinhDoChuyenMon = value; }
        }

        private String m_TenTrinhDoChuyenMon;
        public String TenTrinhDoChuyenMon
        {
            get { return m_TenTrinhDoChuyenMon; }
            set { m_TenTrinhDoChuyenMon = value; }
        }
    }
}

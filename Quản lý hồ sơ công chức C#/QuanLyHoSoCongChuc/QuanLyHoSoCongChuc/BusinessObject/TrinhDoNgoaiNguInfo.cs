using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class TrinhDoNgoaiNguInfo
    {
        public TrinhDoNgoaiNguInfo()
        {
        }
        private String m_MaTrinhDoNgoaiNgu;
        public String MaTrinhDoNgoaiNgu
        {
            get { return m_MaTrinhDoNgoaiNgu; }
            set { m_MaTrinhDoNgoaiNgu = value; }
        }

        private String m_TenTrinhDoNgoaiNgu;
        public String TenTrinhDoNgoaiNgu
        {
            get { return m_TenTrinhDoNgoaiNgu; }
            set { m_TenTrinhDoNgoaiNgu = value; }
        }
    }
}

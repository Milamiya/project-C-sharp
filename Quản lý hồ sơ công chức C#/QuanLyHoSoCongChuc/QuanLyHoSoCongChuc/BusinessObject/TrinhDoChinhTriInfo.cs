using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class TrinhDoChinhTriInfo
    {
        public TrinhDoChinhTriInfo()
        {
        }
        private String m_MaTrinhDoChinhTri;
        public String MaTrinhDoChinhTri
        {
            get { return m_MaTrinhDoChinhTri; }
            set { m_MaTrinhDoChinhTri = value; }
        }

        private String m_TenTrinhDoChinhTri;
        public String TenTrinhDoChinhTri
        {
            get { return m_TenTrinhDoChinhTri; }
            set { m_TenTrinhDoChinhTri = value; }
        }
    }
}


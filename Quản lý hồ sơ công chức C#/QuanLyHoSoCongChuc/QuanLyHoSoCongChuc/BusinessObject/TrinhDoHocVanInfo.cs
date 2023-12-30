using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class TrinhDoHocVanInfo
    {
        public TrinhDoHocVanInfo()
        {
        }
        private String m_MaTrinhDoHocVan;
        public String MaTrinhDoHocVan
        {
            get { return m_MaTrinhDoHocVan; }
            set { m_MaTrinhDoHocVan = value; }
        }

        private String m_TenTrinhDoHocVan;
        public String TenTrinhDoHocVan
        {
            get { return m_TenTrinhDoHocVan; }
            set { m_TenTrinhDoHocVan = value; }
        }
    }
}

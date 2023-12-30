using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class TrinhDoTinHocInfo
    {
        public TrinhDoTinHocInfo()
        {
        }
        private String m_MaTrinhDoTinHoc;
        public String MaTrinhDoTinHoc
        {
            get { return m_MaTrinhDoTinHoc; }
            set { m_MaTrinhDoTinHoc = value; }
        }

        private String m_TenTrinhDoTinHoc;
        public String TenTrinhDoTinHoc
        {
            get { return m_TenTrinhDoTinHoc; }
            set { m_TenTrinhDoTinHoc = value; }
        }
    }
}

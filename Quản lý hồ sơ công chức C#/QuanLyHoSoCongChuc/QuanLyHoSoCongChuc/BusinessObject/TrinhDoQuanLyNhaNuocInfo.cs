using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class TTrinhDoQuanLyNhaNuocInfo
    {
        public TTrinhDoQuanLyNhaNuocInfo()
        {
        }
        private String m_MaTTrinhDoQuanLyNhaNuoc;
        public String MaTTrinhDoQuanLyNhaNuoc
        {
            get { return m_MaTTrinhDoQuanLyNhaNuoc; }
            set { m_MaTTrinhDoQuanLyNhaNuoc = value; }
        }

        private String m_TenTTrinhDoQuanLyNhaNuoc;
        public String TenTTrinhDoQuanLyNhaNuoc
        {
            get { return m_TenTTrinhDoQuanLyNhaNuoc; }
            set { m_TenTTrinhDoQuanLyNhaNuoc = value; }
        }
    }
}

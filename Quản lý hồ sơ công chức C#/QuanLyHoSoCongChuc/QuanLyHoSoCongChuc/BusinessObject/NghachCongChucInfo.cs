using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class NghachCongChucInfo
    {
        public NghachCongChucInfo()
        {
        }
        private String m_MaNghachCongChuc;
        public String MaNghachCongChuc
        {
            get { return m_MaNghachCongChuc; }
            set { m_MaNghachCongChuc = value; }
        }

        private String m_TenNghachCongChuc;
        public String TenNghachCongChuc
        {
            get { return m_TenNghachCongChuc; }
            set { m_TenNghachCongChuc = value; }
        }
    }
}

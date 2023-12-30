using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class LoaiCanBoInfo
    {
        public LoaiCanBoInfo()
        { 
        }
        private String m_MaLoaiCanBo;
        public String MaLoaiCanBo
        {
            get { return m_MaLoaiCanBo; }
            set { m_MaLoaiCanBo = value; }
        }

        private String m_TenLoaiCanBo;
        public String TenLoaiCanBo
        {
            get { return m_TenLoaiCanBo; }
            set { m_TenLoaiCanBo = value; }
        }
    }
}

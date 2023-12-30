using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class LoaiDonViInfo
    {
        public LoaiDonViInfo()
        { 
        }
        private String m_MaLoaiDonVi;
        public String MaLoaiDonVi
        {
            get { return m_MaLoaiDonVi; }
            set { m_MaLoaiDonVi = value; } 
        }
        private String m_TenLoaiDonVi;
        public String TenLoaiDonVi
        {
            get { return m_TenLoaiDonVi; }
            set { m_TenLoaiDonVi = value; }
        }
    }
}

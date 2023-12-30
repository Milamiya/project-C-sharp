using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class DonViInfo
    {
        public DonViInfo( )
        {                
        }
        //Ma DonVi
        private String m_MaDonVi;
        public String MaDonVi
        {
            get  { return m_MaDonVi; }
            set  { m_MaDonVi = value; }
        }
        private String m_MaLoaiDonVi;
        public String MaLoaiDonVi
        {
            get { return m_MaLoaiDonVi; }
            set { m_MaLoaiDonVi = value; }
        }
        //Ten DonVi
        private String m_TenDonVi;
        public String TenDonVi
        {
            get { return m_TenDonVi; }
            set { m_TenDonVi = value; }
        }

    }
}




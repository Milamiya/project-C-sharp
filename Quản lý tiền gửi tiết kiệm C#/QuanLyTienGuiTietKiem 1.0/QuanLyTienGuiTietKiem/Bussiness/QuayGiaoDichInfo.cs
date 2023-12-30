using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class QuayGiaoDichInfo
    {
        public QuayGiaoDichInfo()
        {
        }

        private PhongGiaoDichInfo m_MaPhongGD;
        public PhongGiaoDichInfo MaPhongGD
        {
            get { return m_MaPhongGD; }
            set { m_MaPhongGD = value; }
        }

        private String m_MaQuayGD;
        public String MaQuayGD
        {
            get { return m_MaQuayGD; }
            set { m_MaQuayGD = value; }
        }

        
    }
}

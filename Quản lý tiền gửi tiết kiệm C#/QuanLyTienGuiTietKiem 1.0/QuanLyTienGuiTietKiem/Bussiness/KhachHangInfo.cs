using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class KhachHangInfo
    {
        public KhachHangInfo()
        {
        }

        private String m_MaKH;
        public String MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private String m_CMND;
        public String CMND
        {
            get { return m_CMND; }
            set { m_CMND = value; }
        }

        private DateTime m_NgayCap;
        public DateTime NgayCap
        {
            get { return m_NgayCap; }
            set { m_NgayCap = value; }
        }

        private String m_NoiCap;
        public String NoiCap
        {
            get { return m_NoiCap; }
            set { m_NoiCap = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_DienThoai;
        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }

      
    }
}

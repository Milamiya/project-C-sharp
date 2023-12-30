using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class PhongGiaoDichInfo
    {
        public PhongGiaoDichInfo()
        {
        }

        private String m_MaPhongGD;
        public String MaPhongGD
        {
            get { return m_MaPhongGD; }
            set { m_MaPhongGD = value; }
        }

        private String m_TenPhongGD;
        public String TenPhongGD
        {
            get { return m_TenPhongGD; }
            set { m_TenPhongGD = value; }
        }

        private String m_DiaDiem;
        public String DiaDiem
        {
            get { return m_DiaDiem; }
            set { m_DiaDiem = value; }
        }
        private String m_DienThoai;
        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }
    }
}

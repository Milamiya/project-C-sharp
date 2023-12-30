using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class LaiSuatTietKiemInfo
    {
        public LaiSuatTietKiemInfo()
        {
        }
   
        private String m_MaLoaiTietKiem;
        public String MaLoaiTietKiem
        {
            get { return m_MaLoaiTietKiem; }
            set { m_MaLoaiTietKiem = value; }
        }

        private DateTime m_Ngay;
        public DateTime Ngay
        {
            get { return m_Ngay; }
            set { m_Ngay = value; }
        }

        private float m_MucLaiSuat;
        public float MucLaiSuat
        {
            get { return m_MucLaiSuat; }
            set { m_MucLaiSuat = value; }
        }
    }
}

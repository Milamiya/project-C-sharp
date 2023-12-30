using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class DMLoaiTienInfo
    {
        public DMLoaiTienInfo()
        {
        }

        private String m_MaLoaiTien;
        public String MaLoaiTien
        {
            get { return m_MaLoaiTien; }
            set { m_MaLoaiTien = value; }
        }

        private String m_LoaiTien;
        public String LoaiTien
        {
            get { return m_LoaiTien; }
            set { m_LoaiTien = value; }
        }

        private int m_SoLuong;
        public int SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        }
        
    }
}

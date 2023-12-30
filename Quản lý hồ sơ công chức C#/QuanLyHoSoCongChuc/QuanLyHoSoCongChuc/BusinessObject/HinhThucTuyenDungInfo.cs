using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class HinhThucTuyenDungInfo
    {
        public HinhThucTuyenDungInfo()
        {
        }
        private String m_MaHinhThucTuyenDung;
        public String MaHinhThucTuyenDung
        {
            get { return m_MaHinhThucTuyenDung; }
            set { m_MaHinhThucTuyenDung = value; }
        }

        private String m_TenHinhThucTuyenDung;
        public String TenHinhThucTuyenDung
        {
            get { return m_TenHinhThucTuyenDung; }
            set { m_TenHinhThucTuyenDung = value; }
        }
    }
}


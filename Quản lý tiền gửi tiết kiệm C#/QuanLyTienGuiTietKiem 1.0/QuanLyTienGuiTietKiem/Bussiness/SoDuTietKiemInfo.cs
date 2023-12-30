using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class SoDuTietKiemInfo
    {
        public SoDuTietKiemInfo()
        {
        }

        private LoaiTietKiemInfo m_MaLoaiTietKiem;
        public LoaiTietKiemInfo MaLoaiTietKiem
        {
            get { return m_MaLoaiTietKiem; }
            set { m_MaLoaiTietKiem = value; }
        }

        private SoTietKiemInfo m_MaSoTietKiem;
        public SoTietKiemInfo MaSoTietKiem
        {
            get { return m_MaSoTietKiem; }
            set { m_MaSoTietKiem = value; }
        }

        private DateTime m_NgayCapNhat;
        public DateTime NgayCapNhat
        {
            get { return m_NgayCapNhat; }
            set { m_NgayCapNhat = value; }
        }

        private float m_SoDu;
        public float SoDu
        {
            get { return m_SoDu; }
            set { m_SoDu = value; }
        }
     
        
    }
}

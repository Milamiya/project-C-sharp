using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class InPhieuLuuTienGuiInfo
    {
        public InPhieuLuuTienGuiInfo()
        {
        }

        private KhachHangInfo m_KhachHang;
        public KhachHangInfo KhachHang
        {
            get { return m_KhachHang; }
            set { m_KhachHang = value; }
        }

        private SoTietKiemInfo m_SoTietKiem;
        public SoTietKiemInfo SoTietKiem
        {
            get { return m_SoTietKiem; }
            set { m_SoTietKiem = value; }
        }

        private LoaiTietKiemInfo m_LoaiTietKiem;
        public LoaiTietKiemInfo LoaiTietKiem
        {
            get { return m_LoaiTietKiem; }
            set { m_LoaiTietKiem = value; }
        }

        private LaiSuatTietKiemInfo m_LaiSuatTietKiem;
        public LaiSuatTietKiemInfo LaiSuatTietKiem
        {
            get { return m_LaiSuatTietKiem; }
            set { m_LaiSuatTietKiem = value; }
        }

        private SoDuTietKiemInfo m_SoDuTietKiem;
        public SoDuTietKiemInfo SoDuTietKiem
        {
            get { return m_SoDuTietKiem; }
            set { m_SoDuTietKiem = value; }
        }

        private ChiTietPhatSinhGDInfo m_ChiTietPhatSinhGD;
        public ChiTietPhatSinhGDInfo ChiTietPhatSinhGD
        {
            get { return m_ChiTietPhatSinhGD; }
            set { m_ChiTietPhatSinhGD = value; }
        }

        private DMLoaiTienInfo m_DMLoaiTien;
        public DMLoaiTienInfo DMLoaiTien
        {
            get { return m_DMLoaiTien; }
            set { m_DMLoaiTien = value; }
        }
       
    }
}

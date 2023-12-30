using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class MoSoTietKiemInfo
    {
        public MoSoTietKiemInfo()
        {
        }

        private SoTietKiemInfo m_MaSoietKiem;
        public SoTietKiemInfo MaSoTietKiem
        {
            get { return m_MaSoietKiem; }
            set { m_MaSoietKiem = value; }
        }

        private SoTietKiemInfo m_NgayHieuLuc;
        public SoTietKiemInfo NgayHieuLuc
        {
            get { return m_NgayHieuLuc; }
            set { m_NgayHieuLuc = value; }
        }

        private SoTietKiemInfo m_NgayDenHan;
        public SoTietKiemInfo NgayDenHan
        {
            get { return m_NgayDenHan; }
            set { m_NgayDenHan = value; }
        }

        private KhachHangInfo m_MaKhachHang;
        public KhachHangInfo MaKhachHang
        {
            get { return m_MaKhachHang; }
            set { m_MaKhachHang = value; }
        }

        private LoaiTietKiemInfo m_LoaiTietKiem;
        public LoaiTietKiemInfo LoaiTietKiem
        {
            get { return m_LoaiTietKiem; }
            set { m_LoaiTietKiem = value; }
        }

        private LaiSuatTietKiemInfo m_LaiSuat;
        public LaiSuatTietKiemInfo LaiSuat
        {
            get { return m_LaiSuat; }
            set { m_LaiSuat = value; }
        }

        private DMLoaiTienInfo m_LoaiTien;
        public DMLoaiTienInfo LoaiTien
        {
            get { return m_LoaiTien; }
            set { m_LoaiTien = value; }
        }

        private float m_SoTienGui;
        public float SoTienGui
        {
            get { return m_SoTienGui; }
            set { m_SoTienGui = value; }
        }
    }
    
}

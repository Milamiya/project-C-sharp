using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class InSoTietKiemInfo
    {
        public InSoTietKiemInfo()
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

        private DMTaiKhoanInfo m_DMTaiKhoan;
        public DMTaiKhoanInfo DMTaiKhoan
        {
            get { return m_DMTaiKhoan; }
            set { m_DMTaiKhoan = value; }
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

        private PhanQuyenInfo m_PhanQuyen;
        public PhanQuyenInfo PhanQuyen
        {
            get { return m_PhanQuyen; }
            set { m_PhanQuyen = value; }
        }
    }
}

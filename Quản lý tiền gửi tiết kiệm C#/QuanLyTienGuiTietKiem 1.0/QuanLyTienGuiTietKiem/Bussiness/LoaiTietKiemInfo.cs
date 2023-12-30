using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class LoaiTietKiemInfo
    {
        public LoaiTietKiemInfo()
        {
        }
    
        private String m_MaLoaiTietKiem;
        public String MaLoaiTietKiem
        {
            get { return m_MaLoaiTietKiem; }
            set { m_MaLoaiTietKiem = value; }
        }

        private String m_TenLoaiTietKiem;
        public String TenLoaiTietKiem
        {
            get { return m_TenLoaiTietKiem; }
            set { m_TenLoaiTietKiem = value; }
        }

        private int m_KyHan;
        public int KyHan
        {
            get { return m_KyHan; }
            set { m_KyHan = value; }
        }

        private bool m_DangHuuDong;
        public bool DangHuuDong
        {
            get { return m_DangHuuDong; }
            set { m_DangHuuDong = value; }
        }

        private DMLoaiTienInfo m_MaLoaiTien;
        public DMLoaiTienInfo MaLoaiTien
        {
            get { return m_MaLoaiTien; }
            set { m_MaLoaiTien = value; }
        }

        private DMKyLaiTKInfo m_MaKyTinhLai;
        public DMKyLaiTKInfo MaKyTinhLai
        {
            get { return m_MaKyTinhLai; }
            set { m_MaKyTinhLai = value; }
        }

        private DMTaiKhoanInfo m_SoHieuTaiKhoan;
        public DMTaiKhoanInfo SoHieuTaiKhoan
        {
            get { return m_SoHieuTaiKhoan; }
            set { m_SoHieuTaiKhoan = value; }
        }
    }
}

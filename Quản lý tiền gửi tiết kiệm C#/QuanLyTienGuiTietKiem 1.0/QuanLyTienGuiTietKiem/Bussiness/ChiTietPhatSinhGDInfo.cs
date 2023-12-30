using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class ChiTietPhatSinhGDInfo
    {
        public ChiTietPhatSinhGDInfo ()
        {
        }
        private String m_SoGiaoDich;
        public String SoGiaoDich
        {
            get { return m_SoGiaoDich; }
            set { m_SoGiaoDich = value; }
        }

        private PhatSinhTietKiemInfo m_SoButToan;
        public PhatSinhTietKiemInfo SoButToan
        {
            get { return m_SoButToan; }
            set { m_SoButToan = value; }
        }

        private PhatSinhTietKiemInfo m_NgayGiaoDich;
        public PhatSinhTietKiemInfo NgayGiaoDich
        {
            get { return m_NgayGiaoDich;}
            set { m_NgayGiaoDich = value; }
        }

        private DMTaiKhoanInfo m_SoHieuTaiKhoanNo;
        public DMTaiKhoanInfo SoHieuTaiKhoanNo
        {
            get { return m_SoHieuTaiKhoanNo; }
            set { m_SoHieuTaiKhoanNo = value; }
        }

        private DMTaiKhoanInfo m_SoHieuTaiKhoanCo;
        public DMTaiKhoanInfo SoHieuTaiKhoanCo
        {
            get { return m_SoHieuTaiKhoanCo; }
            set { m_SoHieuTaiKhoanCo = value; }
        }

        private float m_SoTien;
        public float SoTien
        {
            get { return m_SoTien; }
            set { m_SoTien = value; }
        }

    }
}

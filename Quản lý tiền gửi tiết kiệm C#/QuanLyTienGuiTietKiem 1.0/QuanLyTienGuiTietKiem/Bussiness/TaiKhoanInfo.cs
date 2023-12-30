using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class TaiKhoanInfo
    {
        public TaiKhoanInfo()
        {
        }
        private DateTime m_NgayCapNhat;
        public DateTime NgayCapNhat
        {
            get { return m_NgayCapNhat; }
            set { m_NgayCapNhat = value; }
        }

        private float m_SoDuDauNgay;
        public float SoDuDauNgay
        {
            get { return m_SoDuDauNgay; }
            set { m_SoDuDauNgay = value; }
        }

        private float m_SoPhatSinhNo;
        public float SoPhatSinhNo
        {
            get { return m_SoPhatSinhNo; }
            set { m_SoPhatSinhNo = value; }
        }

        private float m_SoPhatSinhCo;
        public float SoPhatSinhCo
        {
            get { return m_SoPhatSinhCo; }
            set { m_SoPhatSinhCo = value; }
        }

        private DMTaiKhoanInfo m_SoHieuTaiKhoan;
        public DMTaiKhoanInfo SoHieuTaiKhoan
        {
            get { return m_SoHieuTaiKhoan; }
            set { m_SoHieuTaiKhoan = value; }
        }
    }
}

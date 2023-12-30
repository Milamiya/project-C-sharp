using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class NguoiDungInfo
    {
        private String m_MaNguoiDung;
        public String MaNguoiDung
        {
            get { return m_MaNguoiDung; }
            set { m_MaNguoiDung = value; }
        }

        private int m_MaQuyen;
        public int MaQuyen
        {
            get { return m_MaQuyen; }
            set { m_MaQuyen = value; }
        }
        private String m_TenDangNhap;
        public String TenDangNhap
        {
            get { return m_TenDangNhap; }
            set { m_TenDangNhap = value; }
        }

        private String m_TenNguoiDung;
        public String TenNguoiDung
        {
            get { return m_TenNguoiDung; }
            set { m_TenNguoiDung = value; }
        }

        private String m_MatKhau;
        public String MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
        public NguoiDungInfo(String MaNguoiDung, String TenNguoiDung, String TenDangNhap, String MatKhau, int MaQuyen)
        {
            m_MaNguoiDung = MaNguoiDung;
            m_TenNguoiDung = TenNguoiDung;
            m_TenDangNhap = TenDangNhap;
            m_MatKhau = MatKhau;
            m_MaQuyen = MaQuyen;


        }
        public NguoiDungInfo()
        { }




    }
}

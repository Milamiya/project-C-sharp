using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class PhanQuyenInfo
    {
        public PhanQuyenInfo()
        {
        }

        private QuyenInfo m_MaQuyen;
        public QuyenInfo MaQuyen
        {
            get { return m_MaQuyen; }
            set { m_MaQuyen = value; }
        }

        private NhomNguoiDungInfo m_MaNhomNguoiDung;
        public NhomNguoiDungInfo MaNhomNguoiDung
        {
            get { return m_MaNhomNguoiDung; }
            set { m_MaNhomNguoiDung = value; }
        }

        private NhanVienInfo m_MaNV;
        public NhanVienInfo MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private String m_TenDangNhap;
        public String TenDangNhap
        {
            get { return m_TenDangNhap; }
            set { m_TenDangNhap = value; }
        }

        private String m_MatKhau;
        public String MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
        
    }
}

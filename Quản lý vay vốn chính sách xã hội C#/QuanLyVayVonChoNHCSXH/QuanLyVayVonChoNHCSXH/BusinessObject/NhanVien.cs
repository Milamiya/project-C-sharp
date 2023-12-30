using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyVayVonChoNHCSXH.BusinessObject
{
    public class NhanVien
    {
        public NhanVien() { }

        private String m_MaNV;

        public String MANV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private String m_HoTenNV;

        public String HOTENNV
        {
            get { return m_HoTenNV; }
            set { m_HoTenNV = value; }
        }
        public NhanVien(String manhanvien, String tennv)
       {
           m_MaNV = manhanvien;
           m_HoTenNV = tennv;
       }

        private String m_DiaChi;

        public String DIACHI
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private DateTime m_NgaySinh;

        public DateTime NGAYSINH
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }
	
        private String m_MaPhongBan;

        public String MAPHONGBAN
        {
            get { return m_MaPhongBan; }
            set { m_MaPhongBan = value; }
        }

        private String m_MaChucVu;

        public String MACHUCVU
        {
            get { return m_MaChucVu; }
            set { m_MaChucVu = value; }
        }

        private String m_GhiChu;

        public String GHICHU
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        }
	

    }
}

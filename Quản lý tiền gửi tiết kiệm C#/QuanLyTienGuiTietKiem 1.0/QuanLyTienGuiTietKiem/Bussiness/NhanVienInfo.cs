using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class NhanVienInfo
    {
        public NhanVienInfo()
        {
        }

        private String m_MaNV;
        public String MaNV
        {
            get { return m_MaNV; }
            set { m_MaNV = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private PhongGiaoDichInfo m_MaPhongGD;
        public PhongGiaoDichInfo MaPhongGD
        {
            get { return m_MaPhongGD; }
            set { m_MaPhongGD = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }

        private String m_DienThoai;
        public String DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }

       
    }
}

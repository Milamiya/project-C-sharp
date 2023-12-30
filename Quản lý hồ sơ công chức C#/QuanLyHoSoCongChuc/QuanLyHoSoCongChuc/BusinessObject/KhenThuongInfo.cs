using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class KhenThuongInfo
    {
        
   
        public KhenThuongInfo()
        { 
        }
        private String m_MaKhenThuong;
        public String MaKhenThuong
        {
            get { return m_MaKhenThuong; }
            set { m_MaKhenThuong = value; }
        }

        private String m_MaNhanVien;
        public String MaNhanVien
        {
            get { return m_MaNhanVien; }
            set { m_MaNhanVien = value; }
        }

        private String m_LoaiKhenThuong;
        public String LoaiKhenThuong
        {
            get { return m_LoaiKhenThuong; }
            set { m_LoaiKhenThuong = value; }
        }

        private String m_HinhThucKhenThuong;
        public String HinhThucKhenThuong
        {
            get { return m_HinhThucKhenThuong; }
            set { m_HinhThucKhenThuong = value; }
        }

        

        private String m_CapKhenThuong;
        public String CapKhenThuong
        {
            get { return m_CapKhenThuong; }
            set { m_CapKhenThuong = value; }
        }
        private String m_Nam;
        public String Nam
        {
            get { return m_Nam; }
            set { m_Nam = value; }
        }
    }
}

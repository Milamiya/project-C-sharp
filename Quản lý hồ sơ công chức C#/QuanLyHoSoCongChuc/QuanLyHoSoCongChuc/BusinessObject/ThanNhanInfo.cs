using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class ThanNhanInfo
    {
        public ThanNhanInfo()
        {
        }
        private String m_MaThanNhan;
        public String MaThanNhan
        {
            get { return m_MaThanNhan; }
            set { m_MaThanNhan = value; }
        }

        private String m_MaNhanVien;
        public String MaNhanVien
        {
            get { return m_MaNhanVien; }
            set { m_MaNhanVien = value; }
        }

        private String m_MaQuanHe;
        public String MaQuanHe
        {
            get { return m_MaQuanHe; }
            set { m_MaQuanHe = value; }
        }        

        private String m_TenThanNhan;
        public String TenThanNhan
        {
            get { return m_TenThanNhan; }
            set { m_TenThanNhan = value; }
        }

        private DateTime m_NamSinh;
        public DateTime NamSinh
        {
            get { return m_NamSinh; }
            set { m_NamSinh = value; }
        }

        private String m_DiaChi;
        public String DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }


        private String m_NgheNghiep;
        public String NgheNghiep
        {
            get { return m_NgheNghiep; }
            set { m_NgheNghiep = value; }
        }

        private String m_NuocDinhCu;
        public String NuocDinhCu
        {
            get { return m_NuocDinhCu; }
            set { m_NuocDinhCu = value; }
        }

        private String m_QuocTich;
        public String QuocTich
        {
            get { return m_QuocTich; }
            set { m_QuocTich = value; }
        }

        private DateTime m_NamDinhCu;
        public DateTime NamDinhCu
        {
            get { return m_NamDinhCu; }
            set { m_NamDinhCu = value; }
        }




    }
}

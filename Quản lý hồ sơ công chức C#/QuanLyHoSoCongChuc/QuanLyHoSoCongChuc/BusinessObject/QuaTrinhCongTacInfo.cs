using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class QuaTrinhCongTacInfo
    {
        public QuaTrinhCongTacInfo()
        { 
        }
        private String m_MaQuaTrinhCongTac;
        public String MaQuaTrinhCongTac
        {
            get { return m_MaQuaTrinhCongTac; }
            set { m_MaQuaTrinhCongTac = value; }
        }

        private String m_MaNhanVien;
        public String MaNhanVien
        {
            get { return m_MaNhanVien; }
            set { m_MaNhanVien = value; }
        }

        private String m_TenQuaTrinhCongTac;
        public String TenQuaTrinhCongTac
        {
            get { return m_TenQuaTrinhCongTac; }
            set { m_TenQuaTrinhCongTac = value; }
        }

        private DateTime m_ThoiGianBatDauCongTac;
        public DateTime ThoiGianBatDauCongTac
        {
            get { return m_ThoiGianBatDauCongTac; }
            set { m_ThoiGianBatDauCongTac = value; }
        }

        private DateTime m_ThoiGianKetThucCongTac;
        public DateTime ThoiGianKetThucCongTac
        {
            get { return m_ThoiGianKetThucCongTac; }
            set { m_ThoiGianKetThucCongTac = value; }
        }

    }
}

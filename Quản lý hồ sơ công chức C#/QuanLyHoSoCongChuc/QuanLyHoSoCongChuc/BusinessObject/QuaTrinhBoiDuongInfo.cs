using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class QuaTrinhBoiDuongInfo
    {
        public QuaTrinhBoiDuongInfo()
        { 
        }
        private String m_MaQuaTrinhBoiDuong;
        public String MaQuaTrinhBoiDuong
        {
            get { return m_MaQuaTrinhBoiDuong; }
            set { m_MaQuaTrinhBoiDuong = value; }
        }

        private String m_MaNhanVien;
        public String MaNhanVien
        {
            get { return m_MaNhanVien; }
            set { m_MaNhanVien = value; }
        }

        private String m_TenQuaTrinhBoiDuong;
        public String TenQuaTrinhBoiDuong
        {
            get { return m_TenQuaTrinhBoiDuong; }
            set { m_TenQuaTrinhBoiDuong = value; }
        }

        private DateTime m_ThoiGianBoiDuong;
        public DateTime ThoiGianBoiDuong
        {
            get { return m_ThoiGianBoiDuong; }
            set { m_ThoiGianBoiDuong = value; }
        }

        private String m_NoiBoiDuong;
        public String NoiBoiDuong
        {
            get { return m_NoiBoiDuong; }
            set { m_NoiBoiDuong = value; }
        }

        private String m_LoaiHinhBoiDuong;
        public String LoaiHinhBoiDuong
        {
            get { return m_LoaiHinhBoiDuong; }
            set { m_LoaiHinhBoiDuong = value; }
        }
        private String m_ChungChi;
        public String ChungChi
        {
            get { return m_ChungChi; }
            set { m_ChungChi = value; }
        }
    }
}

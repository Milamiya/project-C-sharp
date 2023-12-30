using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class QuaTrinhDaoTaoInfo
    {
        public QuaTrinhDaoTaoInfo()
        { 
        }
        private String m_MaQuaTrinhDaoTao;
        public String MaQuaTrinhDaoTao
        {
            get { return m_MaQuaTrinhDaoTao; }
            set { m_MaQuaTrinhDaoTao = value; }
        }

        private String m_MaNhanVien;
        public String MaNhanVien
        {
            get { return m_MaNhanVien; }
            set { m_MaNhanVien = value; }
        }

        private String m_TenQuaTrinhDaoTao;
        public String TenQuaTrinhDaoTao
        {
            get { return m_TenQuaTrinhDaoTao; }
            set { m_TenQuaTrinhDaoTao = value; }
        }

        private DateTime m_ThoiGianBatDauDaoTao;
        public DateTime ThoiGianBatDauDaoTao
        {
            get { return m_ThoiGianBatDauDaoTao; }
            set { m_ThoiGianBatDauDaoTao = value; }
        }

        private DateTime m_ThoiGianKetThucDaoTao;
        public DateTime ThoiGianKetThucDaoTao
        {
            get { return m_ThoiGianKetThucDaoTao; }
            set { m_ThoiGianKetThucDaoTao = value; }
        }

        private String m_HinhThucDaoTao;
        public String HinhThucDaoTao
        {
            get { return m_HinhThucDaoTao; }
            set { m_HinhThucDaoTao = value; }
        }
        private String m_BangCap;
        public String BangCap
        {
            get { return m_BangCap; }
            set { m_BangCap = value; }
        }
    }

}

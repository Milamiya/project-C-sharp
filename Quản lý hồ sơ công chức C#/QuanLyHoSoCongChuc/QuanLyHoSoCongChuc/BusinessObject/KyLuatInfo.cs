using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class KyLuatInfo
    {
        public KyLuatInfo()
        { 
        }
        private String m_MaKyLuat;
        public String MaKyLuat
        {
            get { return m_MaKyLuat; }
            set { m_MaKyLuat = value; }
        }

        private String m_MaNhanVien;
        public String MaNhanVien
        {
            get { return m_MaNhanVien; }
            set { m_MaNhanVien = value; }
        }

        private DateTime m_NgayKyLuat;
        public DateTime NgayKyLuat
        {
            get { return m_NgayKyLuat; }
            set { m_NgayKyLuat = value; }
        }

        private String m_HinhThucKyLuat;
        public String HinhThucKyLuat
        {
            get { return m_HinhThucKyLuat; }
            set { m_HinhThucKyLuat = value; }
        }

        private String m_CoQuanRaQuyetDinh;
        public String CoQuanRaQuyetDinh
        {
            get { return m_CoQuanRaQuyetDinh; }
            set { m_CoQuanRaQuyetDinh = value; }
        }

        private String m_NguyenNhan;
        public String NguyenNhan
        {
            get { return m_NguyenNhan; }
            set { m_NguyenNhan = value; }
        }
        private String m_CoQuanSauKyLuat;
        public String CoQuanSauKyLuat
        {
            get { return m_CoQuanSauKyLuat; }
            set { m_CoQuanSauKyLuat = value; }
        }
    }
}

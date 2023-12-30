using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class HocSinhInfo
    {
        public HocSinhInfo()
        {

        }

        private String m_MaHocSinh;
        public String MaHocSinh
        {
            get { return m_MaHocSinh; }
            set { m_MaHocSinh = value; }
        }

        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        private bool m_GioiTinh;
        public bool GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }

        private String m_NoiSinh;
        public String NoiSinh
        {
            get { return m_NoiSinh; }
            set { m_NoiSinh = value; }
        }

        private DanTocInfo m_DanToc;
        public DanTocInfo DanToc
        {
            get { return m_DanToc; }
            set { m_DanToc = value; }
        }

        private TonGiaoInfo m_TonGiao;
        public TonGiaoInfo TonGiao
        {
            get { return m_TonGiao; }
            set { m_TonGiao = value; }
        }

        private String m_HoTenCha;
        public String HoTenCha
        {
            get { return m_HoTenCha; }
            set { m_HoTenCha = value; }
        }

        private NgheNghiepInfo m_NNghiepCha;
        public NgheNghiepInfo NNghiepCha
        {
            get { return m_NNghiepCha; }
            set { m_NNghiepCha = value; }
        }

        private String m_HoTenMe;
        public String HoTenMe
        {
            get { return m_HoTenMe; }
            set { m_HoTenMe = value; }
        }

        private NgheNghiepInfo m_NNghiepMe;
        public NgheNghiepInfo NNghiepMe
        {
            get { return m_NNghiepMe; }
            set { m_NNghiepMe = value; }
        }
    }
}
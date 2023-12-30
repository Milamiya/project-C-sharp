using System;
using System.Collections.Generic;
using System.Text;

//Hoàn chỉnh
namespace QLHocSinhTHPT.Bussiness
{
    public class LopInfo
    {
        public LopInfo()
        {

        }

        private String m_MaLop;
        public String MaLop
        {
            get { return m_MaLop; }
            set { m_MaLop = value; }
        }

        private String m_TenLop;
        public String TenLop
        {
            get { return m_TenLop; }
            set { m_TenLop = value; }
        }

        private KhoiLopInfo m_KhoiLop;
        public KhoiLopInfo KhoiLop
        {
            get { return m_KhoiLop; }
            set { m_KhoiLop = value; }
        }

        private NamHocInfo m_NamHoc;
        public NamHocInfo NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        private int m_SiSo;
        public int SiSo
        {
            get { return m_SiSo; }
            set { m_SiSo = value; }
        }

        private GiaoVienInfo m_GiaoVien;
        public GiaoVienInfo GiaoVien
        {
            get { return m_GiaoVien; }
            set { m_GiaoVien = value; }
        }
    }
}

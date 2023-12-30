using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class LopInfo
    {
        #region MaLop
        private string m_MaLop;

        public string MaLop
        {
            get { return m_MaLop; }
            set { m_MaLop = value; }
        }
        #endregion

        #region TenLop
        private string m_TenLop;

        public string TenLop
        {
            get { return m_TenLop; }
            set { m_TenLop = value; }
        }
        #endregion

        #region KhoiLop
        private KhoiLopInfo m_KhoiLop;

        public KhoiLopInfo KhoiLop
        {
            get { return m_KhoiLop; }
            set { m_KhoiLop = value; }
        }
	
        #endregion

        #region NamHoc
        private NamHocInfo m_NamHoc;

        public NamHocInfo NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        }

        #endregion

        #region SiSo
        private int m_SiSo;

        public int SiSo
        {
            get { return m_SiSo; }
            set { m_SiSo = value; }
        }

        #endregion

        #region GiaoVien
        private GiaoVienInfo m_GiaoVien;

        public GiaoVienInfo GiaoVien
        {
            get { return m_GiaoVien; }
            set { m_GiaoVien = value; }
        }
	
        #endregion

        public LopInfo()
        {
            this.MaLop = "";
        }

        public LopInfo(string maLop, string tenLop, KhoiLopInfo khoiLop, NamHocInfo namHoc, int siSo, GiaoVienInfo giaoVien)
        {
            this.MaLop = maLop;
            this.TenLop = tenLop;
            this.KhoiLop = khoiLop;
            this.NamHoc = namHoc;
            this.SiSo = siSo;
            this.GiaoVien = giaoVien;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class PhanCongInfo
    {
        #region MaPhanCong
        private int m_MaPhanCong;

        public int MaPhanCong
        {
            get { return m_MaPhanCong; }
            set { m_MaPhanCong = value; }
        }
	
        #endregion

        #region LopMonHoc
        private LopMonHocInfo m_LopMonHoc;

        public LopMonHocInfo LopMonHoc
        {
            get { return m_LopMonHoc; }
            set { m_LopMonHoc = value; }
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

        public PhanCongInfo()
        {
        }


        public PhanCongInfo(int maPhanCong, LopMonHocInfo lopMonHoc, GiaoVienInfo giaoVien)
        {
            this.MaPhanCong = maPhanCong;
            this.LopMonHoc = lopMonHoc;
            this.GiaoVien = giaoVien;
        }
    }
}

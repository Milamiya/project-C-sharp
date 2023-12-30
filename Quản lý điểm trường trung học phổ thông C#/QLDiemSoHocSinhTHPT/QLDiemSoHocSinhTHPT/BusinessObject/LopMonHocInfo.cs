using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class LopMonHocInfo
    {
        #region MaLopMonHoc
        private int m_MaLopMonHoc;

        public int MaLopMonHoc
        {
            get { return m_MaLopMonHoc; }
            set { m_MaLopMonHoc = value; }
        }

        #endregion

        #region Lop
        private LopInfo m_Lop;

        public LopInfo Lop
        {
            get { return m_Lop; }
            set { m_Lop = value; }
        }
	
        #endregion

        #region MonHoc
        private MonHocInfo m_MonHoc;

        public MonHocInfo MonHoc
        {
            get { return m_MonHoc; }
            set { m_MonHoc = value; }
        }

        #endregion

        public LopMonHocInfo()
        {
        }

        public LopMonHocInfo(int maLopMonHoc, LopInfo lop, MonHocInfo monHoc)
        {
            this.MaLopMonHoc = maLopMonHoc;
            this.Lop = lop;
            this.MonHoc = monHoc;
        }
    }
}

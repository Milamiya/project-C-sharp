using System;
using System.Collections.Generic;
using System.Text;
using QLDiemSoHocSinhTHPT.BusinessObject;
using QLDiemSoHocSinhTHPT.Controller;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class KQCaNamMonHocInfo
    {
        #region PhanLop
        private PhanLopInfo m_PhanLop;

        public PhanLopInfo PhanLop
        {
            get { return m_PhanLop; }
            set { m_PhanLop = value; }
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

        #region DTBMonCaNam
        private float m_DTBMonCaNam;

        public float DTBMonCaNam
        {
            get { return m_DTBMonCaNam; }
            set { m_DTBMonCaNam = value; }
        }
	
        #endregion

        public KQCaNamMonHocInfo()
        {
        }

        public KQCaNamMonHocInfo(PhanLopInfo phanLop, MonHocInfo monHoc, float diemTB)
        {
            this.PhanLop = phanLop;
            this.MonHoc = monHoc;
            this.DTBMonCaNam = diemTB;
        }
    }
}

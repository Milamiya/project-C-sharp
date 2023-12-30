using System;
using System.Collections.Generic;
using System.Text;
using QLDiemSoHocSinhTHPT.BusinessObject;
using QLDiemSoHocSinhTHPT.Controller;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class KQHocKyMonHocInfo
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

        #region HocKy
        private HocKyInfo m_HocKy;

        public HocKyInfo HocKy
        {
            get { return m_HocKy; }
            set { m_HocKy = value; }
        }

        #endregion

        #region DTBMonHocKy
        private float m_DTBMonHocKy;

        public float DTBMonHocKy
        {
            get { return m_DTBMonHocKy; }
            set { m_DTBMonHocKy = value; }
        }

        #endregion

        public KQHocKyMonHocInfo()
        {
        }

        public KQHocKyMonHocInfo(PhanLopInfo phanLop, MonHocInfo monHoc, HocKyInfo hocKy, float diemTB)
        {
            this.PhanLop = phanLop;
            this.MonHoc = monHoc;
            this.HocKy = hocKy;
            this.DTBMonHocKy = diemTB;
        }
    }
}

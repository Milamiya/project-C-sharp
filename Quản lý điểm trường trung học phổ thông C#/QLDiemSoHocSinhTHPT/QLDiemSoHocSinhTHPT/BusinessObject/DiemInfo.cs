using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class DiemInfo
    {
        #region Id
        private int m_Id;

        public int Id
        {
            get { return m_Id; }
            set { m_Id = value; }
        }
	
        #endregion

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

        #region LoaiDiem
        private LoaiDiemInfo m_LoaiDiem;

        public LoaiDiemInfo LoaiDiem
        {
            get { return m_LoaiDiem; }
            set { m_LoaiDiem = value; }
        }
	
        #endregion

        #region Diem
        private float m_Diem;

        public float Diem
        {
            get { return m_Diem; }
            set { m_Diem = value; }
        }

        #endregion
    }
}

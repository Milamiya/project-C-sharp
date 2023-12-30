using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class CBQL_KTXInfo
    {
        #region CanBo
        private CanBoInfo m_CanBo;

        public CanBoInfo CanBo
        {
            get { return m_CanBo; }
            set { m_CanBo = value; }
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
        #region KTX
        private KTXInfo m_KTX;

        public KTXInfo KTX
        {
            get { return m_KTX; }
            set { m_KTX = value; }
        } 
        #endregion
        #region Ngày Bắt Đầu
        private DateTime m_NgayBatDau;

        public DateTime NgayBatDau
        {
            get { return m_NgayBatDau; }
            set { m_NgayBatDau = value; }
        } 
        #endregion
        #region Ngày Kết Thúc
        private DateTime m_NgayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return m_NgayKetThuc; }
            set { m_NgayKetThuc = value; }
        } 
        #endregion        
	
    }
}

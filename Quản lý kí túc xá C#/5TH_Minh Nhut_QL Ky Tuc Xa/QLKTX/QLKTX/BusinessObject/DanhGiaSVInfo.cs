using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class DanhGiaSVInfo
    {
        #region SinhVien
        private SinhVienInfo m_SinhVien;

        public SinhVienInfo SinhVien
        {
            get { return m_SinhVien; }
            set { m_SinhVien = value; }
        } 
        #endregion
        #region HocKi
        private HocKiInfo mHocKi;

        public HocKiInfo Hocki
        {
            get { return mHocKi; }
            set { mHocKi = value; }
        } 
        #endregion
        #region DanhGia

        private DanhGiaInfo m_DanhGia;

        public DanhGiaInfo DanhGiay

        {
            get { return m_DanhGia; }
            set { m_DanhGia = value; }
        } 
        #endregion        
        #region Tích cực
        private string m_TichCuc;

        public string TichCuc
        {
            get { return m_TichCuc; }
            set { m_TichCuc = value; }
        } 
        #endregion
        #region Tiêu Cực
        private string m_TieuCuc;

        public string TieuCuc
        {
            get { return m_TieuCuc; }
            set { m_TieuCuc = value; }
        } 
        #endregion
        #region Ghi Chú
        private string m_GhiChu;

        public string GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        } 
        #endregion
	
	
    }

}

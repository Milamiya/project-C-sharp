using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class HoatDongSVInfo
    {
        public HoatDongSVInfo()
        {
            m_HoatDong = new HoatDongInfo();
            m_SinhVien = new SinhVienInfo();
        }
            
        #region Hoạt động
        private HoatDongInfo m_HoatDong;

        public HoatDongInfo HoatDong
        {
            get { return m_HoatDong; }
            set { m_HoatDong = value; }
        }

        #endregion
        #region SinhVien
        private SinhVienInfo m_SinhVien;

        public SinhVienInfo SinhVien
        {
            get { return m_SinhVien; }
            set { m_SinhVien = value; }
        } 
        #endregion
        #region Ngày
        private DateTime m_Ngay;

        public DateTime Ngay
        {
            get { return m_Ngay; }
            set { m_Ngay = value; }
        } 
        #endregion
        #region Ghi chú
        private string m_GhiChu;

        public string GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        } 
        #endregion

	

	

    }
}

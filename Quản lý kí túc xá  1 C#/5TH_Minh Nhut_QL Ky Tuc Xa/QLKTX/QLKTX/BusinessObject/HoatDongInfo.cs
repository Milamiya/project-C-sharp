using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class HoatDongInfo
    {
        #region Mã hoạt động
        private int m_MaHoatDong;

        public int MaHoatDong
        {
            get { return m_MaHoatDong; }
            set { m_MaHoatDong = value; }
        } 
        #endregion
        #region Tên hoạt động
        private string m_TenHoatDong;

        public string TenHoatDong
        {
            get { return m_TenHoatDong; }
            set { m_TenHoatDong = value; }
        } 
        #endregion
	
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class HocKyInfo
    {
        #region MaHocKy
        private string m_MaHocKy;

        public string MaHocKy
        {
            get { return m_MaHocKy; }
            set { m_MaHocKy = value; }
        }
        #endregion

        #region TenHocKy
        private string m_TenHocKy;

        public string TenHocKy
        {
            get { return m_TenHocKy; }
            set { m_TenHocKy = value; }
        }
        #endregion

        #region HeSo
        private int m_HeSo;

        public int HeSo
        {
            get { return m_HeSo; }
            set { m_HeSo = value; }
        }

        #endregion
    }
}

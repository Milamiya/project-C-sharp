using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class HanhKiemInfo
    {
        /// <summary>
        /// 
        /// </summary>
        #region MaHanhKiem
        private string m_MaHanhKiem;

        public string MaHanhKiem
        {
            get { return m_MaHanhKiem; }
            set { m_MaHanhKiem = value; }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        #region TenHanhKiem
        private string m_TenHanhKiem;

        public string TenHanhKiem
        {
            get { return m_TenHanhKiem; }
            set { m_TenHanhKiem = value; }
        }
        #endregion
    }
}

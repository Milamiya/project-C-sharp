using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class TonGiaoInfo
    {
        /// <summary>
        /// Ma ton giao
        /// </summary>
        #region MaTonGiao
        private int m_MaTonGiao;

        public int MaTonGiao
        {
            get { return m_MaTonGiao; }
            set { m_MaTonGiao = value; }
        }
        #endregion


        /// <summary>
        /// Tên ton giao
        /// </summary>
        #region TenTonGiao
        private string m_TenTonGiao;

        public string TenTonGiao
        {
            get { return m_TenTonGiao; }
            set { m_TenTonGiao = value; }
        }
        #endregion
    }
}

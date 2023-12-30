using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class TonGiaoInfo
    {
        #region Mã tôn giáo
        private int m_MaTonGiao;

        public int MaTonGiao
        {
            get { return m_MaTonGiao; }
            set { m_MaTonGiao = value; }
        } 
        #endregion
        #region Tên tôn giao
        private string m_TenTonGiao;

        public string TenTonGiao
        {
            get { return m_TenTonGiao; }
            set { m_TenTonGiao = value; }
        } 
        #endregion

    }
}

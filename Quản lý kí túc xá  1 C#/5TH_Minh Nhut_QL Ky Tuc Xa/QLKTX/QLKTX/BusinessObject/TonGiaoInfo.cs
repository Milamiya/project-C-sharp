using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class TonGiaoInfo
    {
        #region M� t�n gi�o
        private int m_MaTonGiao;

        public int MaTonGiao
        {
            get { return m_MaTonGiao; }
            set { m_MaTonGiao = value; }
        } 
        #endregion
        #region T�n t�n giao
        private string m_TenTonGiao;

        public string TenTonGiao
        {
            get { return m_TenTonGiao; }
            set { m_TenTonGiao = value; }
        } 
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class KyLuatInfo
    {
        #region M� t�n gi�o
        private int m_MaKyLuat;

        public int MaKyLuat
        {
            get { return m_MaKyLuat; }
            set { m_MaKyLuat = value; }
        } 
        #endregion
        #region T�n t�n giao
        private string m_TenKyLuat;

        public string TenKyLuat
        {
            get { return m_TenKyLuat; }
            set { m_TenKyLuat = value; }
        } 
        #endregion

    }
}

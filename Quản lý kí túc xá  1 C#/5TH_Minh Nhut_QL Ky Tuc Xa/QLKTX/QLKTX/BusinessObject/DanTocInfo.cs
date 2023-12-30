using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class DanTocInfo
    {
        #region MaDanToc
        private int m_MaDanToc;

        public int MaDanToc
        {
            get { return m_MaDanToc; }
            set { m_MaDanToc = value; }
        } 
        #endregion
        #region Tên dân tộc
        private string m_TenDanToc;

        public string TenDanToc
        {
            get { return m_TenDanToc; }
            set { m_TenDanToc = value; }
        } 
        #endregion
	
    }
}

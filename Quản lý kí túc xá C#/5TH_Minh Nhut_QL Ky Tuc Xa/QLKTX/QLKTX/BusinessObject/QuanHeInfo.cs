using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class QuanHeInfo
    {
        #region Mã quan hệ
        private int m_MaQuanHe;

        public int MaQuanHe
        {
            get { return m_MaQuanHe; }
            set { m_MaQuanHe = value; }
        } 
        #endregion
        #region Tên quan hệ
        private string m_TenQuanHe;

        public string TenQuanHe
        {
            get { return m_TenQuanHe; }
            set { m_TenQuanHe = value; }
        } 
        #endregion
	
    }
}

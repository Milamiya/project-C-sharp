using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class QuocTichInfo
    {
        #region Mã quốc tịch
        private int m_MaQuocTich;

        public int MaQuocTich
        {
            get { return m_MaQuocTich; }
            set { m_MaQuocTich = value; }
        } 
        #endregion
        #region Tên quốc tịch
        private string m_TenQuocTich;

        public string TenQuocTich
        {
            get { return m_TenQuocTich; }
            set { m_TenQuocTich = value; }
        } 
        #endregion
	
    }
}

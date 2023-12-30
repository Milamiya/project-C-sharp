using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class CapInfo
    {
        #region Mã Số
        private int m_MaCap;

        
        public int MaCap
        {
            get { return m_MaCap; }
            set { m_MaCap = value; }
        } 
        #endregion
        #region Tên Cấp
        private string m_tenCap;

        public string TenCap
        {
            get { return m_tenCap; }
            set { m_tenCap = value; }
        } 
        #endregion

    }
}

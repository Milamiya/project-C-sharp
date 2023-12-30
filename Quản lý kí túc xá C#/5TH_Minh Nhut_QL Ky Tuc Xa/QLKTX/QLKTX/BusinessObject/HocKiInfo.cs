using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class HocKiInfo
    {
        #region NamHoc
        private NamHocInfo m_NamHoc;

        public NamHocInfo NamHoc
        {
            get { return m_NamHoc; }
            set { m_NamHoc = value; }
        } 
        #endregion
        #region Mã học kì
        private int m_MaHocKi;

        public int MaHocKi
        {
            get { return m_MaHocKi; }
            set { m_MaHocKi = value; }
        } 
        #endregion
        #region TenHocKi
        private String m_TenHocKi;

        public String TenHocKi
        {
            get { return m_TenHocKi; }
            set { m_TenHocKi = value; }
        }
        
        #endregion
	
	
	
    }
}

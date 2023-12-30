using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class CanBoInfo
    {
        #region MaSo
        private int m_MaCBQL;

        public int MaSo
        {
            get { return m_MaCBQL; }
            set { m_MaCBQL = value; }
        } 
        #endregion
        #region Tên
        private string m_TenCBQL;

        public string Ten
        {
            get { return m_TenCBQL; }
            set { m_TenCBQL = value; }
        } 
        #endregion
        #region Địa Chỉ
        private string m_DiaChi;

        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        } 
        #endregion
	
	

    }
}

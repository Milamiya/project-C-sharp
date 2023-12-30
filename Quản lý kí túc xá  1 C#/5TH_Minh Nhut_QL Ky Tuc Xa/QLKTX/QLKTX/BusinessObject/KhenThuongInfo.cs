using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class KhenThuongInfo
    {
        #region Mã hoạt động
        private int m_MaKhenThuong;

        public int MaKhenThuong
        {
            get { return m_MaKhenThuong; }
            set { m_MaKhenThuong = value; }
        } 
        #endregion
        #region Tên hoạt động
        private string m_TenKhenThuong;

        public string TenKhenThuong
        {
            get { return m_TenKhenThuong; }
            set { m_TenKhenThuong = value; }
        } 
        #endregion
	
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class DanhGiaInfo
    {
        #region Mã Đánh Giá
        private int m_MaDanhGia;

        public int MaDanhGia
        {
            get { return m_MaDanhGia; }
            set { m_MaDanhGia = value; }
        } 
        #endregion
        #region Tên Đánh gia
        private string m_TenDanhGia;

        public string TenDanhGia
        {
            get { return m_TenDanhGia; }
            set { m_TenDanhGia = value; }
        } 
        #endregion

    }
}

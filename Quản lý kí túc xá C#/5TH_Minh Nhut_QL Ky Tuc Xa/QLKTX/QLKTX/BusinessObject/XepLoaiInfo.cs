using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class XepLoaiInfo
    {
        #region Mã xếp loại
        private int m_MaXepLoai;

        public int MaXepLoai
        {
            get { return m_MaXepLoai; }
            set { m_MaXepLoai = value; }
        } 
        #endregion
        #region Tên xếp loại
        private string m_TenXepLoai;

        public string TenXepLoai
        {
            get { return m_TenXepLoai; }
            set { m_TenXepLoai = value; }
        } 
        #endregion
        #region Điểm cận trên
        private decimal m_DiemCanTren;

        public decimal DiemCanTren
        {
            get { return m_DiemCanTren; }
            set { m_DiemCanTren = value; }
        } 
        #endregion
        #region Điểm cận dưới
        private decimal m_DiemCanDuoi;

        public decimal DiemCanDuoi
        {
            get { return m_DiemCanDuoi; }
            set { m_DiemCanDuoi = value; }
        }
        #endregion

    }
}

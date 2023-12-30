using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class LoaiDiemInfo
    {
        /// <summary>
        /// Ma loai diem
        /// </summary>
        #region MaLoai
        private string m_MaLoai;
        public string MaLoai
        {
            get { return m_MaLoai; }
            set { m_MaLoai = value; }
        }
        #endregion

        /// <summary>
        /// Ten loai diem
        /// </summary>
        #region TenLoai
        private string m_TenLoai;
        public string TenLoai
        {
            get { return m_TenLoai; }
            set { m_TenLoai = value; }
        }
        #endregion

        /// <summary>
        /// He so
        /// </summary>
        #region HeSo
        private int m_HeSo;
        public int HeSo
        {
            get { return m_HeSo; }
            set { m_HeSo = value; }
        }
        #endregion
    }
}

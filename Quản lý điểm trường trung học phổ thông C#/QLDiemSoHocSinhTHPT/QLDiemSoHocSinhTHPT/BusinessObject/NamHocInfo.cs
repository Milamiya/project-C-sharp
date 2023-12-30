using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class NamHocInfo
    {
        /// <summary>
        /// Ma nam hoc
        /// </summary>
        #region MaNamHoc
        private string m_MaNamHoc;

        public string MaNamHoc
        {
            get { return m_MaNamHoc; }
            set { m_MaNamHoc = value; }
        }
        #endregion

        /// <summary>
        /// Ten nam hoc
        /// </summary>
        #region TenNamHoc
        private string m_TenNamHoc;

        public string TenNamHoc
        {
            get { return m_TenNamHoc; }
            set { m_TenNamHoc = value; }
        }
        #endregion

        public NamHocInfo()
        {
        }

        public NamHocInfo(string maNamHoc, string tenNamHoc)
        {
            this.MaNamHoc = maNamHoc;
            this.TenNamHoc = tenNamHoc;
        }
    }
}

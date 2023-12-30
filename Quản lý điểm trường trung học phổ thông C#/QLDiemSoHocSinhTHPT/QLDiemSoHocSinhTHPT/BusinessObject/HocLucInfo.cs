using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class HocLucInfo
    {
        /// <summary>
        /// Ma hoc luc
        /// </summary>
        #region MaHocLuc
        private string m_MaHocLuc;

        public string MaHocLuc
        {
            get { return m_MaHocLuc; }
            set { m_MaHocLuc = value; }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        #region TenHocLuc
        private string m_TenHocLuc;

        public string TenHocLuc
        {
            get { return m_TenHocLuc; }
            set { m_TenHocLuc = value; }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        #region DiemCanTren
        private string m_DiemCanTren;

        public string DiemCanTren
        {
            get { return m_DiemCanTren; }
            set { m_DiemCanTren = value; }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        #region DiemCanDuoi
        private string m_DiemCanDuoi;

        public string DiemCanDuoi
        {
            get { return m_DiemCanDuoi; }
            set { m_DiemCanDuoi = value; }
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        #region DiemKhongChe
        private string m_DiemKhongChe;

        public string DiemKhongChe
        {
            get { return m_DiemKhongChe; }
            set { m_DiemKhongChe = value; }
        }
        #endregion
    }
}

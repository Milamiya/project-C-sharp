using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class MonHocInfo
    {
        /// <summary>
        /// Ma mon hoc
        /// </summary>
        #region MaMonHoc
        private string m_MaMonHoc;

        public string MaMonHoc
        {
            get { return m_MaMonHoc; }
            set { m_MaMonHoc = value; }
        }
        #endregion

        /// <summary>
        /// Ten mon hoc
        /// </summary>
        #region TenMonHoc
        private string m_TenMonHoc;

        public string TenMonHoc
        {
            get { return m_TenMonHoc; }
            set { m_TenMonHoc = value; }
        }
        #endregion

        /// <summary>
        /// So tiet
        /// </summary>
        #region SoTiet
        private int m_SoTiet;

        public int SoTiet
        {
            get { return m_SoTiet; }
            set { m_SoTiet = value; }
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

        public MonHocInfo()
        {

        }

        public MonHocInfo(string maMonHoc, string tenMonHoc, int soTiet, int heSo)
        {
            this.MaMonHoc = maMonHoc;
            this.TenMonHoc = tenMonHoc;
            this.SoTiet = soTiet;
            this.HeSo = heSo;
        }
    }
}

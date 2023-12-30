using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class KetQuaInfo
    {
        /// <summary>
        /// Ma ket qua
        /// </summary>
        #region MaKetQua
        private string m_MaKetQua;

        public string MaKetQua
        {
            get { return m_MaKetQua; }
            set { m_MaKetQua = value; }
        }
        #endregion

        /// <summary>
        /// Ten ket qua
        /// </summary>
        #region TenKetQua
        private string m_TenKetQua;

        public string TenKetQua
        {
            get { return m_TenKetQua; }
            set { m_TenKetQua = value; }
        }
        #endregion
    }
}

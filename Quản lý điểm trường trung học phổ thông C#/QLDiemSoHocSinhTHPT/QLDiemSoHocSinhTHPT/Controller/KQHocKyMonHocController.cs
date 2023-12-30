using System;
using System.Collections.Generic;
using System.Text;
using QLDiemSoHocSinhTHPT.Data;
using QLDiemSoHocSinhTHPT.BusinessObject;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class KQHocKyMonHocController
    {
        #region Data
        private KQHocKyMonHocData m_Data;

        public KQHocKyMonHocData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }

        #endregion

        public KQHocKyMonHocController()
        {
            this.Data = new KQHocKyMonHocData();
        }

    }
}

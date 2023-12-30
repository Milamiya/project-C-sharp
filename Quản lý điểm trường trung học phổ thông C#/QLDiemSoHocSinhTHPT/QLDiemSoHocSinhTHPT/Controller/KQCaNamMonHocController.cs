using System;
using System.Collections.Generic;
using System.Text;
using QLDiemSoHocSinhTHPT.Data;

namespace QLDiemSoHocSinhTHPT.Controller
{
    public class KQCaNamMonHocController
    {
        #region Data
        private KQCaNamMonHocData m_Data;

        public KQCaNamMonHocData Data
        {
            get { return m_Data; }
            set { m_Data = value; }
        }
	
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public KQCaNamMonHocController()
        {
            this.Data = new KQCaNamMonHocData();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="maHocSinhLop"></param>
        /// <param name="maMonHoc"></param>
        public static float TinhDTBMonCaNam(string maHocSinhLop, string maMonHoc)
        {
            KQCaNamMonHocData data = new KQCaNamMonHocData();
            return (float)Convert.ToDouble(data.TinhDTBMonCaNam(maHocSinhLop, maMonHoc));
        }
    }
}

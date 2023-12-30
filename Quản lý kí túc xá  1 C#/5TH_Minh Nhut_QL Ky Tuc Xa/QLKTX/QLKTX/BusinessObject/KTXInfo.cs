using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class KTXInfo
    {
        #region DS Dãy
        private IList<DayInfo> DS_Day;

        public IList<DayInfo> DSDay
        {
            get { return DS_Day; }
            set { DS_Day = value; }
        } 
        #endregion
        #region DS Cán bộ
        private IList<CanBoInfo> DS_CanBo;

        public IList<CanBoInfo> DSCanBo
        {
            get { return DS_CanBo; }
            set { DS_CanBo = value; }
        } 
        #endregion
        #region Mã Kí túc xá
        private string m_MaKTX;

        public string MaKTX
        {
            get { return m_MaKTX; }
            set { m_MaKTX = value; }
        } 
        #endregion
        #region Tên Kí túc xá
        private string m_TenKTX;

        public string TenKTX
        {
            get { return m_TenKTX; }
            set { m_TenKTX = value; }
        } 
        #endregion
        #region Số Dãy
        private int m_SoDay;

        public int SoDay
        {
            get { return m_SoDay; }
            set { m_SoDay = value; }
        }

        #endregion

	


    }
}

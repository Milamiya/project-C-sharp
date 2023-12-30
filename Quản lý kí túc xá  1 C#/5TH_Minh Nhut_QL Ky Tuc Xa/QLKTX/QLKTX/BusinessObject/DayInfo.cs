using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class DayInfo
    {
        #region DSPhong
        private IList<PhongInfo> DS_Phong;

        public IList<PhongInfo> DSPhong
        {
            get { return DS_Phong; }
            set { DS_Phong = value; }
        } 
        #endregion
        #region KTX
        private KTXInfo m_KTX;

        public KTXInfo KTX
        {
            get { return m_KTX; }
            set { m_KTX = value; }
        } 
        #endregion
        #region Mã Số Dãy
        private string m_MaDay;

        public string MaDay
        {
            get { return m_MaDay; }
            set { m_MaDay = value; }
        } 
        #endregion
        #region Số Lượng Phòng
        private int m_SoLuongPhong;

        public int SoLuongPhong
        {
            get { return m_SoLuongPhong; }
            set { m_SoLuongPhong = value; }
        } 
        #endregion
        #region Cờ Đỏ
        private SinhVienInfo m_CoDo;

        public SinhVienInfo CoDo
        {
            get { return m_CoDo; }
            set { m_CoDo = value; }
        } 
        #endregion
        private string m_TenDay;

        public string TenDay
        {
            get { return m_TenDay; }
            set { m_TenDay = value; }
        }
	
	    
    }
}

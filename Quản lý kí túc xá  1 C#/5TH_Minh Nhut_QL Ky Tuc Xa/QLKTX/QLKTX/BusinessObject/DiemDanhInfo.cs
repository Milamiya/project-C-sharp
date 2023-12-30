using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class DiemDanhInfo
    {
        #region SinhVien
        private SinhVienInfo m_SinhVien;
        public SinhVienInfo SinhVien
        {
            get { return m_SinhVien; }
            set { m_SinhVien = value; }
        }
        #endregion
        #region Phong
        private PhongInfo m_Phong;

        public PhongInfo Phong
        {
            get { return m_Phong; }
            set { m_Phong = value; }
        }
        #endregion
        #region Ngày Vắng
        private DateTime m_NgayVang;

        public DateTime NgayVang
        {
            get { return m_NgayVang; }
            set { m_NgayVang = value; }
        } 
        #endregion
        #region Có Phép
        private bool m_CoPhep;

        public bool CoPhep
        {
            get { return m_CoPhep; }
            set { m_CoPhep = value; }
        } 
        #endregion
	


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class ThanNhanInfo
    {

        public ThanNhanInfo()
        {
            m_NgheNghiep = new NgheNghiepInfo();
            m_QuanHe = new QuanHeInfo();
        }

        #region Sinh Viên
		
        private SinhVienInfo m_SinhVien;

        public SinhVienInfo SinhVien
        {
            get { return m_SinhVien; }
            set { m_SinhVien = value; }
        }

	    #endregion
        #region Tên Thân nhân
        private string m_HoTen;

        public string HoTenThanNhan
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        } 
        #endregion
        private int m_MaThanNhan;

        public int MaThanNhan
        {
            get { return m_MaThanNhan; }
            set { m_MaThanNhan = value; }
        }

        #region Nghề Nghiệp
        private NgheNghiepInfo m_NgheNghiep;

        public NgheNghiepInfo NgheNghiep
        {
            get { return m_NgheNghiep; }
            set { m_NgheNghiep = value; }
        } 
        #endregion
        #region Quan hệ
        private QuanHeInfo m_QuanHe;

        public QuanHeInfo QuanHe
        {
            get { return m_QuanHe; }
            set { m_QuanHe = value; }
        } 
        #endregion

	
	
    }
}

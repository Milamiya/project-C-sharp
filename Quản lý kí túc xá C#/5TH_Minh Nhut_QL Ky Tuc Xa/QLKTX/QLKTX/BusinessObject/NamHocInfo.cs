using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class NamHocInfo
    {
        #region DSHocKi
        private IList<HocKiInfo> dsHocKi;

        public IList<HocKiInfo> DSHocKi
        {
            get { return dsHocKi; }
            set { dsHocKi = value; }
        } 
        #endregion
        #region Mã năm học
        private string  m_MaNamHoc;

        public string MaNamHoc
        {
            get { return m_MaNamHoc; }
            set { m_MaNamHoc = value; }
        } 
        #endregion
        #region Tên năm hoc
        private string m_TenNamHoc;

        public string TenNamHoc
        {
            get { return m_TenNamHoc; }
            set { m_TenNamHoc = value; }
        } 
        #endregion
        #region Ngày bắt đầu
        private DateTime m_NgayBatdau;

        public DateTime NgayBatDau
        {
            get { return m_NgayBatdau; }
            set { m_NgayBatdau = value; }
        } 
        #endregion
        #region Ngày kết thúc
        private DateTime m_NgayKetThuc;

        public DateTime NgayKetThuc
        {
            get { return m_NgayKetThuc; }
            set { m_NgayKetThuc = value; }
        } 
        #endregion


	



    }
}

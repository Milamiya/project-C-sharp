using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class DanhGiaPhongInfo
    {
        #region Phong
        private PhongInfo m_Phong;

        public PhongInfo Phong
        {
            get { return m_Phong; }
            set { m_Phong = value; }
        }
        #endregion
        #region XepLoai
        private XepLoaiInfo m_XepLoai;

        public XepLoaiInfo XepLoai
        {
            get { return m_XepLoai; }
            set { m_XepLoai = value; }
        }
        #endregion
        #region Học kì
        private HocKiInfo m_HocKi;

        public HocKiInfo HocKi
        {
            get { return m_HocKi; }
            set { m_HocKi = value; }
        } 
        #endregion
        #region Tháng
        private int m_Thang;

        public int Thang
        {
            get { return m_Thang; }
            set { m_Thang = value; }
        } 
        #endregion
        #region Điểm
        private decimal m_Diem;

        public decimal Diem
        {
            get { return m_Diem; }
            set { m_Diem = value; }
        } 
        #endregion
        #region Ghi chú
        private string m_GhiChu;

        public string GhiChu
        {
            get { return m_GhiChu; }
            set { m_GhiChu = value; }
        } 
        #endregion
	
	
	
    }
}

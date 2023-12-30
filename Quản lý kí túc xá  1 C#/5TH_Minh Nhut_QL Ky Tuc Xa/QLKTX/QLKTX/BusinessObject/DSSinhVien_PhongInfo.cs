using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class DSSinhVien_PhongInfo
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
        #region Ngày vào
        private DateTime m_NgayVao;

        public DateTime NgayVao
        {
            get { return m_NgayVao; }
            set { m_NgayVao = value; }
        } 
        #endregion
        #region Ngày ra
        private DateTime m_NgayRa;

        public DateTime NgayRa
        {
            get { return m_NgayRa; }
            set { m_NgayRa = value; }
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

using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class KhenThuognSVInfo
    {
        #region SinhVien
        private SinhVienInfo m_SinhVien;
        public SinhVienInfo SinhVine
        {
            get { return m_SinhVien; }
            set { m_SinhVien = value; }
        }
        #endregion
        #region CanBo
        private CanBoInfo m_CanBo;

        public CanBoInfo CanBo
        {
            get { return m_CanBo; }
            set { m_CanBo = value; }
        }
        #endregion
        #region Cap
        private CapInfo m_Cap;

        public CapInfo Cap
        {
            get { return m_Cap; }
            set { m_Cap = value; }
        }
        #endregion        
        #region Lý do
        private string m_LyDo;

        public string LyDo
        {
            get { return m_LyDo; }
            set { m_LyDo = value; }
        } 
        #endregion
        #region Ngày
        private DateTime m_Ngay;

        public DateTime Ngay
        {
            get { return m_Ngay; }
            set { m_Ngay = value; }
        } 
        #endregion
        #region Quyết định số
        private string m_QuyetDinhSo;

        public string QuyetDinhSo
        {
            get { return m_QuyetDinhSo; }
            set { m_QuyetDinhSo = value; }
        }
        
        #endregion
        #region Mã khen thưởng
        private int m_MaKhenThuong;

        public int MaKhenThuong
        {
            get { return m_MaKhenThuong; }
            set { m_MaKhenThuong = value; }
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

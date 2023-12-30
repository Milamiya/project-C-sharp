using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class TienDienInfo
    {
        #region Phòng
        private PhongInfo m_Phong;

        public PhongInfo Phong
        {
            get { return m_Phong; }
            set { m_Phong = value; }
        } 
        #endregion
        #region Tháng
        private DateTime m_Thang;

        public DateTime Thang
        {
            get { return m_Thang; }
            set { m_Thang = value; }
        } 
        #endregion
        #region Năm
        private DateTime m_Nam;

        public DateTime Nam
        {
            get { return m_Nam; }
            set { m_Nam = value; }
        } 
        #endregion
        #region Số KW tiêu thụ
        private int m_SoKW;

        public int SoKW
        {
            get { return m_SoKW; }
            set { m_SoKW = value; }
        } 
        #endregion
        #region Thành tiền
        private int m_ThanhTien;

        public int ThanhTien
        {
            get { return m_ThanhTien; }
            set { m_ThanhTien = value; }
        } 
        #endregion
        #region Tiền Thu
        private int m_TienThu;

        public int TienThu
        {
            get { return m_TienThu; }
            set { m_TienThu = value; }
        } 
        #endregion
        #region Ngày thu
        private DateTime m_NgayThu;

        public DateTime NgayThu
        {
            get { return m_NgayThu; }
            set { m_NgayThu = value; }
        } 
        #endregion
        #region Người thu
        private CBQL_KTXInfo m_NguoiThu;

        public CBQL_KTXInfo NguoiThu
        {
            get { return m_NguoiThu; }
            set { m_NguoiThu = value; }
        } 
        #endregion
        #region Ghi ghú
        private string m_GhiCHu;

        public string GhiCHu
        {
            get { return m_GhiCHu; }
            set { m_GhiCHu = value; }
        } 
        #endregion
        #region Đơn giá
        private int m_DonGia;

        public int DonGia
        {
            get { return m_DonGia; }
            set { m_DonGia = value; }
        } 
        #endregion
		

    }
}

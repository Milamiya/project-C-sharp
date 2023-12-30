using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class HocSinhInfo
    {
        #region MaHocSinh

        private string m_MaHocSinh;
        public string MaHocSinh
        {
            get { return m_MaHocSinh; }
            set { m_MaHocSinh = value; }
        }
        #endregion

        #region HoTen
        private string m_HoTen;

        public string HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }
	
        #endregion

        #region GioiTinh
        private bool m_GioiTinh;
        public bool GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }
        #endregion

        #region NgaySinh

        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }
        #endregion

        #region NoiSinh

        private string m_NoiSinh;
        public string NoiSinh
        {
            get { return m_NoiSinh; }
            set { m_NoiSinh = value; }
        }
        #endregion

        #region DiaChi
        private string m_DiaChi;
        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }
        #endregion

        #region DanToc
        private DanTocInfo m_DanToc;

        public DanTocInfo DanToc
        {
            get { return m_DanToc; }
            set { m_DanToc = value; }
        }

        #endregion

        #region TonGiao
        private TonGiaoInfo m_TonGiao;

        public TonGiaoInfo TonGiao
        {
            get { return m_TonGiao; }
            set { m_TonGiao = value; }
        }

        #endregion

        #region HoTenCha
        private string m_HoTenCha;
        public string HoTenCha
        {
            get { return m_HoTenCha; }
            set { m_HoTenCha = value; }
        }
        #endregion

        #region NgheNghiepCha
        private NgheNghiepInfo m_NgheNghiepCha;

        public NgheNghiepInfo NgheNghiepCha
        {
            get { return m_NgheNghiepCha; }
            set { m_NgheNghiepCha = value; }
        }

	    #endregion

        #region HoTenMe
        private string m_HoTenMe;
        public string HoTenMe
        {
            get { return m_HoTenMe; }
            set { m_HoTenMe = value; }
        }
        #endregion

        #region NgheNghiepMe
        private NgheNghiepInfo m_NgheNghiepMe;

        public NgheNghiepInfo NgheNghiepMe
        {
            get { return m_NgheNghiepMe; }
            set { m_NgheNghiepMe = value; }
        }
	
        #endregion

        public HocSinhInfo()
        {

        }

        public HocSinhInfo(string maHocSinh, string hoTen, bool gioiTinh, DateTime ngaySinh, string noiSinh, string diaChi, DanTocInfo danTon, TonGiaoInfo tonGiao, string hoTenCha, NgheNghiepInfo ngheNghiepCha, string hoTenMe, NgheNghiepInfo ngheNghiepMe)
        {
            this.MaHocSinh = maHocSinh;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.NoiSinh = noiSinh;
            this.DiaChi = diaChi;
            this.DanToc = danTon;
            this.TonGiao = tonGiao;
            this.HoTenCha = hoTenCha;
            this.NgheNghiepCha = ngheNghiepCha;            
            this.HoTenMe = hoTenMe;
            this.NgheNghiepMe = ngheNghiepMe;
        }
    }
}

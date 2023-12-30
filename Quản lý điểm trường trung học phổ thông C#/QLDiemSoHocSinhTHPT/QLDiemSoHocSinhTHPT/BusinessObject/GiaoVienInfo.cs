using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class GiaoVienInfo
    {
        #region MaGiaoVien

        private string m_MaGiaoVien;
        public string MaGiaoVien
        {
            get { return m_MaGiaoVien; }
            set { m_MaGiaoVien = value; }
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

        #region GioiTinh
        private bool m_GioiTinh;
        public bool GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
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

        #region DienThoai
        private string m_DienThoai;
        public string DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        }
        #endregion

        public GiaoVienInfo()
        {
            this.MaGiaoVien = "";
        }

        public GiaoVienInfo(string maGiaoVien, string hoTen, DateTime ngaySinh, string noiSinh, bool gioiTinh, string diaChi, string dienThoai)
        {
            this.MaGiaoVien = maGiaoVien;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.NoiSinh = noiSinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.DienThoai = dienThoai;
        }
    }
}

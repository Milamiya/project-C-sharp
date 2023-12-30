using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class PhongInfo
    {
        #region DS Sinh viên
        private IList<DSSinhVien_PhongInfo> DS_SinhVien_Phong;

        public IList<DSSinhVien_PhongInfo> DSSinhVienPhong
        {
            get { return DS_SinhVien_Phong; }
            set { DS_SinhVien_Phong = value; }
        } 
        #endregion
        #region Dãy
        private DayInfo m_Day;

        public DayInfo Day
        {
            get { return m_Day; }
            set { m_Day = value; }
        } 
        #endregion
        #region Mã Phòng
        private string m_MaPhong;

        public string MaPhong
        {
            get { return m_MaPhong; }
            set { m_MaPhong = value; }
        } 
        #endregion
        #region Tên Phòng
        private string m_tenPhong;

        public string TenPhong
        {
            get { return m_tenPhong; }
            set { m_tenPhong = value; }
        }
        
        #endregion
        #region Số Lượng
        private int m_SoLuong;

        public int SoLuong
        {
            get { return m_SoLuong; }
            set { m_SoLuong = value; }
        } 
        #endregion
        #region Số Lượng tối đa
        private int m_SoLuongToiDa;

        public int SoLuongToiDa
        {
            get { return m_SoLuongToiDa; }
            set { m_SoLuongToiDa = value; }
        } 
        #endregion
        #region Trạng thái
        private TrangThaiPhongInfo m_TrangThai;

        public TrangThaiPhongInfo TrangThai
        {
            get { return m_TrangThai; }
            set { m_TrangThai = value; }
        } 
        #endregion	
        private bool m_PhongNam;

        public bool PhongNam
        {
            get { return m_PhongNam; }
            set { m_PhongNam = value; }
        }

    }
}

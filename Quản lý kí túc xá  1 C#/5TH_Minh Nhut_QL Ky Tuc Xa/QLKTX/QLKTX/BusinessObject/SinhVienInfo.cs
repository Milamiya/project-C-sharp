using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX.BusinessObject
{
    public class SinhVienInfo
    {
        public SinhVienInfo()
        {
            m_QuocTich = new QuocTichInfo();
            m_TonGiao = new TonGiaoInfo();
            m_DanToc = new DanTocInfo();
            
        }
        #region DS Sinh viên _ Phòng
        private IList<DSSinhVien_PhongInfo> m_DSSinhVien_Phong;

        public IList<DSSinhVien_PhongInfo> DSSinhVienPhong
        {
            get { return m_DSSinhVien_Phong; }
            set { m_DSSinhVien_Phong = value; }
        } 
        #endregion
        #region DanhGia

        private IList<DanhGiaSVInfo> m_Danhgia;

        public IList<DanhGiaSVInfo> DanhGiaSinhVien
        {
            get { return m_Danhgia; }
            set { m_Danhgia = value; }
        }
        
        #endregion
        #region HoatDong
        private HoatDongSVInfo m_HoatDong;

        public HoatDongSVInfo HoatDong
        {
            get { return m_HoatDong; }
            set { m_HoatDong = value; }
        }

		 
	    #endregion
        #region DiemDanh
        private DiemDanhInfo m_DiemDanh;

        public DiemDanhInfo DiemDanh
        {
            get { return m_DiemDanh; }
            set { m_DiemDanh = value; }
        } 
        #endregion
        #region Mã số KTX
        private string m_MaKTX;

        public string MaKTX
        {
            get { return m_MaKTX; }
            set { m_MaKTX = value; }
        } 
        #endregion
        #region Năm sinh
        private DateTime m_Namsinh;

        public DateTime Namsinh
        {
            get { return m_Namsinh; }
            set { m_Namsinh = value; }
        } 
        #endregion
        #region Họ tên
        private string m_HoTen;

        public string HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }
        
        #endregion
        #region Số chứng minh nhân dân
        private string m_SoCMDN;

        public string SoCMDN
        {
            get { return m_SoCMDN; }
            set { m_SoCMDN = value; }
        } 
        #endregion
        #region Số điện thoại
        private string m_DienThoai;

        public string DienThoai
        {
            get { return m_DienThoai; }
            set { m_DienThoai = value; }
        } 
        #endregion
        #region Mã số sinh viên
        private string m_MSSV;

        public string MSSV
        {
            get { return m_MSSV; }
            set { m_MSSV = value; }
        } 
        #endregion
        #region Giới tính
        private bool m_GioiTinh;

        public bool GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        } 
        #endregion
        #region Địa chỉ
        private string m_DiaChi;

        public string DiaChi
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        } 
        #endregion
        #region QuocTich
        private QuocTichInfo m_QuocTich;

        public QuocTichInfo QuocTich
        {
            get { return m_QuocTich; }
            set { m_QuocTich = value; }
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
        #region ThanNhan
        private IList<ThanNhanInfo> DS_ThanNhan =new List<ThanNhanInfo>();

        public IList<ThanNhanInfo> DSThanNhan
        {

            get { return DS_ThanNhan; }
            set { DS_ThanNhan = value; }
        } 
        #endregion
        #region Đoàn viên
        private bool m_DoanVien;

        public bool DoanVien
        {
            get { return m_DoanVien; }
            set { m_DoanVien = value; }
        } 
        #endregion
        #region Đảng viên
        private bool m_DangVien;

        public bool DangVien
        {
            get { return m_DangVien; }
            set { m_DangVien = value; }
        } 
        #endregion
        #region Cảm tình đảng
        private bool m_CamTinhDang;

        public bool CamTinhDang
        {
            get { return m_CamTinhDang; }
            set { m_CamTinhDang = value; }
        } 
        #endregion
        #region Ngày vào KTX
        private DateTime m_NgayVaoKTX;

        public DateTime NgayVaoKTX
        {
            get { return m_NgayVaoKTX; }
            set { m_NgayVaoKTX = value; }
        } 
        #endregion
        #region Ngày ra KTX
        private DateTime m_NgayRaKTX;

        public DateTime NgayRaKTX
        {
            get { return m_NgayRaKTX; }
            set { m_NgayRaKTX = value; }
        } 
        #endregion        
        #region Hình ảnh
        private string m_HinhAnh;

        public string HinhAnh
        {
            get { return m_HinhAnh; }
            set { m_HinhAnh = value; }
        } 
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class NguoiDungInfo
    {
        #region MaNguoiDung
        private int m_MaNguoiDung;

        public int MaNguoiDung
        {
            get { return m_MaNguoiDung; }
            set { m_MaNguoiDung = value; }
        }
        #endregion

        #region LoiaNguoiDung
        private LoaiNguoiDungInfo m_LoaiNguoiDung;

        public LoaiNguoiDungInfo LoaiNguoiDung
        {
            get { return m_LoaiNguoiDung; }
            set { m_LoaiNguoiDung = value; }
        }
        #endregion

        #region TenNguoiDung
        private String m_TenNguoiDung;

        public String TenNguoiDung
        {
            get { return m_TenNguoiDung; }
            set { m_TenNguoiDung = value; }
        }

        #endregion

        #region TenDangNhap
        private String m_TenDangNhap;

        public String TenDangNhap
        {
            get { return m_TenDangNhap; }
            set { m_TenDangNhap = value; }
        }
        #endregion

        #region MaKhau
        private String m_MatKhau;

        public String MatKhau
        {
            get { return m_MatKhau; }
            set { m_MatKhau = value; }
        }
        #endregion

        #region GiaoVien
        private GiaoVienInfo m_GiaoVien;

        public GiaoVienInfo GiaoVien
        {
            get { return m_GiaoVien; }
            set { m_GiaoVien = value; }
        }
        #endregion

        public NguoiDungInfo()
        {
            this.MaNguoiDung = 0;
        }

        public NguoiDungInfo(string maNguoiDung)
        {
            this.GiaoVien = new QLDiemSoHocSinhTHPT.Controller.GiaoVienController().LayTuMa("GV0001");
        }

        public NguoiDungInfo(int maNguoiDung, LoaiNguoiDungInfo loaiNguoiDung, String tenNguoiDung, String tenDangNhap, String matKhau, GiaoVienInfo giaoVien) 
        {
            this.MaNguoiDung = maNguoiDung;
            this.LoaiNguoiDung = loaiNguoiDung;
            this.TenNguoiDung = tenNguoiDung;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.GiaoVien = giaoVien;
        }
    }
}

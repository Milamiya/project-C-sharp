using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTienGuiTietKiem.Bussiness
{
    public class SoTietKiemInfo
    {
        public SoTietKiemInfo()
        {
        }

        private LoaiTietKiemInfo m_MaLoaiTietKiem;
        public LoaiTietKiemInfo MaLoaiTietKiem
        {
            get { return m_MaLoaiTietKiem; }
            set { m_MaLoaiTietKiem = value; }
        }

        private String m_MaSoTietKiem;
        public String MaSoTietKiem
        {
            get { return m_MaSoTietKiem; }
            set { m_MaSoTietKiem = value; }
        }

        private DateTime m_NgayMoSo;
        public DateTime NgayMoSo
        {
            get { return m_NgayMoSo; }
            set { m_NgayMoSo = value; }
        }
       
        private DateTime m_NgayHieuLuc;
        public DateTime NgayHieuLuc
        {
            get { return m_NgayHieuLuc; }
            set { m_NgayHieuLuc = value; }
        }

	
	    private DateTime m_NgayDenHan;
        public DateTime NgayDenHan
        {
            get { return m_NgayDenHan; }
            set { m_NgayDenHan = value; }
        }

        private DateTime m_NgayTinhLaiGanNhat;
        public DateTime NgayTinhLaiGanNhat
        {
            get { return m_NgayTinhLaiGanNhat; }
            set { m_NgayTinhLaiGanNhat = value; }
        }

        private DateTime m_NgayTaiKyGui;
        public DateTime NgayTaiKyGui
        {
            get { return m_NgayTaiKyGui; }
            set { m_NgayTaiKyGui = value; }
        }

        private float m_LaiDaTra;
        public float LaiDaTra
        {
            get { return m_LaiDaTra; }
            set { m_LaiDaTra = value; }
        }
	    
        private float m_LaiNhapVon;
        public float LaiNhapVon
        {
            get { return m_LaiNhapVon; }
            set { m_LaiNhapVon = value; }
        }
	
        private DateTime m_NgayNhapVon;
        public DateTime NgayNhapVon
        {
            get { return m_NgayNhapVon; }
            set { m_NgayNhapVon = value; }
        }

        private Boolean m_PhongToa;
        public Boolean PhongToa
        {
            get { return m_PhongToa; }
            set { m_PhongToa = value; }
        }

        private DateTime m_NgayTatToan;
        public DateTime NgayTatToan
        {
            get { return m_NgayTatToan; }
            set { m_NgayTatToan = value; }
        }

        private KhachHangInfo m_MaKH;
        public KhachHangInfo MaKH
        {
            get { return m_MaKH; }
            set { m_MaKH = value; }
        }

        private SoDuTietKiemInfo m_SoDuTK;
        public SoDuTietKiemInfo SoDuTK
        {
            get { return m_SoDuTK; }
            set { m_SoDuTK = value; }
        }
        private LaiSuatTietKiemInfo m_LaiSuatTK;
        public LaiSuatTietKiemInfo LaiSuatTK
        {
            get { return m_LaiSuatTK; }
            set { m_LaiSuatTK = value; }
        }
        private ChiTietPhatSinhGDInfo m_ChiTietPSGD;
        public ChiTietPhatSinhGDInfo ChiTietPSGD
        {
            get { return m_ChiTietPSGD; }
            set { m_ChiTietPSGD = value; }
        }

        private DMKyLaiTKInfo m_DMKyTinhLai;
        public DMKyLaiTKInfo DMKyTinhLai
        {
            get { return m_DMKyTinhLai; }
            set { m_DMKyTinhLai = value; }
        }

        private PhongGiaoDichInfo m_PhongGiaoDich;
        public PhongGiaoDichInfo PhongGiaoDich
        {
            get { return m_PhongGiaoDich; }
            set { m_PhongGiaoDich = value; }
        }
    }
}

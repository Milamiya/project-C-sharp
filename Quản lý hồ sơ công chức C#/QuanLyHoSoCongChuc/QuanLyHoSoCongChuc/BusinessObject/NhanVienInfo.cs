using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyHoSoCongChuc.BusinessObject
{
    public class NhanVienInfo
    {
        public NhanVienInfo()
        {
        }

        //
        private String m_MaNhanVien;
        public String MaNhanVien
        {
            get { return m_MaNhanVien; }
            set { m_MaNhanVien = value; }
        }

        //
        private String m_HoTen;
        public String HoTen
        {
            get { return m_HoTen; }
            set { m_HoTen = value; }
        }

        //
        private String m_TenGoiKhac;
        public String TenGoiKhac
        {
            get { return m_TenGoiKhac; }
            set { m_TenGoiKhac = value; }
        }

        //
        private String m_GioiTinh;
        public String GioiTinh
        {
            get { return m_GioiTinh; }
            set { m_GioiTinh = value; }
        }
        private GioiTinhInfo m_GT;
        public GioiTinhInfo GT
        {
            get { return m_GT; }
            set { m_GT = value; }
        }

        //
        private DateTime m_NgaySinh;
        public DateTime NgaySinh
        {
            get { return m_NgaySinh; }
            set { m_NgaySinh = value; }
        }

        //
        private String m_NoiSinh;
        public String NoiSinh
        {
            get { return m_NoiSinh; }
            set { m_NoiSinh = value; }
        }

        //
        private String m_SoCMND;
        public String SoCMND
        {
            get { return m_SoCMND; }
            set { m_SoCMND = value; }
        }

        //
        private String m_NoiCap;
        public String NoiCap
        {
            get { return m_NoiCap; }
            set { m_NoiCap = value; }
        }

        //
        private DateTime m_NgayCap;
        public DateTime NgayCap
        {
            get { return m_NgayCap; }
            set { m_NgayCap = value; }
        }

        //
        private String m_DanToc;
        public String DanToc
        {
            get { return m_DanToc; }
            set { m_DanToc = value; }
        }

        //
        private String m_TonGiao;
        public String TonGiao
        {
            get { return m_TonGiao; }
            set { m_TonGiao = value; }
        }

        //
        private String m_QueQuan;
        public String QueQuan
        {
            get { return m_QueQuan; }
            set { m_QueQuan = value; }
        }

        //
        private String m_HoKhau;
        public String HoKhau
        {
            get { return m_HoKhau; }
            set { m_HoKhau = value; }
        }

        //
        private String m_NoiOHienTai;
        public String NoiOHienTai
        {
            get { return m_NoiOHienTai; }
            set { m_NoiOHienTai = value; }
        }

        //
        private String m_DienThoaiNhaRieng;
        public String DienThoaiNhaRieng
        {
            get { return m_DienThoaiNhaRieng; }
            set { m_DienThoaiNhaRieng = value; }
        }

        //
        private String m_DienThoaiDiDong;
        public String DienThoaiDiDong
        {
            get { return m_DienThoaiDiDong; }
            set { m_DienThoaiDiDong = value; }
        }

        //
        private String m_TinhTrangHonNhan;
        public String TinhTrangHonNhan
        {
            get { return m_TinhTrangHonNhan; }
            set { m_TinhTrangHonNhan = value; }
        }

        //
        private String m_ThanhPhanXuatThan;
        public String ThanhPhanXuatThan
        {
            get { return m_ThanhPhanXuatThan; }
            set { m_ThanhPhanXuatThan = value; }
        }

        //
        private String m_DienUuTienGiaDinh;
        public String DienUuTienGiaDinh
        {
            get { return m_DienUuTienGiaDinh; }
            set { m_DienUuTienGiaDinh = value; }
        }

        //
        private String m_DienUuTienCuaBanThan;
        public String DienUuTienCuaBanThan
        {
            get { return m_DienUuTienCuaBanThan; }
            set { m_DienUuTienCuaBanThan = value; }
        }

        //
        private String m_NangKhieu;
        public String NangKhieu
        {
            get { return m_NangKhieu; }
            set { m_NangKhieu = value; }
        }

        //
        private DateTime m_NgayHopDong;
        public DateTime NgayHopDong
        {
            get { return m_NgayHopDong; }
            set { m_NgayHopDong = value; }
        }

        //
        private DateTime m_NgayTuyenDung;
        public DateTime NgayTuyenDung
        {
            get { return m_NgayTuyenDung; }
            set { m_NgayTuyenDung = value; }
        }

        //
       
        private String m_MaDonVi;
        public String MaDonVi
        {
            get { return m_MaDonVi; }
            set { m_MaDonVi = value; }
        }
        private DonViInfo m_DonVi;
        public DonViInfo DonVi
        {
            get { return m_DonVi; }
            set { m_DonVi = value; }
        }
        //
        private String m_HinhThucTuyenDung;
        public String HinhThucTuyenDung
        {
            get { return m_HinhThucTuyenDung; }
            set { m_HinhThucTuyenDung = value; }
        }

        //
        private String m_CongViecDuocGiao;
        public String CongViecDuocGiao
        {
            get { return m_CongViecDuocGiao; }
            set { m_CongViecDuocGiao = value; }
        }

        //
        private DateTime m_NgayBoNhiemVaoNghach;
        public DateTime NgayBoNhiemVaoNghach
        {
            get { return m_NgayBoNhiemVaoNghach; }
            set { m_NgayBoNhiemVaoNghach = value; }
        }

        //
        private DateTime m_NgayVaoCoQuanHienNay;
        public DateTime NgayVaoCoQuanHienNay
        {
            get { return m_NgayVaoCoQuanHienNay; }
            set { m_NgayVaoCoQuanHienNay = value; }
        }

        //
        private String m_LoaiCanBo;
        public String LoaiCanBo
        {
            get { return m_LoaiCanBo; }
            set { m_LoaiCanBo = value; }
        }

        //
        private String m_CongViecVaoCoQuanHienNay;
        public String CongViecVaoCoQuanHienNay
        {
            get { return m_CongViecVaoCoQuanHienNay; }
            set { m_CongViecVaoCoQuanHienNay = value; }
        }

        //
        private String m_DangNghiBHXH;
        public String DangNghiBHXH
        {
            get { return m_DangNghiBHXH; }
            set { m_DangNghiBHXH = value; }
        }

        //
        private String m_ChucVuHienTai;
        public String ChucVuHienTai
        {
            get { return m_ChucVuHienTai; }
            set { m_ChucVuHienTai = value; }
        }
        private ChucVuInfo m_ChucVu;
        public ChucVuInfo ChucVu
        {
            get { return m_ChucVu; }
            set { m_ChucVu = value; }
        }
        //
        private DateTime m_NgayBoNhiemChucVuHienTai;
        public DateTime NgayBoNhiemChucVuHienTai
        {
            get { return m_NgayBoNhiemChucVuHienTai; }
            set { m_NgayBoNhiemChucVuHienTai = value; }
        }

     
        //Lan bo nhiem chuc vu co quan hien tai
        private String m_LanBoNhiem;
        public String LanBoNhiem
        {
            get { return m_LanBoNhiem; }
            set { m_LanBoNhiem = value; }
        }

        //
        private String m_ChucVuKiemNhiem;
        public String ChucVuKiemNhiem
        {
            get { return m_ChucVuKiemNhiem; }
            set { m_ChucVuKiemNhiem = value; }
        }

        //Chuc vu cao nhat da qua
        private String m_ChucVuCaoNhat;
        public String ChucVuCaoNhat
        {
            get { return m_ChucVuCaoNhat; }
            set { m_ChucVuCaoNhat = value; }
        }

        //
        private DateTime m_NgayVaoDang;
        public DateTime NgayVaoDang
        {
            get { return m_NgayVaoDang; }
            set { m_NgayVaoDang = value; }
        }

        //
        private DateTime m_NgayChinhThuc;
        public DateTime NgayChinhThuc
        {
            get { return m_NgayChinhThuc; }
            set { m_NgayChinhThuc = value; }
        }

        //
        private String m_ChucVuDang;
        public String ChucVuDang
        {
            get { return m_ChucVuDang; }
            set { m_ChucVuDang = value; }
        }

        //
        private String m_DoanVien;
        public String DoanVien
        {
            get { return m_DoanVien; }
            set { m_DoanVien = value; }
        }

        //
        private DateTime m_NgayThamGiaToChucCTXH;
        public DateTime NgayThamGiaToChucCTXH
        {
            get { return m_NgayThamGiaToChucCTXH; }
            set { m_NgayThamGiaToChucCTXH = value; }
        }

        //
        private String m_TenToChucCTXH;
        public String TenToChucCTXH
        {
            get { return m_TenToChucCTXH; }
            set { m_TenToChucCTXH = value; }
        }

        //
        private String m_ChucVuDoanThe;
        public String ChucVuDoanThe
        {
            get { return m_ChucVuDoanThe; }
            set { m_ChucVuDoanThe = value; }
        }

        //
        private String m_TheoHocKhoaDTBD;
        public String TheoHocKhoaDTBD
        {
            get { return m_TheoHocKhoaDTBD; }
            set { m_TheoHocKhoaDTBD = value; }
        }

        //
        private String m_TrinhDoHocVan;
        public String TrinhDoHocVan
        {
            get { return m_TrinhDoHocVan; }
            set { m_TrinhDoHocVan = value; }
        }

        //
        private String m_TrinhDoChuyenMon;
        public String TrinhDoChuyenMon
        {
            get { return m_TrinhDoChuyenMon; }
            set { m_TrinhDoChuyenMon = value; }
        }

        //
        private String m_TrinhDoLyLuanChinhTri;
        public String TrinhDoLyLuanChinhTri
        {
            get { return m_TrinhDoLyLuanChinhTri; }
            set { m_TrinhDoLyLuanChinhTri = value; }
        }

        //
        private String m_TrinhDoQuanLyNhaNuoc;
        public String TrinhDoQuanLyNhaNuoc
        {
            get { return m_TrinhDoQuanLyNhaNuoc; }
            set { m_TrinhDoQuanLyNhaNuoc = value; }
        }

        //
        private String m_TrinhDoTinHoc;
        public String TrinhDoTinHoc
        {
            get { return m_TrinhDoTinHoc; }
            set { m_TrinhDoTinHoc = value; }
        }

        //
        private String m_TrinhDoNgoaiNgu;
        public String TrinhDoNgoaiNgu
        {
            get { return m_TrinhDoNgoaiNgu; }
            set { m_TrinhDoNgoaiNgu = value; }
        }

        //
        private String m_NghachCongChuc;
        public String NghachCongChuc
        {
            get { return m_NghachCongChuc; }
            set { m_NghachCongChuc = value; }
        }

        //
        private String m_MaNghach;
        public String MaNghach
        {
            get { return m_MaNghach; }
            set { m_MaNghach = value; }
        }

        //
        private String m_BacLuong;
        public String BacLuong
        {
            get { return m_BacLuong; }
            set { m_BacLuong = value; }
        }

        //
        private String m_HeSoLuong;
        public String HeSoLuong
        {
            get { return m_HeSoLuong; }
            set { m_HeSoLuong = value; }
        }

        //
        private String m_Huong85;
        public String Huong85
        {
            get { return m_Huong85; }
            set { m_Huong85 = value; }
        }

        //
        private String m_ChenhLechBaoLuu;
        public String ChenhLechBaoLuu
        {
            get { return m_ChenhLechBaoLuu; }
            set { m_ChenhLechBaoLuu = value; }
        }

        
        //
        private DateTime m_NgayHuong;
        public DateTime NgayHuong
        {
            get { return m_NgayHuong; }
            set { m_NgayHuong = value; }
        }


        //
        private String m_MocTinhNangLuongLanSau;
        public String MocTinhNangLuongLanSau
        {
            get { return m_MocTinhNangLuongLanSau; }
            set { m_MocTinhNangLuongLanSau = value; }
        }
        private String m_NgayNangLuong;
        public String NgayNangLuong
        {
            get { return m_NgayNangLuong; }
            set { m_NgayNangLuong = value; }
        }
        //
        private String m_HeSoPhuCapChucVu;
        public String HeSoPhuCapChucVu
        {
            get { return m_HeSoPhuCapChucVu; }
            set { m_HeSoPhuCapChucVu = value; }
        }

        //
        private String m_PhuCapThamNienVuotKhung;
        public String PhuCapThamNienVuotKhung
        {
            get { return m_PhuCapThamNienVuotKhung; }
            set { m_PhuCapThamNienVuotKhung = value; }
        }

        //
        private String m_HeSoPhuCapKiemNhiem;
        public String HeSoPhuCapKiemNhiem
        {
            get { return m_HeSoPhuCapKiemNhiem; }
            set { m_HeSoPhuCapKiemNhiem = value; }
        }

        //
        private String m_HeSoPhuCapKhac;
        public String HeSoPhuCapKhac
        {
            get { return m_HeSoPhuCapKhac; }
            set { m_HeSoPhuCapKhac = value; }
        }

        //
        private String m_SoSoBHXH;
        public String SoSoBHXH
        {
            get { return m_SoSoBHXH; }
            set { m_SoSoBHXH = value; }
        }

        //
        private DateTime m_NgayBatDauDonhBHXH;
        public DateTime NgayBatDauDonhBHXH
        {
            get { return m_NgayBatDauDonhBHXH; }
            set { m_NgayBatDauDonhBHXH = value; }
        }
    }
}

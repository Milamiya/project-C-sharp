using System;
using System.Collections.Generic;
using System.Text;
using QLKTX.Phong;
using QLKTX.Day;
using QLKTX.KTX;
namespace QLKTX
{
    public class FormChung
    {
        public static frmFlashScreen flash = null;
        #region He Thong
        public static frmNamHoc namHoc = null;
        public static frmHocKi hocKy = null;
        public static frmQuocTich quoctich = null;
        public static frmDanToc dantoc = null;
        public static frmTonGiao tongiao = null;
        public static frmCanBo canbo = null;
        public static frmNguoiDung nguoidung = null;
        public static Dialog.DiaLog_HoatDong hoatdong = null;
        public static frmHoatDongSinhVien hoatdongsinhvien = null;
        public static frmKyLuat kyluat = null;
        public static Dialog.DiaLog_KhenThuong khenthuong = null;
        public static frmKhenThuongSinhVien khenthuongsinhvien = null;
        public static Dialog.DiaLog_Cap cap = null;
        public static frmDanhGia danhgia = null;
        public static frmXepLoai xeploai = null;

        public static frmBackup backup = null;
        public static frmRestore restore = null;
       

        #endregion

        #region TroGiup
        

        public static frmDangNhap dangNhap = null;
        public static frmGioiThieu gioiThieu = null;
        #endregion

        #region Sinh vien
        public static frmThemSinhVien themSinhVien = null;
        public static frmSuaSinhVien suaSinhVien = null;
        public static frmXoaSinhVien xoaSinhVien = null;
        public static frmTraCuuSinhVien traCuuSinhVien = null;
        public static frmThongKeSinhVien thongKeSinhVien = null;
        public static frmKyLuatSinhVien kyLuatSinhVien = null;        
        public static frmDiemDanhSinhVien diemDanhSinhVien = null;
        public static frmDanhGiaSinhVien danhGiaSinhVien = null;        
        public static frmChuyenPhongSinhVien chuyenPhongSinhVien = null;
        public static frmThongKeSinhVienThuocPhong thongKeSinhVienThuocPhong = null;
        public static frmThongKeSinhVienThuocDay thongKeSinhVienThuocDay = null;
        public static frmThongKeSinhVienThuocKTX thongKeSinhVienThuocKTX = null;
        public static SinhVien.frmXepPhongSinhVien xepphong = null;

        #endregion
        #region KTX
        public static frmKTX ktx = null;
        #endregion
        #region Day
        public static frmDay day = null;
        #endregion

        #region Phong
        public static frmPhong phong = null;
        public static frmNhapDiem_Phong nhapdiem = null;
        #endregion
    }
}

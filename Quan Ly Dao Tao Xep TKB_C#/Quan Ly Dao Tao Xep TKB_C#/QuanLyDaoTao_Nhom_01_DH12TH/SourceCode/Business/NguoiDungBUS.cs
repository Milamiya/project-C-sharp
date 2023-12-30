using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    /// <summary>
    /// Người dùng business
    /// </summary>
    public static class NguoiDungBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        /// <summary>
        /// Load danh sách tất cả các người dùng
        /// </summary>
        /// <returns>Bảng các người dùng</returns>
        public static Table<NguoiDung> DanhSachNguoiDung()
        {
            try
            {
                return db.NguoiDungs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lưu các thay đổi vào CSDL
        /// </summary>
        public static void LuuThayDoi()
        {
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Xóa 1 người dùng
        /// </summary>
        /// <param name="tenDangNhap">Tên đăng nhập</param>
        public static void Xoa(string tenDangNhap)
        {
            try
            {
                db.NguoiDungs.DeleteOnSubmit(db.NguoiDungs.Single(nd => nd.TenDangNhap == tenDangNhap));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Lấy thông tin của 1 người dùng
        /// </summary>
        /// <param name="tenDangNhap">Tên đăng nhập</param>
        public static NguoiDung LayThongTin(string tenDangNhap)
        {
            try
            {
                return db.NguoiDungs.Single(nd => nd.TenDangNhap == tenDangNhap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Kiểm tra người dùng có tồn tại không
        /// </summary>
        /// <param name="tenDangNhap">tên đăng nhập</param>
        /// <returns>True: tồn tại. Flase: không tồn tại</returns>
        public static bool KiemTraTenDangNhap(string tenDangNhap)
        {
            try
            {
                return db.NguoiDungs.Any(nd => nd.TenDangNhap == tenDangNhap);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string LayMatKhau(string tenDangNhap)
        {
            try
            {
                return db.NguoiDungs.Single(nd => nd.TenDangNhap == tenDangNhap).MatKhau;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            try
            {
                if (KiemTraTenDangNhap(tenDangNhap))
                {
                    NguoiDung nguoiDung = db.NguoiDungs.Single(nd => nd.TenDangNhap == tenDangNhap);
                    if(nguoiDung.MatKhau == UtilitiesClass.MaHoaMD5(matKhauCu))
                    {
                        nguoiDung.MatKhau = UtilitiesClass.MaHoaMD5(matKhauMoi);
                        db.SubmitChanges();
                        return true;
                    }
                    else
                        throw new Exception("Mật khẩu cũ không chính xác.");
                }
                else
                    throw new Exception("Không tồn tại người dùng \"" + tenDangNhap + "\"");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Them(NguoiDung nd)
        {
            try
            {
                db.NguoiDungs.InsertOnSubmit(nd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ThietLapLaiMatKhau(string tenDangNhap, string matKhauMoi)
        {
            try
            {
                db.NguoiDungs.Single(nd => nd.TenDangNhap == tenDangNhap).MatKhau = UtilitiesClass.MaHoaMD5(matKhauMoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable LayDuLieu()
        {
            try
            {
                return (new DataProvider()).GetTable("Select TenDangNhap, TenNguoiDung, Quyen, MoTaQuyen from NguoiDung");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

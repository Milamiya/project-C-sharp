using System;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;
using Util;

namespace QLHS.DAL
{
    public class NguoiDungDAL : ConnectData
    {
        /// <summary>
        /// Lấy danh sách người dùng
        /// </summary>
        /// <returns></returns>
        public DataTable LayDT_NguoiDung()
        {
            string sql = "SELECT MaND, a.MaLoaiND, TenLoaiND, TenGiaoVien ,TenDNhap, a.TrangThai "
                         + " FROM NGUOIDUNG a,GIAOVIEN b, LOAINGUOIDUNG c "
                         + " WHERE a.MaND = b.MaGiaoVien and a.MaLoaiND = c.MaLoaiND";
            return GetTable(sql);
        }

        /// <summary>
        /// Lấy danh sách người dùng đăng nhập
        /// </summary>
        /// <returns></returns>
        public DataTable LayDT_NguoiDung_DangNhap()
        {
            string sql = "SELECT MaND, a.MaLoaiND, TenLoaiND, TenGiaoVien ,TenDNhap "
                         + " FROM NGUOIDUNG a,GIAOVIEN b, LOAINGUOIDUNG c "
                         + " WHERE a.MaND = b.MaGiaoVien and a.MaLoaiND = c.MaLoaiND AND a.TrangThai = 1";
            return GetTable(sql);
        }

        public NguoiDungDTO LayDTO_ThongTin_NguoiDung(string username)
        {
            string sql = "SELECT MaND, a.MaLoaiND, MatKhau, TenLoaiND, TenGiaoVien ,TenDNhap, a.TrangThai "
                         + " FROM NGUOIDUNG a, GIAOVIEN b, LOAINGUOIDUNG c "
                         + " WHERE a.MaND = b.MaGiaoVien and a.MaLoaiND = c.MaLoaiND "
                         + " AND TenDNhap = '" + username + "'";
            NguoiDungDTO nguoiDung = null;
            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                nguoiDung = new NguoiDungDTO();
                nguoiDung.MaND = Convert.ToString(dr["MaND"]);
                nguoiDung.LoaiNguoiDung.MaLoai = Convert.ToString(dr["MaLoaiND"]);
                nguoiDung.LoaiNguoiDung.TenLoaiND = Convert.ToString(dr["TenLoaiND"]);
                nguoiDung.TenND = Convert.ToString(dr["TenGiaoVien"]);
                nguoiDung.TenDNhap = Convert.ToString(dr["TenDNhap"]);
                nguoiDung.MatKhau = Convert.ToString(dr["MatKhau"]);
                nguoiDung.TrangThai = Convert.ToInt16(dr["TrangThai"]);
            }
            CloseConnect();
            return nguoiDung;
        }

        /// <summary>
        /// Đổi mật khẩu người dùng
        /// </summary>
        /// <param name="tenDangNhap">Tên đăng nhập</param>
        /// <param name="newPassword">Mật khẩu mới</param>
        public bool DoiMatKhauNguoiDung(string tenDangNhap, string newPassword)
        {
            string sql = "UPDATE NGUOIDUNG SET MatKhau = '" + ObjectUtil.MaHoaMD5(newPassword) +
                         "' WHERE TenDNhap = '" + tenDangNhap + "'";
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Kiểm tra tồn tại người dùng
        /// </summary>
        /// <param name="maUser">String: Mã người dùng</param>
        /// <returns></returns>
        public bool KiemTraTonTai_NguoiDung(string maUser)
        {
            string sql = "SELECT MaND FROM NGUOIDUNG WHERE MaND = '" + maUser + "'";
            return ExecuteScalar(sql) != null;
        }

        /// <summary>
        /// Kiểm tra tồn tại tài khoản
        /// </summary>
        /// <param name="taiKhoan"></param>
        /// <returns></returns>
        public bool KiemTraTonTai_TaiKhoan(string taiKhoan)
        {
            string sql = "SELECT TenDNhap FROM NGUOIDUNG WHERE TenDNhap = '" + taiKhoan + "'";
            return ExecuteScalar(sql) != null;
        }

        /// <summary>
        /// Thêm thông tin người dùng
        /// </summary>
        /// <param name="user">NguoiDungDTO</param>
        /// <returns></returns>
        public bool Them_ThongTin_NguoiDung(NguoiDungDTO user)
        {
            string sql = string.Format("INSERT INTO NGUOIDUNG (MaND, MaLoaiND, TenDNhap, MatKhau, TrangThai ) "
                                       + "VALUES ('{0}','{1}','{2}','{3}','{4}')",
                                       user.MaND, user.LoaiNguoiDung.MaLoai, user.TenDNhap,
                                       ObjectUtil.MaHoaMD5(user.MatKhau), user.TrangThai);
            if (ExecuteQuery(sql) > 0)
                return true;
            return false;
        }

        /// <summary>
        /// Sửa thông tin người dùng
        /// </summary>
        /// <param name="user">NguoiDungDTO</param>
        /// <returns></returns>
        public bool Sua_ThongTin_NguoiDung(NguoiDungDTO user)
        {
            string updatePassword = (user.MatKhau == "")
                                        ? ""
                                        : "MatKhau = '" + ObjectUtil.MaHoaMD5(user.MatKhau) + "',";
            string sql =
                string.Format(
                    "UPDATE NGUOIDUNG SET MaLoaiND = '{0}', TenDNhap = '{1}', " + updatePassword + " TrangThai = '{2}' "
                    + "WHERE MaND = '{3}'",
                    user.LoaiNguoiDung.MaLoai, user.TenDNhap, user.TrangThai, user.MaND);
            if (ExecuteQuery(sql) > 0)
                return true;
            return false;
        }

        /// <summary>
        /// Xóa thông tin người dùng
        /// </summary>
        /// <param name="maUser">String: Mã user</param>
        /// <returns></returns>
        public bool Xoa_ThongTin_NguoiDung(string maUser)
        {
            string sql = "DELETE FROM NGUOIDUNG WHERE MaND = '" + maUser + "'";
            return ExecuteQuery(sql) > 0;
        }
    }
}
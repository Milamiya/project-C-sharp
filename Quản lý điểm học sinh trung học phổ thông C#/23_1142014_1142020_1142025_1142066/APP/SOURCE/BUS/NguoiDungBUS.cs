using System.Data;
using QLHS.DAL;
using QLHS.DTO;

namespace QLHS.BUS
{
    public class NguoiDungBUS
    {
        private readonly NguoiDungDAL _nguoiDungDAL;

        public NguoiDungBUS()
        {
            _nguoiDungDAL = new NguoiDungDAL();
        }

        /// <summary>
        /// Lấy danh sách người dùng
        /// </summary>
        /// <returns></returns>
        public DataTable LayDT_NguoiDung()
        {
            return _nguoiDungDAL.LayDT_NguoiDung();
        }

        /// <summary>
        /// Lấy danh sách người dùng đăng nhập
        /// </summary>
        /// <returns></returns>
        public DataTable LayDT_NguoiDung_DangNhap()
        {
            return _nguoiDungDAL.LayDT_NguoiDung_DangNhap();
        }

        /// <summary>
        /// Lấy thông tin người dùng qua username
        /// </summary>
        /// <param name="username">String: username</param>
        /// <returns></returns>
        public NguoiDungDTO LayThongTin_NguoiDung(string username)
        {
            return _nguoiDungDAL.LayDTO_ThongTin_NguoiDung(username);
        }

        /// <summary>
        /// Đổi mật khẩu người dùng
        /// </summary>
        /// <param name="tenDangNhap">Tên đăng nhập</param>
        /// <param name="matKhau">Mật khẩu mới</param>
        public bool DoiMatKhau_NguoiDung(string tenDangNhap, string matKhau)
        {
            return _nguoiDungDAL.DoiMatKhauNguoiDung(tenDangNhap, matKhau);
        }

        /// <summary>
        /// Kiểm tra tồn tại người dùng
        /// </summary>
        /// <param name="maUser">String: Mã người dùng</param>
        /// <returns></returns>
        public bool KiemTraTonTai_NguoiDung(string maUser)
        {
            return _nguoiDungDAL.KiemTraTonTai_NguoiDung(maUser);
        }

        /// <summary>
        /// Kiểm tra tồn tại tài khoản
        /// </summary>
        /// <returns></returns>
        public bool KiemTraTonTai_TaiKhoan(string taiKhoan)
        {
            return _nguoiDungDAL.KiemTraTonTai_TaiKhoan(taiKhoan);
        }

        /// <summary>
        /// Thêm thông tin người dùng
        /// </summary>
        /// <param name="user">NguoiDungDTO</param>
        /// <returns></returns>
        public bool Them_NguoiDung(NguoiDungDTO user)
        {
            return _nguoiDungDAL.Them_ThongTin_NguoiDung(user);
        }

        /// <summary>
        /// Sửa thông tin người dùng
        /// </summary>
        /// <param name="user">NguoiDungDTO</param>
        /// <returns></returns>
        public bool Sua_NguoiDung(NguoiDungDTO user)
        {
            return _nguoiDungDAL.Sua_ThongTin_NguoiDung(user);
        }

        /// <summary>
        /// Xóa thông tin người dùng
        /// </summary>
        /// <param name="maUser">String: Mã user</param>
        /// <returns></returns>
        public bool Xoa_NguoiDung(string maUser)
        {
            return _nguoiDungDAL.Xoa_ThongTin_NguoiDung(maUser);
        }
    }
}
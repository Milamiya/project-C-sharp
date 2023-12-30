using System.Data;
using QLHS.DAL;
using QLHS.DTO;
using Util;

namespace QLHS.BUS
{
    public class GiaoVienBUS
    {
        private readonly GiaoVienDAL _giaoVienDAL;

        public GiaoVienBUS()
        {
            _giaoVienDAL = new GiaoVienDAL();
        }

        /// <summary>
        /// Lấy datatable danh sách giáo viên
        /// </summary>
        /// <returns></returns>
        public DataTable LayDT_DanhSachGiaoVien()
        {
            return _giaoVienDAL.LayDT_DanhSach_GiaoVien();
        }

        /// <summary>
        /// Xóa hồ sơ giáo viên
        /// </summary>
        /// <param name="maGiaoVien">string: mã giáo viên</param>
        /// <returns></returns>
        public bool Xoa_HoSo_GiaoVien(string maGiaoVien)
        {
            return _giaoVienDAL.Xoa_HoSo_GiaoVien(maGiaoVien);
        }

        /// <summary>
        /// Thêm hồ sơ giáo viên
        /// </summary>
        /// <param name="giaoVien">GiaoVienDTO</param>
        /// <returns></returns>
        public bool Them_HoSo_GiaoVien(GiaoVienDTO giaoVien)
        {
            giaoVien.MaGiaoVien = ObjectUtil.NextID(_giaoVienDAL.Lay_MaCuoiCung(), "GV", 3);
            return _giaoVienDAL.Them_HoSo_GiaoVien(giaoVien);
        }

        /// <summary>
        /// Cập nhật hồ sơ giáo viên
        /// </summary>
        /// <param name="giaoVien">GiaoVienDTO</param>
        /// <returns></returns>
        public bool CapNhat_HoSo_GiaoVien(GiaoVienDTO giaoVien)
        {
            return _giaoVienDAL.CapNhat_GiaoVien(giaoVien);
        }

        /// <summary>
        /// Kiểm tra tồn tại hồ sơ giáo viên
        /// </summary>
        /// <param name="maGiaoVien">string: mã giáo viên</param>
        /// <returns></returns>
        public bool KiemTonTai_HoSo_GiaoVien(string maGiaoVien)
        {
            return _giaoVienDAL.KiemTonTai_GiaoVien(maGiaoVien);
        }
    }
}
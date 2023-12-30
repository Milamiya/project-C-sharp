using System;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAL
{
    public class GiaoVienDAL : ConnectData
    {
        /// <summary>
        /// Lấy datatable danh sách giáo viên
        /// </summary>
        /// <returns></returns>
        public DataTable LayDT_DanhSach_GiaoVien()
        {
            string sql = "SELECT MaGiaoVien, TenGiaoVien FROM GIAOVIEN";
            return GetTable(sql);
        }

        /// <summary>
        /// Thêm hồ sơ giáo viên
        /// </summary>
        /// <param name="giaoVien">GiaoVienDTO</param>
        /// <returns></returns>
        public bool Them_HoSo_GiaoVien(GiaoVienDTO giaoVien)
        {
            string sql = string.Format("INSERT INTO GIAOVIEN VALUES ('{0}',N'{1}')", giaoVien.MaGiaoVien,
                                       giaoVien.TenGiaoVien);
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Xóa hồ sơ giáo viên
        /// </summary>
        /// <param name="maGiaoVien">string: mã giáo viên</param>
        /// <returns></returns>
        public bool Xoa_HoSo_GiaoVien(string maGiaoVien)
        {
            string sql = "\nDELETE FROM NGUOIDUNG WHERE MaND = '" + maGiaoVien + "'\n";
            sql += "UPDATE LOP SET MaGiaoVien = NULL WHERE MaGiaoVien = '" + maGiaoVien + "'\n";
            sql += "DELETE FROM GIAOVIEN WHERE MaGiaoVien ='" + maGiaoVien + "'\n";
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Cập nhật hồ sơ giáo viên
        /// </summary>
        /// <param name="giaoVien">GiaoVienDTO</param>
        /// <returns></returns>
        public bool CapNhat_GiaoVien(GiaoVienDTO giaoVien)
        {
            string sql = string.Format("UPDATE GIAOVIEN SET TenGiaoVien = N'{0}' "
                                       + "WHERE MaGiaoVien='{1}' ", giaoVien.TenGiaoVien, giaoVien.MaGiaoVien);
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Kiểm tra tồn tại hồ sơ giáo viên
        /// </summary>
        /// <param name="maGiaoVien">string: mã giáo viên</param>
        /// <returns></returns>
        public bool KiemTonTai_GiaoVien(string maGiaoVien)
        {
            string sql = string.Format("SELECT COUNT(*) as SoLuong FROM GIAOVIEN WHERE MaGiaoVien = '{0}'", maGiaoVien);
            return Convert.ToInt32(ExecuteScalar(sql)) == 1;
        }

        /// <summary>
        /// Lấy mã cuối cùng (MaGiaoVien) - Bảng GiaoVien
        /// </summary>
        /// <returns>String: Mã cuối cùng</returns>
        public string Lay_MaCuoiCung()
        {
            return GetLastID("GIAOVIEN", "MaGiaoVien");
        }
    }
}
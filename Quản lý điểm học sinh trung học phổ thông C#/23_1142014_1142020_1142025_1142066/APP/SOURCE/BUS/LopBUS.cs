using System.Collections.Generic;
using System.Data;
using QLHS.DAL;
using QLHS.DTO;

namespace QLHS.BUS
{
    public class LopBUS
    {
        private readonly LopDAL _lopDAL;

        public LopBUS()
        {
            _lopDAL = new LopDAL();
        }

        /// <summary>
        /// Lấy DataTable Lớp từ mã năm và khối
        /// </summary>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <param name="maKhoi">String: mã khối</param>
        /// <returns>DataTable:</returns>
        public DataTable LayDTLop_MaNam_MaKhoi(string maNamHoc, string maKhoi)
        {
            return _lopDAL.LayDTLop_MaNam_MaKhoi(maNamHoc, maKhoi);
        }

        /// <summary>
        /// Lấy list Lớp từ mã năm và khối
        /// </summary>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <param name="maKhoi">String: mã khối</param>
        /// <returns>List:</returns>
        public IEnumerable<LopDTO> LayListLop_MaNam_MaKhoi(string maNamHoc, string maKhoi)
        {
            return _lopDAL.LayListLop_MaNam_MaKhoi(maNamHoc, maKhoi);
        }

        /// <summary>
        /// Lấy tên giáo viên chủ nhiệm
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>String: Tên giáo viên</returns>
        public string LayTenGiaoVien_MaLop(string maLop)
        {
            return _lopDAL.LayTen_GiaoVien_MaLop(maLop);
        }

        /// <summary>
        /// Kiểm tra tồn tại mã lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>Bool</returns>
        public bool KiemTraTonTai_MaLop(string maLop)
        {
            return _lopDAL.KiemTra_TonTaiMaLop(maLop);
        }

        /// <summary>
        /// Thêm lớp mới
        /// </summary>
        /// <param name="lop">LopDTO</param>
        /// <returns></returns>
        public bool Them_Lop(LopDTO lop)
        {
            return _lopDAL.Them_HoSo_Lop(lop);
        }

        /// <summary>
        /// Cập nhật giáo viên chủ nhiệm
        /// </summary>
        /// <param name="lop">LopDTO</param>
        /// <returns></returns>
        public bool CapNhat_GiaoVienCN_Lop(LopDTO lop)
        {
            return _lopDAL.CapNhat_GiaoVienCN_Lop(lop);
        }

        /// <summary>
        /// Xóa lớp từ mã lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns></returns>
        public bool Xoa_Lop(string maLop)
        {
            return _lopDAL.Xoa_HoSo_Lop(maLop);
        }
    }
}
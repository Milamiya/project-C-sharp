using System.Data;
using QLHS.DAL;
using QLHS.DTO;

namespace QLHS.BUS
{
    public class MonHocBUS
    {
        private readonly MonHocDAL _monHocDAL;

        public MonHocBUS()
        {
            _monHocDAL = new MonHocDAL();
        }


        /// <summary>
        /// Lấy Datatable danh sách môn học
        /// </summary>
        /// <returns>Datatable</returns>
        public DataTable LayDT_DanhSach_MonHoc()
        {
            return _monHocDAL.LayDT_DanhSach_MonHoc();
        }

        /// <summary>
        /// Lấy DataTable môn học đang sử dụng
        /// </summary>
        /// <param name="layDangSuDung">Đang sử dụng?</param>
        /// <returns></returns>
        public DataTable LayDT_DanhSach_MonHoc(bool layDangSuDung)
        {
            return _monHocDAL.LayDT_DanhSach_MonHoc(layDangSuDung);
        }


        /// <summary>
        /// Xóa môn học
        /// </summary>
        /// <param name="maMonHoc">string: Mã môn học</param>
        /// <returns></returns>
        public bool Xoa_MonHoc(string maMonHoc)
        {
            return _monHocDAL.Xoa_MonHoc(maMonHoc);
        }

        /// <summary>
        /// Thêm môn học
        /// </summary>
        /// <param name="monHoc">MonHocDTO</param>
        /// <returns></returns>
        public bool Them_MonHoc(MonHocDTO monHoc)
        {
            return _monHocDAL.Them_MonHoc(monHoc);
        }

        /// <summary>
        /// Cập nhật môn học
        /// </summary>
        /// <param name="monHoc">MonHocDTO</param>
        /// <returns></returns>
        public bool CapNhat_MonHoc(MonHocDTO monHoc)
        {
            return _monHocDAL.CapNhat_MonHoc(monHoc);
        }

        /// <summary>
        /// Kiểm tra tồn tại môn học
        /// </summary>
        /// <param name="maMonHoc">string: Mã môn học</param>
        /// <returns></returns>
        public bool KiemTraTonTai_MonHoc(string maMonHoc)
        {
            return _monHocDAL.KiemTraTonTai_MonHoc(maMonHoc);
        }
    }
}
using System.Data;
using QLHS.DAL;

namespace QLHS.BUS
{
    public class LoaiNguoiDungBUS
    {
        private readonly LoaiNguoiDungDAL _loaiNguoiDungDAL;

        public LoaiNguoiDungBUS()
        {
            _loaiNguoiDungDAL = new LoaiNguoiDungDAL();
        }

        /// <summary>
        /// Lấy datatable loại người dùng
        /// </summary>
        /// <returns></returns>
        public DataTable LayDT_LoaiNguoiDung()
        {
            return _loaiNguoiDungDAL.Lay_DT_LoaiNguoiDung();
        }
    }
}
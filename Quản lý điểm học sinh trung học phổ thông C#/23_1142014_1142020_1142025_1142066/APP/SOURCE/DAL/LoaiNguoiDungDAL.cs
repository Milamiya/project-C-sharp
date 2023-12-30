using System.Data;

namespace QLHS.DAL
{
    public class LoaiNguoiDungDAL : ConnectData
    {
        /// <summary>
        /// Lấy datatable loại người dùng
        /// </summary>
        /// <returns></returns>
        public DataTable Lay_DT_LoaiNguoiDung()
        {
            return GetTable("SELECT MaLoaiND,TenLoaiND FROM LOAINGUOIDUNG");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using QLHS.DAL;
using QLHS.DTO;

namespace QLHS.BUS
{
    public class NamHocBUS
    {
        private readonly NamHocDAL _namHocDAL;

        public NamHocBUS()
        {
            _namHocDAL = new NamHocDAL();
        }

        /// <summary>
        /// Lấy list năm học
        /// </summary>
        /// <returns>List</returns>
        public List<NamHocDTO> LayList_NamHoc()
        {
            return _namHocDAL.LayList_NamHoc();
        }

        /// <summary>
        /// Lấy DataTable năm học
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDTNamHoc()
        {
            return _namHocDAL.LayDT_NamHoc();
        }

        /// <summary>
        /// Lấy DataTable năm học có mã năm học là tham  số truyền vào
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDTNamHoc(string maNamHoc)
        {
            return _namHocDAL.LayDT_NamHoc(maNamHoc);
        }

        /// <summary>
        /// Lấy DataTable năm học làm năm hiện tại=năm học mới
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_NamHocHienTai()
        {
            return _namHocDAL.LayDTNamHocHienTai();
        }

        /// <summary>
        /// Lấy DataTable năm học cần chuyển lên lớp khi kết thúc năm học
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_NamHocTruoc()
        {
            return _namHocDAL.LayDT_NamHocTruoc();
        }

        /// <summary>
        /// Lấy datatable thêm mới trong 10 năm gần đây
        /// </summary>
        /// <returns></returns>
        public DataTable LayDT_NamHoc_ThemMoi()
        {
            var tbNH = new DataTable();
            tbNH.Columns.Add("MaNamHoc");
            tbNH.Columns.Add("TenNamHoc");
            for (int i = DateTime.Now.Year; i >= DateTime.Now.Year - 9; i--)
            {
                DataRow dr = tbNH.NewRow();
                int mstart = (i%100), msend = ((i + 1)%100);
                dr["MaNamHoc"] = "NH" + (mstart < 10 ? "0" + mstart.ToString() : mstart.ToString())
                                 + (msend < 10 ? "0" + msend.ToString() : msend.ToString());
                dr["TenNamHoc"] = i.ToString() + " - " + (i + 1).ToString();
                tbNH.Rows.Add(dr);
            }
            return tbNH;
        }

        /// <summary>
        /// Kiểm tra tồn tại 1 năm học
        /// </summary>
        /// <param name="maNamHoc">string: mã năm học</param>
        /// <returns></returns>
        public bool KiemTraTonTai_NamHoc(string maNamHoc)
        {
            return _namHocDAL.KiemTraTonTai_MaNamHoc(maNamHoc);
        }

        /// <summary>
        /// Thêm 1 năm học mới (không kiểm tra trùng mã năm học cũ)
        /// </summary>
        /// <param name="namHoc">NamHocDTO</param>
        /// <returns></returns>
        public bool Them_NamHoc(NamHocDTO namHoc)
        {
            return _namHocDAL.Them_NamHoc(namHoc);
        }

        /// <summary>
        /// Xóa 1 năm học (xóa toàn bộ thông tin liên quan đến năm học đó)
        /// </summary>
        /// <param name="maNamHoc">string: mã năm học</param>
        /// <returns></returns>
        public bool Xoa_NamHoc(string maNamHoc)
        {
            return _namHocDAL.Xoa_NamHoc(maNamHoc);
        }

        /// <summary>
        /// Lấy tên năm học
        /// </summary>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <returns></returns>
        public string LayTenNamHoc_MaNamHoc(string maNamHoc)
        {
            return _namHocDAL.LayTenNamHoc(maNamHoc);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;

namespace QLHS.DAL
{
    public class NamHocDAL : ConnectData
    {
        /// <summary>
        /// Lấy list năm học
        /// </summary>
        /// <returns>List: NamHocDTO</returns>
        public List<NamHocDTO> LayList_NamHoc()
        {
            string sql = "SELECT MaNamHoc, TenNamHoc FROM NAMHOC";
            var listNamHoc = new List<NamHocDTO>();
            NamHocDTO namHoc;

            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                namHoc = new NamHocDTO(Convert.ToString(dr["MaNamHoc"]),
                                       Convert.ToString(dr["TenNamHoc"]));
                listNamHoc.Add(namHoc);
            }
            CloseConnect();

            return listNamHoc;
        }

        /// <summary>
        /// Lấy DataTable năm học
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_NamHoc()
        {
            DataTable dbNamHoc =
                GetTable("Select MaNamHoc, TenNamHoc FROM NAMHOC "
                         + "WHERE MaNamHoc NOT IN (SELECT GiaTri FROM QUYDINH WHERE Khoa = 'MaNamHocHT') "
                         + "ORDER BY MaNamHoc ASC ");

            DataRow drNamHocHienTai = GetFirstDataRow("SELECT MaNamHoc, TenNamHoc FROM NAMHOC "
                                                      +
                                                      "WHERE MaNamHoc IN (SELECT GiaTri FROM QUYDINH WHERE Khoa = 'MaNamHocHT') ");

            DataRow drAdd = dbNamHoc.NewRow();
            drAdd["MaNamHoc"] = drNamHocHienTai["MaNamHoc"];
            drAdd["TenNamHoc"] = drNamHocHienTai["TenNamHoc"];

            dbNamHoc.Rows.InsertAt(drAdd, 0);

            return dbNamHoc;
        }

        /// <summary>
        /// Lấy DataTable năm học có mã năm học là tham  số truyền vào
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_NamHoc(string maNamHoc)
        {
            string sql = string.Format("SELECT MaNamHoc, TenNamHoc FROM NAMHOC WHERE MaNamHoc='{0}'", maNamHoc);
            return GetTable(sql);
        }

        /// <summary>
        /// Lấy DataTable năm học làm năm hiện tại=năm học mới
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDTNamHocHienTai()
        {
            string sql =
                "SELECT MaNamHoc,TenNamHoc FROM NAMHOC WHERE MaNamHoc in (select GiaTri from QUYDINH where Khoa='MaNamHocHT') ";
            return GetTable(sql);
        }

        /// <summary>
        /// Lấy DataTable năm học cần chuyển lên lớp khi kết thúc năm học
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_NamHocTruoc()
        {
            string sql =
                "SELECT MaNamHoc,TenNamHoc FROM NAMHOC WHERE substring(TenNamHoc,8,4) = (select substring(TenNamHoc,1,4) as TenNamHoc from NAMHOC WHERE MaNamHoc in (select GiaTri from QUYDINH where Khoa='MaNamHocHT')) ";
            return GetTable(sql);
        }

        /// <summary>
        /// Kiểm tra tồn tại 1 năm học
        /// </summary>
        /// <param name="maNamHoc">string: mã năm học</param>
        /// <returns></returns>
        public bool KiemTraTonTai_MaNamHoc(string maNamHoc)
        {
            string sql = "SELECT * FROM NAMHOC WHERE MaNamHoc = '" + maNamHoc + "'";
            return GetTable(sql).Rows.Count > 0;
        }

        /// <summary>
        /// Thêm 1 năm học mới (không kiểm tra trùng mã năm học cũ)
        /// </summary>
        /// <param name="namHoc">NamHocDTO</param>
        /// <returns></returns>
        public bool Them_NamHoc(NamHocDTO namHoc)
        {
            string sql = "INSERT INTO NAMHOC (MaNamHoc,TenNamHoc) VALUES ('" + namHoc.MaNamHoc + "','" +
                         namHoc.TenNamHoc + "')";
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Xóa 1 năm học (xóa toàn bộ thông tin liên quan đến năm học đó)
        /// </summary>
        /// <param name="maNamHoc">string: mã năm học</param>
        /// <returns></returns>
        public bool Xoa_NamHoc(string maNamHoc)
        {
            var lopDAL = new LopDAL();
            lopDAL.Xoa_HoSo_Lop_Nam(maNamHoc);
            return ExecuteQuery("DELETE FROM NAMHOC WHERE MaNamHoc = '" + maNamHoc + "'") > 0;
        }

        /// <summary>
        /// Lấy tên năm học
        /// </summary>
        /// <param name="maNamHoc">String: Mã năm học</param>
        /// <returns></returns>
        public string LayTenNamHoc(string maNamHoc)
        {
            return Convert.ToString(ExecuteScalar("SELECT TenNamHoc FROM NAMHOC WHERE MaNamHoc = '" + maNamHoc + "'"));
        }
    }
}
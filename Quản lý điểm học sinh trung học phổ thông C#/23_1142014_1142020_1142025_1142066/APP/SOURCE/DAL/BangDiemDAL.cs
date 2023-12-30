using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;

namespace QLHS.DAL
{
    public class BangDiemDAL : ConnectData
    {
        private readonly MonHocDAL _monHocDAL;

        public BangDiemDAL()
        {
            _monHocDAL = new MonHocDAL();
        }

        /// <summary>
        /// Lấy bảng điểm môn học theo học kỳ của lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <param name="maHocKy">String: Mã học kỳ</param>
        /// <param name="maMonHoc">String: Mã môn học</param>
        /// <returns></returns>
        public DataTable LayBangDiem_MonHoc_HocKy_Lop(string maLop, string maHocKy, string maMonHoc)
        {
            if (maLop == "" || maHocKy == "" || maMonHoc == "")
                return null;
            // Trước khi lấy, kiểm tra xem đã khởi tạo hay chưa? Nếu chưa thì khởi tạo
            string sql = string.Format("INSERT INTO BANGDIEM(MaHocSinh,MaHocKy,MaMonHoc,MaLop) "
                                       + "SELECT distinct pl.MaHocSinh, '{0}' MaHocKy, '{2}' MaMonHoc, pl.MaLop "
                                       + "FROM PHANLOP pl LEFT JOIN BANGDIEM bd ON pl.MaLop = bd.MaLop "
                                       + "WHERE pl.MaLop = '{1}' "
                                       + "AND pl.MaHocSinh NOT IN "
                                       + "(select MaHocSinh FROM BANGDIEM "
                                       + "WHERE MaLop = '{1}' AND MaHocKy = '{0}' AND MaMonHoc = '{2}')",
                                       maHocKy, maLop, maMonHoc);
            ExecuteQuery(sql);
            // Lấy bảng điểm
            sql = "\nSELECT bd.*, pl.STT, hs.TenHocSinh "
                  +
                  "FROM BANGDIEM bd, PHANLOP pl, HOCSINH hs WHERE hs.MaHocSinh = pl.MaHocSinh AND bd.MaHocSinh = pl.MaHocSinh AND pl.MaLop = bd.MaLop "
                  + "AND bd.MaLop = '" + maLop + "' AND bd.MaHocKy='" + maHocKy + "' AND bd.MaMonHoc = '" + maMonHoc +
                  "' "
                  + "ORDER BY pl.STT ASC";
            return GetTable(sql);
        }

        /// <summary>
        /// Lưu bảng điểm 1 môn học / 1 học sinh / 1 học kỳ / 1 lớp / 1 năm học
        /// </summary>
        /// <param name="bd">BangDiemDTO</param>
        /// <returns>Bool</returns>
        public bool LuuBangDiem_MonHoc_HocSinh_HocKy(BangDiemDTO bd)
        {
            const int diemNull = -1;
            string sql = string.Format("UPDATE BANGDIEM SET DM_1 = {1}, DM_2 = {2}, D15_1 = {3}, D15_2 = {4}, "
                                       + "D15_3 = {5}, D15_4 = {6}, D1T_1 = {7}, D1T_2 = {8}, DThi = {9}, DTB = {10} "
                                       + "WHERE MaHocSinh = '{0}' AND MaHocKy = '{11}' AND MaLop = '{12}'",
                                       bd.HocSinh.MaHocSinh,
                                       (bd.DM_1 == diemNull) ? "NULL" : bd.DM_1.ToString(),
                                       (bd.DM_2 == diemNull) ? "NULL" : bd.DM_2.ToString(),
                                       (bd.D15_1 == diemNull) ? "NULL" : bd.D15_1.ToString(),
                                       (bd.D15_2 == diemNull) ? "NULL" : bd.D15_2.ToString(),
                                       (bd.D15_3 == diemNull) ? "NULL" : bd.D15_3.ToString(),
                                       (bd.D15_4 == diemNull) ? "NULL" : bd.D15_4.ToString(),
                                       (bd.D1T_1 == diemNull) ? "NULL" : bd.D1T_1.ToString(),
                                       (bd.D1T_2 == diemNull) ? "NULL" : bd.D1T_2.ToString(),
                                       (bd.DThi == diemNull) ? "NULL" : bd.DThi.ToString(),
                                       (bd.DTB == diemNull) ? "NULL" : bd.DTB.ToString(),
                                       bd.MaHocKy, bd.LopDTO.MaLop);
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Xóa bảng điểm 1 môn học / 1 học sinh / 1 học kỳ / 1 lớp / 1 năm học
        /// </summary>
        /// <param name="bd">BangDiemDTO</param>
        /// <returns>bool</returns>
        public bool XoaBangDiem_MonHoc_HocSinh_HocKy(BangDiemDTO bd)
        {
            string sql = string.Format("UPDATE BANGDIEM SET DM_1 = NULL, DM_2 =  NULL, D15_1 = NULL, D15_2 =  NULL, "
                                       +
                                       "D15_3 = NULL, D15_4 = NULL, D1T_1 =  NULL, D1T_2 =  NULL, DThi =  NULL, DTB =  NULL "
                                       + "WHERE MaHocSinh = '{0}' "
                                       + "AND MaLop = '{1}' AND MaHocKy = {2} AND MaMonHoc = '{3}'",
                                       bd.HocSinh.MaHocSinh, bd.LopDTO.MaLop, bd.MaHocKy, bd.MonHoc.MaMonHoc);
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Xóa bảng điểm của 1 học sinh thuộc 1 lớp nào đó
        /// </summary>
        /// <param name="maHocSinh">String: Mã học sinh</param>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns></returns>
        public bool XoaBangDiem_HocSinh_Lop(string maHocSinh, string maLop)
        {
            return
                ExecuteQuery("DELETE FROM BANGDIEM WHERE MaHocSinh = '" + maHocSinh + "' AND MaLop = '" + maLop + "'") >
                0;
        }

        /// <summary>
        /// Cập nhật lớp mới cho bảng điểm của 1 học sinh
        /// </summary>
        /// <param name="maHocSinh">String: Mã học sinh</param>
        /// <param name="maLopCu">String: Mã lớp cũ</param>
        /// <param name="maLopMoi">String: Mã lớp mới</param>
        /// <returns></returns>
        public bool CapNhat_BangDiem_HocSinh_LopMoi(string maHocSinh, string maLopCu, string maLopMoi)
        {
            return ExecuteQuery("UPDATE BANGDIEM SET MaLop = '" + maLopMoi
                                + "' WHERE MaLop = '" + maLopCu + "' AND MaHocSinh = '" + maHocSinh + "'") > 0;
        }


        /// <summary>
        /// Lấy bảng điểm môn học học kỳ của 1 lớp
        /// </summary>
        /// <param name="maLop">String: mã lớp</param>
        /// <param name="maMonHoc">String: mã môn học</param>
        /// <param name="maHocKy">String: mã học kỳ</param>
        /// <returns>DataTable</returns>
        public DataTable LayBangDiem_MonHoc_Lop(string maLop, string maMonHoc, string maHocKy)
        {
            string sql = string.Format("SELECT * FROM BANGDIEM bd LEFT JOIN PHANLOP pl "
                                       + "ON bd.MaHocSinh = pl.MaHocSinh AND bd.MaLop = pl.MaLop WHERE "
                                       + "MaMonHoc = '{0}' AND pl.MaLop = '{1}' AND bd.DTB IS NOT NULL "
                                       + "AND MaHocKy = '{2}'", maMonHoc, maLop, maHocKy);
            return GetTable(sql);
        }

        /// <summary>
        /// Lấy điểm môn học theo học kỳ của lớp
        /// </summary>
        /// <param name="maMonHoc">string: Mã môn học</param>
        /// <param name="maKhoi">string: Mã khối</param>
        /// <param name="maHocKy">string: Mã học kỳ</param>
        /// <param name="maNamHoc">string: Mã năm học</param>
        /// <returns></returns>
        public DataTable LayBangDiem_MonHoc_HocKy_KhoiLop(string maMonHoc, string maKhoi, string maHocKy,
                                                          string maNamHoc)
        {
            string sql =
                string.Format("SELECT TenNamHoc, MaHocKy, LEFT(lop.MaLop,2) as MaKhoi, lop.MaNamHoc, TenMonHoc, TenLop, TenGiaoVien, SiSo, count(*) as SoLuongDat, ((cast(count(lop.MaLop) as real) )/SiSo) as TyLe"
                              +
                              " FROM BANGDIEM bdiem, HOCSINH hsinh, GIAOVIEN gvien, LOP lop, PHANLOP plop, MONHOC mhoc, NAMHOC namhoc "
                              + " WHERE hsinh.MaHocSinh=bdiem.MaHocSinh AND gvien.MaGiaoVien=lop.MaGiaoVien "
                              + " AND mhoc.MaMonHoc=bdiem.MaMonHoc AND namhoc.MaNamHoc=lop.MaNamHoc "
                              + " AND DTB>=5 "
                              + " AND lop.MaLop=plop.MaLop AND plop.MahocSinh=hsinh.MaHocSinh "
                              + " AND bdiem.MaMonHoc='" + maMonHoc + "' "
                              + " AND MaHocKy='" + maHocKy + "' AND LEFT(lop.MaLop,2)='" + maKhoi + "' "
                              + " AND RIGHT(lop.MaLop,6)='" + maNamHoc + "' "
                              +
                              " GROUP BY lop.Malop, TenNamHoc, MaHocKy, lop.MaNamHoc, TenMonHoc, TenLop, TenGiaoVien, SiSo ");
            return GetTable(sql);
        }

        /// <summary>
        /// Lấy bảng điểm học kỳ của 1 học sinh
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <param name="maHocSinh">String: Mã học sinh</param>
        /// <param name="maHocKy">String: Mã học kỳ</param>
        /// <returns>DataTable</returns>
        public DataTable LayBangDiem_HocKy_HocSinh(string maLop, string maHocSinh, string maHocKy)
        {
            List<MonHocDTO> listMH = _monHocDAL.LayList_MonHoc();

            string sql = "SELECT b.*, m.HeSo FROM MONHOC m LEFT JOIN BANGDIEM b ON m.MaMonHoc = b.MaMonHoc "
                         + "WHERE m.TrangThai = 1 AND b.MaHocKy = " + maHocKy + " "
                         + "AND  b.MaLop = '" + maLop + "' AND MaHocSinh = '" + maHocSinh + "'";
            DataTable tbBangDiem = GetTable(sql);

            // Trường hợp bảng điểm đã nhập đủ
            if (tbBangDiem.Rows.Count == listMH.Count)
                return tbBangDiem;
            // Trường hợp bảng điểm chưa đủ ta phải add thêm các môn học còn thiếu
            sql = "SELECT m.MaMonHoc FROM MONHOC m "
                  + "WHERE  m.TrangThai = 1 AND m.MaMonHoc NOT IN "
                  + "(SELECT b.MaMonHoc FROM BANGDIEM b WHERE b.MaHocKy = " + maHocKy + " "
                  + "AND b.MaLop = '" + maLop + "' AND b.MaHocSinh = '" + maHocSinh + "')";
            var listMaMHBoSung = new List<string>();
            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                listMaMHBoSung.Add(dr["MaMonHoc"].ToString());
            }
            CloseConnect();

            foreach (string bDiemMH in listMaMHBoSung)
            {
                DataRow drbDiemBsung = tbBangDiem.NewRow();
                drbDiemBsung["MaHocSinh"] = maHocSinh;
                drbDiemBsung["MaLop"] = maLop;
                drbDiemBsung["MaHocKy"] = maHocKy;
                drbDiemBsung["MaMonHoc"] = bDiemMH;

                tbBangDiem.Rows.Add(drbDiemBsung);
            }
            return tbBangDiem;
        }
    }
}
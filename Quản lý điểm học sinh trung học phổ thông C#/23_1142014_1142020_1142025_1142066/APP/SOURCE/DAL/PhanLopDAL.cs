using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;

namespace QLHS.DAL
{
    public class PhanLopDAL : ConnectData
    {
        /// <summary>
        /// Lấy hồ sơ phân lớp học sinh trong năm cũ có tồn tại trong năm mới chưa
        /// </summary>
        /// <param name="maHocSinh"></param>
        /// <param name="maKhoi"></param>
        /// <param name="maNamHoc"></param>
        /// <returns>PhanLopDTO</returns>
        public PhanLopDTO Lay_PhanLop_HocSinh_Khoi_NamHoc(string maHocSinh, string maKhoi, string maNamHoc)
        {
            string khoiIn;
            switch (maKhoi)
            {
                case "10":
                    khoiIn = "(10,11)";
                    break;
                case "11":
                    khoiIn = "(11,12)";
                    break;
                default:
                    khoiIn = "(12)";
                    break;
            }
            string sql = "select a.STT, a.MaHocSinh,b.TenLop, b.MaLop, b.TenLop, h.TenHocSinh from PHANLOP as a, LOP as b, HOCSINH h "
                         + "where a.MaLop=b.MaLop and h.MaHocSinh = a.MaHocSinh "
                         + "and a.MaHocSinh='" + maHocSinh + "' and b.MaNamHoc= '"
                         + maNamHoc + "' and b.MaKhoiLop in " + khoiIn + "  ";
            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            PhanLopDTO phanlop = null;
            while (dr.Read())
            {
                phanlop = new PhanLopDTO
                              {
                                  MaHocSinh = Convert.ToString(dr["MaHocSinh"]),
                                  TenHocSinh = Convert.ToString(dr["TenHocSinh"]),
                                  STT = Convert.ToInt32(dr["STT"]),
                                  MaLop = Convert.ToString(dr["MaLop"]),
                                  TenLop = Convert.ToString(dr["TenLop"])
                              };
                break;
            }

            CloseConnect();
            return phanlop;
        }

        public bool KiemTraTonTai_STT(int stt, string maLop)
        {
            string sql = "SELECT STT FROM PHANLOP WHERE MaLop = '" + maLop + "' AND STT = " + stt;
            return GetTable(sql).Rows.Count > 0;
        }

        public int Lay_STT_TiepTheo(string maLop)
        {
            string sql = "SELECT STT FROM PHANLOP WHERE MaLop = '" + maLop + "' ORDER BY STT DESC";
            return Convert.ToInt32(ExecuteScalar(sql)) + 1;
        }

        public int Lay_STT_HienTai(string maHocSinh, string maLop)
        {
            string sql = "SELECT STT FROM PHANLOP WHERE MaLop = '" + maLop + "' AND MaHocSinh = '" + maHocSinh + "'";
            return Convert.ToInt32(ExecuteScalar(sql));
        }

        /// <summary>
        /// Kiểm tra xem mã học sinh đã  phân lớp hay chưa
        /// </summary>
        /// <param name="maHocSinh">String: mã học sinh</param>
        /// <returns>Bool</returns>
        public bool KiemTra_TonTai_HocSinh_PhanLop(string maHocSinh)
        {
            string sql = "SELECT * FROM PHANLOP WHERE MaHocSinh = '" + maHocSinh + "'";
            return GetTable(sql).Rows.Count > 0;
        }

        /// <summary>
        /// Đếm sỉ số của 1 lớp
        /// </summary>
        /// <param name="maLop">String: Mã lớp</param>
        /// <returns>Int</returns>
        public int Dem_SiSo_Lop(string maLop)
        {
            string sql = "SELECT count(*) FROM PHANLOP WHERE MaLop = '" + maLop + "'";
            return Convert.ToInt32(ExecuteScalar(sql));
        }

        /// <summary>
        /// Cập nhật STT cho cả lớp
        /// </summary>
        /// <param name="maLop">String: mã lớp</param>
        /// <param name="arrayList">ArrayList: ArrayList HocSinhChuanHoaTenDTO</param>
        /// <returns>Bool</returns>
        public bool CapNhat_STT_Lop(string maLop, ArrayList arrayList)
        {
            string sql = "";
            foreach (HocSinhChuanHoaTenDTO hs in arrayList)
            {
                sql += "\nUPDATE PHANLOP SET STT = " + hs.STT + " WHERE MaHocSinh = '" + hs.MaHocSinh +
                       "' AND MaLop = '" + maLop + "'";
            }
            return ExecuteQuery(sql) > 0;
        }

        public bool ChuyenLop_HocSinh(Dictionary<string, string> dsHocsinh, string maLopMoi)
        {
            if (dsHocsinh.Count == 0)
                return false;

            string sql = "INSERT INTO PHANLOP(STT,MaHocSinh,MaLop) ";
            string union = "";
            foreach (var item in dsHocsinh)
            {
                sql += union + "\n SELECT " + 0 + ",'" + item.Key + "','" + maLopMoi + "' ";
                union = " UNION ";
            }
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Thay đổi lớp mới cho học sinh 
        /// </summary>
        /// <param name="maHocSinh">String: mã học sinh</param>
        /// <param name="maLopCu">String: Mã lớp cũ</param>
        /// <param name="maLopMoi">String: Mã lớp mới</param>
        /// <returns></returns>
        public bool ThayDoi_LopMoi_HocSinh(string maHocSinh, string maLopCu, string maLopMoi)
        {
            return ExecuteQuery("UPDATE PHANLOP SET MaLop ='" + maLopMoi + "' WHERE MaLop = '" +
                                maLopCu + "' AND MaHocSinh = '" + maHocSinh + "'") > 0;
        }

        public bool Xoa_DSHocSinh_Lop(Dictionary<string, string> dsHocsinhchon, string maLop)
        {
            string sql = "";
            foreach (var item in dsHocsinhchon)
            {
                sql += "\nDELETE FROM PHANLOP WHERE MaHocSinh='" + item.Key + "' AND MaLop='" + maLop + "' ";
            }
            return ExecuteQuery(sql) > 0;
        }

        public DataTable LayDT_Lop_MaKhoi_KhacMaLop_MaNam(string maNamHoc, string maKhoi, string maLop)
        {
            string sql = string.Format("SELECT MaLop, TenLop from Lop where "
                                       + " MaKhoiLop = '{0}' AND MaNamHoc = '{1}' and MaLop not in('{2}') ", maKhoi,
                                       maNamHoc, maLop);
            return GetTable(sql);
        }

        public bool KiemTraTonTao_HSinh_TrongLop_ChuyenLop(string maHocSinh, string maLop)
        {
            string sql = "select pl.MaHocSinh from PhanLop pl,HocSinh hs where pl.MaHocSinh='" + maHocSinh +
                         "' and pl.MaLop='" + maLop + "' and pl.MaHocSinh=hs.MaHocSinh";
            return ExecuteScalar(sql) != null;
        }
    }
}
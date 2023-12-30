using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;

namespace QLHS.DAL
{
    public class MonHocDAL : ConnectData
    {
        /// <summary>
        /// Thêm môn học
        /// </summary>
        /// <param name="monHocDTO"></param>
        /// <returns></returns>
        public bool Them_MonHoc(MonHocDTO monHocDTO)
        {
            string sql = string.Format("INSERT INTO MONHOC VALUES ('{0}',N'{1}',{2},{3},{4})",
                                       monHocDTO.MaMonHoc, monHocDTO.TenMonHoc, monHocDTO.SoTiet,
                                       monHocDTO.HeSo, monHocDTO.TrangThai);
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Xóa môn học
        /// </summary>
        /// <param name="maMonHoc">string: Mã môn học</param>
        /// <returns></returns>
        public bool Xoa_MonHoc(string maMonHoc)
        {
            string bd = "SELECT count(*) as SoLuong FROM BANGDIEM WHERE MaMonHoc='" + maMonHoc + "'";
            int count = Convert.ToInt32(ExecuteScalar(bd));
            if (count > 0)
            {
                return false;
            }
            string sql = "DELETE FROM MONHOC WHERE MaMonHoc ='" + maMonHoc + "'\n";
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Cập nhật môn học
        /// </summary>
        /// <returns></returns>
        public bool CapNhat_MonHoc(MonHocDTO monHocDTO)
        {
            string sql = string.Format("UPDATE MONHOC SET TenMonHoc = N'{0}', SoTiet={1}, HeSo={2}, TrangThai={3} "
                                       + "WHERE MaMonHoc='{4}' ", monHocDTO.TenMonHoc, monHocDTO.SoTiet,
                                       monHocDTO.HeSo, monHocDTO.TrangThai, monHocDTO.MaMonHoc);
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Kiểm tra tồn tại môn học
        /// </summary>
        /// <param name="maMonHoc">string: Mã môn học</param>
        /// <returns></returns>
        public bool KiemTraTonTai_MonHoc(string maMonHoc)
        {
            string sql = string.Format("SELECT count(*) as SoLuong FROM MonHoc WHERE MaMonHoc = '{0}'", maMonHoc);
            return Convert.ToInt32(ExecuteScalar(sql)) == 1;
        }


        /// <summary>
        /// Lấy Datatable danh sách môn học
        /// </summary>
        /// <param name="chiLayCacMonDangHoc">True: Chỉ lấy các môn đang học, False: Lấy tất cả 13 môn</param>
        /// <returns>Datatable</returns>
        public DataTable LayDT_DanhSach_MonHoc(bool chiLayCacMonDangHoc = true)
        {
            string sql;
            sql = string.Format(chiLayCacMonDangHoc
                                    ? "SELECT MaMonHoc, TenMonHoc, SoTiet, HeSo FROM MONHOC WHERE TrangThai = 1 ORDER BY TenMonHoc ASC"
                                    : "SELECT MaMonHoc, TenMonHoc, SoTiet, HeSo, TrangThai FROM MONHOC ORDER BY TenMonHoc");

            return GetTable(sql);
        }

        public MonHoc_HeSoDTO LayDTO_HeSoMonHoc()
        {
            string sql = "SELECT MaMonHoc, HeSo FROM MONHOC WHERE TrangThai = 1";
            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            var dsHeSo = new MonHoc_HeSoDTO();
            while (dr.Read())
            {
                double heso = Convert.ToDouble(dr["HeSo"]);
                switch (dr["MaMonHoc"].ToString())
                {
                    case "toan":
                        dsHeSo.toan = heso;
                        break;
                    case "ly":
                        dsHeSo.ly = heso;
                        break;
                    case "hoa":
                        dsHeSo.hoa = heso;
                        break;
                    case "sinh":
                        dsHeSo.sinh = heso;
                        break;
                    case "nvan":
                        dsHeSo.nvan = heso;
                        break;
                    case "su":
                        dsHeSo.su = heso;
                        break;
                    case "dia":
                        dsHeSo.dia = heso;
                        break;
                    case "nngu":
                        dsHeSo.nngu = heso;
                        break;
                    case "tin":
                        dsHeSo.tin = heso;
                        break;
                    case "tduc":
                        dsHeSo.tduc = heso;
                        break;
                    case "gdcd":
                        dsHeSo.gdcd = heso;
                        break;
                    case "qphong":
                        dsHeSo.qphong = heso;
                        break;
                    case "cnghe":
                        dsHeSo.cnghe = heso;
                        break;
                }
            }
            CloseConnect();
            return dsHeSo;
        }

        /// <summary>
        /// Lấy danh sách môn học
        /// </summary>
        /// <param name="chiLayCacMonDangHoc">True: Chỉ lấy các môn đang học, False: Lấy tất cả 13 môn</param>
        /// <returns>List MonHocDTO</returns>
        public List<MonHocDTO> LayList_MonHoc(bool chiLayCacMonDangHoc = true)
        {
            string sql;
            if (chiLayCacMonDangHoc)
                sql =
                    string.Format(
                        "SELECT MaMonHoc, TenMonHoc, SoTiet, HeSo,TrangThai FROM MONHOC WHERE TrangThai = 1 ORDER BY TenMonHoc ASC");
            else
                sql = string.Format("SELECT MaMonHoc, TenMonHoc, SoTiet, HeSo, TrangThai FROM MONHOC ORDER BY TenMonHoc");

            OpenConnect();
            var listMonHocDTO = new List<MonHocDTO>();
            MonHocDTO monhocDTO;
            SqlDataReader dr = ExecuteReader(sql);
            while (dr.Read())
            {
                monhocDTO = new MonHocDTO();
                monhocDTO.MaMonHoc = Convert.ToString(dr["MaMonHoc"]);
                monhocDTO.TenMonHoc = Convert.ToString(dr["TenMonHoc"]);
                monhocDTO.SoTiet = Convert.ToInt16(dr["SoTiet"]);
                monhocDTO.HeSo = Convert.ToInt16(dr["HeSo"]);
                monhocDTO.TrangThai = Convert.ToInt16(dr["TrangThai"]);
                listMonHocDTO.Add(monhocDTO);
            }
            CloseConnect();
            return listMonHocDTO;
        }
    }
}
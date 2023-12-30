using System;
using System.Data.SqlClient;
using QLHS.DTO;

namespace QLHS.DAL
{
    public class QuyDinhDAL : ConnectData
    {
        /// <summary>
        /// Lấy giá trị quy định
        /// </summary>
        /// <param name="khoa">string: khóa</param>
        /// <returns>object: giá trị</returns>
        public object LayGiaTri(string khoa)
        {
            string sql = "SELECT giatri FROM QUYDINH WHERE khoa = '" + khoa + "'";
            return ExecuteScalar(sql);
        }

        /// <summary>
        /// Sửa quy định
        /// </summary>
        /// <param name="quyDinhDTO">QuyDinhDTO</param>
        /// <returns></returns>
        public bool SuaQuyDinh(QuyDinhDTO quyDinhDTO)
        {
            string sql = string.Format("UPDATE QUYDINH SET GiaTri= N'{0}' WHERE Khoa = 'DiaChiTruong'\n",
                                       quyDinhDTO.DiaChiTruong);
            sql += string.Format("UPDATE QUYDINH SET GiaTri= N'{0}' WHERE Khoa = 'MaNamHocHT'\n",
                                 quyDinhDTO.MaNamHoc);
            sql += string.Format("UPDATE QUYDINH SET GiaTri= N'{0}' WHERE Khoa = 'DiemChuan'\n",
                                 quyDinhDTO.DiemChuan);
            sql += string.Format("UPDATE QUYDINH SET GiaTri= N'{0:dd-MM-yyyy}' WHERE Khoa = 'NgayApDung'\n",
                                 quyDinhDTO.NgayApDung);
            sql += string.Format("UPDATE QUYDINH SET GiaTri= N'{0}' WHERE Khoa = 'SiSoCanTren'\n",
                                 quyDinhDTO.SiSoCanTren);
            sql += string.Format("UPDATE QUYDINH SET GiaTri= N'{0}' WHERE Khoa = 'SoLuongLop'\n",
                                 quyDinhDTO.SoLuongLop);
            sql += string.Format("UPDATE QUYDINH SET GiaTri= N'{0}' WHERE Khoa = 'TenTruong'\n",
                                 quyDinhDTO.TenTruong);
            sql += string.Format("UPDATE QUYDINH SET GiaTri= N'{0}' WHERE Khoa = 'TuoiCanDuoi'\n",
                                 quyDinhDTO.TuoiCanDuoi);
            sql += string.Format("UPDATE QUYDINH SET GiaTri= N'{0}' WHERE Khoa = 'TuoiCanTren'\n",
                                 quyDinhDTO.TuoiCanTren);
            return ExecuteQuery(sql) > 0;
        }

        /// <summary>
        /// Lấy danh sách quy định
        /// </summary>
        /// <returns></returns>
        public QuyDinhDTO LayDS_QuyDinh()
        {
            string sql = "SELECT Khoa, GiaTri FROM QuyDinh";
            OpenConnect();
            SqlDataReader dr = ExecuteReader(sql);
            var quyDinh = new QuyDinhDTO();
            while (dr.Read())
            {
                switch (Convert.ToString(dr["Khoa"]))
                {
                    case "MaNamHocHT":
                        quyDinh.MaNamHoc = Convert.ToString(dr["GiaTri"]);
                        break;
                    case "DiaChiTruong":
                        quyDinh.DiaChiTruong = Convert.ToString(dr["GiaTri"]);
                        break;
                    case "DiemChuan":
                        quyDinh.DiemChuan = Convert.ToDouble(dr["GiaTri"]);
                        break;
                    case "NgayApDung":
                        quyDinh.NgayApDung = Convert.ToDateTime(dr["GiaTri"]);
                        break;
                    case "SiSoCanTren":
                        quyDinh.SiSoCanTren = Convert.ToInt32(dr["GiaTri"]);
                        break;
                    case "SoLuongLop":
                        quyDinh.SoLuongLop = Convert.ToInt32(dr["GiaTri"]);
                        break;
                    case "TenTruong":
                        quyDinh.TenTruong = Convert.ToString(dr["GiaTri"]);
                        break;
                    case "TuoiCanDuoi":
                        quyDinh.TuoiCanDuoi = Convert.ToInt32(dr["GiaTri"]);
                        break;
                    case "TuoiCanTren":
                        quyDinh.TuoiCanTren = Convert.ToInt32(dr["GiaTri"]);
                        break;
                }
            }
            CloseConnect();
            return quyDinh;
        }
    }
}
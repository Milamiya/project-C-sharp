using QLHS.DTO;

namespace QLHS.DAL
{
    public class ChuyenLopDAL : ConnectData
    {
        public bool Luu_ThongTin_ChuyenLop(string maHocSinh, ChuyenLopDTO cl)
        {
            string sql = "set dateformat dmy\n";
            sql +=
                string.Format(
                    "INSERT INTO CHUYENLOP (TuLop, DenLop , NgayChuyen, LyDoChuyen, ChuyenBangDiem, MaHocSinh) "
                    + "VALUES ('{0}','{1}','{2}',N'{3}','{4}','{5}')",
                    cl.TuLop, cl.DenLop, cl.NgayChuyen.ToString("dd-MM-yyy HH:mm:ss"), cl.LyDoChuyen, cl.GiuLaiBangDiem,
                    maHocSinh);
            return ExecuteQuery(sql) > 0;
        }

        public bool KiemTra_HocSinhThuocLop_DuocChuyenTuLop(string maHocSinh, string maLopMoi, string maLopCu)
        {
            string sql = "select pl.MaHocSinh "
                         + " from PHANLOP pl,CHUYENLOP cl "
                         + " where pl.MaHocSinh='" + maHocSinh + "' and pl.MaHocSinh=cl.MaHocSinh "
                         + " and pl.MaLop='" + maLopMoi + "' "
                         + " and cl.DenLop=pl.MaLop and cl.TuLop='" + maLopCu + "' "
                         + " and pl.MaHocSinh in(select MaHocSinh from PHANLOP pl1 where pl1.MaLop='" + maLopCu + "') "
                         + " and cl.DenLop not in (select TuLop from CHUYENLOP cl1 where cl1.MaHocSinh='" + maHocSinh +
                         "')";
            return GetTable(sql).Rows.Count > 0;
        }

        public bool KiemTra_HocSinhCo_BangDiem(string maHocSinh, string maLop)
        {
            string sql = "select MaHocSinh from BANGDIEM where MaHocSinh='" + maHocSinh + "' and MaLop='" + maLop +
                         "'  ";
            return GetTable(sql).Rows.Count > 0;
        }

        public bool Xoa_ChuyenLop(string maHocSinh, string tuLop, string denLop)
        {
            string sql = "delete from CHUYENLOP where TuLop='" + tuLop + "' and DenLop='" + denLop + "' and MaHocSinh='" +
                         maHocSinh + "' ";
            return ExecuteQuery(sql) > 0;
        }
    }
}
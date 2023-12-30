using System.Data;

namespace QLHS.DAL
{
    public class KhoiDAL : ConnectData
    {
        public DataTable LayDT_Khoi(string MaNamHoc)
        {
            string sql =
                "select distinct MaKhoiLop as MaKhoi ,N'Khối '+CONVERT(varchar,MaKhoiLop) as TenKhoi from LOP where MaNamHoc='" +
                MaNamHoc + "' ";
            return GetTable(sql);
        }

        public DataTable LayDT_Khoi10(string MaNamHoc)
        {
            string sql =
                "select distinct MaKhoiLop as MaKhoi ,N'Khối '+CONVERT(varchar,MaKhoiLop) as TenKhoi from LOP where MaNamHoc='" +
                MaNamHoc + "' and MaKhoiLop=10 ";
            return GetTable(sql);
        }

        public DataTable LayDT_Khoi_PhanLopCu(string MaNamHoc)
        {
            string sql =
                "select distinct MaKhoiLop as MaKhoi ,N'Khối '+CONVERT(varchar,MaKhoiLop) as TenKhoi from LOP where MaNamHoc='" +
                MaNamHoc + "' and MaKhoiLop in (10,11)";
            return GetTable(sql);
        }

        public DataTable LayDT_Khoi_Chuyen(string MaNamHoc, string MaKhoi)
        {
            string sql =
                "select distinct MaKhoiLop as MaKhoi ,N'Khối '+CONVERT(varchar,MaKhoiLop) as TenKhoi from LOP where MaNamHoc='" +
                MaNamHoc + "' and MaKhoiLop ='" + MaKhoi + "'";
            return GetTable(sql);
        }
    }
}
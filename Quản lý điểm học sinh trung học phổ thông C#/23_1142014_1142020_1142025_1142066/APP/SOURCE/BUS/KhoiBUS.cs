using System;
using System.Data;
using QLHS.DAL;

namespace QLHS.BUS
{
    public class KhoiBUS
    {
        private readonly KhoiDAL _khoiDAL;

        public KhoiBUS()
        {
            _khoiDAL = new KhoiDAL();
        }

        /// <summary>
        /// Lấy DataTable Khối
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LayDT_Khoi()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("MaKhoi");
            dataTable.Columns.Add("TenKhoi");
            for (int khoi = 10; khoi <= 12; khoi++)
            {
                DataRow dr = dataTable.NewRow();
                dr["MaKhoi"] = khoi;
                dr["TenKhoi"] = "Khối " + khoi;
                dataTable.Rows.Add(dr);
            }
            return dataTable;
        }

        public DataTable LayDT_Khoi_PhanLop(string MaKhoi)
        {
            int ma = Convert.ToInt32(MaKhoi);
            var dataTable = new DataTable();
            dataTable.Columns.Add("MaKhoi");
            dataTable.Columns.Add("TenKhoi");
            int gioihan = ma + 1;
            if (ma == 12)
                gioihan = ma;
            for (int khoi = gioihan; khoi >= ma; khoi--)
            {
                DataRow dr = dataTable.NewRow();
                dr["MaKhoi"] = khoi;
                dr["TenKhoi"] = "Khối " + khoi;
                dataTable.Rows.Add(dr);
            }
            return dataTable;
        }

        public DataTable LayDT_Khoi(string MaNamHoc)
        {
            return _khoiDAL.LayDT_Khoi(MaNamHoc);
        }

        public DataTable LayDT_Khoi10(string MaNamHoc)
        {
            return _khoiDAL.LayDT_Khoi10(MaNamHoc);
        }

        public DataTable LayDT_Khoi_PhanLopCu(string MaNamHoc)
        {
            return _khoiDAL.LayDT_Khoi_PhanLopCu(MaNamHoc);
        }

        public DataTable LayDT_Khoi_ChuyenLop(string MaNamHoc, string MaKhoi)
        {
            return _khoiDAL.LayDT_Khoi_Chuyen(MaNamHoc, MaKhoi);
        }
    }
}
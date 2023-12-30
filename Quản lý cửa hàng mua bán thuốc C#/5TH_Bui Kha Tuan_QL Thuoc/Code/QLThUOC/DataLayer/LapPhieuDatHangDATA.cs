using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LapPhieuDatHangDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSPhieuDatHang()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUDATHANG");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
        public DataTable TimKiemPhieuDatHang(String MaPhieuDH, String ChonNgay, String NgayBD, String NgayKT)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM PHIEUDATHANG WHERE MAPHIEUDH LIKE '%'+@maphieudh+'%'";
            cmd.Parameters.Add("maphieudh", SqlDbType.NVarChar).Value = MaPhieuDH;
            if (ChonNgay != "NONE")
            {
                sql += ChonNgay + " (NGAYLAP>=@ngaybd AND NGAYLAP<=@ngaykt)";
                cmd.Parameters.Add("ngaybd", SqlDbType.DateTime).Value = NgayBD;
                cmd.Parameters.Add("ngaykt", SqlDbType.DateTime).Value = NgayKT;
            }

            cmd.CommandText = sql;

            ds.Load(cmd);

            return ds;
        }
    }
}

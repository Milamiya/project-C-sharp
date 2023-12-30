using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LapPhieuThanhLiDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSPhieuThahLi()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUTHANHLI");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
        public DataTable TimKiemPhieuThanhLi(String MaPhieuTL, String ChonNgay, String NgayBD, String NgayKT)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM PHIEUTHANHLI WHERE MAPHIEUTL LIKE '%'+@maphieutl+'%'";
            cmd.Parameters.Add("maphieutl", SqlDbType.NVarChar).Value = MaPhieuTL;
            if (ChonNgay != "NONE")
            {
                sql += ChonNgay + " (NGAYTHANH>=@ngaybd AND NGAYTHANH<=@ngaykt)";
                cmd.Parameters.Add("ngaybd", SqlDbType.DateTime).Value = NgayBD;
                cmd.Parameters.Add("ngaykt", SqlDbType.DateTime).Value = NgayKT;
            }

            cmd.CommandText = sql;

            ds.Load(cmd);

            return ds;
        }
    }
}

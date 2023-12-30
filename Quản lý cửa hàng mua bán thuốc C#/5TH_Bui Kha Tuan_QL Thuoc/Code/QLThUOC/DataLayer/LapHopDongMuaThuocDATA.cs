using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LapHopDongMuaThuocDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSHopDongMuaThuoc()
        {
            SqlCommand cmd = new SqlCommand("select * from HD_MUATHUOC");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
        public DataTable TimKiemHopDong(String MaHD, String ChonNgay, String NgayBD, String NgayKT)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM HD_MUATHUOC WHERE MAHD LIKE '%'+@mahd+'%'";
            cmd.Parameters.Add("mahd", SqlDbType.NVarChar).Value = MaHD;
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

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class NhaCungCapDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSNhaCungCap()
        {
            SqlCommand cmd = new SqlCommand("select * from NHACC");
            ds.Load(cmd);
            return ds;
        }
        public DataTable TimKiemNCC(String MaNCC, String ChonTenNCC, String TenNCC, String ChonDiaChi, String DiaChiNCC)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM NHACC WHERE MANCC LIKE '%'+@mancc+'%'";
            cmd.Parameters.Add("mancc", SqlDbType.NVarChar).Value = MaNCC;
            if (ChonTenNCC != "NONE")
            {
                sql += ChonTenNCC + " TENNCC LIKE '%' + @tenncc + '%'";
                cmd.Parameters.Add("tenncc", SqlDbType.NVarChar).Value = TenNCC;
            }
            if (ChonDiaChi != "NONE")
            {
                sql += ChonDiaChi + " DIACHINCC LIKE '%' + @diachincc + '%'";
                cmd.Parameters.Add("diachincc", SqlDbType.NVarChar).Value = DiaChiNCC;
            }
            cmd.CommandText = sql;

            ds.Load(cmd);

            return ds;

        }
        public void Update()
        {
            ds.Update();
        }
    }
}

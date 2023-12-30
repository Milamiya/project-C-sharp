using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LoThuocDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSLoThuoc()
        {
            SqlCommand cmd = new SqlCommand("select * from LOTHUOC");
            ds.Load(cmd);
            return ds;
        }
        public DataTable TimKiemLoThuoc(String MaLo, String ChonTenLo, String TenLo, String ChonMaThuoc, String MaThuoc)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM LOTHUOC WHERE MALO LIKE '%'+@malo+'%'";
            cmd.Parameters.Add("malo", SqlDbType.NVarChar).Value = MaLo;
            if (ChonTenLo != "NONE")
            {
                sql += ChonTenLo + " TENLO LIKE '%' + @tenlo + '%'";
                cmd.Parameters.Add("tenlo", SqlDbType.NVarChar).Value = TenLo;
            }
            if (ChonMaThuoc != "NONE")
            {
                sql += ChonMaThuoc + " MATHUOC LIKE '%' + @mathuoc + '%'";
                cmd.Parameters.Add("mathuoc", SqlDbType.DateTime).Value = MaThuoc;
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

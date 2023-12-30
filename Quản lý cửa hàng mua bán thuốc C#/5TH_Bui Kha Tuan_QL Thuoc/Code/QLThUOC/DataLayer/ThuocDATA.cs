using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class ThuocDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSThuoc()
        {
            SqlCommand cmd = new SqlCommand("select * from THUOC");
            ds.Load(cmd);
            return ds;
        }
         public DataTable TimKiemThuoc(String MaThuoc, String ChonTenThuoc, String TenThuoc)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM THUOC WHERE MATHUOC LIKE '%'+@mathuoc+'%'";
            cmd.Parameters.Add("mathuoc", SqlDbType.NVarChar).Value = MaThuoc;
            if (ChonTenThuoc != "NONE")
            {
                sql += ChonTenThuoc + " TENTHUOC LIKE '%' + @tenthuoc + '%'";
                cmd.Parameters.Add("tenthuoc", SqlDbType.NVarChar).Value = TenThuoc;
            }
            cmd.CommandText = sql;

            ds.Load(cmd);

            return ds;

        }
        public DataTable DSThuoc()
        {
            SqlCommand cmd = new SqlCommand("select * from THUOC t,LOAITHUOC lt,DVTINH dv where t.MADVT=dv.MADVT and t.MALOAITHUOC=lt.MALOAITHUOC");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

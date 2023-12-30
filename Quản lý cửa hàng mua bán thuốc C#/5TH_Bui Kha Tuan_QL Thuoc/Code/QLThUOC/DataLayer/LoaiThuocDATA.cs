using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LoaiThuocDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSLoaiThuoc()
        {
            SqlCommand cmd = new SqlCommand("select * from LOAITHUOC");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

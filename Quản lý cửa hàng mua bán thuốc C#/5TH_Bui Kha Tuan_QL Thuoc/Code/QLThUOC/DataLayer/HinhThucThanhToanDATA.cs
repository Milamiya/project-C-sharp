using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class HinhThucThanhToanDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSHinhThucThanhToan()
        {
            SqlCommand cmd = new SqlCommand("select * from HT_THANHTOAN");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BaoCaoThongKe.DataLayer
{
    public class DonViTinhData
    {
        DataService ds = new DataService();

        public DataTable LayDSDonViTinh()
        {
            SqlCommand cmd = new SqlCommand("SELECT * From DonViTinh");
            ds.Load(cmd);
            return ds;
        }

        public void Update()
        {
            ds.Update();
        }
    }
}

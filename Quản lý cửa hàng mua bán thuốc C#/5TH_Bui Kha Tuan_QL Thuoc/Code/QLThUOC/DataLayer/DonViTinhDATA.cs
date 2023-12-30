using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class DonViTinhDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSDonViTinh()
        {
            SqlCommand cmd = new SqlCommand("select * from DVTINH");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

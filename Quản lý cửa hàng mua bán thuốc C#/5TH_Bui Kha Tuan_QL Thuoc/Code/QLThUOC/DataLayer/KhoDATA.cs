using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class KhoDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSKho()
        {
            SqlCommand cmd = new SqlCommand("select * from KHO");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

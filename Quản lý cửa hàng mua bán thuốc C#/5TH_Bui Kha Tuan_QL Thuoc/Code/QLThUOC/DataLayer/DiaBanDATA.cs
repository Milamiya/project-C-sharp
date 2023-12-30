using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class DiaBanDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSDiaBan()
        {
            SqlCommand cmd = new SqlCommand("select * from DIABANHD");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        } 
    }
}

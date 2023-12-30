using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class PhanCongDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSPhanCong()
        {
            SqlCommand cmd = new SqlCommand("select * from PHANCONG_DBHD");
            ds.Load(cmd);
            return ds;
        }
        public DataTable DSPhanCong()
        {
            SqlCommand cmd = new SqlCommand("select * from PHANCONG_DBHD ph,DIABANHD db,TDVIEN tdv,THUOC t where ph.MATDV=tdv.MATDV and ph.MADB=db.MADB and ph.MATHUOC=t.MATHUOC");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

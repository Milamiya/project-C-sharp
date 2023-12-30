using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LoaiKhachHangDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSLoaiKhachHang()
        {
            SqlCommand cmd = new SqlCommand("select * from LOAIKH");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

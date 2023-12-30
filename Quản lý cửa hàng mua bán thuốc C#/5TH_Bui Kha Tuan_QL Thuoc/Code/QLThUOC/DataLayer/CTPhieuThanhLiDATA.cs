using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class CTPhieuThanhLiDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSCTPhieuThanhLi()
        {
            SqlCommand cmd = new SqlCommand("select * from CT_PHIEUTHANHLI");
            ds.Load(cmd);
            return ds;
        }
        public DataTable LayDSCTPhieuThanhLi(String ctPhieuThanhLi)
        {
            String sql = "select * from CT_PHIEUTHANHLI where MAPHIEUTL='" + ctPhieuThanhLi + "'";
            SqlCommand cmd = new SqlCommand(sql);
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

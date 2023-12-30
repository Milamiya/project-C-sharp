using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class CTHopDongMuaThuocDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSCTHopDongMuaThuoc()
        {
            SqlCommand cmd = new SqlCommand("select * from CT_HD_MUATHUOC");
            ds.Load(cmd);
            return ds;
        }
        public DataTable LayDSCTHopDongMuaThuoc(String ctHDMT)
        {
            String sql = "select * from CT_HD_MUATHUOC where MAHD='" + ctHDMT + "'";
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

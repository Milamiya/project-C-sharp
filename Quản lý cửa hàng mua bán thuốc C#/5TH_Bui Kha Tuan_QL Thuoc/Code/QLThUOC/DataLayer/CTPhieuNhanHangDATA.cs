using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class CTPhieuNhanHangDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSCTPhieuNhanHang()
        {
            SqlCommand cmd = new SqlCommand("select * from CT_PHIEUNHANHANG");
            ds.Load(cmd);
            return ds;
        }
        public DataTable LayDSCTPhieuNhanHang(String ctPhieuNhanHang)
        {
            String sql = "select * from CT_PHIEUNHANHANG where MAPHIEUNH='" + ctPhieuNhanHang + "'";
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

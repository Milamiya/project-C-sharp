using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class CTPhieuDatHangDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSCTPhieuDatHang()
        {
            SqlCommand cmd = new SqlCommand("select * from CT_PHIEUDATHANG");
            ds.Load(cmd);
            return ds;
        }
        public DataTable LayDSCTPhieuDatHang(String ctPhieuDatHang)
        {
            String sql = "select * from CT_PHIEUDATHANG where MAPHIEUDH='" + ctPhieuDatHang + "'";
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

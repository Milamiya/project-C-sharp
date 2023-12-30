using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class CTPhieuXuatKhoDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSCTPhieuXuatKho()
        {
            SqlCommand cmd = new SqlCommand("select * from CT_PHIEUXUATKHO");
            ds.Load(cmd);
            return ds;
        }
        public DataTable LayDSCTPhieuXuatKho(String ctPhieuXuatKho)
        {
            String sql = "select * from CT_PHIEUXUATKHO where MAPHIEUXK='" + ctPhieuXuatKho + "'";
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

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class CTPhieuNhapKhoDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSCTPhieuNhapKho()
        {
            SqlCommand cmd = new SqlCommand("select * from CT_PHIEUNHAPKHO");
            ds.Load(cmd);
            return ds;
        }
        public DataTable LayDSCTPhieuNhapKho(String ctPhieuNhapKho)
        {
            String sql = "select * from CT_PHIEUNHAPKHO where MAPHIEUNK='" + ctPhieuNhapKho + "'";
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

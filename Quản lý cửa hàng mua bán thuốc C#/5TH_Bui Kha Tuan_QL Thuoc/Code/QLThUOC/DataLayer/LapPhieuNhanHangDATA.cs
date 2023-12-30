using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LapPhieuNhanHangDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSPhieuNhanHang()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUNHANHANG");
            ds.Load(cmd);
            return ds;
        }
        public DataTable DSPhieuNhanHang()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUNHANHANG pnh,CT_PHIEUNHANHANG ctp,NHANVIEN nv,THUOC t where pnh.MANV=nv.MANV and pnh.MAPHIEUNH=ctp.MAPHIEUNH and ctp.MATHUOC=t.MATHUOC");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }

        public DataTable TimKiemPhieuNhanHang(String MaPhieuNH, String ChonNgayGiao, String NgayBD, String NgayKT)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM PHIEUNHANHANG WHERE MAPHIEUNH LIKE '%'+@maphieunh+'%'";
            cmd.Parameters.Add("maphieunh", SqlDbType.NVarChar).Value = MaPhieuNH;
            if (ChonNgayGiao != "NONE")
            {
                sql += ChonNgayGiao + " (NGAYGIAO>=@ngaybd AND NGAYGIAO<=@ngaykt)";
                cmd.Parameters.Add("ngaybd", SqlDbType.DateTime).Value = NgayBD;
                cmd.Parameters.Add("ngaykt", SqlDbType.DateTime).Value = NgayKT;
            }
           
            cmd.CommandText = sql;

            ds.Load(cmd);

            return ds;
        }
    }
}

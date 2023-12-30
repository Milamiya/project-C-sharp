using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LapPhieuNhapKhoDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSPhieuNhapKho()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUNHAPKHO");
            ds.Load(cmd);
            return ds;
        }
        public DataTable DSPhieuNhapKho()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUNHAPKHO pnk,CT_PHIEUNHAPKHO ctp,NHANVIEN nv,KHO k,THUOC t where pnk.MAPHIEUNK=ctp.MAPHIEUNK and pnk.MANV=nv.MANV and pnk.MAKHO=k.MAKHO and ctp.MATHUOC=t.MATHUOC");
            ds.Load(cmd);
            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
        public DataTable TimKiemPhieuNhapKho(String MaPhieuNK, String ChonNgayNK, String NgayBD, String NgayKT)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM PHIEUNHAPKHO WHERE MAPHIEUNK LIKE '%'+@maphieunk+'%'";
            cmd.Parameters.Add("maphieunk", SqlDbType.NVarChar).Value = MaPhieuNK;
            if (ChonNgayNK != "NONE")
            {
                sql += ChonNgayNK + " (NGAYNK>=@ngaybd AND NGAYNK<=@ngaykt)";
                cmd.Parameters.Add("ngaybd", SqlDbType.DateTime).Value = NgayBD;
                cmd.Parameters.Add("ngaykt", SqlDbType.DateTime).Value = NgayKT;
            }
            
            cmd.CommandText = sql;

            ds.Load(cmd);

            return ds;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class LapPhieuXuatKhoDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSPhieuXuatKho()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUXUATKHO");
            ds.Load(cmd);
            return ds;
        }
        public DataTable DSPhieuXuatKho()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUXUATKHO xk,KHACHHANG kh,NHANVIEN nv,THUOC t,CT_PHIEUXUATKHO ctp,KHO k where xk.MAPHIEUXK=ctp.MAPHIEUXK and xk.MAKH=kh.MAKH and xk.MANV=nv.MANV and ctp.MATHUOC=t.MATHUOC and xk.MAKHO=k.MAKHO");
            ds.Load(cmd);
            return ds;
        }
        public DataTable TimKiemPhieuXuatKho(String MaPhieuXK, String ChonNgayXK, String NgayBD, String NgayKT)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM PHIEUXUATKHO WHERE MAPHIEUXK LIKE '%'+@maphieuxk+'%'";
            cmd.Parameters.Add("maphieuxk", SqlDbType.NVarChar).Value = MaPhieuXK;
            if (ChonNgayXK != "NONE")
            {
                sql += ChonNgayXK + " (NGAYXUAT>=@ngaybd AND NGAYXUAT<=@ngaykt)";
                cmd.Parameters.Add("ngaybd", SqlDbType.DateTime).Value = NgayBD;
                cmd.Parameters.Add("ngaykt", SqlDbType.DateTime).Value = NgayKT;
            }

            cmd.CommandText = sql;

            ds.Load(cmd);

            return ds;
        }
        public void Update()
        {
            ds.Update();
        }
    }
}

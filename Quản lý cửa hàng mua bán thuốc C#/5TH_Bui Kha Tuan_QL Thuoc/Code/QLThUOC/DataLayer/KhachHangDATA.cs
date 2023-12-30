using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{
    public class KhachHangDATA
    {
        DataService ds = new DataService();
        public DataTable LayDSKhachHang()
        {
            SqlCommand cmd = new SqlCommand("select * from KHACHHANG");
            ds.Load(cmd);
            return ds;
        }
        public DataTable TimKiemKH(String MaKH, String ChonHoTen, String HoTenKH, String ChonDiaChi, String DiaChiKH)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM KHACHHANG WHERE MAKH LIKE '%'+@makh+'%'";
            cmd.Parameters.Add("makh", SqlDbType.NVarChar).Value = MaKH;
            if (ChonHoTen != "NONE")
            {
                sql += ChonHoTen + " HOTENKH LIKE '%' + @hoten + '%'";
                cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = HoTenKH;
            }
            if (ChonDiaChi != "NONE")
            {
                sql += ChonDiaChi + " DIACHIKH LIKE '%' + @diachi + '%'";
                cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = DiaChiKH;
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

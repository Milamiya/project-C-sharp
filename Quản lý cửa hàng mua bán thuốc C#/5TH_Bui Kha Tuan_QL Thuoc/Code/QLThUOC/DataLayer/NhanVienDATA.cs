using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLThUOC.DataLayer
{   
    public class NhanVienDATA
    {
        DataService dl = new DataService();
        public DataTable LayDSNhanVien()
        {
            SqlCommand cmd = new SqlCommand("select * from NHANVIEN");
            dl.Load(cmd);
            return dl;
        }
        public DataTable TimKiemNV(String MaNV, String ChonHoTen, String HoTenNV, String ChonNgaySinh, String NgaySinh,String ChonDiaChi,String DiaChi,String ChonTenLoaiNV,String TenLoaiNV)
        {
            SqlCommand cmd = new SqlCommand();
            String sql = "SELECT * FROM NHANVIEN WHERE MANV LIKE '%'+@manv+'%'";
            cmd.Parameters.Add("manv", SqlDbType.NVarChar).Value = MaNV;
            if (ChonHoTen != "NONE")
            {
                sql += ChonHoTen + " HOTENNV LIKE '%' + @hoten + '%'";
                cmd.Parameters.Add("hoten", SqlDbType.NVarChar).Value = HoTenNV;
            }
            if (ChonNgaySinh != "NONE")
            {
                sql += ChonNgaySinh + " NGAYSINH LIKE '%' + @ngaysinh + '%'";
                cmd.Parameters.Add("ngaysinh", SqlDbType.DateTime).Value = NgaySinh;
            }
            if (ChonDiaChi != "NONE")
            {
                sql += ChonDiaChi + " DIACHI LIKE '%' + @diachi + '%'";
                cmd.Parameters.Add("diachi", SqlDbType.NVarChar).Value = DiaChi;
            }
            if (ChonTenLoaiNV != "NONE")
            {
                sql += ChonTenLoaiNV + " TENLOAINV LIKE '%' + @tenloainv + '%'";
                cmd.Parameters.Add("tenloainv", SqlDbType.NVarChar).Value = TenLoaiNV;
            }
            cmd.CommandText = sql;

            dl.Load(cmd);

            return dl;

        }
        public void Update()
        {
            dl.Update();
        }
        public DataTable LayDSNhanVien(String tendangnhap)
        {
            String sql = "SELECT * FROM NHANVIEN WHERE TENDN = @ten";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.Add("ten", SqlDbType.VarChar).Value = tendangnhap;
            dl.Load(cmd);
            return dl;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;

namespace QLKTX.DataLayer
{
    public class PhongData
    {
        DataService ser = new DataService();
        public DataTable LayDSPhong()
        {
            SqlCommand command = new SqlCommand("Select * from Phong p,[Day] d,TrangThaiPhong tt where p.MaDay=d.MaDay and p.TrangThai=tt.MaTrangThai");
            ser.Load(command);
            return ser;
        }
        public DataTable LayDSPhong_DK_DAY(string maday)
        {
            SqlCommand command = new SqlCommand("Select * from Phong where MADAY=@maday");
            command.Parameters.Add("@maday", SqlDbType.NVarChar, 4).Value = maday;
            ser.Load(command);
            return ser;
        }
        public bool Them(PhongInfo phong)
        {
            SqlCommand command = new SqlCommand("insert into Phong(MAPHG,TENPHG,MADAY,SOLUONGTOIDA,TRANGTHAI,PHONGNAM)"
                                                          +"values(@maphg,@tenphg,@maday,@soluong,@trangthai,@phongnam)");
            command.Parameters.Add("@maphg",SqlDbType.VarChar,4).Value = phong.MaPhong;
            command.Parameters.Add("@tenphg",SqlDbType.NVarChar,30).Value = phong.TenPhong;
            command.Parameters.Add("@maday",SqlDbType.VarChar,4).Value = phong.Day.MaDay;
            command.Parameters.Add("@soluong",SqlDbType.Int).Value = phong.SoLuongToiDa;
            command.Parameters.Add("@trangthai",SqlDbType.Int).Value = phong.TrangThai.MaTrangThai;
            command.Parameters.Add("@phongnam", SqlDbType.Bit).Value = phong.PhongNam;
            try
            {
                ser.Load(command);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
            
        }
        public bool Xoa(PhongInfo phong)
        {
            SqlCommand command = new SqlCommand("Delete Phong where MAPHG = @maphg");
            command.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = phong.MaPhong;

            try
            {
                ser.Load(command);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public bool Sua(PhongInfo phong)
        {

            SqlCommand command = new SqlCommand("Update Phong set TENPHG=@tenphg,"
                                    +"MADAY=@maday,SOLUONGTOIDA=@soluong,TRANGTHAI=@trangthai"+
                                    ",PHONGNAM=@phongnam where MAPHG=@maphg");
            command.Parameters.Add("@maphg", SqlDbType.VarChar, 4).Value = phong.MaPhong;
            command.Parameters.Add("@tenphg", SqlDbType.NVarChar, 30).Value = phong.TenPhong;
            command.Parameters.Add("@maday", SqlDbType.VarChar, 4).Value = phong.Day.MaDay;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = phong.SoLuongToiDa;
            command.Parameters.Add("@trangthai", SqlDbType.Int).Value = phong.TrangThai.MaTrangThai;
            command.Parameters.Add("@phongnam", SqlDbType.Bit).Value = phong.PhongNam;
            try
            {
                ser.Load(command);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
    }
}

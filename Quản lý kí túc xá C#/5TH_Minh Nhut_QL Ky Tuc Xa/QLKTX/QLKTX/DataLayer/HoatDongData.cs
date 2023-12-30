using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QLKTX.BusinessObject;
namespace QLKTX.DataLayer
{
    public class HoatDongData
    {
        DataService ser = new DataService();
        public DataTable LayDSHoatDong()
        {
            SqlCommand com = new SqlCommand("Select * from HOATDONG");
            ser.Load(com);
            return ser;
        }
        public bool Them(HoatDongInfo hoatdong)
        {
            SqlCommand com = new SqlCommand("Insert into HOATDONG(MAHOATDONG,TENHOATDONG) values(@ma,@ten)");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = hoatdong.MaHoatDong;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = hoatdong.TenHoatDong;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public bool Xoa(HoatDongInfo hoatdong)
        {
            SqlCommand com = new SqlCommand("Delete HOATDONG where MAHOATDONG=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = hoatdong.MaHoatDong;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public bool Sua(HoatDongInfo hoatdong)
        {
            SqlCommand com = new SqlCommand("Update HOATDONG set TENHOATDONG=@ten where MAHOATDONG=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = hoatdong.MaHoatDong;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = hoatdong.TenHoatDong;
            try
            {
                ser.Load(com);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public DataTable LayMaLonNhat()
        {
            SqlCommand com = new SqlCommand("Select MAX(MAHOATDONG) from HOATDONG");
            ser.Load(com);
            return ser;
        }

        //chu duoc chi thu thoi
        public DataTable Tim(string s)
        {
            SqlCommand com = new SqlCommand("Select HOTEN, GIOITINH from SINHVIEN where HOTEN LIKE @ten");
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = "%"+s+"%";
            ser.Load(com);
            return ser;
        }
    }
}

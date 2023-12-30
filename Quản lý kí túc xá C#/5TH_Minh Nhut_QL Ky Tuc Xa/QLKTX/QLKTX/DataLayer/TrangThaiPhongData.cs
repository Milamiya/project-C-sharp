using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;

namespace QLKTX.DataLayer
{
    public class TrangThaiPhongData
    {
        DataService ser = new DataService();
        public DataTable LayDSTinhTrangPhong()
        {
            SqlCommand com = new SqlCommand("Select * from TRANGTHAIPHONG");
            ser.Load(com);
            return ser;
        }
        public bool Them(TrangThaiPhongInfo phong)
        {
            SqlCommand com = new SqlCommand("Insert into TrangThaiPhong(MATRANGTHAI,TENTRANGTHAI) values(@ma,@ten)");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = phong.MaTrangThai;            
            com.Parameters.Add("@ten", SqlDbType.NVarChar,30).Value = phong.TenTrangThai;
            try
            {
                ser.Load(com);
                return true;
            }
            catch(Exception e)
            {
                e.ToString();
                return false;
            }
        }
        public bool Xoa(TrangThaiPhongInfo phong)
        {
            SqlCommand com = new SqlCommand("Delete TrangThaiPhong where MATRANGTHAI=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = phong.MaTrangThai;            
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
        public bool Sua(TrangThaiPhongInfo phong)
        {
            SqlCommand com = new SqlCommand("Update TrangThaiPhong set TENTRANGTHAI=@ten where MATRANGTHAI=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = phong.MaTrangThai;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = phong.TenTrangThai;
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
            SqlCommand com = new SqlCommand("Select MAX(MATRANGTHAI) from TRANGTHAIPHONG");
            ser.Load(com);
            return ser;
        }
    }
}

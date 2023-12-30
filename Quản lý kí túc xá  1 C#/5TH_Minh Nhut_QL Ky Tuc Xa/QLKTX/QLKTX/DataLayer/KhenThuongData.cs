using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QLKTX.BusinessObject;
namespace QLKTX.DataLayer
{
    public class KhenThuongData
    {
        DataService ser = new DataService();
        public DataTable LayDSKhenThuong()
        {
            SqlCommand com = new SqlCommand("Select * from HOATDONG");
            ser.Load(com);
            return ser;
        }
        public bool Them(KhenThuongInfo hoatdong)
        {
            SqlCommand com = new SqlCommand("Insert into HOATDONG(MAHOATDONG,TENHOATDONG) values(@ma,@ten)");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = hoatdong.MaKhenThuong;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = hoatdong.TenKhenThuong;
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
        public bool Xoa(KhenThuongInfo hoatdong)
        {
            SqlCommand com = new SqlCommand("Delete HOATDONG where MAHOATDONG=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = hoatdong.MaKhenThuong;
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
        public bool Sua(KhenThuongInfo hoatdong)
        {
            SqlCommand com = new SqlCommand("Update HOATDONG set TENHOATDONG=@ten where MAHOATDONG=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = hoatdong.MaKhenThuong;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = hoatdong.TenKhenThuong;
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

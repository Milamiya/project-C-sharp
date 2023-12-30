using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;
namespace QLKTX.DataLayer
{
    public class CapData
    {
        DataService ser = new DataService();
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MACAP) from CAP");
            ser.Load(s);
            return ser;
        }
        public DataTable LayDSCap()
        {
            SqlCommand com = new SqlCommand("Select * from CAP");
            ser.Load(com);
            return ser;
        }
        public bool Them(CapInfo cap)
        {
            SqlCommand com = new SqlCommand("Insert into CAP(MACAP,TENCAP) values(@ma,@ten)");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = cap.MaCap;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = cap.TenCap;
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
        public bool Xoa(CapInfo cap)
        {
            SqlCommand com = new SqlCommand("Delete CAP where MACAP=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = cap.MaCap;
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
        public bool Sua(CapInfo cap)
        {
            SqlCommand com = new SqlCommand("Update CAP set TENCAP=@ten where MACAP=@ma");
            com.Parameters.Add("@ma", SqlDbType.Int).Value = cap.MaCap;
            com.Parameters.Add("@ten", SqlDbType.NVarChar, 30).Value = cap.TenCap;
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
            SqlCommand com = new SqlCommand("Select MAX(MACAP) from CAP");
            ser.Load(com);
            return ser;
        }
        public bool XoaCap(CapInfo qh)
        {
            try
            {
                SqlCommand s = new SqlCommand("DELETE Cap where MACap=" + qh.MaCap.ToString());
                ser.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false; ;
            }

        }
        public bool ThemCap(CapInfo qh)
        {
            try
            {
                SqlCommand s = new SqlCommand("INSERT INTO Cap(MACap,TENCap) values(" + qh.MaCap.ToString() + ",N'" + qh.TenCap + "')");
                ser.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false; ;
            }

        }
        public bool CapNhatCap(CapInfo qh)
        {
            try
            {
                SqlCommand s = new SqlCommand("UPDATE Cap SET TENCap = N'" + qh.TenCap + "' WHERE MACap=" + qh.MaCap);
                ser.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false; ;
            }

        }
    }
}

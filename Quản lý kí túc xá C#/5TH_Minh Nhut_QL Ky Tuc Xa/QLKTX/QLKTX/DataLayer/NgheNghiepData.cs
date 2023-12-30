using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;
using QLKTX.Controller;

namespace QLKTX.DataLayer
{
    public class NgheNghiepData
    {
        DataService ser = new DataService();
        public DataTable DSNgheNghiep()
        {
            SqlCommand s = new SqlCommand("SELECT * FROM NGHENGHIEP");
            ser.Load(s);
            return ser;
        }
        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MANGHENGHIEP) from NGHENGHIEP");
            ser.Load(s);
            return ser;
        }
        public bool XoaNgheNghiep(NgheNghiepInfo nn)
        {
            try
            {
                SqlCommand s = new SqlCommand("DELETE NGHENGHIEP where MANGHENGHIEP=" + nn.MaNgheNghiep.ToString());
                ser.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false; ;
            }

        }
        public bool ThemNgheNghiep(NgheNghiepInfo nn)
        {
            try
            {
                SqlCommand s = new SqlCommand("INSERT INTO NGHENGHIEP(MANGHENGHIEP,TENNGHENGHIEP) values(" + nn.MaNgheNghiep.ToString() + ",N'" + nn.TenNgheNghep.ToString() + "')");
                ser.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false; ;
            }

        }
        public bool CapNhatNgheNghiep(NgheNghiepInfo nn)
        {
            try
            {
                SqlCommand s = new SqlCommand("UPDATE NGHENGHIEP SET TENNGHENGHIEP = N'" + nn.TenNgheNghep + "' WHERE MANGHENGHIEP=" + nn.MaNgheNghiep);                
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

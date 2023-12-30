using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLKTX.BusinessObject;

namespace QLKTX.DataLayer
{
    public class QuanHeData
    {
        DataService ser = new DataService();
        public DataTable DSQuanHe()
        {
            SqlCommand s = new SqlCommand("SELECT * FROM QUANHE");
            ser.Load(s);
            return ser;
        }

        public DataTable LayMaMax()
        {
            SqlCommand s = new SqlCommand("select MAX(MAQUANHE) from QUANHE");
            ser.Load(s);
            return ser;
        }
        public bool XoaQuanHe(QuanHeInfo qh)
        {
            try
            {
                SqlCommand s = new SqlCommand("DELETE QUANHE where MAQUANHE="+qh.MaQuanHe.ToString());
                ser.Load(s);                
                return true;
            }
            catch(Exception e)
            {
                e.ToString();
                return false; ;
            }
            
        }
        public bool ThemQuanHe(QuanHeInfo qh)
        {
            try
            {
                SqlCommand s = new SqlCommand("INSERT INTO QUANHE(MAQUANHE,TENQUANHE) values(" + qh.MaQuanHe.ToString()+",N'"+qh.TenQuanHe+"')");                
                ser.Load(s);
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false; ;
            }

        }
        public bool CapNhatQuanHe(QuanHeInfo qh)
        {
            try
            {               
                SqlCommand s = new SqlCommand("UPDATE QUANHE SET TENQUANHE = N'"+qh.TenQuanHe+"' WHERE MAQUANHE="+qh.MaQuanHe);                
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

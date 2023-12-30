
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QLKTX.DataLayer
{
    public class HocKiData
    {
        DataService ser = new DataService();
        public HocKiData()
        {
        }
        public DataTable LayDSHocKi()
        {
            SqlCommand com = new SqlCommand("Select * from HocKi");
            ser.Load(com);
            return ser;
        }
        public DataTable LayDSHocKi_DK_NamHoc(string maNam)
        {
            SqlCommand com = new SqlCommand("Select * from HocKi where MANAM=@manam");
            com.Parameters.Add("@manam", SqlDbType.VarChar, 5).Value = maNam;
            ser.Load(com);
            return ser;
        }
        
        public void Update()
        {
            ser.Update();
        }
        public int GetMaxMaSo()
        {
            SqlCommand com = new SqlCommand("select Max(MAHOCKI) from HOCKI");
            ser.Load(com);            
            try
            {
                return (int)ser.Rows[0][0];
            }
            catch (Exception e)
            {
                e.ToString();
                return 0;
            }
        }
    }
}

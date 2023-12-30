using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace GiaoDienCuaHang.DataLayer
{
   public class PhieuSuCoData
    {
        DataService ds = new DataService();
        public DataTable LayDSPSC()
        {
            SqlCommand cmd = new SqlCommand("select * from PHIEUSUCO");
            ds.Load(cmd);
            return ds;
        }
       public DataTable LayDS_PhieuSuCo(String psc)
       {
           SqlCommand cmd = new SqlCommand("select * from PHIEUSUCO where MASP=@sp");

           cmd.Parameters.Add("sp", SqlDbType.VarChar).Value = psc;
           ds.Load(cmd);
           return ds;
       }
        public DataRow NewRow()
        {
            return ds.NewRow();
        }
        public void Add(DataRow r)
        {
            ds.Rows.Add(r);
        }
       public void Update()
       {
           ds.Update();
       }
    }
   
}

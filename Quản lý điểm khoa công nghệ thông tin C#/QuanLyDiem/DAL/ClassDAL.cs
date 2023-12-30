using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class ClassDAL
    {
        public SqlConnection GetConnect()
        {
            return new SqlConnection("server=TY-PC;User id=sa;password=04091990;database=CNPM_1");
        }
        public DataTable GetTable(string sql)
        {
            SqlConnection con = GetConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
            con.Close();
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = GetConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}

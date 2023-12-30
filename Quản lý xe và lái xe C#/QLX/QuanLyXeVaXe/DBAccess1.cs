using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace QuanLyXeVaXe
{
    class DBAccess1
    {
         public SqlConnection GetCon()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;"+
                "Database = master;Integrated Security=True;User Instance=True");
        }
    }
}

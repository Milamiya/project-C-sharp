using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace QLPKT
{
    class Connect
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Connect()
        {
            StreamReader reader=new StreamReader("ConnectString.con");
            Server = reader.ReadLine().Split(':')[1];
            this.Database = reader.ReadLine().Split(':')[1];
            this.UserName = reader.ReadLine().Split(':')[1];
            this.Password = reader.ReadLine().Split(':')[1];
            reader.Close();
        }
        public SqlConnection GetConnect()
        {
            if (this.UserName!="")
                return new SqlConnection("Data Source=" + this.Server + ";Initial Catalog=" + this.Database + ";User Id=" + this.UserName + ";Password=" + this.Password + ";");
            else
                return new SqlConnection("Data Source=" + this.Server + ";Initial Catalog=" + this.Database + ";Integrated Security=True");
        }
        public static void WriteFile(string server,string data,string uid,string pass)
        {
            StreamWriter writer = new StreamWriter("ConnectString.con");
            writer.WriteLine("Server:"+server);
            writer.WriteLine("Database:"+data);
            writer.WriteLine("UserName:" + uid);
            writer.WriteLine("PassWord:" + pass);
            writer.Close();
        }

    }
}

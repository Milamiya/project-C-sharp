using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QuanLyCafe.DataAccess
{
    class ConnectDB
    {

        SqlConnection con;
        SqlCommand sqlcom;
        SqlDataReader sqldr;
        public string Server { get; set; }
        public string Database { get; set; }


        public ConnectDB()
        {
            try
            {
                StreamReader read = new StreamReader("Sinfo");
                this.Server = (read.ReadLine().Split(':')[1]);
                this.Database = (read.ReadLine().Split(':')[1]);
                read.Close();
            }
            catch
            {

            }
        }

        public SqlConnection getcon()
        {

            return new SqlConnection("Data Source=" + this.Server + ";Initial Catalog =" + this.Database + "; Integrated Security=SSPI;");

        }
        public static void writefile(string server, string db)
        {
            StreamWriter write = new StreamWriter("Sinfo");
            write.WriteLine("SV=:" + server);
            write.WriteLine("DB=:" + db);
            write.Close();

        }
        public DataTable taobang(string sql)
        {
            con = getcon();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;


        }
        public void ExcuteNonQuery(string sql)
        {
            con = getcon();
            sqlcom = new SqlCommand(sql, con);
            con.Open();
            sqlcom.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }

        public bool kiemtra(string sql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            int n = (int)sqlcom.ExecuteScalar();
            con.Close();
            if (n > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public int returnscalarnumber(string sql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            int n = (int)sqlcom.ExecuteScalar();
            con.Close();
            return n;
        }

        public string LoadLable(string sql)
        {
            string ketqua = "";
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(sql, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                ketqua = sqldr[0].ToString();
            }
            con.Close();
            return ketqua;
        }
        public void LoadLenCombobox(ComboBox cb, string SQL, int chiso)
        {
            cb.Items.Clear();
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(SQL, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            con.Close();
        }

        public static string ToTitleCase(string mText)
        {
            string rText = "";
            try
            {
                System.Globalization.CultureInfo cultureInfo =
                System.Threading.Thread.CurrentThread.CurrentCulture;
                System.Globalization.TextInfo TextInfo = cultureInfo.TextInfo;
                rText = TextInfo.ToTitleCase(mText);
            }
            catch
            {
                rText = mText;
            }
            return rText;
        }

        public bool kiemtrauser(string sql, string user, string pass)
        {
            con = getcon();
            bool a = true;
            sqlcom = new SqlCommand(sql, con);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (user == sqldr[0].ToString() && pass == sqldr[1].ToString())
                {
                    a = false;
                }
                else
                {
                    a = true;
                }
            }
            return a;
        }

        public bool KiemtraUsername(string strsql)
        {
            con = getcon();
            con.Open();
            sqlcom = new SqlCommand(strsql, con);
            int tontai = (int)(sqlcom.ExecuteScalar());
            con.Close();
            if (tontai > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

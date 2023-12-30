using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BaoCaoThongKe
{
    public class ThamSo
    {
        public static byte Admin
        {
            get
            {
                DataService DT_SV = new DataService();
                object obj = DT_SV.ExecuteScalar(new SqlCommand("SELECT ADMIN FROM THAM_SO"));
                return Convert.ToByte(obj);
            }
            set
            {
                DataService DT_SV = new DataService();
                DT_SV.ExecuteNoneQuery(new SqlCommand("UPDATE THAM_SO SET ADMIN="+value));

            }         

        }
        private static string M_USERNAME;

        public static string USERNAME
        {
            get{return M_USERNAME;}
            set{M_USERNAME=value;}
        }
        private static string M_PASSWORD;
	
        public static string PASSWORD
        {
            get{return M_PASSWORD;}
            set{M_PASSWORD=value;}
        }


        }
    }


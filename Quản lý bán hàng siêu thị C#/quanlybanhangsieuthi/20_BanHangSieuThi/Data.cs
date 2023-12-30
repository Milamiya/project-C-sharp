using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _20_BanHangSieuThi
{
    class Data
    {
        public static SqlConnection Conn;
        public static string connString;

        public static void Connect()
        {
            connString = "server=P2SHARE;uid=sa;pwd=p2share;database=BanHangSieuThi";
            Conn = new SqlConnection(connString);// gọi đối tg kết nối
            Conn.Open();// mở kết nối
        }

        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)// kiểm tra dk nếu kết nối dc
            {
                Conn.Close();//đóng kết nối
                Conn.Dispose();// giải phóng tài nguyên
                Conn = null;// gán lại biến kết nối bằng rỗng
            }
        }

        public static DataTable GetDataToTable(string sql)
        {

            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlAdapter.Fill(dt);
            conn.Close();
            return dt;

        }
        public static bool Checkey(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter mydata = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

       public static void RunSql(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Data.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        //public static void RunSql(string sql)
        //{
        //    SqlConnection conn = new SqlConnection(connString);
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    try
        //    {
        //        cmd.ExecuteNonQuery();//thực thi các câu lệnh sql không yêu cầu trả về tập dữ liệu,VD insert, update,delete

        //    }
        //    catch (SqlException se)
        //    {
        //        MessageBox.Show("Lỗi cơ sở dữ liệu! Hãy nhấn F1!");
        //        MessageBox.Show("" + se.Message);
        //    }
        //}

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Data.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cmd.Dispose();
            cmd = null;
        }

        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1990))
                return true;
            else
                return false;
        }

        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, Data.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Data.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay = DateTime.Now.ToShortDateString().Split('/');
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime = DateTime.Now.ToLongTimeString().Split(':');
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];

            //xóa kí tự trắng và PM or AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        public static string ChuyenSoSangChu(string sNumber)
        {
            int mLen;
            int mDigit;
            string mTemp = "";
            string[] mNumText;
            // xóa các dấu phẩy nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1;
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + "" + mNumText[mDigit];
                if (mLen == i)//chữ số cuối cùng ko cần xét tiếp
                    break;
                switch ((mLen - i) % 9)
                {
                    case 0:
                        mTemp = mTemp + " tỉ";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 6:
                        mTemp = mTemp + " triệu";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    case 3:
                        mTemp = mTemp + " nghìn";
                        if (sNumber.Substring(i + 1, 3) == "000")
                            i = i + 3;
                        break;
                    default:
                        switch ((mLen - i) % 3)
                        {
                            case 2:
                                mTemp = mTemp + " trăm";
                                break;
                            case 1:
                                mTemp = mTemp + " mười";
                                break;
                        }
                        break;
                }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mười không", "");
            mTemp = mTemp.Replace("không mười không", "");

            //Loại bỏ trường hợp 00x
            mTemp = mTemp.Replace("không mười", "linh");

            //loại bỏ trường hợp x0,x>=2
            mTemp = mTemp.Replace("mười không", "mười");

            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mười", "mười");

            //Fix trường hợp x4,x>=2
            mTemp = mTemp.Replace("mười bốn", "mười tư");

            //fix trường họp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");

            //fix trường hợp x5,x>=2
            mTemp = mTemp.Replace("mười năm", "mười lăm");

            //fix th x1,x>=2
            mTemp = mTemp.Replace("mười một", "mười một");

            //fix trường hơpk x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");

            //bỏ ký tự space
            mTemp = mTemp.Trim();

            //viết hoa kí tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
    }
}
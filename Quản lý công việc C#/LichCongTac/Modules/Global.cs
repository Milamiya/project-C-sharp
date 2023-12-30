using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LichCongTac.Modules
{
    public class Global
    {
        Modules.StringMessage strMess = new StringMessage();

        //Hàm Kiểm Tra Dữ Liệu Có Trong Database Hay Không
        public Boolean Test_Record_Database(string strChuoiDieuKien, string strTableName, SqlConnection sqlCNN)
        {
            bool bolReturn = false;
            string strSQL = "Select * from " + strTableName.Trim() + " where " + strChuoiDieuKien;
            SqlCommand sqlCmd = new SqlCommand(strSQL, sqlCNN);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            //if ((sqlReader != null) && (!sqlReader.IsClosed)) sqlReader.Close();
            if (sqlReader.HasRows)
            {
                bolReturn = true;
            }
            sqlReader.Dispose();
            sqlReader.Close();
            return bolReturn;
        }

        //Hàm Thực Hiện Câu Lệnh Sql
        public void SQL_Database(string str, SqlConnection conn)
        {
            if (MessageBox.Show(strMess.strCoMuonThucHien, strMess.strTieuDe, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                SqlCommand commn = new SqlCommand(str, conn);
                commn.ExecuteNonQuery();
                MessageBox.Show(strMess.strThaoTacThanhCong, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(strMess.strHuyThaoTac, strMess.strTieuDe, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                SqlCommand commn = new SqlCommand(str, conn);
                commn.ExecuteNonQuery();
            }
        }

        //Tải Dữ Liệu Vào ListView 
        public void LoadDataListView(DataTable dtTable, ListView listV)
        {
            listV.Items.Clear();
            for (int i = 0; i <= dtTable.Rows.Count - 1; i++)
            {
                listV.Items.Add(dtTable.Rows[i]["TenDangNhap"].ToString().Trim());
                listV.Items[i].SubItems.Add(dtTable.Rows[i]["NgayBatDau"].ToString().Trim());
                listV.Items[i].SubItems.Add(dtTable.Rows[i]["NgayKetThuc"].ToString().Trim());
                listV.Items[i].SubItems.Add(dtTable.Rows[i]["NoiDungCongViec"].ToString().Trim());
                listV.Items[i].SubItems.Add(dtTable.Rows[i]["TrangThaiThucHien"].ToString().Trim());

            }
        }

        //Hàm Chuyển Đổi Ngày Tháng Năm Thành Tháng Ngày Năm Hoặc Ngược lại
        public string Convert_Day(string strDay)
        {
            try
            {
                string str1 = strDay.Substring(0, 3);
                string str2 = strDay.Substring(3, 3);
                string str3 = strDay.Substring(6, 4);
                return str2 + str1 + str3;
            }
            catch
            {
                return null;
            }
        }

        //Hàm tạo bảng và chèn dữ liệu vào DataGrid
        public void LoadDataGrid(DataGrid grd, string strSQL,SqlConnection sqlCNN)
        {
            SqlDataAdapter sqlADP= null;
            DataTable dtTable = null;
            try
            {
                sqlADP = new SqlDataAdapter(strSQL, sqlCNN);
                dtTable = new DataTable();
                sqlADP.Fill(dtTable);
                if(dtTable!=null)
                {
                    DataColumn dc = new DataColumn();
                    dc.ColumnName = "Select";
                    dc.DataType = Type.GetType("System.Boolean");
                    dc.DefaultValue = false;
                    if(dtTable.Columns.Contains("Select")==false)
                    {
                        dtTable.Columns.Add(dc);
                    }
                    dtTable.DefaultView.AllowDelete=false;
                    dtTable.DefaultView.AllowEdit=true;
                    dtTable.DefaultView.AllowNew=false;
                    grd.DataSource=dtTable;
                }
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message,strMess.strTieuDe,MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            finally
            {
                sqlADP = null;
                dtTable = null;
            }
        }

        //Chuyển Đổi Định Dạng Của Ngày (01/01/2008)
        public string ConvertFormatDay(string str)
        {
            int intFirstSymbol = str.IndexOf("/");
            if (intFirstSymbol == 1)
            {
                str = "0" + str;
            }
            int intSecondSymbol = str.IndexOf("/", 3);          
            if (intSecondSymbol == 4)
            {
                int intLengthOfYear = str.Length - 3;
                str = str.Substring(0, 3) + "0" + str.Substring(3,intLengthOfYear);
            }
            return str;
        }

        //Hàm Kiểm tra xem có phải chuỗi nhập vào là một số hay không
        public bool TestNumber(string str)
        {
            try
            {
                double doubleNumber = 0;
                doubleNumber = Double.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Hàm Đổi Giờ Ra Số 
        public int ConvertTime(string str)
        {
            int intFirstColon = str.IndexOf(":");
            string strHour = str.Substring(0, intFirstColon);
            int intSpace = str.IndexOf(" ");
            string strMinute = str.Substring(intFirstColon + 1, intSpace - 1 - intFirstColon);
            string strTime = str.Substring(intSpace + 1, 2);

            int intHour = Convert.ToInt32(strHour);
            intHour = intHour * 60;
            int intMinute = Convert.ToInt32(strMinute);
            int intTime = 0;
            if (strTime == "PM")
            {
                intTime = 60 * 12;
            }

            return intHour + intMinute + intTime;
        }

        //Hàm Lấy Ngày Trong Chuỗi dd/mm/yyyy
        public string getDay(string str)
        {
            int intFirstSymbol = str.IndexOf("/");
            string strDay = str.Substring(0, intFirstSymbol);
            return strDay;
        }

        //Hàm Lấy Tháng Trong Chuỗi dd/mm/yyyy
        public string getMonth(string str)
        {
            int intFirstSymbol = str.IndexOf("/");
            int intSecondSymbol = str.IndexOf("/", intFirstSymbol + 1);
            string strMonth = str.Substring(intFirstSymbol + 1, intSecondSymbol - intFirstSymbol - 1);
            return strMonth;
        }

        //Hàm Lấy Năm Trong Chuỗi dd/mm/yyyy
        public string getYear(string str)
        { 
            int intFirstSymbol = str.IndexOf("/");
            int intSecondSymbol = str.IndexOf("/", intFirstSymbol + 1);
            string strYear = str.Substring(intSecondSymbol + 1, str.Length - intSecondSymbol - 1);
            return strYear;
        }
    }
}

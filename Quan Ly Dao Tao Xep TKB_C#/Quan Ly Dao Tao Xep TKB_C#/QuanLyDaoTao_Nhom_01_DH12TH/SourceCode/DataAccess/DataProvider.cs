using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using QuanLyDaoTao.Properties;
using QuanLyDaoTao.Utilities;
using QuanLyDaoTao.Presentation;
using System.Data.OleDb;

namespace QuanLyDaoTao.DataAccess
{
    /// <summary>
    /// Cung cấp các dịch vụ cơ bản để thao tác với CSDL.
    /// </summary>
    public class DataProvider
    {
        #region Biến thành viên

        /// <summary>
        /// String: Chuỗi kết nối
        /// </summary>
        private string _strConnect;

        /// <summary>
        /// SqlConnection: Đối tượng kết nối
        /// </summary>
        private SqlConnection _connect;
        
        #endregion

        #region Thuộc tính

        /// <summary>
        /// String: Chuỗi kết nối
        /// </summary>
        public string ConnectionString
        {
            get { return _strConnect; }
            set { _strConnect = value; }
        }

        /// <summary>
        /// SqlConnection: Đối tượng kết nối.\nRead-only
        /// </summary>
        public SqlConnection Connection
        {
            get { return _connect; }
        }

        #endregion

        #region Phương thức

        /// <summary>
        /// Tự động tạo chuỗi kết nối và kết nối thử để kiểm tra.
        /// \nNếu kết nối không thành công sẽ hiện form cấu hình kết nối
        /// </summary>
        public DataProvider()
        {
            _strConnect = Settings.Default.ConnectString;
            // Nếu không kết nối được
            if (!frmAddConnection.TestConnect())
            {
                if (frmAddConnection.Show() == DialogResult.OK)
                    _strConnect = Settings.Default.ConnectString;
                else
                    Environment.Exit(1);
            }
            Connect();
        }

        #region Thao tác đóng, mở kết nối

        /// <summary>
        /// Hàm kiểm tra kết nối với chuỗi kết nối mặc định (là thành viên của lớp này)
        /// </summary>
        /// <returns>True: kết nối thành công. False: không thành công</returns>
        private bool Connect()
        {
            try
            {
                _connect = new SqlConnection(_strConnect);
                OpenConnect();
                return true;
            }
            catch (SqlException ex)
            {
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        /// <summary>
        /// Kiểm tra kết nối với Database theo chuỗi kết nối truyền vào
        /// </summary>
        /// <param name="strConnect">String: Chuỗi kết nối</param>
        /// <returns></returns>
        protected bool TestConnect(string strConnect)
        {
            if (strConnect != "")
                _strConnect = strConnect;
            return Connect();
        }


        /// <summary>
        /// Mở kết nối
        /// </summary>
        protected void OpenConnect()
        {
            try
            {
                if (_connect == null)
                {
                    _connect = new SqlConnection(_strConnect);
                    _connect.Open();
                }
                else if (_connect.State == ConnectionState.Closed)
                    _connect.Open();
            }
            catch(Exception ex)
            {
                ExceptionUtil.Throw(ex.Message);
            }
        }

        /// <summary>
        /// Đóng kết nối
        /// </summary>
        protected void CloseConnect()
        {
            _connect.Close();
        }

        #endregion

        #region Hàm thực thi các câu lệnh sql

        /// <summary>
        /// Hàm thực hiện câu query truyền vào
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <returns>Int: Số dòng được thực thi</returns>
        public int ExecuteNonQuery(string sql)
        {
            int numRecords = 0;
            SqlTransaction sqlTran = null;
            try
            {
                // Mở kết nối
                this.OpenConnect();
                // Mở Transaction
                sqlTran = _connect.BeginTransaction();
                SqlCommand command = new SqlCommand(sql, _connect, sqlTran);
                numRecords = command.ExecuteNonQuery();
                // Thực thi
                sqlTran.Commit();
            }
            catch (SqlException ex)
            {
                //Roolback data
                if (sqlTran != null)
                    sqlTran.Rollback();
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
            }
            finally
            {
                // Đóng kn
                CloseConnect();
            }
            // Trả về số record thực thi
            return numRecords;
        }

        /// <summary>
        /// Hàm thực hiện câu lệnh truyền vào
        /// </summary>
        /// <param name="command">SqlCommand: Câu lệnh cần thực hiện</param>
        /// <returns>Int: Số dòng được thực thi</returns>
        public int ExecuteNonQuery(SqlCommand command)
        {
            int numRecords = 0;
            SqlTransaction sqlTran = null;
            try
            {
                // Mở kết nối
                this.OpenConnect();
                // Mở Transaction
                sqlTran = _connect.BeginTransaction();
                command.Connection = _connect;
                command.Transaction = sqlTran;
                numRecords = command.ExecuteNonQuery();
                // Thực thi
                sqlTran.Commit();
            }
            catch (SqlException ex)
            {
                //Roolback data
                if (sqlTran != null)
                    sqlTran.Rollback();
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
            }
            finally
            {
                // Đóng kn
                CloseConnect();
            }
            // Trả về số record thực thi
            return numRecords;
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                SqlCommand command = new SqlCommand(sql, _connect);
                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
        }

        public SqlDataReader ExecuteReader(SqlCommand command)
        {
            try
            {
                command.Connection = _connect;
                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Lấy giá trị của dòng đầu tiên, cột đầu tiên
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <returns>Object: có thể ép kiểu lại.</returns>
        public object ExecuteScalar(string sql)
        {
            try
            {
                OpenConnect();
                SqlCommand command = new SqlCommand(sql, _connect);
                return command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
            finally
            {
                CloseConnect();
            }
        }

        /// <summary>
        /// Lấy giá trị của dòng đầu tiên, cột đầu tiên
        /// </summary>
        /// <param name="command">SqlCommand: Câu lệnh cần thực hiện</param>
        /// <returns>Object: có thể ép kiểu lại.</returns>
        public object ExecuteScalar(SqlCommand command)
        {
            try
            {
                OpenConnect();
                command.Connection = _connect;
                return command.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
                return string.Empty;
            }
            finally
            {
                CloseConnect();
            }
        }

        /// <summary>
        /// Lấy mã cuối cùng của 1 mã số trong 1 bảng (Dùng để tính toán lấy mã số tiếp theo)
        /// </summary>
        /// <param name="nameTable">String: Tên datatabale</param>
        /// <param name="nameSelectColumn">String: Tên cột mã số</param>
        /// <returns>String: Mã cuối cùng</returns>
        public string GetLastID(string nameTable, string nameSelectColumn)
        {
            SqlCommand command = new SqlCommand("Select top 1 " + nameSelectColumn + " from " + nameTable + " order by " + nameSelectColumn + " desc", _connect);
            return (string) ExecuteScalar(command);
        }

        /// <summary>
        /// Hàm lấy DataTable từ 1 chuỗi truy vấn
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <returns>Datatable: Kết quả truy vấn</returns>
        public DataTable GetTable(string sql)
        {
            try
            {
                // Tạo dataApdapter vai trò như 1 ống hút thực hiện query đổ vào Datatable
                SqlDataAdapter dataApdater = new SqlDataAdapter(sql, _connect);
                DataTable table = new DataTable();
                // Đổ vào database
                dataApdater.Fill(table);
                return table;
            }
            catch (SqlException ex)
            {
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Hàm lấy DataTable từ 1 chuỗi truy vấn
        /// </summary>
        /// <param name="sql">SqlCommand: Câu lệnh cần thực hiện</param>
        /// <returns>Datatable: Kết quả truy vấn</returns>
        public DataTable GetTable(SqlCommand command)
        {
            try
            {
                command.Connection = _connect;
                // Tạo dataApdapter vai trò như 1 ống hút thực hiện query đổ vào Datatable
                SqlDataAdapter dataApdater = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                // Đổ vào database
                dataApdater.Fill(table);
                return table;
            }
            catch (SqlException ex)
            {
                ExceptionUtil.Throw(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Truy vấn lấy dòng đầu tiên
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <returns>DataRow: Dòng đầu tiên của kết quả</returns>
        public DataRow GetFirstDataRow(string sql)
        {
            try
            {
                return GetTable(sql).Rows[0];
            }
            catch (Exception ex)
            {
                ExceptionUtil.Throw(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Truy vấn lấy dòng đầu tiên
        /// </summary>
        /// <param name="sql">SqlCommand: Câu lệnh cần thực hiện</param>
        /// <returns>DataRow: Dòng đầu tiên của kết quả</returns>
        public DataRow GetFirstDataRow(SqlCommand command)
        {
            try
            {
                return GetTable(command).Rows[0];
            }
            catch (Exception ex)
            {
                ExceptionUtil.Throw(ex.Message);
                return null;
            }
        }

        #endregion

        /// <summary>
        /// Update nguyên bảng xuống CSDL 1 lần 1 luôn. Kaka dữ chưa
        /// </summary>
        /// <param name="db">DataTable</param>
        /// <returns>int: số dòng ảnh hưởng</returns>
        public int UpdateTable(DataTable table)
        {
            int result = 0;
            SqlTransaction tr = null;
            try
            {
                this.OpenConnect();

                tr = _connect.BeginTransaction();

                SqlCommand command = new SqlCommand("Select * from NHANVIEN");
                command.Connection = _connect;
                command.Transaction = tr;

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                result = dataAdapter.Update(table);

                tr.Commit();

            }
            catch (Exception e)
            {
                if (tr != null)
                    tr.Rollback();
                ExceptionUtil.Throw(e.Message);

            }
            finally
            {
                this.CloseConnect();
            }
            return result;
        }

        public bool BackupDatabase(string fileName, string path)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"BACKUP DATABASE @databasename TO  DISK = @path WITH NOFORMAT, NOINIT,  NAME = @ten, SKIP, NOREWIND, NOUNLOAD,  STATS = 10");
                cmd.Parameters.Add("path", SqlDbType.NVarChar).Value = path + @"\" + fileName;
                cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = fileName;
                cmd.Parameters.Add("databasename", SqlDbType.NVarChar).Value = _connect.Database;
                cmd.Connection = _connect;
                OpenConnect();
                return cmd.ExecuteNonQuery() == -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnect();
            }
        }

        public bool RestoreDatabase(string path)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Use master RESTORE DATABASE @databasename FROM  DISK = @path WITH  FILE = 1,  NOUNLOAD, REPLACE,  STATS = 10");
                cmd.Parameters.Add("path", SqlDbType.NVarChar).Value = path;
                cmd.Parameters.Add("databasename", SqlDbType.NVarChar).Value = Settings.Default.DatabaseName;
                cmd.Connection = _connect;
                OpenConnect();
                return cmd.ExecuteNonQuery() == -1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnect();
            }
        }

        #endregion

        public void ImportDataFromExcel(string path, string tableName, string selectCommand)
        {
            //string myexceldataquery = "select student,rollno,course from [" + tableName + "$]";
            try
            {
                string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source=" + path + ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
                OleDbCommand oledbcmd = new OleDbCommand(selectCommand, oledbconn);
                oledbconn.Open();
                OleDbDataReader dr = oledbcmd.ExecuteReader();
                SqlBulkCopy bulkcopy = new SqlBulkCopy(this._connect);
                bulkcopy.DestinationTableName = tableName;
                OpenConnect();
                while (dr.Read())
                {
                    bulkcopy.WriteToServer(dr);
                }
                oledbconn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnect();
            }
        }
    }

}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FirstConnectDB;
using FirstConnectDB.Properties;
using Util;

namespace QLHS.DAL
{
    public class ConnectData
    {
        private SqlCommand _mCommand;
        private SqlConnection _mConnect;
        private SqlDataAdapter _mDataApdater;
        private DataTable _mTable;
        private string _strConnect = "";


        protected ConnectData()
        {
            _strConnect = Settings.Default.ConnectString;
            // Nếu không kết nối được
            if (!FrmAddConnection.TestConnect())
            {
                if (FrmAddConnection.Show() == DialogResult.OK)
                    _strConnect = Settings.Default.ConnectString;
                else
                    Environment.Exit(1);
            }

            Connect();
        }

        #region Thao tác đóng, mở kết nối

        /// <summary>
        /// Hàm kết nối CSDL
        /// </summary>
        /// <returns>Bool</returns>
        private bool Connect()
        {
            try
            {
                _mConnect = new SqlConnection(_strConnect);
                OpenConnect();
                return true;
            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnect();
            }
        }

        /// <summary>
        /// Kiểm tra kết nối với Database
        /// </summary>
        /// <param name="strConnect">String: Chuỗi kết nối</param>
        /// <returns></returns>
        protected bool TestConnect(string strConnect = "")
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
                if (_mConnect != null)
                    if (_mConnect.State == ConnectionState.Closed)
                        _mConnect.Open();
            }
            catch
            {
                return;
            }
        }

        /// <summary>
        /// Đóng kết nối
        /// </summary>
        protected void CloseConnect()
        {
            if (_mConnect != null)
                if (_mConnect.State == ConnectionState.Open)
                    _mConnect.Close();
        }

        #endregion

        /// <summary>
        /// Hàm lấy DataTable từ 1 chuỗi truy vấn
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <param name="setPropertiesDataTable">Bool (default FALSE): Sử dụng properties DataTable hay không? 
        /// Nếu có dùng gridview chỉnh sửa nhiều dòng thì bắt buộc phải setPropertiesDataTable = TRUE </param>
        /// <returns>Datatable: Kết quả truy vấn</returns>
        protected DataTable GetTable(string sql, bool setPropertiesDataTable = false)
        {
            try
            {
                if (setPropertiesDataTable)
                {
                    // Tạo dataApdapter vai trò như 1 ống hút thực hiện query đổ vào Datatable
                    _mDataApdater = new SqlDataAdapter(sql, _mConnect);
                    _mTable = new DataTable();
                    // Đổ vào database
                    _mDataApdater.Fill(_mTable);
                    return _mTable;
                }
                var ap = new SqlDataAdapter(sql, _mConnect);
                var tb = new DataTable();
                ap.Fill(tb);
                return tb;
            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Truy vấn lấy dòng đầu tiên
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <returns>DataRow: Dòng đầu tiên của kết quả</returns>
        protected DataRow GetFirstDataRow(string sql)
        {
            return GetTable(sql).Rows[0];
        }

        /// <summary>
        /// Lấy 1 dòng mới ứng với DataTable (Bắt buột trên Datatable truy vấn lần trước phải set properties = TRUE)
        /// </summary>
        /// <returns>Datarow: Dòng mới với kiểu dữ liệu từ DataTable hiện tại</returns>
        protected DataRow GetNewRow()
        {
            return _mTable.NewRow();
        }

        /// <summary>
        /// Lưu 1 dòng mới vào DataTable (Bắt buột trên Datatable truy vấn lần trước phải set properties = TRUE)
        /// </summary>
        /// <param name="dr">Datarow: Dòng mới với kiểu dữ liệu từ DataTable hiện tại được tạo từ hàm GetNewRow()</param>
        protected void AddNewRow(DataRow dr)
        {
            _mTable.Rows.Add(dr);
        }

        #region Hàm thực thi các câu lệnh sql

        /// <summary>
        /// Hàm thực hiện câu query truyền vào
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <returns>Int: Số dòng được thực thi</returns>
        protected int ExecuteQuery(string sql)
        {
            int numRecords = 0;
            SqlTransaction sqlTran = null;
            try
            {
                // Mở kết nối
                OpenConnect();
                // Mở Transaction
                sqlTran = _mConnect.BeginTransaction();
                var sqlComm = new SqlCommand(sql, _mConnect) {Transaction = sqlTran};
                numRecords = sqlComm.ExecuteNonQuery();
                // Thực thi
                sqlTran.Commit();
            }
            catch (SqlException ex)
            {
                // Roolback data
                if (sqlTran != null)
                    sqlTran.Rollback();
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
            }
            finally
            {
                // Đóng kn
                CloseConnect();
            }
            // Trả về số record thực thi
            return numRecords;
        }

        protected SqlDataReader ExecuteReader(string sql)
        {
            try
            {
                var command = new SqlCommand(sql, _mConnect);
                return command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Lấy giá trị của dòng đầu tiên, cột đầu tiên
        /// </summary>
        /// <param name="sql">String: Chuỗi truy vấn</param>
        /// <returns>Object: có thể ép kiểu lại.</returns>
        protected object ExecuteScalar(string sql)
        {
            try
            {
                OpenConnect();
                _mCommand = new SqlCommand(sql, _mConnect);
                return _mCommand.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                ExceptionUtil.ThrowMsgBox(ex.ErrorCode + ": " + ex.Message);
                return null;
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
        protected string GetLastID(string nameTable, string nameSelectColumn)
        {
            string sql = "SELECT TOP 1 * FROM " + nameTable + " ORDER BY " + nameSelectColumn + " DESC";
            return (string) ExecuteScalar(sql);
        }

        #endregion
    }
}
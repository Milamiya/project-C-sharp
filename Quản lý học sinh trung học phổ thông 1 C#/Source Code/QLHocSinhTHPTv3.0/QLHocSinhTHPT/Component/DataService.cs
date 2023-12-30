using System;
using System.Xml;
using System.Data;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using QLHocSinhTHPT.Component;

namespace QLHocSinhTHPT
{
    partial class DataService : DataTable
    {
        #region Fields
        private static  SqlConnection   m_Connection;
        public static   String          m_ConnectString = "";
        private         SqlCommand      m_Command;
        private         SqlDataAdapter  m_DataAdapter;
        #endregion

        #region Constructor
        public DataService()
        {

        }
        #endregion

        #region Hàm lấy lệnh connection
        public static void ConnectionString()
        {
            XmlDocument xmlDoc = XML.XMLReader("Connection.xml");
            XmlElement  xmlEle = xmlDoc.DocumentElement;

            try
            {
                if (xmlEle.SelectSingleNode("costatus").InnerText == "true")
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";Integrated Security=True;";
                }
                else
                {
                    m_ConnectString = "Data Source=" + xmlEle.SelectSingleNode("servname").InnerText + ";Initial Catalog=" + xmlEle.SelectSingleNode("database").InnerText + ";User Id=" + xmlEle.SelectSingleNode("username").InnerText + ";Password=" + xmlEle.SelectSingleNode("password").InnerText + ";";
                }

                Utilities.DatabaseName = xmlEle.SelectSingleNode("database").InnerText;
            }
            catch
            {
                MessageBoxEx.Show("Lỗi kết nối đến cơ sở dữ liệu! Xin vui lòng thiết lập lại kết nối...", "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load
        public void Load(SqlCommand m_Sql)
        {
            m_Command = m_Sql;
            try
            {
                m_Command.Connection = m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                this.Clear();
                m_DataAdapter.Fill(this);
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion

        #region OpenConnection
        public static bool OpenConnection()
        {
            if (m_ConnectString == "")
                ConnectionString();
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch
            {
                m_Connection.Close();
                return false;
            }
        }
        #endregion

        #region CloseConnection
        public void CloseConnection()
        {
            m_Connection.Close();
        }
        #endregion

        #region Update DataTable
        public int ExecuteNoneQuery()
        {
            int result = 0;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = m_SqlTran;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);

                result = m_DataAdapter.Update(this);
                m_SqlTran.Commit();
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }
        #endregion

        #region Thực thi câu lệnh SQL
        public int ExecuteNoneQuery(SqlCommand m_Sql)
        {
            int result = 0;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();

                m_Sql.Connection = m_Connection;
                m_Sql.Transaction = m_SqlTran;
                result = m_Sql.ExecuteNonQuery();

                this.AcceptChanges();
                m_SqlTran.Commit();
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }
        #endregion

        #region ExecuteScalar
        public object ExecuteScalar(SqlCommand m_Sql)
        {
            object result = null;
            SqlTransaction m_SqlTran = null;
            try
            {
                m_SqlTran = m_Connection.BeginTransaction();
                m_Sql.Connection = m_Connection;
                m_Sql.Transaction = m_SqlTran;
                result = m_Sql.ExecuteScalar();

                this.AcceptChanges();
                m_SqlTran.Commit();
                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch
            {
                if (m_SqlTran != null)
                    m_SqlTran.Rollback();
                throw;
            }
            return result;
        }
        #endregion

        #region Đổi mật khẩu, thiết lập lại kết nối
        public void ChangePassword(String userName, String newPassword)
        {
            m_DataAdapter = new SqlDataAdapter();
            
            SqlCommand cmd = new SqlCommand("UPDATE NGUOIDUNG SET MatKhau = @matkhau WHERE TenDNhap = @tendangnhap");
            cmd.Parameters.Add("tendangnhap", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("matkhau", SqlDbType.VarChar).Value = newPassword;

            if (m_ConnectString == "")
                ConnectionString();

            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(m_ConnectString);
                m_Connection.Open();
            }

            m_Command = new SqlCommand();
            m_Command = cmd;

            try
            {
                m_Command.Connection = m_Connection;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                //this.Clear();

                m_DataAdapter.Fill(this);

                SqlCommandBuilder buider = new SqlCommandBuilder(m_DataAdapter);
                m_DataAdapter.Update(this);
            }
            catch (Exception e)
            {
                MessageBoxEx.Show("Không thể thực thi câu lệnh SQL này!\nLỗi: " + e.Message, "ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
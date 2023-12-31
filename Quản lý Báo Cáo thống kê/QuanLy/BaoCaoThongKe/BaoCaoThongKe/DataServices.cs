using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.OleDb;
using BaoCaoThongKe;


namespace BaoCaoThongKe
{
    public class DataService : DataTable
    {
        static SqlConnection m_Connection;
        SqlDataAdapter m_DataAdapter;
        SqlCommand m_Command;
        //
        public DataSet m_Dataset = null;
        DataSet dataset;
        public static string str_db_server = "localhost";
        public const string str_db_name = "THONGKE";
        public static string str_db_user = "sa";
        public static string str_db_password = "";


        string strConn = "Data Source = .\\SQLEXPRESS; Initial Catalog = THONGKE;Integrated Security=true;";

        public DataService()
        {
            try
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();
                Desktop.frmDangnhap.dn = true;
            }
            catch (Exception e)
            {
                Desktop.frmDangnhap.dn = false;
            }
        }

        public void Load(SqlCommand command)
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);
                m_Connection.Open();

            }
            m_Command = command;
            m_Command.Connection = m_Connection;

            m_DataAdapter = new SqlDataAdapter(m_Command);
            this.Clear();
            try
            {
                m_DataAdapter = new SqlDataAdapter(m_Command);
                m_DataAdapter.Fill(this);
            }
            catch (Exception e)
            {
                e.ToString();  
            }
        }
        public void Select(SqlCommand cmd)
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                m_Connection = new SqlConnection(strConn);

                m_Connection.Open();
            }
            m_Command = cmd;

            m_Command.Connection = m_Connection;
            this.Clear();

            try
            {
                m_DataAdapter = new SqlDataAdapter(m_Command);

                m_DataAdapter.Fill(this);
            }
            catch (Exception)
            {

            }

        }


        public void Update()
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);
            try
            {

                m_DataAdapter.Update(this);
                //MessageBox.Show("Cập nhật thành công");
                
            }
            catch (Exception e)
            {
                e.ToString();
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        public void ExecuteNonQuery(SqlCommand cmd)
        {
            cmd.Connection = m_Connection;
            cmd.ExecuteNonQuery();
        }

        public void Execute(SqlCommand cmd)
        {
            cmd.Connection = m_Connection;
            cmd.ExecuteNonQuery();
        }

        public DataTable Table(SqlCommand cmd)
        {
            cmd.Connection = m_Connection;
            DataTable table = new DataTable();
            dataset = new DataSet();
            m_DataAdapter = new SqlDataAdapter(cmd);

            m_DataAdapter.Fill(dataset);
            table = dataset.Tables[0];
            return table;
        }

        public DataTable Table(string strSQL)
        {
            DataTable table = new DataTable();
            dataset = new DataSet();
            m_DataAdapter = new SqlDataAdapter(strSQL, m_Connection);
            m_DataAdapter.Fill(dataset);
            table = dataset.Tables[0];
            return table;
        }
        public int ExecuteNoneQuery()
        {
            int KQ = 0;
            SqlTransaction sqltr = null;
            try
            {
                sqltr = m_Connection.BeginTransaction();

                m_Command.Connection = m_Connection;
                m_Command.Transaction = sqltr;

                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;

                SqlCommandBuilder Builder = new SqlCommandBuilder(m_DataAdapter);
               
                KQ = m_DataAdapter.Update(this);

                sqltr.Commit();


            }
            catch(Exception e)
            {
                if (sqltr != null)
                    sqltr.Rollback();
            }
            return KQ;
            
        }
        public int ExecuteNoneQuery(SqlCommand cmd)
        {
            int KQ = 0;
            SqlTransaction sqltr = null;

            try
            {
                sqltr = m_Connection.BeginTransaction();
                cmd.Connection = m_Connection;

                cmd.Transaction = sqltr;

                KQ = cmd.ExecuteNonQuery();
                this.AcceptChanges();
                sqltr.Commit();
            }
            catch(Exception e)
            {
                if (sqltr != null)
                    sqltr.Rollback();
                throw;
            }
            return KQ;
        }
        //
        //
        public object ExecuteScalar(SqlCommand cmd)
        {
            object result = null;
            SqlTransaction tr = null;

            try
            {
                tr = m_Connection.BeginTransaction();

                cmd.Connection = m_Connection;

                cmd.Transaction = tr;

                result = cmd.ExecuteScalar();

                this.AcceptChanges();

                tr.Commit();

                if (result == DBNull.Value)
                {
                    result = null;
                }
            }
            catch
            {
                if (tr != null) tr.Rollback();
                throw;
            }
            return result;
        }
    }
}

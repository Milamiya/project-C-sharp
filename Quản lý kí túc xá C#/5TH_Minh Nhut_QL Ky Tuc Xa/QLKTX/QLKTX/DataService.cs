using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace QLKTX
{
    public class DataService:DataTable
    {
        static SqlConnection m_Connection;
        SqlDataAdapter m_DataAdapter;
        SqlCommand m_Command;
        string strConn = "";
            //"Data Source=localhost;Initial Catalog=QLKTX;User Id=sa;Password=;";
        //string strConn = "Data Source=localhost;Initial Catalog=QLKTX;Integrated Security=true";

        public DataService()
        {        
        }
        public void Load(SqlCommand command)
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                try
                {
                    strConn = KetNoi("KetNoi");
                    m_Connection = new SqlConnection(strConn);
                    m_Connection.Open();

                }
                catch (Exception e)
                {
                    ToanCuc.TaoKetNoi ketnoi = new QLKTX.ToanCuc.TaoKetNoi();
                    ketnoi.ShowDialog();
                    strConn = KetNoi("KetNoi");
                    m_Connection = new SqlConnection(strConn);
                    m_Connection.Open();

                }
            }
            m_Command = command;
            m_Command.Connection = m_Connection;

            m_DataAdapter = new SqlDataAdapter(m_Command);
            this.Clear();

            m_DataAdapter.Fill(this);


        }
        public void ThiHanh(SqlCommand command)
        {
            if (m_Connection == null || m_Connection.State == ConnectionState.Closed)
            {
                try
                {


                    strConn = KetNoi("KetNoi").Replace("Initial Catalog=QLKTX;", ""); ;
                    m_Connection = new SqlConnection(strConn);
                    m_Connection.Open();

                }
                catch (Exception e)
                {
                    ToanCuc.TaoKetNoi ketnoi = new QLKTX.ToanCuc.TaoKetNoi();
                    ketnoi.ShowDialog();
                    strConn = KetNoi("KetNoi").Replace("Initial Catalog=QLKTX;", "");
                    m_Connection = new SqlConnection(strConn);
                    m_Connection.Open();

                }
            }

            m_Command = command;   
            m_Command.Connection = m_Connection;
            m_Command.CommandText = "use master";
            
            m_Command.ExecuteNonQuery();
            m_Command = command;            
            m_Command.ExecuteNonQuery();
        }

        public void Update()
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(m_DataAdapter);                
                int i= m_DataAdapter.Update(this);                
                System.Windows.Forms.MessageBox.Show("Thành công");
            }
            catch (Exception e)
            {                
                System.Windows.Forms.MessageBox.Show("Không Thành công");
            }
        }
        public bool CapNhat(SqlCommand s)
        {
            try
            {
                m_DataAdapter = new SqlDataAdapter(s);               

                
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                System.Windows.Forms.MessageBox.Show("Loi");
                return false;
            }
            
            
        }
        /// <summary>
        /// Lay chuoi ket noi tu registry
        /// </summary>
        /// <returns></returns>
        public string KetNoi(string s)
        {            
            RegistryKey key = Registry.CurrentUser;
            RegistryKey softKey = key.OpenSubKey("Software", true);
            RegistryKey QLKTXKey = softKey.OpenSubKey("QLKTX", true);            
            return QLKTXKey.GetValue(s).ToString();
        }
    }
}

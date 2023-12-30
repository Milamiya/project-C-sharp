using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyXeVaXe
{
    public partial class frm_backupAndRestore : Form
    {
        private SqlConnection sqlconnect, sqlconnect1;
        public frm_backupAndRestore()
        {
            InitializeComponent();
            connect();
        }

        void connect()
        {
            sqlconnect = new SqlConnection();
            sqlconnect.ConnectionString = "Data Source = THUYDUONG-PC\\SQLEXPRESS;" +
                                          "Database = GOODLUCK;" +
                                          "Integrated Security = SSPI;";
                                          
            sqlconnect.Open();
        }
        void connect1()
        {
            sqlconnect1 = new SqlConnection();
            sqlconnect1.ConnectionString = "Data Source = .\\SQLEXPRESS;" +
                                          "Database = master;" +
                                          "Integrated Security = SSPI;";
            sqlconnect1.Open();
        }
        void backup(String path)
        {

            
            try
            {
                string strBackup = "BACKUP DATABASE GOODLUCK TO DISK = '" + path + "'";
                SqlCommand cmd = sqlconnect.CreateCommand();
                cmd.CommandText = strBackup;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Backup completed!");
                
                sqlconnect.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database backup error! Please try again!");
            }

        }
        void restore(String path)
        {

            connect1();
            try
            {
                string strBackup = "RESTORE DATABASE GOODLUCK FROM DISK = '" + path + "'";
                SqlCommand cmd = sqlconnect1.CreateCommand();
                cmd.CommandText = strBackup;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Database Restore error! Please try again!");
                

                sqlconnect1.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Restore completed!");
            }

        }
        private void frm_backupAndRestore_Load(object sender, EventArgs e)
        {
            
        }
        
        

        private void button1Backup_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "(Backup file *.bak|*.bak)";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                backup(saveFileDialog1.FileName);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                restore(openFileDialog1.FileName);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

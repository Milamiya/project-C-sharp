using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;

namespace QLPKT
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            authen.SelectedIndex = 0;
            buttom_ok.Enabled = true;
            buttom_ok.BackgroundImage = Image.FromFile(@"Image\buttom_ok3.png");
            load();
            server.Text= SystemInformation.ComputerName + @"\SQLEXPRESS";
        }

        private void load()
        {
            Process netUtility = new Process();
            netUtility.StartInfo.FileName = "net.exe";
            netUtility.StartInfo.CreateNoWindow = true;
            netUtility.StartInfo.Arguments = "view";
            netUtility.StartInfo.RedirectStandardOutput = true;
            netUtility.StartInfo.UseShellExecute = false;
            netUtility.StartInfo.RedirectStandardError = true;
            netUtility.Start();
            StreamReader streamReader = new StreamReader(netUtility.StandardOutput.BaseStream,netUtility.StandardOutput.CurrentEncoding);
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                if (line.StartsWith("\\"))
                {
                    server.Items.Add(line.Substring(2).Substring(0,line.Substring(2).IndexOf(" ")).ToUpper()+@"\SQLEXPRESS");
                }
            }
            streamReader.Close();
            netUtility.WaitForExit(1000);
            server.Items.Add(SystemInformation.ComputerName + @"\SQLEXPRESS");
        }

        private void buttom_test_Click(object sender, EventArgs e)
        {
            //Quyền Windows
            if (authen.SelectedIndex == 0)
            {
                database.Items.Clear();
                SqlConnection conn = new SqlConnection("Data Source=" + server.Text + ";Initial Catalog=master;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("SP_DATABASES", conn);
                //SP_DATABASES là một store procedure có sẵn của sql server để lấy ra tất cả csdl trong sql server
                SqlDataReader reader;
                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        database.Items.Add(reader[0].ToString());
                    }
                    database.Enabled = true;
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lỗi, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    conn.Dispose();
                    cmd.Dispose();
                }
            }

            //Quyền SQL Server
            if (authen.SelectedIndex == 1)
            {
                database.Items.Clear();
                SqlConnection con = new SqlConnection("Data Source=" + server.Text + ";Initial Catalog=master;User Id=" + username.Text + ";Password=" + pass.Text + ";");
                SqlCommand cmd = new SqlCommand("SP_DATABASES", con);
                SqlDataReader reader;

                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        database.Items.Add(reader[0].ToString());
                    }
                    database.Enabled = true;
                    MessageBox.Show("Kết nối thành công!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Lỗi, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();

                    con.Dispose();
                    cmd.Dispose();
                }
            }
        }

        private void authen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authen.SelectedIndex == 0)
            {
                username.Enabled = false;
                pass.Enabled = false;
            }
            else
            {
                username.Enabled = true;
                pass.Enabled = true;
            }
        }

        private void database_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttom_ok.Enabled = true;
            buttom_ok.BackgroundImage = Image.FromFile(@"Image\buttom_ok.png");
        }

        private void buttom_ok_Click(object sender, EventArgs e)
        {
            if (authen.SelectedIndex == 0)
                Connect.WriteFile(server.Text, database.Text, "", "");
            else Connect.WriteFile(server.Text, database.Text, username.Text, pass.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

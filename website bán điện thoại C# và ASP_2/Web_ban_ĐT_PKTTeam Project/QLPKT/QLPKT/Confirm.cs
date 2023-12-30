using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLPKT
{
    public partial class Confirm : Form
    {
        SqlConnection conn;
        string manager;
        string check;

        public Confirm(string c)
        {
            InitializeComponent();
            Config file = new Config(Application.StartupPath + "\\config.ini");
            string connectionstring = file.ReadValue("server", "connstring");
            conn = new SqlConnection(connectionstring);
            check = c;
        }

        private void buttom_confirm_Click(object sender, EventArgs e)
        {
            if (account.Text.Length == 0 || pass.Text.Length == 0)
                error.Text = "User và Pass không được rỗng!";
            else
            {
                string sql = "select* from Admin where MaAD=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", account.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                bool kt = reader.Read(); reader.Close();
                if (kt)
                {
                    cmd.CommandText = "select* from Admin where MaAD=@id and PassWord=@pass";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@id", account.Text);
                    cmd.Parameters.AddWithValue("@pass", pass.Text);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        error.Text = "Đăng nhập thành công";
                        manager = reader["Manager"].ToString();
                        reader.Close();
                        conn.Close();
                    }
                    else error.Text = "Sai password!";
                }
                else error.Text = "Account không tồn tại";
                conn.Close();
            }

            conn.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Manager where MaM='" + manager + "'", conn);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                if ((bool)reader2["MASTER"] == true || (bool)reader2[check] == true)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    error.Text = "Xác nhận thành công";
                }
                else
                    error.Text = "Người này không có quyền xác nhận";
            }
            reader2.Close();
            conn.Close();

        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

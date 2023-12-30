using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace QLPKT
{
    public partial class Changepass : Form
    {
        public string user;
        public string pass;
        SqlConnection conn;

        public Changepass(string user1, string pass1,SqlConnection conn1)
        {
            InitializeComponent();
            user = user1;
            pass = pass1;
            conn = conn1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Changepass_Load(object sender, EventArgs e)
        {
            namebox.Text = user;
            passcode.Focus();
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {

            if (newpass.Text.Length == 0 || confirmpass.Text.Length == 0)
                error.Text = "Change password not success! Please check again!";
            else if (error1.Text.Length != 0 || error2.Text.Length != 0 || error3.Text.Length != 0)
                error.Text = "Change password not success! Please check again!";
            else
            {
                string sql = "update Admin set PassWord=@pass where UserName=@user";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@pass", confirmpass.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                error.Text = "Change password success!";
            }
        }

        private void newpass_TextChanged(object sender, EventArgs e)
        {
            if (newpass.Text.Length > 15 || newpass.Text.Length < 6)
                error1.Text = "Your password must be 6 to 15 characters long!";
            else if (newpass.Text.Length == 0)
                error1.Text = "Not Null";
            else if (Regex.IsMatch(newpass.Text, @" +$"))
                error1.Text = "Not type space!";
            else error1.Text = "";
        }

        private void passcode_TextChanged(object sender, EventArgs e)
        {
            if (passcode.Text != pass)
                error3.Text = "Incorrect password!";
            else error3.Text = "";
        }
        private void confirmpass_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(confirmpass.Text, newpass.Text) == 0)
                error2.Text = "";
            else error2.Text = "The passwords you entered do not match!";
        }

    }
}

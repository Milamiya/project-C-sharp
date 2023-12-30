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
    public partial class Factory_Add : Form
    {
        private SqlConnection conn;

        public bool bname = false;
        public bool bphone = true;
        public bool bemail = true;
        public bool badd = true;

        public Factory_Add(SqlConnection conn1)
        {
            InitializeComponent();
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void buttom_add_Click(object sender, EventArgs e)
        {
            if (bname == false || bphone == false || bemail == false || badd == false)
            {
                error.Text = "Add not success! Please check again!";
            }
            else
            {
                string sql = "insert NhaSanXuat (MaSX,TenSX,DT,Email,DiaChi) values('',@name,@phone,@email,@add)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@name", namebox.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@add", add.Text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select top(1) MaSX from NhaSanXuat order by MaSX desc";
                id.Text = (string)cmd.ExecuteScalar();
                conn.Close();
                error.Text = "Add success!";
                this.DialogResult = DialogResult.OK;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            phone.Clear();
            email.Clear();
            add.Clear();
            id.Clear();
            error.Text = "";
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(namebox.Text, "[a-zA-Z]+$"))
            {
                errorProvider1.SetError(namebox, "Allow char");
                bname = false;
            }
            else
            {
                errorProvider1.Clear();
                error.Text = "";
                bname = true;
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(phone.Text, "[^0-9-]+"))
            {
                errorProvider1.SetError(phone, "Allow number, not type space");
                bphone = false;
            }
            else if (phone.Text.Length == 0)
            {
                errorProvider1.SetError(phone, "Allow number, not type space");
                bphone = false;
            }
            else if (phone.Text.Length > 10 || phone.Text.Length < 10)
            {
                errorProvider1.SetError(phone, "Allow number 10 characters");
                bphone = false;
            }
            else
            {
                errorProvider1.Clear();
                bphone = true;
                error.Text = "";
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(email.Text, @"^[A-z0-9_]+([.][A-z0-9_]+)*([@][A-z0-9_]{3,})+([.][A-z0-9_]+)*[.][A-z]{2,4}$"))
            {
                errorProvider1.SetError(email, "Allow char");
                bemail = false;
            }
            else
            {
                errorProvider1.Clear();
                bemail = true;
                error.Text = "";
            }
        }

        private void add_TextChanged(object sender, EventArgs e)
        {
            if (add.Text.Length == 0)
            {
                errorProvider1.SetError(add, "Not Null");
                badd = false;

            }
            else
            {
                errorProvider1.Clear();
                error.Text = "";
                badd = true;
            }
        }

        private void Factory_Add_Load(object sender, EventArgs e)
        {

        }

    }
}

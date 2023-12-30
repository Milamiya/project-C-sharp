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
    public partial class Customer_Add : Form
    {
        private SqlConnection conn;
        public bool bname = false;
        public bool bphone = false;
        public bool bemail = true;
        public bool badd = false;
        public bool bidcard = false;
        public bool bpass = true;

        public Customer_Add(SqlConnection conn1)
        {
            InitializeComponent();
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
            Ngay_Load();
        }

        private void buttom_add_Click(object sender, EventArgs e)
        {
            if (bidcard == false || bphone == false || bemail == false || badd == false || bpass == false)
            {
                error.Text = "Add not success! Please check again!";
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KhachHang where CMND=@idcard", conn);
                cmd.Parameters.AddWithValue("@idcard", idcard.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    errorProvider1.SetError(idcard, "This idcard was registed!");
                    conn.Close();
                    error.Text = "Add not success! Please check again!";
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    bidcard = true;
                    errorProvider1.Clear();
                    error.Text = "";
                    string sql = "insert KhachHang (MaKH,HoTen,DT,Email,NgaySinh,DiaChi,GioiTinh,CMND,PassWord) values('',@name,@phone,@email,@birth,@add,@sex,@idcard,@pass)";
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@name", namebox.Text);
                    cmd.Parameters.AddWithValue("@phone", phone.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@birth", month.Text + "/" + day.Text + "/" + year.Text);
                    cmd.Parameters.AddWithValue("@add", add.Text);
                    cmd.Parameters.AddWithValue("@idcard", idcard.Text);
                    cmd.Parameters.AddWithValue("@pass", cofirmtextbox.Text);
                    if (sex.Text == "Male")
                        cmd.Parameters.AddWithValue("@sex", true);
                    else cmd.Parameters.AddWithValue("@sex", false);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    error.Text = "Add success!";
                }
            }
        }

        private void day_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select* from Thang where @ngay<=Ngay", conn);
            cmd.Parameters.AddWithValue("@ngay", day.SelectedValue);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            month.DisplayMember = "Thang";
            month.ValueMember = "Thang";
            month.DataSource = dt.DefaultView;
            conn.Close();
        }

        protected void Ngay_Load()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select Ngay from Ngay", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            day.DisplayMember = "Ngay";
            day.ValueMember = "Ngay";
            day.DataSource = dt.DefaultView;
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int d = int.Parse(day.SelectedValue.ToString());
            int m = int.Parse(month.SelectedValue.ToString());
            if (d == 29 && m == 2)
            {
                conn.Open();
                string sql = "select* from NamNhuan";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                year.DisplayMember = "Nam";
                year.ValueMember = "Nam";
                year.DataSource = dt.DefaultView;
                conn.Close();
            }
            else
            {
                string sql = "select* from Nam";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                year.DisplayMember = "Nam";
                year.ValueMember = "Nam";
                year.DataSource = dt.DefaultView;
            }
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
                bname = true;
                error.Text = "";
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
                bphone = false;
                errorProvider1.SetError(phone, "Allow number, not type space");
            }
            else if (phone.Text.Length > 11 || phone.Text.Length < 10)
            {
                bphone = false;
                errorProvider1.SetError(phone, "Allow number 10 characters");
            }
            else
            {
                bphone = true;
                errorProvider1.Clear();
                error.Text = "";
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(email.Text, @"^[A-z0-9_]+([.][A-z0-9_]+)*([@][A-z0-9_]{3,})+([.][A-z0-9_]+)*[.][A-z]{2,4}$"))
            {
                bemail = false;
                errorProvider1.SetError(email, "The email you entered do not match!");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KhachHang where Email=@email", conn);
                cmd.Parameters.AddWithValue("@email", email.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    errorProvider1.SetError(email, "This email was registed");
                }
                else
                {
                    reader.Close();
                    bemail = true;
                    errorProvider1.Clear();
                    error.Text = "";
                }
                conn.Close();
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
                badd = true;
                error.Text = "";
                errorProvider1.Clear();
            }
        }

        private void passtextbox_TextChanged(object sender, EventArgs e)
        {
            if (passtextbox.Text.Length == 0 || passtextbox.Text.Length < 6 || passtextbox.Text.Length > 15)
            {
                bpass = false;
                errorProvider1.SetError(passtextbox, "Not type space,only allow char 6-15");
            }
            else
            {
                bpass = true;
                errorProvider1.Clear();
                error.Text = "";
            }
        }

        private void cofirmtextbox_TextChanged(object sender, EventArgs e)
        {
            if (cofirmtextbox.Text != passtextbox.Text)
            {
                errorProvider1.SetError(cofirmtextbox, "The password you entered do not match!");
                bpass = false;
            }
            else
            {
                errorProvider1.Clear();
                bpass = true;
            }
        }

        private void idcard_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(idcard.Text, "[^0-9]+"))
            {
                bidcard = false;
                errorProvider1.SetError(idcard, "Allow number, not type space");
            }
            else if (idcard.Text.Length == 0 || idcard.Text.Length > 9 || idcard.Text.Length < 9)
            {
                bidcard = false;
                errorProvider1.SetError(idcard, "Allow number 9 characters");
            }
            else
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from KhachHang where CMND=@idcard", conn);
                cmd.Parameters.AddWithValue("@idcard", idcard.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    errorProvider1.SetError(idcard, "This idcard was registed!");
                }
                else
                {
                    reader.Close();
                    bidcard = true;
                    errorProvider1.Clear();
                    error.Text = "";
                }
                conn.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            phone.Clear();
            idcard.Clear();
            passtextbox.Clear();
            cofirmtextbox.Clear();
            email.Clear();
            add.Clear();
            error.Text = "";
            errorProvider1.Clear();
        }

        private void Customer_Add_Load(object sender, EventArgs e)
        {

        }
    }
}

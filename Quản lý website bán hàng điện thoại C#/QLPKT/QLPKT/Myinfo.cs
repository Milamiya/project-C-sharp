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
    public partial class Myinfo : Form
    {
        private string user;
        private string pass;
        private string name;
        private string id;
        private SqlConnection conn;

        public Myinfo(string user1, string pass1, string name1, string id1, SqlConnection conn1)
        {
            InitializeComponent();
            user = user1;
            pass = pass1;
            name = name1;
            id = id1;
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void Myinfo_Load(object sender, EventArgs e)
        {
            error.Text = "";
            string sql = "select CONVERT(varchar, NgaySinh, 103) as NgaySinh,* from Admin where MaAD=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool kt = reader.Read(); 
            if (kt)
            {
                namebox.Text = reader["HoTen"].ToString();
                phone.Text = reader["DT"].ToString();
                email.Text = reader["Email"].ToString();
                day.Text = reader["NgaySinh"].ToString().Split('/')[0];
                month.Text = reader["NgaySinh"].ToString().Split('/')[1];
                year.Text = reader["NgaySinh"].ToString().Split('/')[2];
                add.Text = reader["DiaChi"].ToString();
                if ((bool)reader["GioiTinh"] == true)
                    sex.Text = "Male";
                else sex.Text = "Female";
                idcard.Text = reader["CMND"].ToString();
                reader.Close();
            }
            conn.Close();
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            namebox.Enabled = true;
            phone.Enabled = true;
            email.Enabled = true;
            day.Enabled = true;
            month.Enabled = true;
            year.Enabled = true;
            add.Enabled = true;
            sex.Enabled = true;
            idcard.Enabled = true;
            error.Text = "";
            tab_tip.Visible = true;
        }

        private void buttom_update_Click(object sender, EventArgs e)
        {
            string sql = "update Admin set HoTen=@name, DT=@phone, Email=@email, NgaySinh=@birth, DiaChi=@add, GioiTinh=@sex, CMND=@idcard where MaAD=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", namebox.Text);
            cmd.Parameters.AddWithValue("@phone", phone.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@birth", month.Text + "/" + day.Text + "/" + year.Text);
            cmd.Parameters.AddWithValue("@add", add.Text);
            cmd.Parameters.AddWithValue("@idcard", int.Parse(idcard.Text));
            if (sex.Text=="Male")
            cmd.Parameters.AddWithValue("@sex", true);
            else cmd.Parameters.AddWithValue("@sex", false);
            cmd.ExecuteNonQuery();
            conn.Close();
            error.Text = "Update success!";

            namebox.Enabled = false;
            phone.Enabled = false;
            email.Enabled = false;
            day.Enabled = false;
            month.Enabled = false;
            year.Enabled = false;
            add.Enabled = false;
            sex.Enabled = false;
            idcard.Enabled = false;
            tab_tip.Visible = false;
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            namebox.Enabled = false;
            phone.Enabled = false;
            email.Enabled = false;
            day.Enabled = false;
            month.Enabled = false;
            year.Enabled = false;
            add.Enabled = false;
            sex.Enabled = false;
            idcard.Enabled = false;
        }

        private void buttom_change_MouseHover(object sender, EventArgs e)
        {
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change2.png");
        }

        private void buttom_change_MouseLeave(object sender, EventArgs e)
        {
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change.png");
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
    }
}

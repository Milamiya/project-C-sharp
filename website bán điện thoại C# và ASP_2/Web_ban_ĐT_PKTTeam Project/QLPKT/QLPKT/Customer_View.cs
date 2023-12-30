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
    public partial class Customer_View : Form
    {
        private DataTable dt;
        private string idsave;
        int i;
        private SqlConnection conn;
        string manager;
        public bool bname = true;
        public bool bphone = true;
        public bool bemail = true;
        public bool badd = true;
        public bool bidcard = true;
        public bool bpass = true;

        public Customer_View(SqlConnection conn1,string man)
        {
            InitializeComponent();
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
            Ngay_Load();
            buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_update.Enabled = false;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
            manager = man;
        }

        private void Customer_View_Load(object sender, EventArgs e)
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
            cofirmtextbox.Enabled = false;
            id.Enabled = false;

            type.Text = "Name";
        }

        private void dataview(int i)
        {
            namebox.Text = dt.Rows[i][3].ToString();
            phone.Text = dt.Rows[i][8].ToString();
            email.Text = dt.Rows[i][9].ToString();
            if (dt.Rows[i][1].ToString() != "")
            {
                day.Text = dt.Rows[i][1].ToString().Split('/')[0];
                month.Text = dt.Rows[i][1].ToString().Split('/')[1];
                year.Text = dt.Rows[i][1].ToString().Split('/')[2];
            }
            add.Text = dt.Rows[i][7].ToString();
            sex.Text = dt.Rows[i][0].ToString();
            id.Text = dt.Rows[i][2].ToString();
            idcard.Text = dt.Rows[i][6].ToString();
            idsave = dt.Rows[i][2].ToString();
            error.Text = "";
            errorProvider1.Clear();
            passtextbox.Text = "";
            cofirmtextbox.Text = "";

            // Phan quyen
            buttom_change.Enabled = true;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change.png");
            buttom_delete.Enabled = true;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete.png");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Manager where MaM='" + manager + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((bool)reader["MASTER"] != true)
                {
                    if ((bool)reader["MC_DELETE"] == false)
                    {
                        buttom_delete.Enabled = false;
                        buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
                    }
                    if ((bool)reader["MC_CHANGE"] == false)
                    {
                        buttom_change.Enabled = false;
                        buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
                    }
                }
            }
            reader.Close();
            conn.Close();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
        }

        private void buttom_showall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select (CASE WHEN GioiTinh='1' THEN 'Male' ELSE N'Female' END) as GioiTinh, CONVERT(varchar, NgaySinh, 103) as NgaySinh,*  from KhachHang", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
            data.Visible = true;
            search.Text = "";
        }

        private void searchwith(string type)
        {
            string sql = "select (CASE WHEN GioiTinh='1' THEN 'Male' ELSE N'Female' END) as GioiTinh, CONVERT(varchar, NgaySinh, 103)as NgaySinh,* from KhachHang where " + type + " like N'%" + search.Text + "%'";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
            if (dt.Rows.Count == 0)
                data.Visible = false;
            else data.Visible = true;
            errorProvider1.Clear();
            error.Text = "";
            namebox.Text = "";
            phone.Text = "";
            email.Text = "";
            day.Text = "";
            month.Text = "";
            year.Text = "";
            add.Text = "";
            sex.Text = "";
            idcard.Text = "";
            id.Text = "";
            passtextbox.Text = "";
            cofirmtextbox.Text = "";
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_update.Enabled = false;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        private void buttom_search_Click(object sender, EventArgs e)
        {
            if (type.Text == "Name")
            {
                searchwith("HoTen");
            }
            if (type.Text == "ID")
            {
                searchwith("MaKH");
            }
            if (type.Text == "Birth")
            {
                searchwith("NgaySinh");
            }
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            error.Text = "";
            namebox.Enabled = true;
            phone.Enabled = true;
            email.Enabled = true;
            day.Enabled = true;
            month.Enabled = true;
            year.Enabled = true;
            add.Enabled = true;
            sex.Enabled = true;
            idcard.Enabled = true;
            passtextbox.Enabled = true;
            cofirmtextbox.Enabled = true;

            buttom_update.Enabled = true;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update.png");
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            error.Text = "";
            namebox.Enabled = false;
            phone.Enabled = false;
            email.Enabled = false;
            day.Enabled = false;
            month.Enabled = false;
            year.Enabled = false;
            add.Enabled = false;
            sex.Enabled = false;
            idcard.Enabled = false;
            id.Enabled = false;
            passtextbox.Enabled = false;
            cofirmtextbox.Enabled = false;
            buttom_update.Enabled = false;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update3.png");
        }

        private void buttom_update_Click(object sender, EventArgs e)
        {
            if (bidcard == false || bphone == false || bemail == false || badd == false || bpass == false)
            {
                error.Text = "Update not success! Please check again!";
            }
            else
            {
                if (cofirmtextbox.Text.Length == 0)
                {
                    string sql = "update KhachHang set HoTen=@name, DT=@phone, Email=@email, NgaySinh=@birth, DiaChi=@add, GioiTinh=@sex, CMND=@idcard where MaKH=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id.Text);
                    cmd.Parameters.AddWithValue("@name", namebox.Text);
                    cmd.Parameters.AddWithValue("@phone", int.Parse(phone.Text));
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@birth", month.Text + "/" + day.Text + "/" + year.Text);
                    cmd.Parameters.AddWithValue("@add", add.Text);
                    cmd.Parameters.AddWithValue("@idcard", int.Parse(idcard.Text));
                    if (sex.Text == "Male")
                        cmd.Parameters.AddWithValue("@sex", true);
                    else cmd.Parameters.AddWithValue("@sex", false);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                    buttom_cancel_Click(sender, e);
                    error.Text = "Update success!";
                    buttom_showall_Click(sender,e);
                }
                else
                {
                    string sql = "update KhachHang set HoTen=@name, DT=@phone, Email=@email, NgaySinh=@birth, DiaChi=@add, GioiTinh=@sex, CMND=@idcard, PassWord=@pass where MaKH=@id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@id", id.Text);
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
                    
                    buttom_cancel_Click(sender, e);
                    error.Text = "Update success!";
                    buttom_showall_Click(sender, e);
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

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from HoaDonBan where MaKH='" + id.Text + "'", conn);
            int c1 = (int)cmd.ExecuteScalar();
            if (c1 > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng này. Khách hàng này có liên quan tới:\n " + c1 + " Hóa đơn bán.", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                dt.Rows.RemoveAt(i);
                error.Text = "Delete success!";
                conn.Close();
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (search.Text == "")
            {
                buttom_search.Enabled = false;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            }
            else
            {
                buttom_search.Enabled = true;
                buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search.png");
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Birth")
                search.Text = "Gõ theo định dạng mm-dd-yyyy";
            if (type.Text == "ID")
                search.Text = "ID có định dạng KH00000";
            if (type.Text == "Name")
                search.Text = "Bạn có thể dùng tiếng việt có dấu";
        }

         private void buttom_next_Click(object sender, EventArgs e)
        {
            if (i < dt.Rows.Count-1)
            {
                i++;
                dataview(i);
                data.Rows[i].Selected = true;
            }
        }

         private void buttom_back_Click(object sender, EventArgs e)
         {
             if (i > 0)
             {
                 i--;
                 dataview(i);
                 data.Rows[i].Selected = true;
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
             else if (phone.Text.Length > 10 || phone.Text.Length < 10)
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
                 SqlCommand cmd = new SqlCommand("select * from KhachHang where Email=@email and MaKH<>@id", conn);
                 cmd.Parameters.AddWithValue("@email", email.Text);
                 cmd.Parameters.AddWithValue("@id", id.Text);
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

         private void textBox2_TextChanged(object sender, EventArgs e)
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
             }
             else
             {
                 errorProvider1.Clear();
             }
         }

         private void search_Click(object sender, EventArgs e)
         {
             search.Text = "";
         }

    }
}

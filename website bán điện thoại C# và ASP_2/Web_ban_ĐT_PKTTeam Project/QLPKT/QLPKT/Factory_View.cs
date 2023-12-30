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
    public partial class Factory_View : Form
    {
        DataTable dt;
        DataTable dt2;
        int i;
        string manager;
        private SqlConnection conn;
        public bool bname = true;
        public bool bphone = true;
        public bool bemail = true;
        public bool badd = true;

        public Factory_View(SqlConnection conn1,string m)
        {
            InitializeComponent();
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
            manager = m;
        }
        
        private void Factory_View_Load(object sender, EventArgs e)
        {
            buttom_search.BackgroundImage = Image.FromFile(@"Image\buttom_search3.png");
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_update.Enabled = false;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update3.png");
            buttom_delete.Enabled = false;
            buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
        }

        private void buttom_showall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select *  from NhaSanXuat", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
            data.Visible = true;
            error.Text = "";
        }

        private void searchwith(string type)
        {
            string sql = "select * from NhaSanXuat where " + type + " like N'%" + search.Text + "%'";
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
            if (dt.Rows.Count == 0)
                data.Visible = false;
            else data.Visible = true;
            datapro.Visible = false;
            errorProvider1.Clear();
            error.Text = "";
            namebox.Text = "";
            phone.Text = "";
            email.Text = "";
            add.Text = "";
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
                searchwith("TenSX");
            }
            if (type.Text == "ID")
            {
                searchwith("MaSX");
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "ID")
                search.Text = "ID có định dạng SX00";
            if (type.Text == "Name")
                search.Text = "Bạn có thể dùng tiếng việt có dấu";
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

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = "";
        }


        private void dataview(int i)
        {
            namebox.Text = dt.Rows[i][1].ToString();
            add.Text = dt.Rows[i][2].ToString();
            phone.Text = dt.Rows[i][3].ToString();
            email.Text = dt.Rows[i][4].ToString();
            id.Text = dt.Rows[i][0].ToString();
            SqlDataAdapter adapter = new SqlDataAdapter("select SanPham.*,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where SanPham.MaSX='"+dt.Rows[i][0].ToString()+"'", conn);
            dt2 = new DataTable();
            adapter.Fill(dt2);
            adapter.Dispose();
            datapro.DataSource = dt2.DefaultView;
            errorProvider1.Clear();
            error.Text = "";
            datapro.Visible = true;

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
                    if ((bool)reader["MM_DELETE"] == false)
                    {
                        buttom_delete.Enabled = false;
                        buttom_delete.BackgroundImage = Image.FromFile(@"Image\buttom_delete3.png");
                    }
                    if ((bool)reader["MM_CHANGE"] == false)
                    {
                        buttom_change.Enabled = false;
                        buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
                    }
                }
            }
            reader.Close();
            conn.Close();
            error.Text = "";
            errorProvider1.Clear();
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            error.Text = "";
            namebox.Enabled = true;
            phone.Enabled = true;
            email.Enabled = true;
            add.Enabled = true;

            buttom_update.Enabled = true;
            buttom_update.BackgroundImage = Image.FromFile(@"Image\buttom_update.png");
        }

        private void buttom_update_Click(object sender, EventArgs e)
        {
            if (bname == false || bphone == false || bemail == false || badd == false)
            {
                error.Text = "Update not success! Please check again!";
            }
            else
            {
                string sql = "update NhaSanXuat set TenSX=@name, DT=@phone, Email=@email, DiaChi=@add where MaSX=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@name", namebox.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@add", add.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                error.Text = "Update success!";

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select *  from NhaSanXuat", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;

                namebox.Enabled = false;
                phone.Enabled = false;
                email.Enabled = false;
                add.Enabled = false;
            }
        }

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select count(*) from SanPham where MaSx='" + id.Text + "'"; 
            SqlCommand cmd = new SqlCommand(sql, conn);
            int count = (int)cmd.ExecuteScalar();

            if ((MessageBox.Show("Bạn cần phải xóa hết sản phẩm của nhà sản xuất này trước khi xóa. Bấm OK hệ thống sẽ tự động xóa " + count + " sản phẩm của nhà sản xuất này", "Waring", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)) == DialogResult.OK)
            {
                cmd.CommandText = "delete NhaSanXuat where MaSX=@id";
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete SanPham where MaSX=@id";
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                error.Text = "Dalete success!";

                dt.Rows.RemoveAt(i);
            }
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            namebox.Enabled = false;
            phone.Enabled = false;
            email.Enabled = false;
            add.Enabled = false;
            errorProvider1.Clear();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
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
         
    }
}

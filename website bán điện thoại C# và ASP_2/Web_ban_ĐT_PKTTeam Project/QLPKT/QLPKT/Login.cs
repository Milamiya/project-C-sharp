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
    public partial class Login : Form
    {
        public string password;
        public string name;
        public string id;
        public string manager;
        public SqlConnection conn;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

            this.Left = 100;
            this.Top = 100;

            try
            {
                Connect c = new Connect();
                conn = c.GetConnect();
                conn.Open();
                conn.Close();
                panel_connect.Visible = false;
            }
            catch (Exception)
            {
                panel_connect.Visible = true;
                Connection co = new Connection();
                nhungc(co);
            }
        }

        private void login_buttom_Click(object sender, EventArgs e)
        {
            bool check = true;
            try
            {
                Connect c = new Connect();
                conn = c.GetConnect();
                conn.Open();
                conn.Close();
                panel_connect.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối thất bại! Vui lòng vào Connection Setting để cài đặt lại kết nối ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                check = false;
            }

            if (account.Text.Length == 0 || pass.Text.Length == 0)
                error.Text = "User và Pass không được rỗng!";
            else
            {
                string sql = "select* from Admin where MaAD=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", account.Text);
                
                try
                {
                    conn.Open();
                    cmd.ExecuteReader();
                    conn.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Dữ liệu không tương thích!\nVui lòng vào Connection Setting để cài đặt lại kết nối ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    check = false;
                }
                if (check == true)
                {
                    conn.Open();
                    cmd.CommandText = "select* from Admin where MaAD=@id";
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
                            name = reader["HoTen"].ToString();
                            id = reader["MaAD"].ToString();
                            password = reader["PassWord"].ToString();
                            manager = reader["Manager"].ToString();
                            reader.Close();
                            conn.Close();
                            Manager f2 = new Manager(password, name, id, manager, conn);
                            nhung(f2);
                        }
                        else error.Text = "Sai password!";
                    }
                    else error.Text = "Account không tồn tại";
                    conn.Close();
                }
            }
        }

        private void pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_buttom_Click(sender, e);
            }
        }

        private int x(int x)
        {
            double rate = (this.Width * 1.0 / 1100 * 1.0);
            x=int.Parse(String.Format("{0:0}", x*rate));
            return x;
        }

        private int y(int y)
        {
            double rate = (this.Height * 1.0 / 600 * 1.0);
            y = int.Parse(String.Format("{0:0}", y * rate));
            return y;
        }

        private void Login_SizeChanged(object sender, EventArgs e)
        {
            this.logo.Location = new System.Drawing.Point(x(71), y(142));
            this.logo.Size = new System.Drawing.Size(x(475), y(292));

            this.account.Location = new System.Drawing.Point(x(749), y(265));
            this.account.Size = new System.Drawing.Size(x(256), y(29));

            this.pass.Location = new System.Drawing.Point(x(749), y(305));
            this.pass.Size = new System.Drawing.Size(x(256), y(29));

            this.lgl1.Location = new System.Drawing.Point(x(742), y(181));
            this.lgl1.Size = new System.Drawing.Size(x(244), y(39));

            this.lgl2.Location = new System.Drawing.Point(x(631), y(270));
            this.lgl2.Size = new System.Drawing.Size(x(102), y(24));

            this.lgl3.Location = new System.Drawing.Point(x(631), y(310));
            this.lgl3.Size = new System.Drawing.Size(x(97), y(24));

            this.login_buttom.Location = new System.Drawing.Point(x(749), y(351));
            this.login_buttom.Size = new System.Drawing.Size(x(104), y(33));

            this.error.Location = new System.Drawing.Point(x(860), y(370));
            this.error.Size = new System.Drawing.Size(0, y(16));

            this.menu_connect.Size = new System.Drawing.Size(x(118), y(54));

        }

        public void nhung(Form f)
        {
            //foreach (Control ctl in panel3.Controls)
            //ctl.Dispose();
            panel_main.Controls.Clear();//Xõa các control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;//quan trọng là dòng này thiếu là chít
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            panel_main.Controls.Add(f);//thêm form mới vào panel
            panel_main.Show();
        }

        public void nhungc(Form f)
        {
            //foreach (Control ctl in panel3.Controls)
            //ctl.Dispose();
            panel_connect.Controls.Clear();//Xõa các control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;//quan trọng là dòng này thiếu là chít
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            panel_connect.Controls.Add(f);//thêm form mới vào panel
            panel_connect.Show();
        }

        private void panel_main_MouseHover(object sender, EventArgs e)
        {
            if (panel_main.Controls.Count == 0)
            {
                Login f = new Login();
                nhung(f);
            }
        }

        private void panel_connect_MouseHover(object sender, EventArgs e)
        {
            if (panel_connect.Controls.Count == 0)
            {
                try
                {
                    Connect c = new Connect();
                    conn = c.GetConnect();
                    conn.Open();
                    conn.Close();
                    panel_connect.Visible = false;
                }
                catch (Exception)
                {
                    panel_connect.Visible = false;
                    MessageBox.Show("Kết nối thất bại! Vui lòng vào Connection Setting để cài đặt lại kết nối ", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }

            }
            
        }

        private void menu_connect_Click(object sender, EventArgs e)
        {
            Connection co = new Connection();
            nhungc(co);
        }

    }

}


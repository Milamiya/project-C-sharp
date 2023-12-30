using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace qlhocvien
{
    public partial class Login : DevComponents.DotNetBar.Office2007Form
    {
        
        public static bool flag;
        public string SAVEUSER, SAVEPASS;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtuser.Select();
        }
        public bool login(string user, string pass)
        {
            string sql = "Select * From QuanLy";
            OleDbConnection cnn = new OleDbConnection();
            cnn.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0 ;" + "Data Source =" +
                                Application.StartupPath + @"\qlhocvien.mdb;" +
                                "Jet OLEDB:Database Password =;" +
                                "User ID = admin";


            cnn.Open();

            OleDbCommand cmd = new OleDbCommand(sql, cnn);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    if (txtuser.Text == reader["username"].ToString())
                    {
                        SAVEUSER = reader["username"].ToString();
                        SAVEPASS = reader["password"].ToString();
                    }
                }
            }
            cnn.Close();
            if (user == SAVEUSER && pass == SAVEPASS)
            {
                return true;
            }
            return false;
        }


        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult ok;
                ok = MessageBox.Show("Bạn Có Chắc Muốn Thoát khỏi Chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }



            }
            catch
            {
                MessageBox.Show("Bắt Lỗi: Exception  ");

            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập không được để trống");
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
            }
            else
            {
                try
                {
                    if (login(txtuser.Text, txtpass.Text) == true)
                    {
                        MessageBox.Show("Đăng nhập thành công");
                        flag = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu sai");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

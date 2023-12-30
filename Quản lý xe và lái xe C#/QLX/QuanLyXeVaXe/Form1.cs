using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyXeVaXe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBAccess db = new DBAccess();
            SqlConnection conn = db.GetCon();

            conn.Open();
            SqlCommand cmd = new SqlCommand("delete tb_HopDong where MaDichVu = '"+textBox1.Text+"' ",conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            SqlCommand cmd2 = new SqlCommand("delete tb_DichVu where MaDichVu = '"+textBox1.Text+"'",conn);
            cmd2.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaDichVu from tb_DichVu ", conn);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            da.Dispose();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            DBAccess db = new DBAccess();
            SqlConnection conn = db.GetCon();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select MaDichVu from tb_DichVu ", conn);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            da.Dispose();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Collections;
using System.Threading;
using QuanLyBanHangDienTu.DataAccess;
using System.Data.SqlClient;

namespace QuanLyBanHangDienTu.Presentation
{
    public partial class fr_Splash_Screen : Form
    {
        public fr_Splash_Screen()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand sqlcom;
        SqlDataReader sqldr;
        public string Server { get; set; }
        ConnectDB db = new ConnectDB();

        private void timer1_Tick(object sender, EventArgs e)
        {
            fr_Dangnhap fr = new fr_Dangnhap();
            fr.Show();
            this.Hide();
            timer1.Enabled = false;
        }

        private void fr_Splash_Screen_Load(object sender, EventArgs e)
        {
            SqlConnection con = db.getcon();
            StreamReader read = new StreamReader("Sinfo");
            this.Server = (read.ReadLine().Split(':')[1]);
            try
            {
                con.Open();
                con.Close();
                timer1.Enabled = true;
                read.Close();
            }
            catch
            {
                fr_Ketnoi fr = new fr_Ketnoi();
                read.Close();
                fr.ShowDialog();

            }
        }
    }
}

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
using QuanLyCafe.DataAccess;
using System.Data.SqlClient;

namespace QuanLyCafe.Presentation
{
    public partial class fr_Splash_Screen : Form
    {
        public fr_Splash_Screen()
        {
            InitializeComponent();
        }
        ConnectDB db = new ConnectDB();

        SqlConnection con;
        SqlCommand sqlcom;
        SqlDataReader sqldr;
        public string Server { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fr_DangNhap fr = new fr_DangNhap();
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

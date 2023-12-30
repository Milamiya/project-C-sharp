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
    public partial class Statistic_Growth : Form
    {
        SqlConnection conn;
        string ty1;
        string ty2;
        int lm;
        int fr;
        int t;
        int y1;
        int y2;
        string masp;

        public Statistic_Growth()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
            listpro_load();
            year1.Text = "2012";
        }

        public void nhung(Form f)
        {
            pannel_nd.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            pannel_nd.Controls.Add(f);
            pannel_nd.Show();
        }
        
        private void Statistic_Growth_Load(object sender, EventArgs e)
        {
            
        }

        private void buttom_ok_Click(object sender, EventArgs e)
        {
            ty1 = type.Text;
            ty2 = typedate.Text;
            lm = int.Parse(limit.Text.Split(' ')[0]);
            fr = int.Parse(from.Text);
            t = int.Parse(to.Text);
            y1 = int.Parse(year1.Text);
            y2 = int.Parse(year2.Text);
            masp = listpro.SelectedValue.ToString();
            Growth_Rate f = new Growth_Rate(ty1,ty2,lm,fr,t,y1,y2,masp);
            nhung(f);
        }

        private void listpro_load()
        { 
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select SanPham.MaSP,TenSP,sum(SLBan) as SL from SanPham,ChiTietHoaDonBan where SanPham.MaSP=ChiTietHoaDonBan.MaSP group by SanPham.MaSP,TenSP order by SL desc", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            listpro.DisplayMember = "TenSP";
            listpro.ValueMember = "MaSP";
            listpro.DataSource = dt.DefaultView;

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Doanh thu")
            {
                listpro.Enabled = false;
            }
            if (type.Text == "Lợi nhuận")
            {
                listpro.Enabled = false;
            }
            if (type.Text == "Doanh số theo sản phẩm")
            {
                listpro.Enabled = true;
            }
        }

        private void typedate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typedate.Text == "Tháng")
            {
                limit.Items.Clear();
                limit.Items.Add("6 tháng");
            }
            if (typedate.Text == "Quý")
            {
                limit.Items.Clear();
                limit.Items.Add("4 quý");
            }
            if (typedate.Text == "Năm")
            {
                limit.Items.Clear();
                limit.Items.Add("4 năm");
                limit.Items.Add("6 năm");
            }
        }

        private void from_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(limit.Text.Split(' ')[0]) == 6)
            {
                if (12 - int.Parse(from.Text) < 5)
                {
                    to.Text = (5 - (12 - int.Parse(from.Text))).ToString();
                    year2.Text = (int.Parse(year1.Text) + 1).ToString();
                }
                else
                { 
                    to.Text = (int.Parse(from.Text) + 5).ToString();
                    year2.Text = year1.Text;
                }
                
            }
        }

        private void limit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (limit.Text == "6 tháng")
            {
                labelfrom.Text = "Từ tháng:";
                labelto.Text = "Đến tháng:";
                year1.Enabled = true;
                from.Items.Clear();
                from.Items.Add("1");
                from.Items.Add("2");
                from.Items.Add("3");
                from.Items.Add("4");
                from.Items.Add("5");
                from.Items.Add("6");
                from.Items.Add("7");
                from.Items.Add("8");
                from.Items.Add("9");
                from.Items.Add("10");
                from.Items.Add("11");
                from.Items.Add("12");
            }
            if (limit.Text == "4 quý")
            {
                labelfrom.Text = "Từ quý:";
                labelto.Text = "Đến quý:";
                year1.Enabled = true;
                from.Items.Clear();
                from.Items.Add("1");
                from.Items.Add("2");
                from.Items.Add("3");

            }
            if (limit.Text == "4 năm" || limit.Text == "6 năm")
            {
                labelfrom.Text = "Từ năm:";
                labelto.Text = "Đến năm:";
                year1.Enabled = false;
                from.Items.Clear();
                from.Items.Add("2011");
                from.Items.Add("2012");
            }
        }

        private void listpro_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        
    }
}

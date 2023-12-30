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
    public partial class VA_brand : Form
    {
        public SqlConnection conn;
        DataTable dt;
        string namebrand;
        int i;
        bool dk = false;

        public VA_brand()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
            type.Text = "Name";
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "ID")
            {
                search.Visible = true;
                search.Text = "ID có định dạng SX00";
            }

            if (type.Text == "Name")
            {
                search.Visible = true;
                search.Text = "Nhập hãng cần tìm";
            }

        }

        private void buttom_showall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select MaSX,TenSX from NhaSanXuat order by MaSX desc", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt.DefaultView;
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttom_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string getdata()
        {
            return namebrand;
        }

        public void setdk(bool dk1)
        {
            dk = dk1;
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
        }

        private void dataview(int i)
        {
            namebrand = dt.Rows[i][1].ToString();
        }

        private void buttom_search_Click(object sender, EventArgs e)
        {
            if (type.Text == "Name")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select MaSX,TenSX from NhaSanXuat where TenSX like N'%" + search.Text + "%' order by MaSX desc", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }
            if (type.Text == "ID")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select MaSX,TenSX from NhaSanXuat where MaSX like N'%" + search.Text + "%' order by MaSX desc", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = "";
        }

        private void VA_brand_Load(object sender, EventArgs e)
        {
            if (dk == true)
                panel1.Enabled = false;
        }

        private void buttom_ok2_Click(object sender, EventArgs e)
        {
            string sql = "insert NhaSanXuat (MaSX,TenSX)values('',@ten)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@ten", name.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            namebrand = name.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}

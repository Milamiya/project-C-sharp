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
    public partial class VA_products : Form
    {
        public SqlConnection conn;
        DataTable dt;
        int i;
        string nameproduct;
        bool dk = false;

        public VA_products()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void buttom_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string getdata()
        {
            return nameproduct;
        }

        public void setdk(bool dk1)
        {
            dk = dk1;
        }

        private void buttom_showall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select maSP,TenSP,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt.DefaultView;
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
            nameproduct = dt.Rows[i][1].ToString();
        }

        private void buttom_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Brand")
            {
                search2.Visible = true;
                search.Visible = false;
            }
            if (type.Text == "ID")
            {
                search2.Visible = false;
                search.Visible = true;
                search.Text = "ID có định dạng SP0000";
            }

            if (type.Text == "Name")
            {
                search2.Visible = false;
                search.Visible = true;
                search.Text = "Nhập sản phẩm cần tìm";
            }
        }

        private void buttom_search_Click(object sender, EventArgs e)
        {
            if (type.Text == "Name")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select maSP,TenSP,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where TenSP like N'%" + search.Text + "%'", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }
            if (type.Text == "ID")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select maSP,TenSP,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where MaSP like N'%" + search.Text + "%'", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }
            if (type.Text == "Brand")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select maSP,TenSP,TenSX  from SanPham join NhaSanXuat on SanPham.MaSX = NhaSanXuat.MaSX where TenSX like N'%" + search2.Text + "%'", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }

        }

        private void factoryload()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select MaSX,TenSX from NhaSanXuat order by MaSX", conn);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            adapter.Fill(dt);
            adapter.Fill(dt2);
            adapter.Dispose();
            factory.DisplayMember = "TenSX";
            factory.ValueMember = "MaSX";
            factory.DataSource = dt.DefaultView;
            search2.ValueMember = "TenSX";
            search2.DataSource = dt2.DefaultView;
        }

        private void VA_products_Load(object sender, EventArgs e)
        {
            factoryload();
            type.Text = "Name";
            if (dk == true)
                panel1.Enabled = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void buttom_ok2_Click(object sender, EventArgs e)
        {
            string sql = "insert SanPham (MaSP,MaSX,TenSP,HinhAnh)values('',@idfac,@namepro,@pic)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@idfac", factory.SelectedValue);
            cmd.Parameters.AddWithValue("@namepro", nameproducts.Text);
            cmd.Parameters.AddWithValue("@pic", "Data Image/none.png");
            cmd.ExecuteNonQuery();
            conn.Close();
            nameproduct = nameproducts.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void search_Click(object sender, EventArgs e)
        {
            search.Text = "";
        }
    }
}

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
    public partial class Customer_Feedback : Form
    {
        private DataTable dt;
        int i;
        private SqlConnection conn;

        public Customer_Feedback()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
            type.Text = "Date";
        }

        private void dataview(int i)
        {
            lbdate.Text = dt.Rows[i][0].ToString();
            lbsubject.Text = dt.Rows[i][2].ToString();
            lbstatus.Text = dt.Rows[i][9].ToString();
            lbname.Text = dt.Rows[i][3].ToString();
            lbadd.Text = dt.Rows[i][4].ToString();
            lbphone.Text = dt.Rows[i][5].ToString();
            lbemail.Text = dt.Rows[i][6].ToString();
            content.Text = dt.Rows[i][8].ToString();

            error.Text = "";
        }

        private void buttom_showall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select CONVERT(varchar, Ngay, 103) as NgayGui,*  from FeedBack order by Ngay desc", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt;
            search.Text = "";
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
            error.Text = "";
        }

        private void buttom_next_Click(object sender, EventArgs e)
        {
            if (i < dt.Rows.Count - 1)
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

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text == "Date")
            {
                search.Visible = true;
                search3.Visible = false;
                search2.Visible = false;
                search.Text = "Gõ theo định dạng mm-dd-yyyy";
            }
            if (type.Text == "ID")
            {
                search.Visible = true;
                search3.Visible = false;
                search2.Visible = false;
                search.Text = "ID có định dạng FB00000";
            }
            if (type.Text == "Status")
            {
                search.Visible = false;
                search3.Visible = false;
                search2.Visible = true;
            }
            if (type.Text == "Subject")
            {
                search.Visible = false;
                search3.Visible = true;
                search2.Visible = false;
            }
        }

        private void search2_SelectedIndexChanged(object sender, EventArgs e)
        {
            search.Text = "";
        }

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Feedback where MaFB='"+dt.Rows[i][0].ToString()+"'",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            error.Text = "Delete success!";
            dt.Rows.RemoveAt(i);
        }

        private void buttom_confirm_Click(object sender, EventArgs e)
        {
            if (lbstatus.Text != "Đã đọc")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update Feedback set TinhTrang= N'Đã đọc' where MaFB='" + dt.Rows[i][1].ToString() + "'", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                error.Text = "Complete!";
                lbstatus.Text = "Đã đọc";
                buttom_search_Click(sender, e);
            }
            else
                MessageBox.Show("Feedback này đã được đọc!", "Waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttom_search_Click(object sender, EventArgs e)
        {
            if (type.Text == "Date")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select CONVERT(varchar, Ngay, 103) as NgayGui,*  from FeedBack where Ngay like N'" + search.Text + "%' order by Ngay desc", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }
            if (type.Text == "ID")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select CONVERT(varchar, Ngay, 103) as NgayGui,*  from FeedBack where MaFB like N'" + search.Text + "%' order by Ngay desc", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }
            if (type.Text == "Status")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select CONVERT(varchar, Ngay, 103) as NgayGui,*  from FeedBack where TinhTrang like N'" + search2.Text + "%' order by Ngay desc", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }
            if (type.Text == "Subject")
            {
                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter("select CONVERT(varchar, Ngay, 103) as NgayGui,*  from FeedBack where ChuDe like N'" + search3.Text + "%' order by Ngay desc", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                adapter.Dispose();
                data.DataSource = dt;
            }
        }

        private void Customer_Feedback_Load(object sender, EventArgs e)
        {

        }
    }
}

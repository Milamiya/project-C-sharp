using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doan
{
    public partial class frmQuanLySinhVien : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;

        public frmQuanLySinhVien()
        {
            sqlcon = new SqlConnection("server=.\\SQLEXPRESS;database=QL_Thitracnghiem;integrated security =true");
            sqlcon.Open();
            InitializeComponent();
        }
      

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            load();
        }
             void load()
        {
            sqlcmd = new SqlCommand("select * from sinhvien ", sqlcon);
            SqlDataReader sqlreader = sqlcmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlreader.Read())
            {
                ListViewItem lvitem = new ListViewItem();
                //lvitem.Text = sqlreader["MaCH"].ToString();
                //lvitem.SubItems.Add(sqlreader["cauhoi"].ToString());

                //string sMaCH = sqlreader["mach"].ToString();

                lvitem.Text = sqlreader["mats"].ToString();
                lvitem.SubItems.Add(sqlreader["hoten"].ToString());
                lvitem.SubItems.Add(sqlreader["ngaysinh"].ToString());
                lvitem.SubItems.Add(sqlreader["gioitinh"].ToString());
                lvitem.SubItems.Add(sqlreader["quequan"].ToString());
                lvitem.SubItems.Add(sqlreader["sodienthoai"].ToString());
                lvitem.SubItems.Add(sqlreader["email"].ToString());

                //lvitem.SubItems.Add(sqlreader["n"].ToString());

                listView1.Items.Add(lvitem);
            }
            sqlreader.Close();
        }
        

        private void btnxoa_Click(object sender, EventArgs e)
        {
            sqlcmd = new SqlCommand("delete sinhvien where mats='" + textBox1.Text + "'", sqlcon);
            sqlcmd.ExecuteNonQuery();

            load();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
            string mats = textBox1.Text;
            string hoten = textBox2.Text;
            string ngaysinh = textBox3.Text;
            string gioitinh = textBox4.Text;
            string quequan = textBox5.Text;
            string sodt = textBox6.Text;
            string email = textBox7.Text;

            string strSQL = "insert SINHVIEN values('" + mats + "','" + hoten + "','" + ngaysinh + "','" + gioitinh + "','" + quequan + "','" + sodt + "','" + email + "')";
            sqlcmd = new SqlCommand(strSQL, sqlcon);
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show("B?n dã dang ký thành công");
            load();
            }
                catch
            {
                MessageBox.Show("Trùng mã sinh viên !!!");
                }
        
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {
                string mats = textBox1.Text;
                string hoten = textBox2.Text;
                string ngaysinh = textBox3.Text;
                string gioitinh = textBox4.Text;
                string quequan = textBox5.Text;
                string sodt = textBox6.Text;
                string email = textBox7.Text;
                sqlcmd = new SqlCommand("update sinhvien  set mats='" + mats + "',hoten='" + hoten + "',ngaysinh='" + ngaysinh + "',gioitinh='" + gioitinh + "',quequan='" + quequan + "',sodienthoai='" + sodt + "',email'" + email + "' ", sqlcon);
                sqlcmd.ExecuteNonQuery();

                load();
            }
            catch
            {
                MessageBox.Show("Loi");
            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
                if (listView1.Items[i].Selected)
                {
                    textBox1.Text = listView1.Items[i].SubItems[0].Text;
                    textBox2.Text = listView1.Items[i].SubItems[1].Text;
                    textBox3.Text = listView1.Items[i].SubItems[2].Text;
                    textBox4.Text = listView1.Items[i].SubItems[3].Text;
                    textBox5.Text = listView1.Items[i].SubItems[4].Text;
                    textBox6.Text = listView1.Items[i].SubItems[5].Text;
                    textBox7.Text = listView1.Items[i].SubItems[6].Text;

                }
        }

    }
}

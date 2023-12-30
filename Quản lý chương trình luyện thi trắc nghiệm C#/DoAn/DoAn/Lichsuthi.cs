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
    public partial class frmLichsuthi : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        string Sngay;
        string ngaychinh;
        public frmLichsuthi()
        {
            sqlcon = new SqlConnection("server=.\\SQLEXPRESS;database=QL_Thitracnghiem;integrated security =true");
            sqlcon.Open();
            InitializeComponent();
        }
       
        private void timkiemtheodiemcaoanhat()
        {
            try
            {
                sqlcmd = new SqlCommand("select ketqua.mats,HOTEN,NGAYTHI,SOCAUDUNG,SOCAUSAI,DIEM FROM THISINHTHI,KETQUA WHERE THISINHTHI.MATS=KETQUA.MATS and ketqua.diem=(select max(diem) from ketqua)", sqlcon);
                SqlDataReader sqlreader = sqlcmd.ExecuteReader();
                listView1.Items.Clear();
                while (sqlreader.Read())
                {
                    ListViewItem lvitem = new ListViewItem();
                    lvitem.Text = sqlreader["MATS"].ToString();
                    lvitem.SubItems.Add(sqlreader["HOTEN"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["NGAYTHI"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["SOCAUDUNG"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["SOCAUSAI"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["DIEM"].ToString().Trim());
                    listView1.Items.Add(lvitem);
                }
                sqlreader.Close();
            }
            catch
            {
                MessageBox.Show("Bạn làm sai thao tác");
                
            }
           

        }

        private void timkiemtheongay()
        {
            if (tbngaythang.Text == "")
            {
                rdb1.Checked = false;
                MessageBox.Show("Bạn điền ngày tháng năm vao trước, theo dạng tháng / ngày / năm", "Có lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbngaythang.Enabled = true;
            }
            else
            {

                Sngay = tbngaythang.Text;
                try
                {
                    
                   
                        sqlcmd = new SqlCommand("select thisinhthi.mats,HOTEN,NGAYTHI,SOCAUDUNG,SOCAUSAI,DIEM FROM THISINHTHI,KETQUA WHERE THISINHTHI.MATS=KETQUA.MATS and ngaythi='" + Sngay + "'", sqlcon);
                        SqlDataReader sqlreader = sqlcmd.ExecuteReader();
                        listView1.Items.Clear();
                        while (sqlreader.Read())
                        {
                            ListViewItem lvitem = new ListViewItem();
                            lvitem.Text = sqlreader["MATS"].ToString();
                            lvitem.SubItems.Add(sqlreader["HOTEN"].ToString().Trim());
                            lvitem.SubItems.Add(sqlreader["NGAYTHI"].ToString().Trim());
                            lvitem.SubItems.Add(sqlreader["SOCAUDUNG"].ToString().Trim());
                            lvitem.SubItems.Add(sqlreader["SOCAUSAI"].ToString().Trim());
                            lvitem.SubItems.Add(sqlreader["DIEM"].ToString().Trim());
                            listView1.Items.Add(lvitem);
                        }
                        sqlreader.Close();
                    
                }
                catch
                {
                    MessageBox.Show("Không có ai thi ngày này '" + Sngay + "'");
                    tbngaythang.Text = "";


                }
            }
        }
        void timkiemtheodiemthapnhat()
        {
            try
            {
                sqlcmd = new SqlCommand("select ketqua.mats,HOTEN,NGAYTHI,SOCAUDUNG,SOCAUSAI,DIEM FROM THISINHTHI,KETQUA WHERE THISINHTHI.MATS=KETQUA.MATS and ketqua.diem=(select min(diem) from ketqua)", sqlcon);
                SqlDataReader sqlreader = sqlcmd.ExecuteReader();
                listView1.Items.Clear();
                while (sqlreader.Read())
                {
                    ListViewItem lvitem = new ListViewItem();
                    lvitem.Text = sqlreader["MATS"].ToString();
                    lvitem.SubItems.Add(sqlreader["HOTEN"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["NGAYTHI"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["SOCAUDUNG"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["SOCAUSAI"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["DIEM"].ToString().Trim());
                    listView1.Items.Add(lvitem);
                }
                sqlreader.Close();
            }
            catch
            {
                MessageBox.Show("Bạn làm sai thao tác");
              
            }
        }
        void loadtatca()
        {
            try
            {
                sqlcmd = new SqlCommand("select thisinhthi.mats,HOTEN,NGAYTHI,SOCAUDUNG,SOCAUSAI,DIEM FROM THISINHTHI,KETQUA WHERE THISINHTHI.MATS=KETQUA.MATS", sqlcon);
                SqlDataReader sqlreader = sqlcmd.ExecuteReader();
                listView1.Items.Clear();
                while (sqlreader.Read())
                {
                    ListViewItem lvitem = new ListViewItem();
                    lvitem.Text = sqlreader["MATS"].ToString();
                    lvitem.SubItems.Add(sqlreader["HOTEN"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["NGAYTHI"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["SOCAUDUNG"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["SOCAUSAI"].ToString().Trim());
                    lvitem.SubItems.Add(sqlreader["DIEM"].ToString().Trim());
                    listView1.Items.Add(lvitem);
                }
                sqlreader.Close();
            }
            catch
            {

                MessageBox.Show("Dữ liệu trống");
                return;
            }
        }
        private void frmLichsuthi_Load(object sender, EventArgs e)
        {
            //loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked==true)
            {

                timkiemtheongay();
            }
            else if (rdbt2.Checked==true)
            {
                timkiemtheodiemcaoanhat();
                tbngaythang.Enabled = false;
              
            }
            else if (rdbt3.Checked == true)
            {
                timkiemtheodiemthapnhat();
                tbngaythang.Enabled = false;
            }
            else if (rdb4.Checked==true)
            {
                loadtatca();
                tbngaythang.Enabled = false;
            }
            else 
            {
                MessageBox.Show("Bạn hãy chọn một cách tìm");
            }
        }

       private void rdbt2_CheckedChanged_1(object sender, EventArgs e)
       {
           tbngaythang.Enabled = false;
       }

       private void rdbt3_CheckedChanged(object sender, EventArgs e)
       {
           tbngaythang.Enabled = false;
       }

       private void rdb4_CheckedChanged(object sender, EventArgs e)
       {
           tbngaythang.Enabled = false;
       }

       private void rdb1_CheckedChanged(object sender, EventArgs e)
       {
           tbngaythang.Enabled = true;
       }

       private void button2_Click(object sender, EventArgs e)
       {
           this.Close();
       }

       private void button4_Click(object sender, EventArgs e)
       {
           if (MessageBox.Show("Bạn có muốn xóa thí sinh có mã thí sinh " + " " + tbmats.Text, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
           {
               sqlcmd = new SqlCommand("delete thisinhthi where mats='" + tbmats.Text + "'", sqlcon);
               sqlcmd.ExecuteNonQuery();
               loadtatca();
           }
       }

       private void listView1_SelectedIndexChanged(object sender, EventArgs e)
       {
            for (int i = 0; i < listView1.Items.Count; i++)
                if (listView1.Items[i].Selected)
                {
                    tbmats.Text = listView1.Items[i].SubItems[0].Text;
                    ngaychinh = listView1.Items[i].SubItems[2].Text;
                }
       }
    }
}

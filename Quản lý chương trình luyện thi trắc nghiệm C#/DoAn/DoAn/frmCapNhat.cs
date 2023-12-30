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
    public partial class frmCapNhat : Form
    {
        SqlConnection sqlcon;
        SqlCommand sqlcmd;
        string g_sCapDo;
        //tao ket noi
        public frmCapNhat()
        {
            sqlcon = new SqlConnection("server=.\\sqlexpress;database=QL_Thitracnghiem;integrated security =true");
            sqlcon.Open();
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
        }
        //mac dinh cac checkbox
        private void Macdinh()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }
        //mac dinh ban dau
        private void Bandau()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            richTextBox1.Text = "";
        }
        string t2;
        string t1;
        //----kiem tra load len lisview
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool bdapan = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    textBox5.Text = listView1.Items[i].SubItems[0].Text;
                    textBox1.Text = listView1.Items[i].SubItems[2].Text;
                    textBox2.Text = listView1.Items[i].SubItems[3].Text;
                    textBox3.Text = listView1.Items[i].SubItems[4].Text;
                    textBox4.Text = listView1.Items[i].SubItems[5].Text;
                    richTextBox1.Text = listView1.Items[i].SubItems[1].Text;
                    string t = listView1.Items[i].SubItems[6].Text.ToString().Trim();
                    if (t.Length >= 2)
                    {
                        for (int ii = 0; ii < t.Length; ii++)
                        {
                            t2 = t[0].ToString();
                            if (t[1].ToString() == "")
                            {
                                t1 = "NULL";
                            }
                            else
                            {
                                t1 = t[1].ToString();
                            }
                        }
                    }
                    else
                    {
                        t2 = t;
                        t1 = "NULL";
                    }
                    Macdinh();
                    if (t1 == "A")
                    {
                        checkBox1.Checked = true;
                    }
                    if (t1 == "B")
                    {
                        checkBox2.Checked = true;
                    }
                    if (t1 == "C")
                    {
                        checkBox3.Checked = true;
                    }
                    if (t1 == "D")
                    {
                        checkBox4.Checked = true;
                    }

                    if (t2 == "A")
                    {
                        checkBox1.Checked = true;
                    }
                    if (t2 == "B")
                    {
                        checkBox2.Checked = true;
                    }
                    if (t2 == "C")
                    {
                        checkBox3.Checked = true;
                    }
                    if (t2 == "D")
                    {
                        checkBox4.Checked = true;
                    }
                    bdapan = true;
                }
                if (bdapan == false)
                {
                    Bandau();
                }
            }

        }

        private void frmCapNhat_Load(object sender, EventArgs e)
        {
            LoadDataToListView();
            comboBox1.SelectedIndex = 0;
        }
        /// <summary>
        /// load len lisview
        /// </summary>
        private void LoadDataToListView()
        {

            sqlcmd = new SqlCommand("select cauhoi.mach,cauhoi,a,b,c,d,dapan from cauhoi,dapan where dapan.mach = cauhoi.mach and trinhdo = '" + g_sCapDo + "'", sqlcon);
            SqlDataReader sqlreader = sqlcmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlreader.Read())
            {
                ListViewItem lvitem = new ListViewItem();
                //lvitem.Text = sqlreader["MaCH"].ToString();
                //lvitem.SubItems.Add(sqlreader["cauhoi"].ToString());

                //string sMaCH = sqlreader["mach"].ToString();

                lvitem.Text = sqlreader["mach"].ToString();
                lvitem.SubItems.Add(sqlreader["cauhoi"].ToString().Trim());
                lvitem.SubItems.Add(sqlreader["A"].ToString().Trim());
                lvitem.SubItems.Add(sqlreader["B"].ToString().Trim());
                lvitem.SubItems.Add(sqlreader["C"].ToString().Trim());
                lvitem.SubItems.Add(sqlreader["D"].ToString().Trim());
                lvitem.SubItems.Add(sqlreader["Dapan"].ToString());

                //lvitem.SubItems.Add(sqlreader["n"].ToString());

                listView1.Items.Add(lvitem);
            }
            sqlreader.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataToListView();
            Bandau();
        }

        private void btLog_Click(object sender, EventArgs e)
        {
            Bandau();
            button4.Enabled = true;
            textBox5.Text = SDienMaTuDong(textBox1.Text, sqlcmd, sqlcon);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sCauA = textBox1.Text;
                string sCauB = textBox2.Text;
                string sCauC = textBox3.Text;
                string sCauD = textBox4.Text;
                string sMaCH = textBox5.Text;
                string sCauHoi = richTextBox1.Text;
                string sCauDung = "";
                string sCauDungLuu = "";
                string sTrinhDo = comboBox1.Text;
                if (richTextBox1.Text.ToString().Trim() == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false))
                {
                    MessageBox.Show("Bạn đã sai làm thao tác", "Thông báo");
                }
                else
                {
                    if (checkBox1.Checked == true)
                    {
                        sCauDung = "A";
                        sCauDungLuu += sCauDung;
                    }
                    if (checkBox2.Checked == true)
                    {
                        sCauDung = "B";
                        sCauDungLuu += sCauDung;
                    }
                    if (checkBox3.Checked == true)
                    {
                        sCauDung = "C";
                        sCauDungLuu += sCauDung;
                    }
                    if (checkBox4.Checked == true)
                    {
                        sCauDung = "D";
                        sCauDungLuu += sCauDung;
                    }

                    sqlcmd = new SqlCommand("update dapan set A='" + sCauA + "',B='" + sCauB + "',C='" + sCauC + "',D='" + sCauD + "',dapan='" + sCauDungLuu + "' where mach='" + sMaCH + "'", sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd = new SqlCommand("update cauhoi set cauhoi='" + sCauHoi + "', trinhdo='" + sTrinhDo + "' where mach='" + sMaCH + "'", sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    LoadDataToListView();
                    Bandau();
                }
            }
            
            catch
            {
                MessageBox.Show("Bạn đã sai làm thao tác", "Thông báo");
            }
        }
        //xoa cau hoi
        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Vui lòng chọn câu hỏi", "Thông báo");
            }
            else
            {
                string sCauHoi = richTextBox1.Text;
                if (MessageBox.Show("Bạn có muốn xóa câu hỏi" + " " + sCauHoi, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string sMaCH = textBox5.Text;
                    sqlcmd = new SqlCommand("delete cauhoi where mach='" + sMaCH + "'", sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd = new SqlCommand("delete dapan where mach='" + sMaCH + "'", sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    LoadDataToListView();
                }
                Bandau();
            }
        }
        private string SDienMaTuDong(string sMa, SqlCommand sqlcmd, SqlConnection sqlcon)
        {
            int iMax = 1;
            sqlcmd = new SqlCommand("select mach from cauhoi", sqlcon);
            SqlDataReader sqlreader = sqlcmd.ExecuteReader();
            while (sqlreader.Read())
            {
                for (int i = 0; i < sqlreader.GetValue(0).ToString().Length; i++)
                {
                    int iSoSanh = int.Parse(sqlreader.GetValue(0).ToString().Substring(1, 4));
                    if (iSoSanh > iMax)
                    {
                        iMax = -iSoSanh;
                    }
                }
            }
            sqlreader.Close();
            if (iMax + 1 < 10)
            {
                sMa = string.Concat("C", "000", iMax + 1);
            }
            if (iMax + 1 >= 10)
            {
                sMa = string.Concat("C", "00", iMax + 1);
            }
            if (iMax + 1 >= 100)
            {
                sMa = string.Concat("C", "0", iMax + 1);
            }
            if (iMax + 1 >= 1000)
            {
                sMa = string.Concat("C", iMax + 1);
            }
            return sMa;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                g_sCapDo = "A";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                g_sCapDo = "B";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                g_sCapDo = "C";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false))
            {
                MessageBox.Show("Bạn chưa thêm đầy đủ thông tin", "Thông báo");
            }
            else
            {
                try
                {

                    string sCauA = textBox1.Text;
                    string sCauB = textBox2.Text;
                    string sCauC = textBox3.Text;
                    string sCauD = textBox4.Text;
                    string sMaCH = textBox5.Text;
                    string sCauHoi = richTextBox1.Text;
                    string sCauDung = "";
                    string sCauDungLuu = "";
                    string sTrinhDo = comboBox1.Text;
                    if (checkBox1.Checked == true)
                    {
                        sCauDung = "A";
                        sCauDungLuu += sCauDung;
                    }
                    if (checkBox2.Checked == true)
                    {
                        sCauDung = "B";
                        sCauDungLuu += sCauDung;
                    }
                    if (checkBox3.Checked == true)
                    {
                        sCauDung = "C";
                        sCauDungLuu += sCauDung;
                    }
                    if (checkBox4.Checked == true)
                    {
                        sCauDung = "D";
                        sCauDungLuu += sCauDung;
                    }

                    sqlcmd = new SqlCommand("insert into dapan values('" + sMaCH + "','" + sCauA + "','" + sCauB + "','" + sCauC + "','" + sCauD + "','" + sCauDungLuu + "') ", sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    sqlcmd = new SqlCommand("insert into cauhoi values('" + sMaCH + "','" + sCauHoi + "','" + sTrinhDo + "') ", sqlcon);
                    sqlcmd.ExecuteNonQuery();
                    LoadDataToListView();
                    button4.Enabled = false;
                }
                //roi hen;de bi coi lai thu de cHOAky thu chay thu hen ok
                catch
                {
                    MessageBox.Show("Bạn đã thao tác sai");
                }
            }
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            float i = 50;
            if (buton1.Text == "Thu Nhỏ")
            {
                while (this.Height > 370)
                {
                    i += 1f;
                    this.Height -= (int)i;
                    Application.DoEvents();
                    buton1.Text = "Mở Rộng";
                }
            }
            else
            {

                while (this.Height < 600)
                {
                    i += 1f;
                    this.Height += (int)i;
                    Application.DoEvents();
                    buton1.Text = "Thu Nhỏ";
                }
            }
        }
    }
}

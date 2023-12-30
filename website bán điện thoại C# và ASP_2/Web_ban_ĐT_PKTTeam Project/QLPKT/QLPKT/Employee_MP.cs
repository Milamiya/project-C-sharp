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
    public partial class Employee_MP : Form
    {
        SqlConnection conn;
        List<CheckBox> cb;
        List<bool> pm;
        DataTable dt;
        int i;

        public Employee_MP()
        {
            InitializeComponent();
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void Employee_MP_Load(object sender, EventArgs e)
        {
            cc1.Checked = true;
            data_load();
            buttom_add.Enabled = false;
            buttom_add.BackgroundImage = Image.FromFile(@"Image\buttom_add3.png");
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_delete.Visible = false;
        }

        private void buttom_add_Click(object sender, EventArgs e)
        {
            if (btit == true)
            {
                list_pm();
                SqlCommand cmd = new SqlCommand("insert Manager values ('',@title,@pm1,@pm2,@pm3,@pm4,@pm5,@pm6,@pm7,@pm8,@pm9,@pm10,@pm11,@pm12,@pm12,@pm14,@pm15,@pm16,@pm17,@pm18,@pm19,@pm20,@pm21,@pm22,@pm23,@pm24,@pm25,@pm26,@pm27,@pm28,@pm29,@pm30,@pm31,@pm32,@pm33,@pm34)", conn);
                cmd.Parameters.AddWithValue("@title", title.Text);
                cmd.Parameters.AddWithValue("@pm1", pm[0]);
                cmd.Parameters.AddWithValue("@pm2", pm[1]);
                cmd.Parameters.AddWithValue("@pm3", pm[2]);
                cmd.Parameters.AddWithValue("@pm4", pm[3]);
                cmd.Parameters.AddWithValue("@pm5", pm[4]);
                cmd.Parameters.AddWithValue("@pm6", pm[5]);
                cmd.Parameters.AddWithValue("@pm7", pm[6]);
                cmd.Parameters.AddWithValue("@pm8", pm[7]);
                cmd.Parameters.AddWithValue("@pm9", pm[8]);
                cmd.Parameters.AddWithValue("@pm10", pm[9]);
                cmd.Parameters.AddWithValue("@pm11", pm[10]);
                cmd.Parameters.AddWithValue("@pm12", pm[11]);
                cmd.Parameters.AddWithValue("@pm13", pm[12]);
                cmd.Parameters.AddWithValue("@pm14", pm[13]);
                cmd.Parameters.AddWithValue("@pm15", pm[14]);
                cmd.Parameters.AddWithValue("@pm16", pm[15]);
                cmd.Parameters.AddWithValue("@pm17", pm[16]);
                cmd.Parameters.AddWithValue("@pm18", pm[17]);
                cmd.Parameters.AddWithValue("@pm19", pm[18]);
                cmd.Parameters.AddWithValue("@pm20", pm[19]);
                cmd.Parameters.AddWithValue("@pm21", pm[20]);
                cmd.Parameters.AddWithValue("@pm22", pm[21]);
                cmd.Parameters.AddWithValue("@pm23", pm[22]);
                cmd.Parameters.AddWithValue("@pm24", pm[23]);
                cmd.Parameters.AddWithValue("@pm25", pm[24]);
                cmd.Parameters.AddWithValue("@pm26", pm[25]);
                cmd.Parameters.AddWithValue("@pm27", pm[26]);
                cmd.Parameters.AddWithValue("@pm28", pm[27]);
                cmd.Parameters.AddWithValue("@pm29", pm[28]);
                cmd.Parameters.AddWithValue("@pm30", pm[29]);
                cmd.Parameters.AddWithValue("@pm31", pm[30]);
                cmd.Parameters.AddWithValue("@pm32", pm[31]);
                cmd.Parameters.AddWithValue("@pm33", pm[32]);
                cmd.Parameters.AddWithValue("@pm34", pm[33]);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "select MaM from Manager where TenM=@title";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@title", title.Text);
                id.Text = (string)cmd.ExecuteScalar();
                conn.Close();

                //data_load();
                error.Text = "Add new success!";
                data_load();
            }
            else
            {
                error.Text = "Insert data";
            }
        }

        private void buttom_change_Click(object sender, EventArgs e)
        {
            if (btit == true)
            {
            list_pm();
            SqlCommand cmd = new SqlCommand("delete from Manager where MaM='"+id.Text+"'",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText="insert Manager values (@MaM,@title,@pm1,@pm2,@pm3,@pm4,@pm5,@pm6,@pm7,@pm8,@pm9,@pm10,@pm11,@pm12,@pm12,@pm14,@pm15,@pm16,@pm17,@pm18,@pm19,@pm20,@pm21,@pm22,@pm23,@pm24,@pm25,@pm26,@pm27,@pm28,@pm29,@pm30,@pm31,@pm32,@pm33,@pm34)";
            cmd.Parameters.AddWithValue("@MaM", id.Text);
            cmd.Parameters.AddWithValue("@title", title.Text);
            cmd.Parameters.AddWithValue("@pm1", pm[0]);
            cmd.Parameters.AddWithValue("@pm2", pm[1]);
            cmd.Parameters.AddWithValue("@pm3", pm[2]);
            cmd.Parameters.AddWithValue("@pm4", pm[3]);
            cmd.Parameters.AddWithValue("@pm5", pm[4]);
            cmd.Parameters.AddWithValue("@pm6", pm[5]);
            cmd.Parameters.AddWithValue("@pm7", pm[6]);
            cmd.Parameters.AddWithValue("@pm8", pm[7]);
            cmd.Parameters.AddWithValue("@pm9", pm[8]);
            cmd.Parameters.AddWithValue("@pm10", pm[9]);
            cmd.Parameters.AddWithValue("@pm11", pm[10]);
            cmd.Parameters.AddWithValue("@pm12", pm[11]);
            cmd.Parameters.AddWithValue("@pm13", pm[12]);
            cmd.Parameters.AddWithValue("@pm14", pm[13]);
            cmd.Parameters.AddWithValue("@pm15", pm[14]);
            cmd.Parameters.AddWithValue("@pm16", pm[15]);
            cmd.Parameters.AddWithValue("@pm17", pm[16]);
            cmd.Parameters.AddWithValue("@pm18", pm[17]);
            cmd.Parameters.AddWithValue("@pm19", pm[18]);
            cmd.Parameters.AddWithValue("@pm20", pm[19]);
            cmd.Parameters.AddWithValue("@pm21", pm[20]);
            cmd.Parameters.AddWithValue("@pm22", pm[21]);
            cmd.Parameters.AddWithValue("@pm23", pm[22]);
            cmd.Parameters.AddWithValue("@pm24", pm[23]);
            cmd.Parameters.AddWithValue("@pm25", pm[24]);
            cmd.Parameters.AddWithValue("@pm26", pm[25]);
            cmd.Parameters.AddWithValue("@pm27", pm[26]);
            cmd.Parameters.AddWithValue("@pm28", pm[27]);
            cmd.Parameters.AddWithValue("@pm29", pm[28]);
            cmd.Parameters.AddWithValue("@pm30", pm[29]);
            cmd.Parameters.AddWithValue("@pm31", pm[30]);
            cmd.Parameters.AddWithValue("@pm32", pm[31]);
            cmd.Parameters.AddWithValue("@pm33", pm[32]);
            cmd.Parameters.AddWithValue("@pm34", pm[33]);
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select MaM from Manager where TenM=@title";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@title", title.Text);
            id.Text = (string)cmd.ExecuteScalar();
            conn.Close();
            error.Text = "Change success!";
            data_load();
            }
            else
            {
                error.Text = "Insert data";
            }

        }

        private void buttom_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Manager where MaM='" + id.Text + "'", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            buttom_addnewpro_Click(sender, e);
            error.Text = "Delete success!";
            dt.Rows.RemoveAt(i);
        }

        private void buttom_addnewpro_Click(object sender, EventArgs e)
        {
            list_pm();
            for (int i = 0; i < cb.Count; i++)
            {
                cb[i].Checked = false;
            }
            cc1.Checked = true;
            id.Text = "";
            title.Text = "";

            buttom_add.Enabled = true;
            buttom_add.BackgroundImage = Image.FromFile(@"Image\buttom_add.png");
            buttom_change.Enabled = false;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change3.png");
            buttom_delete.Visible = false;
        }

        private void data_load()
        {
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter("select MaM,TenM from Manager", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            data.DataSource = dt.DefaultView;

        }

        private void dataview(int i)
        {
            id.Text = dt.Rows[i][0].ToString();
            title.Text = dt.Rows[i][1].ToString();
            SqlCommand cmd = new SqlCommand("select * from Manager where MaM='"+id.Text+"'",conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            list_pm();
            pm = new List<bool>();
            while (reader.Read())
            {
                pm.Add((bool)reader["MASTER"]);
                pm.Add((bool)reader["MI_VIEW"]);
                pm.Add((bool)reader["MI_CHANGE"]);
                pm.Add((bool)reader["ME_DIRECTOR"]);
                pm.Add((bool)reader["ME_VIEW"]);
                pm.Add((bool)reader["ME_CHANGE"]);
                pm.Add((bool)reader["ME_ADD"]);
                pm.Add((bool)reader["ME_DELETE"]);
                pm.Add((bool)reader["MP_DIRECTOR"]);
                pm.Add((bool)reader["MP_VIEW"]);
                pm.Add((bool)reader["MP_CHANGE"]);
                pm.Add((bool)reader["MP_ADD"]);
                pm.Add((bool)reader["MP_DELETE"]);
                pm.Add((bool)reader["MM_VIEW"]);
                pm.Add((bool)reader["MM_CHANGE"]);
                pm.Add((bool)reader["MM_ADD"]);
                pm.Add((bool)reader["MN_DELETE"]);
                pm.Add((bool)reader["MC_DIRECTOR"]);
                pm.Add((bool)reader["MC_VIEW"]);
                pm.Add((bool)reader["MC_CHANGE"]);
                pm.Add((bool)reader["MC_ADD"]);
                pm.Add((bool)reader["MC_DELETE"]);
                pm.Add((bool)reader["MS_DIRECTOR"]);
                pm.Add((bool)reader["MS_VIEW"]);
                pm.Add((bool)reader["MS_CHANGE"]);
                pm.Add((bool)reader["MS_ADD"]);
                pm.Add((bool)reader["MS_DELETE"]);
                pm.Add((bool)reader["MB_DIRECTOR"]);
                pm.Add((bool)reader["MB_VIEW"]);
                pm.Add((bool)reader["MB_CHANGE"]);
                pm.Add((bool)reader["MB_ADD"]);
                pm.Add((bool)reader["MB_DELETE"]);
                pm.Add((bool)reader["ST_VIEW"]);
                pm.Add((bool)reader["ST_PRINT"]);
            }
            reader.Close();
            conn.Close();
            for (int j = 0; j < pm.Count; j++)
            {
                if (pm[j] == true)
                    cb[j].Checked = true;
                else
                    cb[j].Checked = false;
            }

            buttom_add.Enabled = false;
            buttom_add.BackgroundImage = Image.FromFile(@"Image\buttom_add3.png");
            buttom_change.Enabled = true;
            buttom_change.BackgroundImage = Image.FromFile(@"Image\buttom_change.png");
            buttom_delete.Visible = true;
            error.Text = "";
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                dataview(i);
            }
        }

        private void list_pm()
        {
            cb = new List<CheckBox>();
            cb.Add(c1); cb.Add(c2); cb.Add(c3); cb.Add(c4); cb.Add(c5);
            cb.Add(c6); cb.Add(c7); cb.Add(c8); cb.Add(c9); cb.Add(c10);
            cb.Add(c11); cb.Add(c12); cb.Add(c13); cb.Add(c14); cb.Add(c15);
            cb.Add(c16); cb.Add(c17); cb.Add(c18); cb.Add(c19); cb.Add(c20);
            cb.Add(c21); cb.Add(c22); cb.Add(c23); cb.Add(c24); cb.Add(c25);
            cb.Add(c26); cb.Add(c27); cb.Add(c28); cb.Add(c29); cb.Add(c30);
            cb.Add(c31); cb.Add(c32); cb.Add(c33); cb.Add(c34);

            pm = new List<bool>();
            for (int i = 0; i < cb.Count; i++)
            {
                if (cb[i].Checked == true)
                    pm.Add(true);
                else
                    pm.Add(false);
            }
        }

        private void cc1_CheckedChanged(object sender, EventArgs e)
        {
            if (cc1.Checked == true)
            {
                c3.Checked = true;
                c2.Checked = true;
            }
            else
            {
                c3.Checked = false;
                c2.Checked = false;
            }
        }

        private void cc2_CheckedChanged(object sender, EventArgs e)
        {
            if (cc2.Checked == true)
            {
                c5.Checked = true;
                c6.Checked = true;
                c7.Checked = true;
                c8.Checked = true;
            }
            else
            {
                c5.Checked = false;
                c6.Checked = false;
                c7.Checked = false;
                c8.Checked = false;
            }
        }

        private void cc3_CheckedChanged(object sender, EventArgs e)
        {
            if (cc3.Checked == true)
            {
                c10.Checked = true;
                c11.Checked = true;
                c12.Checked = true;
                c13.Checked = true;
                c14.Checked = true;
                c15.Checked = true;
                c16.Checked = true;
                c17.Checked = true;
            }
            else
            {
                c10.Checked = false;
                c11.Checked = false;
                c12.Checked = false;
                c13.Checked = false;
                c14.Checked = false;
                c15.Checked = false;
                c16.Checked = false;
                c17.Checked = false;
            }
        }

        private void cc4_CheckedChanged(object sender, EventArgs e)
        {
            if (cc4.Checked == true)
            {
                c19.Checked = true;
                c20.Checked = true;
                c21.Checked = true;
                c22.Checked = true;
            }
            else
            {
                c19.Checked = false;
                c20.Checked = false;
                c21.Checked = false;
                c22.Checked = false;
            }
        }

        private void cc5_CheckedChanged(object sender, EventArgs e)
        {
            if (cc5.Checked == true)
            {
                c24.Checked = true;
                c25.Checked = true;
                c26.Checked = true;
                c27.Checked = true;
            }
            else
            {
                c24.Checked = false;
                c25.Checked = false;
                c26.Checked = false;
                c27.Checked = false;
            }
        }

        private void cc6_CheckedChanged(object sender, EventArgs e)
        {
            if (cc6.Checked == true)
            {
                c29.Checked = true;
                c30.Checked = true;
                c31.Checked = true;
                c32.Checked = true;
            }
            else
            {
                c29.Checked = false;
                c30.Checked = false;
                c31.Checked = false;
                c32.Checked = false;
            }
        }

        private void cc7_CheckedChanged(object sender, EventArgs e)
        {
            if (cc7.Checked == true)
            {
                c33.Checked = true;
                c34.Checked = true;
            }
            else
            {
                c33.Checked = false;
                c34.Checked = false;
            }
        }
        public bool btit = false;
        private void title_TextChanged(object sender, EventArgs e)
        {
            if (title.Text.Length == 0)
            {
                btit = false;
                error.Text = "Please insert title";
            }
            else
            {
                btit = true;
                error.Text ="";
            }
        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {
            if (c1.Checked == true)
            {
                list_pm();
                for (int i = 0; i < cb.Count; i++)
                {
                    cb[i].Checked = true;
                    cc1.Checked = true;
                    cc2.Checked = true;
                    cc3.Checked = true;
                    cc4.Checked = true;
                    cc5.Checked = true;
                    cc6.Checked = true;
                    cc7.Checked = true;
                }
            }
            else
            {
                list_pm();
                for (int i = 0; i < cb.Count; i++)
                {
                    cb[i].Checked = false;
                    cb[i].Checked = false;
                    cc1.Checked = false;
                    cc2.Checked = false;
                    cc3.Checked = false;
                    cc4.Checked = false;
                    cc5.Checked = false;
                    cc6.Checked = false;
                    cc7.Checked = false;
                }
            }
        } 
     
    }
}

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
    public partial class Permission : Form
    {
        private string manager;
        private SqlConnection conn;
        List<CheckBox> cb;
        List<bool> pm;

        public Permission(string manager1,SqlConnection conn1)
        {
            InitializeComponent();
            manager = manager1;
            conn = conn1;
            Connect c = new Connect();
            conn = c.GetConnect();
        }

        private void Permission_Load(object sender, EventArgs e)
        {
            dataview();
        }

        private void dataview()
        {
            SqlCommand cmd = new SqlCommand("select * from Manager where MaM='" + manager + "'", conn);
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
    }
}

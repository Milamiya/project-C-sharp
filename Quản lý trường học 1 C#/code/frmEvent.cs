using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace College_Management_System
{
    public partial class frmEvent : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

        public frmEvent()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtEventName.Text = "";
            dtpStartingDate.Text = System.DateTime.Today.ToString();
            dtpStartingTime.Text = System.DateTime.Now.TimeOfDay.ToString();
            dtpEndingDate.Text = System.DateTime.Today.ToString();
            dtpEndingTime.Text = System.DateTime.Now.TimeOfDay.ToString();
            txtManagedBy.Text = "";
            txtActivities.Text = "";
            listBox1.Visible = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            checkBox1.Checked = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                {
                    this.listBox1.SelectedIndex = i;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {

                foreach (object lstbxitem in this.listBox1.SelectedItems)
                {

                    txtManagedBy.Text += lstbxitem;

                }
                listBox1.Visible = false;
                txtActivities.Focus();
            }
        }
        public void FillList()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Staffname) FROM Employee", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                listBox1.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    listBox1.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmEvent_Load(object sender, EventArgs e)
        {
            FillList();
            Autocomplete();
            checkBox1.Checked = false;
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEventName.Text == "")
            {
                MessageBox.Show("Please enter event name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEventName.Focus();
                return;
            }
            if (txtManagedBy.Text == "")
            {
                MessageBox.Show("Please select staffs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select EventName from Event where EventName= '" + txtEventName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Event Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEventName.Text = "";
                    txtEventName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into Event(EventName,StartingDate,StartingTime,Endingdate,EndingTime,ManagedBy,Activities) VALUES ('" + txtEventName.Text + "','" + dtpStartingDate.Text + "','" + dtpStartingTime.Text + "','" + dtpEndingDate.Text + "','" + dtpEndingTime.Text + "','" + txtManagedBy.Text + "','" + txtActivities.Text + "')";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();

                btnSave.Enabled = false;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT distinct EventName FROM event", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Event");


                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["EventName"].ToString());

                }
                txtEventName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtEventName.AutoCompleteCustomSource = col;
                txtEventName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update Event set Eventname= @d2, StartingDate= @d3 , StartingTime= @d4 , EndingDate= @d5 , EndingTime = @d6 , ManagedBy= @d7 , Activities= @d8 where EventID= @d1 ";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "Eventid"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 150, "EventName"));
                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "StartingDate"));
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 20, "StartingTime"));
                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 30, "EndingDate"));
                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 20, "EndingTime"));
                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 250, "ManagedBy"));
                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.Text, 1000, "Activities"));
                cmd.Parameters["@d2"].Value = txtEventName.Text;
                cmd.Parameters["@d3"].Value = dtpStartingDate.Text;
                cmd.Parameters["@d4"].Value = dtpStartingTime.Text;
                cmd.Parameters["@d5"].Value = dtpEndingDate.Text;
                cmd.Parameters["@d6"].Value = dtpEndingTime.Text;
                cmd.Parameters["@d7"].Value = txtManagedBy.Text;
                cmd.Parameters["@d8"].Value = txtActivities.Text;
                cmd.Parameters["@d1"].Value = Convert.ToInt32(txtEventID.Text);
              
             
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();

                btnUpdate_record.Enabled = false;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }
        private void delete_records()
        {

            try
            {


                int RowsAffected = 0;

                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from Event where EventID= '" + txtEventID.Text + "'";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    Autocomplete();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmEventRecord form2 = new frmEventRecord();
            form2.label1.Text = label6.Text;
            form2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dtpEndingDate.Text = dtpStartingDate.Text;
                dtpEndingTime.Text = dtpStartingTime.Text;
                dtpEndingDate.Enabled = false;
                dtpEndingTime.Enabled = false;
            }
            else
            {
                dtpEndingDate.Text = System.DateTime.Today.ToString();
                dtpEndingTime.Text = System.DateTime.Now.TimeOfDay.ToString();
                dtpEndingDate.Enabled = true;
                dtpEndingTime.Enabled = true;
            }
        }
    }
}
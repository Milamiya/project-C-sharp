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
    public partial class frmHostel : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        ConnectionString cs = new ConnectionString();

        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       

        public frmHostel()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtHostelID.Text = "";
            txtHostelName.Text = "";
            txtHostelFees.Text = "";
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            btnSave.Enabled = true;
            txtHostelName.Focus();

        }
        private void frmHostel_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtHostelName.Text == "")
            {
                MessageBox.Show("Please enter hostel name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHostelName.Focus();
                return;
            }
            if (txtHostelFees.Text == "")
            {
                MessageBox.Show("Please enter hostel fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHostelFees.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select HostelName from Hostel where HostelName= '" + txtHostelName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Hostel Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHostelName.Text = "";
                    txtHostelName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into hostel(HostelName,HostelFees) VALUES (@d1,@d2)";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.VarChar, 250, "HostelName"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.Int, 10, "HostelFees"));
                cmd.Parameters["@d1"].Value = txtHostelName.Text.Trim();
                cmd.Parameters["@d2"].Value = Convert.ToInt32(txtHostelFees.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                Autocomplete();
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
                SqlCommand cmd = new SqlCommand("SELECT  distinct HostelName FROM Hostel", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Hostel");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["HostelName"].ToString());

                }
                txtHostelName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtHostelName.AutoCompleteCustomSource = col;
                txtHostelName.AutoCompleteMode = AutoCompleteMode.Suggest;

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


                string cq = "delete from Hostel where Hostelid=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "Hostelid"));


                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(txtHostelID.Text);
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
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con.Close();
                }
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

                string cb = "update hostel set hostelname=@d2,hostelfees=@d3 where hostelid=@d1";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "HostelID"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "HostelName"));
                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.Int, 10, "HostelFees"));
                cmd.Parameters["@d1"].Value = Convert.ToInt32(txtHostelID.Text);
                cmd.Parameters["@d2"].Value = txtHostelName.Text;
                cmd.Parameters["@d3"].Value = Convert.ToInt32(txtHostelFees.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmHostelRecord frm = new frmHostelRecord();
            frm.label1.Text = label1.Text;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelRecord frm = new frmHostelRecord();
            frm.label1.Text = label1.Text;
            frm.Show();
        }

        private void txtHostelFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}

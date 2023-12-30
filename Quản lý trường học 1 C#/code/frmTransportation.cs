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
    public partial class frmTransportation : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

        public frmTransportation()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtSourceLocation.Text = "";
            txtBusCharges.Text = "";
            btnSave.Enabled = true;
            btnUpdate_record.Enabled = false;
            btnDelete.Enabled = false;
            txtSourceLocation.Focus();
        }
        private void frmTransportation_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSourceLocation.Text == "")
            {
                MessageBox.Show("Please enter source location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSourceLocation.Focus();
                return;
            }
            if (txtBusCharges.Text == "")
            {
                MessageBox.Show("Please enter bus charges", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusCharges.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select SourceLocation from Transportation where SourceLocation= '" + txtSourceLocation.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Source Location Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSourceLocation.Text = "";
                    txtSourceLocation.Focus();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into Transportation(SourceLocation,BusCharges) VALUES (@d1,@d2)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.Int, 10, "BusCharges"));
                cmd.Parameters["@d1"].Value = txtSourceLocation.Text;
                cmd.Parameters["@d2"].Value = Convert.ToInt32(txtBusCharges.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Transportation Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SqlCommand cmd = new SqlCommand("SELECT distinct SourceLocation FROM Transportation", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Transportation");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["SourceLocation"].ToString());

                }
                txtSourceLocation.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSourceLocation.AutoCompleteCustomSource = col;
                txtSourceLocation.AutoCompleteMode = AutoCompleteMode.Suggest;

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
                string cb = "update Transportation set SourceLocation=@d1,BusCharges=@d2 where RouteID=@d3 ";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.Int, 10, "BusCharges"));
                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.Int, 10, "RouteID"));
                cmd.Parameters["@d1"].Value = txtSourceLocation.Text;
                cmd.Parameters["@d2"].Value = Convert.ToInt32(txtBusCharges.Text);
                cmd.Parameters["@d3"].Value = Convert.ToInt32(txtRouteID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Transportation Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string cq = "delete from Transportation where RouteID=@DELETE1";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "RouteID"));
                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(txtRouteID.Text);
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

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransportationRecord  frm = new frmTransportationRecord();
            frm.label1.Text = label1.Text;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmTransportationRecord frm = new frmTransportationRecord();
            frm.label1.Text = label1.Text;
            frm.Show();
        }

        private void txtBusCharges_KeyPress(object sender, KeyPressEventArgs e)
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

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
    public partial class frmBusHolders : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        ConnectionString cs = new ConnectionString();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       

        public frmBusHolders()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            ScholarNo.Text = "";
            StudentName.Text = "";
            Course.Text = "";
            Branch.Text = "";
            cmbSourceLocation.Text = "";
            dtpStartingDate.Text = DateTime.Today.ToString();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            ScholarNo.Focus();
        }
        private void Autocomplete()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(SourceLocation) from Transportation ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbSourceLocation.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AutocompleScholarNo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(ScholarNo) from student ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ScholarNo.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmTransportationers_Load(object sender, EventArgs e)
        {
            Autocomplete();
            AutocompleScholarNo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ScholarNo.Text == "")
            {
                MessageBox.Show("Please select scholar no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScholarNo.Focus();
                return;
            }
            if (cmbSourceLocation.Text == "")
            {
                MessageBox.Show("Please select Source Location", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSourceLocation.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select ScholarNo from BusHolders where ScholarNo= '" + ScholarNo.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ScholarNo.Text = "";
                    ScholarNo.Focus();

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into BusHolders(ScholarNo,SourceLocation,StartingDate) VALUES (@d1,@d2,@d3)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;


                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "ScholarNo"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "StartingDate"));


                cmd.Parameters["@d1"].Value = ScholarNo.Text;
                cmd.Parameters["@d2"].Value = cmbSourceLocation.Text;
                cmd.Parameters["@d3"].Value = dtpStartingDate.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ScholarNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT Student_Name,Course,Branch FROM student WHERE ScholarNo = '" + ScholarNo.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    StudentName.Text = rdr.GetString(0).Trim();


                    Course.Text = rdr.GetString(1).Trim();

                    Branch.Text = rdr.GetString(2).Trim();
                    cmbSourceLocation.Focus();
                }


                if ((rdr != null))
                {
                    rdr.Close();
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

        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb = "update BusHolders set SourceLocation=@d2,StartingDate=@d3 where Scholarno=@d1";

            cmd = new SqlCommand(cb);

            cmd.Connection = con;


            cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "ScholarNo"));
            cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "SourceLocation"));

            cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "StartingDate"));


            cmd.Parameters["@d1"].Value = ScholarNo.Text;
            cmd.Parameters["@d2"].Value = cmbSourceLocation.Text;
            cmd.Parameters["@d3"].Value = dtpStartingDate.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnUpdate_record.Enabled = false;
            con.Close();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusHoldersRecord1 frm = new frmBusHoldersRecord1();
            frm.label5.Text = label3.Text;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusHoldersRecord1 frm = new frmBusHoldersRecord1();
            frm.label5.Text = label3.Text;
            frm.Show();
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

                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct = "select ScholarNo from BusFeePayment where ScholarNo= '" + ScholarNo.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    Autocomplete();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                int RowsAffected = 0;

                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from BusHolders where ScholarNo= '" + ScholarNo.Text + "'";
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

        private void frmBusHolders_Load(object sender, EventArgs e)
        {
            AutocompleScholarNo();
            Autocomplete();
        }
    }
}

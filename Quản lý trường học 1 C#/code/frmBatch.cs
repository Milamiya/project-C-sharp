using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace College_Management_System
{
    public partial class frmBatch : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
      
        public frmBatch()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            cmbSession.Text = "";
            cmbCourse.Text = "";
            cmbSemester.Text = "";
            cmbSemester.Enabled = false;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            cmbCourse.Enabled = false;
            cmbSession.Focus();
        }
        private void frmBatch_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Autocomplete()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(session) FROM student", CN);
                ds = new DataSet("ds");
                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbSession.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbSession.Items.Add(drow[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSession.Text = cmbSession.Text.Trim();
            cmbCourse.Items.Clear();
            cmbCourse.Text = "";
            cmbCourse.Enabled = true;
            cmbCourse.Focus();

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(course) from student where session = '" + cmbSession.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbCourse.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSemester.Items.Clear();
            cmbSemester.Text = "";
            cmbSemester.Enabled = true;
            cmbSemester.Focus();

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(semestername) from semester where course = '" + cmbCourse.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbSemester.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbSession.Text == "")
            {
                MessageBox.Show("Please select session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSession.Focus();
                return;
            }
            if (cmbCourse.Text == "")
            {
                MessageBox.Show("Please select course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCourse.Focus();
                return;
            }
          
            if (cmbSemester.Text == "")
            {
                MessageBox.Show("Please select semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSemester.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select session,course from batch where Course= '" + cmbCourse.Text + "' and Session= '" + cmbSession.Text + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "insert into batch(Session,course,semester) VALUES ('" + cmbSession.Text + "','" + cmbCourse.Text + "','" + cmbSemester.Text + "')";
                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Batch Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
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
       
        private void btnUpdate_record_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string cb = "update batch set Session='" + cmbSession.Text + "',course='" + cmbCourse.Text + "',semester='" + cmbSemester.Text + "' where BatchID='" + Convert.ToInt32(txtBatchID.Text) + "'";
            cmd = new SqlCommand(cb);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated", "Batch Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnUpdate_record.Enabled = false;
            con.Close();
        }
        private void delete_records()
        {
            try
            {
            int RowsAffected=0;
            con = new SqlConnection(cs.DBConn);

            con.Open();
            string ct = "select Session,Course,Semester from Attendance where Session='" + cmbSession.Text + "' and Course='" + cmbCourse.Text + "' and Semester='" + cmbSemester.Text + "'";
            cmd = new SqlCommand(ct);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                if ((rdr != null))
                {
                    rdr.Close();
                }
                return;
            }
            con = new SqlConnection(cs.DBConn);

            con.Open();
            string ct1 = "select Session,Course,Semester from Attendance where Session='" + cmbSession.Text + "' and Course='" + cmbCourse.Text + "' and Semester='" + cmbSemester.Text + "'";
            cmd = new SqlCommand(ct1);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                if ((rdr != null))
                {
                    rdr.Close();
                }
                return;
            }
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string cq = "delete from batch where batchid='" + txtBatchID.Text + "'";
            cmd = new SqlCommand(cq);
            cmd.Connection = con;
            RowsAffected = cmd.ExecuteNonQuery();
            if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
               con.Close();    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBatchRecord frm = new frmBatchRecord();
            frm.label1.Text = label6.Text;
            frm.Show();
        }

        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBatchRecord frm = new frmBatchRecord();
            frm.label1.Text = label6.Text;
            frm.Show();
        }
    
    }
}

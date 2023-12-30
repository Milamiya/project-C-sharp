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
    public partial class frmSemester : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();


        public frmSemester()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtSemesterID.Text = "";
            txtSemesterName.Text = "";
         
            cmbCourse.Text = "";
    
            txtSemesterName.Focus();
        }
        private void frmSemester_Load(object sender, EventArgs e)
        {
            AutocompleCourse();
            Autocomplete();
        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
          
        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT distinct SemesterName FROM Semester", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "My List");
                //list can be any name u want

                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["SemesterName"].ToString());

                }

                txtSemesterName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSemesterName.AutoCompleteCustomSource = col;
                txtSemesterName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSemesterName.Text == "")
            {
                MessageBox.Show("Please enter semester name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSemesterName.Focus();
                return;
            }
            if (cmbCourse.Text == "")
            {
                MessageBox.Show("Please select course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCourse.Focus();
                return;
            }
           
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select SemesterName from Semester where SemesterName= '" + txtSemesterName.Text + "' and Course= '" + cmbCourse.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSemesterName.Text = "";
                    cmbCourse.Text = "";
                    txtSemesterName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into semester(SemesterName,course) VALUES (@d2,@d3)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

              

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 10, "SemesterName"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 20, "course"));
          

              
                cmd.Parameters["@d2"].Value = txtSemesterName.Text.Trim();
                cmd.Parameters["@d3"].Value = cmbCourse.Text.Trim();
           
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
                con.Close();
                btnSave.Enabled = false;
                Autocomplete();
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

                string cb = "update semester set SemesterName=@d2,course=@d3 where SemesterID=@d1";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "SemesterID"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 10, "SemesterName"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 20, "course"));
              

                cmd.Parameters["@d1"].Value = Convert.ToInt32(txtSemesterID.Text);
                cmd.Parameters["@d2"].Value = txtSemesterName.Text.Trim();
                cmd.Parameters["@d3"].Value = cmbCourse.Text.Trim();
          
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
                con.Close();
                btnUpdate_record.Enabled = false;
                Autocomplete();
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
                string ct1 = "select semester from Attendance where Semester= '" + txtSemesterName.Text + "'";


                cmd = new SqlCommand(ct1);

                cmd.Connection = con;
               

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct2 = "select semester from SubjectInfo where Semester= '" + txtSemesterName.Text + "'";


                cmd = new SqlCommand(ct2);

                cmd.Connection = con;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct3 = "select semester from InternalMarksEntry where Semester= '" + txtSemesterName.Text + "'";


                cmd = new SqlCommand(ct3);

                cmd.Connection = con;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct4 = "select semester from Student where Semester= '" + txtSemesterName.Text + "'";


                cmd = new SqlCommand(ct4);

                cmd.Connection = con;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from semester where SemesterID=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "SemesterID"));


                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(txtSemesterID.Text);
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clear();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
               
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
        public void AutocompleCourse()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(coursename) from course ";

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
        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSemesterRecord frm = new frmSemesterRecord();
            frm.label1.Text = label1.Text;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            frmSemesterRecord frm = new frmSemesterRecord();
            frm.label1.Text = label1.Text;
            frm.Show();
        }

        private void txtSemesterName_TextChanged(object sender, EventArgs e)
        {
            txtSemesterName.Text = txtSemesterName.Text.Trim();
        }

     
        }

      
    }


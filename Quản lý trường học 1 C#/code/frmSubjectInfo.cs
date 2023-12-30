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
    public partial class frmSubjectInfo : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        ConnectionString cs = new ConnectionString();
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       

        public frmSubjectInfo()
        {
            InitializeComponent();
        }
        private void Reset()
        {

            SubjectCode.Text = "";
            SubjectName.Text = "";
           
            cmbCourse.Text = "";
            cmbBranch.Text = "";
            Semester.Text = "";
            btnSave.Enabled = true;
            Delete.Enabled = false;
            Update_record.Enabled = false;
            SubjectCode.Focus();
            cmbBranch.Enabled = false;
            Semester.Enabled = false;
        }
        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void PopulateCourseID()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM( CourseName) from  course";

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
        private void frmSubjectInfo_Load(object sender, EventArgs e)
        {
            PopulateCourseID();
            Autocomplete();
        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT subjectcode FROM subjectinfo", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "subjectinfo");


                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["SubjectCode"].ToString());

                }
                SubjectCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                SubjectCode.AutoCompleteCustomSource = col;
                SubjectCode.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CourseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourse.Text = cmbCourse.Text.Trim();
            cmbBranch.Items.Clear();
            cmbBranch.Text = "";
            cmbBranch.Enabled = true;
            cmbBranch.Focus();

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(Branchname) from course where coursename = '" + cmbCourse.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbBranch.Items.Add(rdr[0]);
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
            if (SubjectCode.Text == "")
            {
                MessageBox.Show("Please enter subject code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubjectCode.Focus();
                return;
            }
            if (SubjectName.Text == "")
            {
                MessageBox.Show("Please enter subject name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubjectName.Focus();
                return;
            }
            if (cmbCourse.Text == "")
            {
                MessageBox.Show("Please select course name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCourse.Focus();
                return;
            }
            if (cmbBranch.Text == "")
            {
                MessageBox.Show("Please select Branch name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBranch.Focus();
                return;
            }
            if (Semester.Text == "")
            {
                MessageBox.Show("Please select semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Semester.Focus();
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select subjectcode from subjectinfo where subjectcode=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "subjectcode"));
                cmd.Parameters["@find"].Value = SubjectCode.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Subject Code Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   SubjectCode.Text = "";
                   SubjectCode.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into subjectinfo(subjectcode,subjectname,coursename,branch,semester) VALUES (@d1,@d2,@d4,@d5,@d6)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "SubjectCode"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "subjectname"));


                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 20, "coursename"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 50, "branchname"));
                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 10, "semester"));
                cmd.Parameters["@d1"].Value = SubjectCode.Text.Trim();
                cmd.Parameters["@d2"].Value = SubjectName.Text.Trim();
              
                cmd.Parameters["@d4"].Value = cmbCourse.Text.Trim();
                cmd.Parameters["@d5"].Value = cmbBranch.Text.Trim();
                cmd.Parameters["@d6"].Value = Semester.Text.Trim();
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

        private void SubjectCode_TextChanged(object sender, EventArgs e)
        {
            SubjectCode.Text = SubjectCode.Text.TrimEnd();
            if (label1.Text == "Admin")
            {
                Delete.Enabled = true;
                Update_record.Enabled = true;
            }
            else
            {
                Delete.Enabled = false;
                Update_record.Enabled = false;
            }
            try
            {
             
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM subjectinfo WHERE SubjectCode = '" + SubjectCode.Text.Trim() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                   
                    SubjectName.Text = (String) rdr["SubjectName"];
                    cmbCourse.Text = (String)rdr["CourseName"];
                    cmbBranch.Text = (String)rdr["Branch"];
                    Semester.Text = (String)rdr["Semester"]; 
                  
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

        private void Update_record_Click(object sender, EventArgs e)
        {
            try{
              con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update subjectinfo set subjectname=@d2,coursename=@d4,branch=@d5,semester=@d6 where subjectcode=@d1"; 

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "SubjectCode"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.VarChar, 250, "subjectname"));

             


                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 20, "coursename"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 50, "branchname"));
                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 10, "semester"));
              
                cmd.Parameters["@d1"].Value = SubjectCode.Text.Trim();
                cmd.Parameters["@d2"].Value = SubjectName.Text.Trim();
               
      
                cmd.Parameters["@d4"].Value = cmbCourse.Text.Trim();
                cmd.Parameters["@d5"].Value = cmbBranch.Text.Trim();
                cmd.Parameters["@d6"].Value = Semester.Text.Trim();
           
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Update_record.Enabled = false;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (SubjectCode.Text == "")
            {
                MessageBox.Show("Please enter subject code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SubjectCode.Focus();
                return;
            }
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
                string ct = "select SubjectCode from Attendance where SubjectCode=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "SubjectCode"));


                cmd.Parameters["@find"].Value = SubjectCode.Text;


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
                string ct1 = "select SubjectCode from InternalMarksEntry where SubjectCode=@find";


                cmd = new SqlCommand(ct1);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "SubjectCode"));


                cmd.Parameters["@find"].Value = SubjectCode.Text;


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


                string cq = "delete from subjectinfo where subjectcode=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 20, "subjectcode"));


                cmd.Parameters["@DELETE1"].Value = SubjectCode.Text;
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

             private void ViewRecord_Click(object sender, EventArgs e)
             {
                 frmSubjectInfoRecord frm = new frmSubjectInfoRecord();
                 frm.Show();
                 this.Hide();
                 
             }

             private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
             {
                 cmbBranch.Text = cmbBranch.Text.Trim();
                 Semester.Items.Clear();
                 Semester.Text = "";
                 Semester.Enabled = true;
                 Semester.Focus();

                 try
                 {

                     con = new SqlConnection(cs.DBConn);
                     con.Open();


                     string ct = "select distinct RTRIM(SemesterName) from Semester where course = '" + cmbCourse.Text + "' order by 1 ";

                     cmd = new SqlCommand(ct);
                     cmd.Connection = con;

                     rdr = cmd.ExecuteReader();

                     while (rdr.Read())
                     {
                         Semester.Items.Add(rdr[0]);
                     }
                     con.Close();

                 }

                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }
        }
    }


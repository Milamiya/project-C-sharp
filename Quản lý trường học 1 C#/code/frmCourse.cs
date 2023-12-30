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
    public partial class frmCourse : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();


        public frmCourse()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtCourseID.Text = "";
            txtCourseName.Text = "";
            txtBranchName.Text = "";
            txtCourseID.Focus();

            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
        }
        private void NewRecord_Click(object sender, EventArgs e)
        {
            txtCourseID.Text="";
            txtCourseName.Text = "";
            txtBranchName.Text = "";
            txtCourseName.Focus();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
        }
        private void Autocomplete()
        {
            try{
            con = new SqlConnection(cs.DBConn);
            con.Open();


            SqlCommand cmd = new SqlCommand("SELECT distinct coursename FROM course", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "course");


            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["Coursename"].ToString());

            }
           txtCourseName.AutoCompleteSource = AutoCompleteSource.CustomSource;
           txtCourseName.AutoCompleteCustomSource = col;
           txtCourseName.AutoCompleteMode = AutoCompleteMode.Suggest;

            con.Close();
        }
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
          
            if (txtCourseName.Text == "")
            {
                MessageBox.Show("Please enter course name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseName.Focus();
                return;
            }
            if (txtBranchName.Text == "")
            {
                MessageBox.Show("Please enter branch name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBranchName.Focus();
                return;
            }
          
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select Coursename,BranchName from Course where CourseName= '" + txtCourseName.Text + "' and BranchName= '" + txtBranchName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    txtCourseName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into course(coursename,branchname) VALUES (@d2,@d3)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

               

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 20, "coursename"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 50, "branchname"));

              
               
                cmd.Parameters["@d2"].Value = txtCourseName.Text.Trim();
                cmd.Parameters["@d3"].Value = txtBranchName.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Course Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                Autocomplete();
                AutocompleteBranch();
                btnSave.Enabled = false;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_record_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb = "update course set coursename=@d2,branchname=@d3 where courseid=@d1";

            cmd = new SqlCommand(cb);

            cmd.Connection = con;

            cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.Int, 20, "courseid"));

            cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 20, "coursename"));

            cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "branchname"));


            cmd.Parameters["@d1"].Value = Convert.ToInt32(txtCourseID.Text);
            cmd.Parameters["@d2"].Value = txtCourseName.Text.Trim();
            cmd.Parameters["@d3"].Value = txtBranchName.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnUpdate_record.Enabled = false;
            Autocomplete();
            AutocompleteBranch();
            con.Close();

        }

        private void Delete_Click(object sender, EventArgs e)
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
                string ct = "select Course from Student where Course=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Course"));


                cmd.Parameters["@find"].Value = txtCourseName.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCourseID.Text = "";
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                    AutocompleteBranch();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct1 = "select Course from semester where Course=@find";


                cmd = new SqlCommand(ct1);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Course"));


                cmd.Parameters["@find"].Value = txtCourseName.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCourseID.Text = "";
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                    AutocompleteBranch();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct2 = "select Course from Section where Course=@find";


                cmd = new SqlCommand(ct2);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Course"));


                cmd.Parameters["@find"].Value = txtCourseName.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCourseID.Text = "";
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                    AutocompleteBranch();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct3 = "select Course from StudentRegistration where Course=@find";


                cmd = new SqlCommand(ct3);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Course"));


                cmd.Parameters["@find"].Value = txtCourseName.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCourseID.Text = "";
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                    AutocompleteBranch();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct4 = "select Coursename from SubjectInfo where Coursename=@find";


                cmd = new SqlCommand(ct4);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Coursename"));


                cmd.Parameters["@find"].Value = txtCourseName.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCourseID.Text = "";
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                    AutocompleteBranch();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct5 = "select Course from FeesDetails where Course=@find";


                cmd = new SqlCommand(ct5);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Course"));


                cmd.Parameters["@find"].Value = txtCourseName.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCourseID.Text = "";
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                    AutocompleteBranch();

                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from course where courseid=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "CourseID"));


                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(txtCourseID.Text);
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCourseID.Text = "";
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                    AutocompleteBranch();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCourseID.Text = "";
                    txtCourseName.Text = "";
                    txtBranchName.Text = "";
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
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
        private void AutocompleteBranch()
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT distinct BranchName FROM course", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "My List");
            //list can be any name u want

            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["BranchName"].ToString());

            }
            txtBranchName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBranchName.AutoCompleteCustomSource = col;
            txtBranchName.AutoCompleteMode = AutoCompleteMode.Suggest;

            con.Close();
        }
     
        private void Course_Load(object sender, EventArgs e)

        {
            Autocomplete();
            AutocompleteBranch();
       
        }

        public void GetDetails_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmCourseRecord form2 = new frmCourseRecord();
            form2.label1.Text = label1.Text;
            form2.Show();
        }

      
     

        private void CourseName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void BranchName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmCourseRecord form2 = new frmCourseRecord();
            form2.label1.Text = label1.Text;
            form2.Show();
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            txtCourseName.Text = txtCourseName.Text.Trim();
        }

        private void txtBranchName_TextChanged(object sender, EventArgs e)
        {
            txtBranchName.Text = txtBranchName.Text.Trim();
        }

    }
}

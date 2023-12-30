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
    public partial class frmInternalMarksEntry : Form
    {
        ConnectionString cs = new ConnectionString();
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        public frmInternalMarksEntry()
        {
            InitializeComponent();
        }

        private void cmbSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCourse.Items.Clear();
            cmbCourse.Text = "";
            cmbCourse.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(course) from Student where session = '" + cmbSession.Text + "'";
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
            cmbBranch.Items.Clear();
            cmbBranch.Text = "";
            cmbBranch.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(branch) from Student where course = '" + cmbCourse.Text + "' and session='" + cmbSession.Text + "'";

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

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSemester.Items.Clear();
            cmbSemester.Text = "";
            cmbSemester.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(Semester) from batch where Course = '" + cmbCourse.Text + "' and session='" + cmbSession.Text + "'";

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

        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSection.Items.Clear();
            cmbSection.Text = "";
            cmbSection.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(Section) from Student,batch where Student.Session=Batch.session and Student.Course = '" + cmbCourse.Text + "' and Student.Branch= '" + cmbBranch.Text + "' and Semester='" + cmbSemester.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbSection.Items.Add(rdr[0]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbSubjectCode.Items.Clear();
                cmbSubjectCode.Text = "";
                cmbSubjectCode.Enabled = true;
                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(SubjectCode) from SubjectInfo where CourseName = '" + cmbCourse.Text + "' and Branch= '" + cmbBranch.Text + "' and semester= '" + cmbSemester.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   cmbSubjectCode.Items.Add(rdr[0]);
                }
                con.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
        }

        private void cmbSubjectCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT SubjectName FROM SubjectInfo WHERE SubjectCode = '" + cmbSubjectCode.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    txtSubjectName.Text = rdr.GetString(0).Trim();
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

        private void btnSubmit_Click(object sender, EventArgs e)
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
            if (cmbBranch.Text == "")
            {
                MessageBox.Show("Please select branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBranch.Focus();
                return;
            }
            if (cmbSemester.Text == "")
            {
                MessageBox.Show("Please select semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSemester.Focus();
                return;
            }

            if (cmbSection.Text == "")
            {
                MessageBox.Show("Please select section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSection.Focus();
                return;
            }
            if (label5.Text == "Admin")
            {
                Delete.Enabled = true;
            }
            else
            {
                Delete.Enabled = false;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string sql = "select rtrim(ScholarNo),rtrim(Enrollment_no),rtrim(student_name) from Student,batch where Student.session=batch.session and Student.Course = '" + cmbCourse.Text + "' and Student.Branch= '" + cmbBranch.Text + "' and Batch.semester= '" + cmbSemester.Text + "' and Student.Session= '" + cmbSession.Text + "' and section='" + cmbSection.Text + "' order by student_name,ScholarNo";
                cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AutocompleSession()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(session) from Student ";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbSession.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmInternalMarksEntry_Load(object sender, EventArgs e)
        {
            AutocompleSession();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
    
        }
        private void Reset()
        {
            cmbBranch.Text="";
            cmbCourse.Text = "";
            cmbSection.Text = "";
            cmbSession.Text = "";
            cmbSemester.Text = "";
            cmbSubjectCode.Text = "";
            txtSubjectName.Text = "";
            cmbExamName.Text = "";
            dtpExamDate.Text = System.DateTime.Today.ToString();
            txtMaxMarks.Text = "";
            txtMinMarks.Text = "";
            cmbBranch.Enabled = false;
            cmbCourse.Enabled = false;
            cmbSemester.Enabled = false;
            cmbSubjectCode.Enabled = false;
            cmbSection.Enabled = false;
            dataGridView1.Rows.Clear();
            btnSave.Enabled = true;
            Delete.Enabled = false;
            Update_record.Enabled = false;
            cmbSession.Focus();
        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
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
            if (cmbBranch.Text == "")
            {
                MessageBox.Show("Please select branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBranch.Focus();
                return;
            }
            if (cmbSemester.Text == "")
            {
                MessageBox.Show("Please select semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSemester.Focus();
                return;
            }

            if (cmbSection.Text == "")
            {
                MessageBox.Show("Please select section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSection.Focus();
                return;
            }
            if (cmbSubjectCode.Text == "")
            {
                MessageBox.Show("Please select subject code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSubjectCode.Focus();
                return;
            }
            if (cmbExamName.Text == "")
            {
                MessageBox.Show("Please select exam name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbExamName.Focus();
                return;
            }
            if (txtMaxMarks.Text == "")
            {
                MessageBox.Show("Please enter max. marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaxMarks.Focus();
                return;
            }
            if (txtMinMarks.Text == "")
            {
                MessageBox.Show("Please enter min. marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMinMarks.Focus();
                return;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (!row.IsNewRow)
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select ScholarNo,SubjectCode,ExamName from InternalMarksEntry where ScholarNo='" + row.Cells[0].Value + "' and SubjectCode='" + cmbSubjectCode.Text + "'  and ExamName= '" + cmbExamName.Text + "'";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if ((rdr != null))
                        {
                            rdr.Close();
                        }
                        return;
                    }
                }
            }
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string cb = "insert into InternalMarksEntry(Session,Course,Branch,Semester,Section,SubjectCode,SubjectName,ExamName,ExamDate,MaxMarks,MinMarks,ScholarNo,MarksObtained) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13)";

            cmd = new SqlCommand(cb);

            cmd.Connection = con;
            // Add Parameters to Command Parameters collection
            cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 30, "Session"));
            cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Course"));
            cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "Branch"));
            cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "Semester"));
            cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 10, "Section"));
            cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 20, "SubjectCode"));
            cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 250, "SubjectName"));
            cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 20, "ExamName"));
            cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 30, "ExamDate"));
            cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.Int, 10, "MinMarks"));
            cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.Int, 10, "MaxMarks"));
            cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.NChar, 15, "ScholarNo"));
            cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.Int, 10, "MarksObtained"));
        

            // Prepare command for repeated execution
            cmd.Prepare();
            // Data to be inserted
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (!row.IsNewRow)
                {
                    cmd.Parameters["@d1"].Value = cmbSession.Text;
                    cmd.Parameters["@d2"].Value = cmbCourse.Text;
                    cmd.Parameters["@d3"].Value = cmbBranch.Text;
                    cmd.Parameters["@d4"].Value = cmbSemester.Text;
                    cmd.Parameters["@d5"].Value = cmbSection.Text;
                    cmd.Parameters["@d6"].Value = cmbSubjectCode.Text;
                    cmd.Parameters["@d7"].Value = txtSubjectName.Text;
                    cmd.Parameters["@d8"].Value = cmbExamName.Text;
                    cmd.Parameters["@d9"].Value = dtpExamDate.Text;
                    cmd.Parameters["@d10"].Value = txtMaxMarks.Text;
                    cmd.Parameters["@d11"].Value = txtMinMarks.Text;
                    cmd.Parameters["@d12"].Value = row.Cells[0].Value;
                    cmd.Parameters["@d13"].Value = row.Cells[3].Value;
                    cmd.ExecuteNonQuery();
                }
            }
            con.Close();
            MessageBox.Show("Successfully saved", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSave.Enabled = false;
               }
                catch (Exception ex)
               {
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
        }

        private void Update_record_Click(object sender, EventArgs e)
        {
            try
            {
            
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string cb = "update InternalMarksEntry set Session=@d1,Course=@d2,Branch=@d3,Semester=@d4,Section=@d5,SubjectName=@d7,ExamDate=@d9,MaxMarks=@d10,MinMarks=@d11,MarksObtained=@d13 where ScholarNo=@d12 and ExamName=@d8 and SubjectCode=@d6 ";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                // Add Parameters to Command Parameters collection
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 30, "Session"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Course"));
                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "Branch"));
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "Semester"));
                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 10, "Section"));
                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 20, "SubjectCode"));
                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 250, "SubjectName"));
                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 20, "ExamName"));
                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 30, "ExamDate"));
                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.Int, 10, "MinMarks"));
                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.Int, 10, "MaxMarks"));
                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.NChar, 15, "ScholarNo"));
                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.Int, 10, "MarksObtained"));


                // Prepare command for repeated execution
                cmd.Prepare();
                // Data to be inserted
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (!row.IsNewRow)
                    {
                        cmd.Parameters["@d1"].Value = cmbSession.Text;
                        cmd.Parameters["@d2"].Value = cmbCourse.Text;
                        cmd.Parameters["@d3"].Value = cmbBranch.Text;
                        cmd.Parameters["@d4"].Value = cmbSemester.Text;
                        cmd.Parameters["@d5"].Value = cmbSection.Text;
                        cmd.Parameters["@d6"].Value = cmbSubjectCode.Text;
                        cmd.Parameters["@d7"].Value = txtSubjectName.Text;
                        cmd.Parameters["@d8"].Value = cmbExamName.Text;
                        cmd.Parameters["@d9"].Value = dtpExamDate.Text;
                        cmd.Parameters["@d10"].Value = txtMaxMarks.Text;
                        cmd.Parameters["@d11"].Value = txtMinMarks.Text;
                        cmd.Parameters["@d12"].Value = row.Cells[0].Value;
                        cmd.Parameters["@d13"].Value = row.Cells[3].Value;
                        cmd.ExecuteNonQuery();
                    }
                }
                con.Close();
                MessageBox.Show("Successfully updated", "Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Update_record.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmInternalMarksEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            this.Hide();
            frm.UserType.Text = label5.Text;
            frm.User.Text = label6.Text;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (label5.Text == "Admin")
                {
                    Update_record.Enabled = true;
                }
                else
                {
                    Update_record.Enabled = false;
                }
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
                if (cmbBranch.Text == "")
                {
                    MessageBox.Show("Please select branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbBranch.Focus();
                    return;
                }
                if (cmbSemester.Text == "")
                {
                    MessageBox.Show("Please select semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSemester.Focus();
                    return;
                }

                if (cmbSection.Text == "")
                {
                    MessageBox.Show("Please select section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSection.Focus();
                    return;
                }
                if (cmbSubjectCode.Text == "")
                {
                    MessageBox.Show("Please select subject code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbSubjectCode.Focus();
                    return;
                }
                if (cmbExamName.Text == "")
                {
                    MessageBox.Show("Please select exam name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbExamName.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string sql = "select RTrim(Student.ScholarNo)[ScholarNo],Rtrim(Enrollment_no)[Enrollment No.], RTRIM(Student_Name)[Student Name], RTRIM(MarksObtained)[Marks Obtained],examdate,MaxMarks,MinMarks from Student,InternalMarksEntry where Student.ScholarNo=InternalMarksEntry.Scholarno and InternalMarksEntry.Course= '" + cmbCourse.Text + "'and InternalMarksEntry.branch='" + cmbBranch.Text + "'and InternalMarksEntry.Session='" + cmbSession.Text + "' and InternalMarksEntry.Semester= '" + cmbSemester.Text + "' and InternalMarksEntry.Section= '" + cmbSection.Text + "' and SubjectCode='" + cmbSubjectCode.Text + "'and ExamName='"  + cmbExamName.Text + "' order by Student.student_name";
                cmd = new SqlCommand(sql, con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2],rdr[3]);
                    dtpExamDate.Text = (string)rdr["ExamDate"];
                    txtMaxMarks.Text = rdr.GetInt32(5).ToString();
                    txtMinMarks.Text = rdr.GetInt32(6).ToString();
                }
                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete the records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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
                string cq = "delete from InternalMarksEntry where Session='" + cmbSession.Text + "' and Course='" + cmbCourse.Text + "' and Branch='" + cmbBranch.Text + "' and Semester='" + cmbSemester.Text + "' and Section='" + cmbSection.Text + "'";
                cmd = new SqlCommand(cq);
                cmd.Connection = con;
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Delete.Enabled = false;
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Delete.Enabled = false;
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
    }
}

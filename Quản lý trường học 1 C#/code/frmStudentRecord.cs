using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace College_Management_System
{
    public partial class frmStudentRecord : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
       

        public frmStudentRecord()
        {
            InitializeComponent();
        }

       
        private void AutocompleteSession()
        {

            try
            {
               

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Student.session) FROM Student", CN);
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
     
        
        private void AutocompleteStudentName()
        {

            try
            {
               

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Student_Name) FROM Student", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                StudentName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    StudentName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void StudentRecord_Load(object sender, EventArgs e)

        {
            cmbSession.Enabled = true;
            AutocompleteSession();
            AutocompleteStudentName();
        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cmbCourse.Text = "";
            cmbBranch.Text = "";
            cmbSession.Text = "";
            cmbSection.Text = "";
            cmbSemester.Text = "";
            cmbBranch.Enabled = false;
            cmbCourse.Enabled = false;
            cmbSemester.Enabled = false;
            cmbSection.Enabled = false;
            cmbSession.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
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
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select RTrim(Student.ScholarNo)[Scholar No.], RTRIM(Student_Name)[Student Name], RTRIM(Admission_No)[Admission No.], RTRIM(DateOfAdmission)[Date Of Admission], RTRIM(Enrollment_no)[Enrollment No.], RTRIM(Fathers_Name)[Father's Name],RTRIM(Mother_name)[Mother's Name], RTRIM(Gender)[Gender], RTRIM(DOB)[DOB],RTRIM(Category)[Category],RTRIM(Religion)[Religion],RTRIM(Student.session)[Session], RTRIM(Address)[Address], RTRIM(Contact_No)[Contact No.], RTRIM(Email)[Email], RTRIM(Student.Course)[Course], RTRIM(Student.Branch)[Branch],RTRIM(Semester)[Semester],RTRIM(Section)[Section], RTRIM(Submitted_Documents)[Documents Submitted], RTRIM(Nationality)[Nationality], RTRIM(High_School_name)[High School], RTRIM(HS_Year_of_passing)[Year Of Passing], RTRIM(HS_Percentage)[Percentage], RTRIM(HS_Board)[Board], RTRIM(Higher_secondary_Name)[Higher Secondary], RTRIM(H_year_of_passing)[HS Year Of Passing], RTRIM(H_percentage)[HS Percentage], RTRIM(H_board)[HS Board]  from student,Batch where Student.session=batch.session and Student.Course= '" + cmbCourse.Text + "'and Student.branch='" + cmbBranch.Text + "'and Student.Session='" + cmbSession.Text + "' and Semester= '" + cmbSemester.Text + "' and Section= '" + cmbSection.Text + "' order by student_name", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "Batch");
                dataGridView1.DataSource = myDataSet.Tables["Student"].DefaultView;
                dataGridView1.DataSource = myDataSet.Tables["Batch"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;
           
                rowsTotal = dataGridView1.RowCount - 1;
                colsTotal = dataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView1.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }

        private void StudentRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu form2 = new frmMainMenu();
            form2.UserType.Text = label10.Text;
            form2.User.Text = label11.Text;
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            DateFrom.Text = DateTime.Today.ToString();
            DateTo.Text = DateTime.Today.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;
           
                rowsTotal = dataGridView2.RowCount - 1;
                colsTotal = dataGridView2.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView2.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView2.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
             
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select RTrim(Student.ScholarNo)[Scholar No.], RTRIM(Student_Name)[Student Name], RTRIM(Admission_No)[Admission No.], RTRIM(DateOfAdmission)[Date Of Admission], RTRIM(Enrollment_no)[Enrollment No.], RTRIM(Fathers_Name)[Father's Name],RTRIM(Mother_name)[Mother's Name], RTRIM(Gender)[Gender], RTRIM(DOB)[DOB],RTRIM(Category)[Category],RTRIM(Religion)[Religion],RTRIM(Student.session)[Session], RTRIM(Address)[Address], RTRIM(Contact_No)[Contact No.], RTRIM(Email)[Email], RTRIM(Student.Course)[Course], RTRIM(Student.Branch)[Branch],RTRIM(Semester)[Semester],RTRIM(Section)[Section], RTRIM(Submitted_Documents)[Documents Submitted], RTRIM(Nationality)[Nationality], RTRIM(High_School_name)[High School], RTRIM(HS_Year_of_passing)[Year Of Passing], RTRIM(HS_Percentage)[Percentage], RTRIM(HS_Board)[Board], RTRIM(Higher_secondary_Name)[Higher Secondary], RTRIM(H_year_of_passing)[HS Year Of Passing], RTRIM(H_percentage)[HS Percentage], RTRIM(H_board)[HS Board]  from student,Batch where Student.session=batch.session and DateOfAdmission between @date1 and @date2", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, " DateOfAdmission").Value = DateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, " DateOfAdmission").Value = DateTo.Value.Date;
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "Batch");
                dataGridView2.DataSource = myDataSet.Tables["Student"].DefaultView;
                dataGridView2.DataSource = myDataSet.Tables["Batch"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtStudent.Text = "";
            dataGridView3.DataSource = null;
            StudentName.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView3.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;
             
                rowsTotal = dataGridView3.RowCount - 1;
                colsTotal = dataGridView3.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView3.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView3.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }

        private void StudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
               
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand(" select RTrim(Student.ScholarNo)[Scholar No.], RTRIM(Student_Name)[Student Name], RTRIM(Admission_No)[Admission No.], RTRIM(DateOfAdmission)[Date Of Admission], RTRIM(Enrollment_no)[Enrollment No.], RTRIM(Fathers_Name)[Father's Name],RTRIM(Mother_name)[Mother's Name], RTRIM(Gender)[Gender], RTRIM(DOB)[DOB],RTRIM(Category)[Category],RTRIM(Religion)[Religion],RTRIM(Student.session)[Session], RTRIM(Address)[Address], RTRIM(Contact_No)[Contact No.], RTRIM(Email)[Email], RTRIM(Student.Course)[Course], RTRIM(Student.Branch)[Branch],RTRIM(Semester)[Semester],RTRIM(Section)[Section], RTRIM(Submitted_Documents)[Documents Submitted], RTRIM(Nationality)[Nationality], RTRIM(High_School_name)[High School], RTRIM(HS_Year_of_passing)[Year Of Passing], RTRIM(HS_Percentage)[Percentage], RTRIM(HS_Board)[Board], RTRIM(Higher_secondary_Name)[Higher Secondary], RTRIM(H_year_of_passing)[HS Year Of Passing], RTRIM(H_percentage)[HS Percentage], RTRIM(H_board)[HS Board]  from student,Batch where Student.session=batch.session and Student_Name= '" + StudentName.Text + "'", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "Batch");
                dataGridView3.DataSource = myDataSet.Tables["Student"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["Batch"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            txtStudent.Text = "";
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            cmbCourse.Text = "";
            cmbBranch.Text = "";
            cmbSession.Text = "";
            cmbSemester.Text = "";
            cmbSection.Text = "";
            DateFrom.Text = DateTime.Today.ToString();
            DateTo.Text = DateTime.Today.ToString();
            StudentName.Text = "";
            cmbBranch.Enabled = false;
            cmbCourse.Enabled = false;
            cmbSemester.Enabled = false;
            cmbSection.Enabled = false;
        }

        private void Branch_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand(" select RTrim(Student.ScholarNo)[Scholar No.], RTRIM(Student_Name)[Student Name], RTRIM(Admission_No)[Admission No.], RTRIM(DateOfAdmission)[Date Of Admission], RTRIM(Enrollment_no)[Enrollment No.], RTRIM(Fathers_Name)[Father's Name],RTRIM(Mother_name)[Mother's Name], RTRIM(Gender)[Gender], RTRIM(DOB)[DOB],RTRIM(Category)[Category],RTRIM(Religion)[Religion],RTRIM(Student.session)[Session], RTRIM(Address)[Address], RTRIM(Contact_No)[Contact No.], RTRIM(Email)[Email], RTRIM(Student.Course)[Course], RTRIM(Student.Branch)[Branch],RTRIM(Semester)[Semester],RTRIM(Section)[Section], RTRIM(Submitted_Documents)[Documents Submitted], RTRIM(Nationality)[Nationality], RTRIM(High_School_name)[High School], RTRIM(HS_Year_of_passing)[Year Of Passing], RTRIM(HS_Percentage)[Percentage], RTRIM(HS_Board)[Board], RTRIM(Higher_secondary_Name)[Higher Secondary], RTRIM(H_year_of_passing)[HS Year Of Passing], RTRIM(H_percentage)[HS Percentage], RTRIM(H_board)[HS Board]  from student,Batch where Student.session=batch.session and Student_Name like '" + txtStudent.Text + "%' order by Student_name", con);
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Student");
                myDA.Fill(myDataSet, "Batch");
                dataGridView3.DataSource = myDataSet.Tables["Student"].DefaultView;
                dataGridView3.DataSource = myDataSet.Tables["Batch"].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Session_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Semester_SelectedIndexChanged(object sender, EventArgs e)
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

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView2.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView2.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dataGridView3_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView3.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView3.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

 

       
        }

       
       
    }
    
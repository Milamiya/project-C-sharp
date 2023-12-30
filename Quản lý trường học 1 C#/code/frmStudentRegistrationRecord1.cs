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
    public partial class frmStudentRegistrationRecord1 : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

       

        public frmStudentRegistrationRecord1()
        {
            InitializeComponent();
        }
        private void AutocompleteCourse()
        {

            try
            {
                
                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Course) FROM StudentRegistration", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                Course.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    Course.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AutocompleteSession()
        {

            try
            {
               
                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Session) FROM StudentRegistration", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                Session.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    Session.Items.Add(drow[0].ToString());

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
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Student_Name) FROM StudentRegistration", CN);
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

        private void frmRegistrationRecord_Load(object sender, EventArgs e)
        {
            AutocompleteCourse();
            AutocompleteSession();
            AutocompleteStudentName();
        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch.Items.Clear();
            Branch.Text = "";
            Branch.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(branch) from StudentRegistration where course= '" + Course.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Branch.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Course.Text == "")
                {
                    MessageBox.Show("Please select course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Course.Focus();
                    return;
                }
                if (Branch.Text == "")
                {
                    MessageBox.Show("Please select branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Branch.Focus();
                    return;
                }
                if (Session.Text == "")
                {
                    MessageBox.Show("Please select session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Session.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select RTRIM(Student_Name)[Student Name], RTRIM(Admission_No)[Admission No.], RTRIM(DateOfAdmission)[Date Of Admission], RTRIM(Fathers_Name)[Father's Name],RTRIM(Mother_name)[Mother's Name], RTRIM(Gender)[Gender], RTRIM(DOB)[DOB],RTRIM(Category)[Category],RTRIM(Religion)[Religion],RTRIM(Session)[Session], RTRIM(Address)[Address], RTRIM(Contact_No)[Contact No.], RTRIM(Email)[Email], RTRIM(Course)[Course], RTRIM(Branch)[Branch], RTRIM(Submitted_Documents)[Documents Submitted],RTRIM(Nationality)[Nationality],RTRIM(GuardianName)[GuardianName],RTRIM(GuardianAddress)[Guardian Address],RTRIM(GuardianContactNo)[Guardian Contact No.], RTRIM(High_School_name)[High School], RTRIM(HS_Year_of_passing)[Year Of Passing], RTRIM(HS_Percentage)[Percentage], RTRIM(HS_Board)[Board], RTRIM(Higher_secondary_Name)[Higher Secondary], RTRIM(H_year_of_passing)[HS Year Of Passing], RTRIM(H_percentage)[HS Percentage], RTRIM(H_board)[HS Board],RTRIM(Graduation)[Graduation],RTRIM(G_Year_Of_Passing)[Grad. Year Of Passing],RTRIM(G_percentage)[Grad. Percentage],RTRIM(G_University)[Grad. University],RTRIM(Post_Graduation)[Post Graduation],RTRIM(PG_Year_Of_Passing)[PG Year Of Passing],RTRIM(PG_percentage)[PG Percentage],RTRIM(PG_University)[PG University]  from studentRegistration where  Course= '" + Course.Text + "'and branch='" + Branch.Text + "'and Session='" + Session.Text + "'order by DateOfAdmission", con);


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "StudentRegistration");

                dataGridView1.DataSource = myDataSet.Tables["StudentRegistration"].DefaultView;




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
            Course.Text = "";
            Branch.Text = "";
            Session.Text = "";
            Branch.Enabled = false;
            Session.Enabled = false;
            Course.Focus();
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
                xlApp.Columns[3].Cells.NumberFormat = "@";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select  RTRIM(Student_Name)[Student Name], RTRIM(Admission_No)[Admission No.], RTRIM(DateOfAdmission)[Date Of Admission], RTRIM(Fathers_Name)[Father's Name],RTRIM(Mother_name)[Mother's Name], RTRIM(Gender)[Gender], RTRIM(DOB)[DOB],RTRIM(Category)[Category],RTRIM(Religion)[Religion],RTRIM(Session)[Session], RTRIM(Address)[Address], RTRIM(Contact_No)[Contact No.], RTRIM(Email)[Email], RTRIM(Course)[Course], RTRIM(Branch)[Branch], RTRIM(Submitted_Documents)[Documents Submitted], RTRIM(Nationality)[Nationality],RTRIM(GuardianName)[GuardianName],RTRIM(GuardianAddress)[Guardian Address],RTRIM(GuardianContactNo)[Guardian Contact No.], RTRIM(High_School_name)[High School], RTRIM(HS_Year_of_passing)[Year Of Passing], RTRIM(HS_Percentage)[Percentage], RTRIM(HS_Board)[Board], RTRIM(Higher_secondary_Name)[Higher Secondary], RTRIM(H_year_of_passing)[HS Year Of Passing], RTRIM(H_percentage)[HS Percentage], RTRIM(H_board)[HS Board],RTRIM(Graduation)[Graduation],RTRIM(G_Year_Of_Passing)[Grad. Year Of Passing],RTRIM(G_percentage)[Grad. Percentage],RTRIM(G_University)[Grad. University],RTRIM(Post_Graduation)[Post Graduation],RTRIM(PG_Year_Of_Passing)[PG Year Of Passing],RTRIM(PG_percentage)[PG Percentage],RTRIM(PG_University)[PG University]  from studentRegistration where  DateOfAdmission between @date1 and @date2 order by DateOfAdmission", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, " DateOfAdmission").Value = DateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, " DateOfAdmission").Value = DateTo.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "StudentRegistration");

                dataGridView2.DataSource = myDataSet.Tables["StudentRegistration"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                xlApp.Columns[3].Cells.NumberFormat = "@";
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

        private void StudentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select  RTRIM(Student_Name)[Student Name], RTRIM(Admission_No)[Admission No.], RTRIM(DateOfAdmission)[Date Of Admission], RTRIM(Fathers_Name)[Father's Name],RTRIM(Mother_name)[Mother's Name], RTRIM(Gender)[Gender], RTRIM(DOB)[DOB],RTRIM(Category)[Category],RTRIM(Religion)[Religion],RTRIM(Session)[Session], RTRIM(Address)[Address], RTRIM(Contact_No)[Contact No.], RTRIM(Email)[Email], RTRIM(Course)[Course], RTRIM(Branch)[Branch], RTRIM(Submitted_Documents)[Documents Submitted], RTRIM(Nationality)[Nationality],RTRIM(GuardianName)[GuardianName],RTRIM(GuardianAddress)[Guardian Address],RTRIM(GuardianContactNo)[Guardian Contact No.], RTRIM(High_School_name)[High School], RTRIM(HS_Year_of_passing)[Year Of Passing], RTRIM(HS_Percentage)[Percentage], RTRIM(HS_Board)[Board], RTRIM(Higher_secondary_Name)[Higher Secondary], RTRIM(H_year_of_passing)[HS Year Of Passing], RTRIM(H_percentage)[HS Percentage], RTRIM(H_board)[HS Board],RTRIM(Graduation)[Graduation],RTRIM(G_Year_Of_Passing)[Grad. Year Of Passing],RTRIM(G_percentage)[Grad. Percentage],RTRIM(G_University)[Grad. University],RTRIM(Post_Graduation)[Post Graduation],RTRIM(PG_Year_Of_Passing)[PG Year Of Passing],RTRIM(PG_percentage)[PG Percentage],RTRIM(PG_University)[PG University] from studentRegistration where  Student_Name= '" + StudentName.Text + "'order by DateOfAdmission", con);


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "StudentRegistration");

                dataGridView3.DataSource = myDataSet.Tables["StudentRegistration"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                xlApp.Columns[3].Cells.NumberFormat = "@";
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

        private void tabControl1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            Course.Text = "";
            Branch.Text = "";
            Session.Text = "";
            DateFrom.Text = DateTime.Today.ToString();
            DateTo.Text = DateTime.Today.ToString();
            StudentName.Text = "";
         
            Branch.Enabled = false;
            Session.Enabled = false;
        }

        private void Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Items.Clear();
            Session.Text = "";
            Session.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(Session) from StudentRegistration where Branch= '" + Branch.Text + "' and Course= '" + Course.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Session.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Hide();
                frmStudent frm = new frmStudent();
                // or simply use column name instead of index
                //dr.Cells["id"].Value.ToString();
                frm.Show();
                frm.StudentName.Text = dr.Cells[0].Value.ToString();
                frm.AdmissionNo.Text = dr.Cells[1].Value.ToString();
                frm.DateOfAdmission.Text = dr.Cells[2].Value.ToString();
                frm.FatherName.Text = dr.Cells[3].Value.ToString();
                frm.MotherName.Text = dr.Cells[4].Value.ToString();
                frm.Gender.Text = dr.Cells[5].Value.ToString();
                frm.DOB.Text = dr.Cells[6].Value.ToString();
                frm.Category.Text = dr.Cells[7].Value.ToString();
                frm.Religion.Text = dr.Cells[8].Value.ToString();
                frm.Session.Text = dr.Cells[9].Value.ToString();
                frm.Address.Text = dr.Cells[10].Value.ToString();
                frm.ContactNo.Text = dr.Cells[11].Value.ToString();
                frm.Email.Text = dr.Cells[12].Value.ToString();
                frm.Course.Text = dr.Cells[13].Value.ToString();
                frm.Branch.Text = dr.Cells[14].Value.ToString();
                frm.DocumentSubmitted.Text = dr.Cells[15].Value.ToString();
                frm.Nationality.Text = dr.Cells[16].Value.ToString();
                frm.GuardianName.Text = dr.Cells[17].Value.ToString();
                frm.GuardianAddress.Text = dr.Cells[18].Value.ToString();
                frm.GuardianContactNo.Text = dr.Cells[19].Value.ToString();
                frm.HS.Text = dr.Cells[20].Value.ToString();
                frm.HSYOP.Text = dr.Cells[21].Value.ToString();
                frm.HSPercentage.Text = dr.Cells[22].Value.ToString();
                frm.HSBoard.Text = dr.Cells[23].Value.ToString();
                frm.HSS.Text = dr.Cells[24].Value.ToString();
                frm.HSSYOP.Text = dr.Cells[25].Value.ToString();
                frm.HSSPercentage.Text = dr.Cells[26].Value.ToString();
                frm.HSSBoard.Text = dr.Cells[27].Value.ToString();
                frm.UG.Text = dr.Cells[28].Value.ToString();
                frm.GYOP.Text = dr.Cells[29].Value.ToString();
                frm.GPercentage.Text = dr.Cells[30].Value.ToString();
                frm.GUniy.Text = dr.Cells[31].Value.ToString();
                frm.PG.Text = dr.Cells[32].Value.ToString();
                frm.PGYOP.Text = dr.Cells[33].Value.ToString();
                frm.PGpercentage.Text = dr.Cells[34].Value.ToString();
                frm.PGUniy.Text = dr.Cells[35].Value.ToString();
                frm.label11.Text = label5.Text;
                frm.label30.Text = label8.Text;
                frm.ScholarNo.Focus();
                frm.Branch.Enabled = false;
               
                frm.Section.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView3_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView3.SelectedRows[0];
                this.Hide();
                frmStudent frm = new frmStudent();
                // or simply use column name instead of index
                //dr.Cells["id"].Value.ToString();
                frm.Show();
                frm.StudentName.Text = dr.Cells[0].Value.ToString();
                frm.AdmissionNo.Text = dr.Cells[1].Value.ToString();
                frm.DateOfAdmission.Text = dr.Cells[2].Value.ToString();
                frm.FatherName.Text = dr.Cells[3].Value.ToString();
                frm.MotherName.Text = dr.Cells[4].Value.ToString();
                frm.Gender.Text = dr.Cells[5].Value.ToString();
                frm.DOB.Text = dr.Cells[6].Value.ToString();
                frm.Category.Text = dr.Cells[7].Value.ToString();
                frm.Religion.Text = dr.Cells[8].Value.ToString();
                frm.Session.Text = dr.Cells[9].Value.ToString();
                frm.Address.Text = dr.Cells[10].Value.ToString();
                frm.ContactNo.Text = dr.Cells[11].Value.ToString();
                frm.Email.Text = dr.Cells[12].Value.ToString();
                frm.Course.Text = dr.Cells[13].Value.ToString();
                frm.Branch.Text = dr.Cells[14].Value.ToString();
                frm.DocumentSubmitted.Text = dr.Cells[15].Value.ToString();
                frm.Nationality.Text = dr.Cells[16].Value.ToString();
                frm.GuardianName.Text = dr.Cells[17].Value.ToString();
                frm.GuardianAddress.Text = dr.Cells[18].Value.ToString();
                frm.GuardianContactNo.Text = dr.Cells[19].Value.ToString();
                frm.HS.Text = dr.Cells[20].Value.ToString();
                frm.HSYOP.Text = dr.Cells[21].Value.ToString();
                frm.HSPercentage.Text = dr.Cells[22].Value.ToString();
                frm.HSBoard.Text = dr.Cells[23].Value.ToString();
                frm.HSS.Text = dr.Cells[24].Value.ToString();
                frm.HSSYOP.Text = dr.Cells[25].Value.ToString();
                frm.HSSPercentage.Text = dr.Cells[26].Value.ToString();
                frm.HSSBoard.Text = dr.Cells[27].Value.ToString();
                frm.UG.Text = dr.Cells[28].Value.ToString();
                frm.GYOP.Text = dr.Cells[29].Value.ToString();
                frm.GPercentage.Text = dr.Cells[30].Value.ToString();
                frm.GUniy.Text = dr.Cells[31].Value.ToString();
                frm.PG.Text = dr.Cells[32].Value.ToString();
                frm.PGYOP.Text = dr.Cells[33].Value.ToString();
                frm.PGpercentage.Text = dr.Cells[34].Value.ToString();
                frm.PGUniy.Text = dr.Cells[35].Value.ToString();
                frm.ScholarNo.Focus();
                frm.label11.Text = label5.Text;
                frm.label30.Text = label8.Text;
                frm.Branch.Enabled = false;
              
                frm.Section.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView2.SelectedRows[0];
                this.Hide();
                frmStudent frm = new frmStudent();
                // or simply use column name instead of index
                //dr.Cells["id"].Value.ToString();
                frm.Show();
                frm.StudentName.Text = dr.Cells[0].Value.ToString();
                frm.AdmissionNo.Text = dr.Cells[1].Value.ToString();
                frm.DateOfAdmission.Text = dr.Cells[2].Value.ToString();
                frm.FatherName.Text = dr.Cells[3].Value.ToString();
                frm.MotherName.Text = dr.Cells[4].Value.ToString();
                frm.Gender.Text = dr.Cells[5].Value.ToString();
                frm.DOB.Text = dr.Cells[6].Value.ToString();
                frm.Category.Text = dr.Cells[7].Value.ToString();
                frm.Religion.Text = dr.Cells[8].Value.ToString();
                frm.Session.Text = dr.Cells[9].Value.ToString();
                frm.Address.Text = dr.Cells[10].Value.ToString();
                frm.ContactNo.Text = dr.Cells[11].Value.ToString();
                frm.Email.Text = dr.Cells[12].Value.ToString();
                frm.Course.Text = dr.Cells[13].Value.ToString();
                frm.Branch.Text = dr.Cells[14].Value.ToString();
                frm.DocumentSubmitted.Text = dr.Cells[15].Value.ToString();
                frm.Nationality.Text = dr.Cells[16].Value.ToString();
                frm.GuardianName.Text = dr.Cells[17].Value.ToString();
                frm.GuardianAddress.Text = dr.Cells[18].Value.ToString();
                frm.GuardianContactNo.Text = dr.Cells[19].Value.ToString();
                frm.HS.Text = dr.Cells[20].Value.ToString();
                frm.HSYOP.Text = dr.Cells[21].Value.ToString();
                frm.HSPercentage.Text = dr.Cells[22].Value.ToString();
                frm.HSBoard.Text = dr.Cells[23].Value.ToString();
                frm.HSS.Text = dr.Cells[24].Value.ToString();
                frm.HSSYOP.Text = dr.Cells[25].Value.ToString();
                frm.HSSPercentage.Text = dr.Cells[26].Value.ToString();
                frm.HSSBoard.Text = dr.Cells[27].Value.ToString();
                frm.UG.Text = dr.Cells[28].Value.ToString();
                frm.GYOP.Text = dr.Cells[29].Value.ToString();
                frm.GPercentage.Text = dr.Cells[30].Value.ToString();
                frm.GUniy.Text = dr.Cells[31].Value.ToString();
                frm.PG.Text = dr.Cells[32].Value.ToString();
                frm.PGYOP.Text = dr.Cells[33].Value.ToString();
                frm.PGpercentage.Text = dr.Cells[34].Value.ToString();
                frm.PGUniy.Text = dr.Cells[35].Value.ToString();
                frm.ScholarNo.Focus();
                frm.Branch.Enabled = false;
               
                frm.Section.Enabled = false;
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
                cmd = new SqlCommand("select  RTRIM(Student_Name)[Student Name], RTRIM(Admission_No)[Admission No.], RTRIM(DateOfAdmission)[Date Of Admission], RTRIM(Fathers_Name)[Father's Name],RTRIM(Mother_name)[Mother's Name], RTRIM(Gender)[Gender], RTRIM(DOB)[DOB],RTRIM(Category)[Category],RTRIM(Religion)[Religion],RTRIM(Session)[Session], RTRIM(Address)[Address], RTRIM(Contact_No)[Contact No.], RTRIM(Email)[Email], RTRIM(Course)[Course], RTRIM(Branch)[Branch], RTRIM(Submitted_Documents)[Documents Submitted], RTRIM(Nationality)[Nationality],RTRIM(GuardianName)[GuardianName],RTRIM(GuardianAddress)[Guardian Address],RTRIM(GuardianContactNo)[Guardian Contact No.], RTRIM(High_School_name)[High School], RTRIM(HS_Year_of_passing)[Year Of Passing], RTRIM(HS_Percentage)[Percentage], RTRIM(HS_Board)[Board], RTRIM(Higher_secondary_Name)[Higher Secondary], RTRIM(H_year_of_passing)[HS Year Of Passing], RTRIM(H_percentage)[HS Percentage], RTRIM(H_board)[HS Board],RTRIM(Graduation)[Graduation],RTRIM(G_Year_Of_Passing)[Grad. Year Of Passing],RTRIM(G_percentage)[Grad. Percentage],RTRIM(G_University)[Grad. University],RTRIM(Post_Graduation)[Post Graduation],RTRIM(PG_Year_Of_Passing)[PG Year Of Passing],RTRIM(PG_percentage)[PG Percentage],RTRIM(PG_University)[PG University] from studentRegistration where  Student_Name like'" + StudentName.Text + "%' order by DateOfAdmission", con);


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "StudentRegistration");

                dataGridView3.DataSource = myDataSet.Tables["StudentRegistration"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            StudentName.Text = "";
            dataGridView3.DataSource = null;
        }

        private void frmStudentRegistrationRecord1_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmStudent frm = new frmStudent();
            this.Hide();
            frm.label11.Text = label5.Text;
            frm.label30.Text = label8.Text;
            frm.Show();
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

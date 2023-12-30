using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace College_Management_System
{
    public partial class frmStudent : Form
    {

        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();
      
          public frmStudent()
        {
            InitializeComponent();
        }
     
        private void Student_Load(object sender, EventArgs e)
        {
           
          
            btnPrint.Enabled = false;
            listBox1.Visible = false;
            printToolStripMenuItem.Enabled = false;
          
            AutocompleCourse();
            Autocomplete();
        }
        public void Reset()
        {

            ScholarNo.Text = "";
            AdmissionNo.Text = "";
            StudentName.Text = "";
            EnrollmentNo.Text = "";
            FatherName.Text = "";
            MotherName.Text = "";
            Category.Text = "";
            Religion.Text = "";
            Session.Text = "";
            DOB.Text = "";
            Gender.Text = "";
            Address.Text = "";
            ContactNo.Text = "";
            Email.Text = "";
            Course.Text = "";
            Branch.Text = "";
           
            Section.Text = "";
            GuardianName.Text = "";
            GuardianContactNo.Text = "";
            GuardianAddress.Text = "";
            UG.Text = "Select Graduation";
            PG.Text = "Select Post Graduation";
            PGpercentage.Text = "";
            PGUniy.Text = "";
            PGYOP.Text = "";
            GYOP.Text = "";
            GUniy.Text = "";
            GPercentage.Text = "";
            HSSYOP.Text = "";
            DateOfAdmission.Text = DateTime.Today.ToString();
            DocumentSubmitted.Text = "";
            Nationality.Text = "";
            HSBoard.Text = "";
            HSPercentage.Text = "";
            HSSBoard.Text = "";
            HSSPercentage.Text = "";
            HSYOP.Text = "";
            HSSYOP.Text = "";
            Picture.Image = Properties.Resources.photo;
            btnPrint.Enabled = false;
            listBox1.Visible = false;
            Branch.Enabled = false;
            Section.Enabled = false;
           

            btnPrint.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            deleteToolStripMenuItem1.Enabled = false;
            updateToolStripMenuItem.Enabled = false;
            printToolStripMenuItem.Enabled = false;

        }

        private void NewRecord_Click(object sender, EventArgs e)
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
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(scholarNo) FROM student", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                ScholarNo.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    ScholarNo.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Save();
        }
        private void update()
        {

            if (ScholarNo.Text == "")
            {
                MessageBox.Show("Please enter Scholar No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScholarNo.Focus();
                return;
            }
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update student set Student_name=@d2,Admission_No=@d3,DateOfAdmission=@d4,Enrollment_no=@d5,Fathers_Name=@d6,Gender=@d7,DOB=@d8,Address=@d9,Session=@d10,Contact_No=@d11,Email=@d12,Course=@d13,Branch=@d14,Submitted_Documents=@d15,Nationality=@d16,GuardianName=@d17,GuardianContactNo=@d18,GuardianAddress=@d19,High_School_name=@d20,HS_Year_of_passing=@d21,HS_Percentage=@d22,HS_Board=@d23,Higher_secondary_Name=@d24,H_year_of_passing=@d25,H_percentage=@d26,H_board=@d27,Graduation=@d28,G_year_of_passing=@d29,G_percentage=@d30,G_University=@d31,Post_graduation=@d32,PG_year_of_passing=@d33,PG_percentage=@d34,PG_university=@d35,mother_name=@d36,Religion=@d37,Category=@d38,section=@d39,photo=@d40 where scholarno=@d1";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                if (UG.SelectedIndex == -1)
                {
                    UG.Text = "";
                }
                if (PG.SelectedIndex == -1)
                {
                    PG.Text = "";
                }

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "ScholarNo"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Student_name"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 15, "Admission_No"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 30, "DateOfAdmission"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 15, "Enrollment_no"));

                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 30, "Fathers_Name"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.NChar, 10, "Gender"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 15, "DOB"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 50, "Address"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 10, "Session"));

                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 10, "Contact_No"));

                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.NChar, 30, "Email"));

                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.NChar, 30, "Course"));

                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.NChar, 30, "Branch"));

                cmd.Parameters.Add(new SqlParameter("@d15", System.Data.SqlDbType.VarChar, 250, "Submitted_Documents"));

                cmd.Parameters.Add(new SqlParameter("@d16", System.Data.SqlDbType.NChar, 20, "Nationality"));
                cmd.Parameters.Add(new SqlParameter("@d17", System.Data.SqlDbType.NChar, 30, "GuardianName"));
                cmd.Parameters.Add(new SqlParameter("@d18", System.Data.SqlDbType.NChar, 10, "GuardianContactNo"));
                cmd.Parameters.Add(new SqlParameter("@d19", System.Data.SqlDbType.NChar, 50, "GuardianAddress"));
                cmd.Parameters.Add(new SqlParameter("@d20", System.Data.SqlDbType.NChar, 30, "High_School_name"));
                cmd.Parameters.Add(new SqlParameter("@d21", System.Data.SqlDbType.NChar, 10, "HS_Year_of_passing"));
                cmd.Parameters.Add(new SqlParameter("@d22", System.Data.SqlDbType.NChar, 10, "HS_Percentage"));
                cmd.Parameters.Add(new SqlParameter("@d23", System.Data.SqlDbType.NChar, 30, "HS_Board"));
                cmd.Parameters.Add(new SqlParameter("@d24", System.Data.SqlDbType.NChar, 30, "Higher_secondary_Name"));
                cmd.Parameters.Add(new SqlParameter("@d25", System.Data.SqlDbType.NChar, 10, "H_year_of_passing"));
                cmd.Parameters.Add(new SqlParameter("@d26", System.Data.SqlDbType.NChar, 10, "H_percentage"));
                cmd.Parameters.Add(new SqlParameter("@d27", System.Data.SqlDbType.NChar, 30, "H_board"));
                cmd.Parameters.Add(new SqlParameter("@d28", System.Data.SqlDbType.NChar, 30, "Graduation"));
                cmd.Parameters.Add(new SqlParameter("@d29", System.Data.SqlDbType.NChar, 10, "G_year_of_passing"));
                cmd.Parameters.Add(new SqlParameter("@d30", System.Data.SqlDbType.NChar, 10, "G_percentage"));
                cmd.Parameters.Add(new SqlParameter("@d31", System.Data.SqlDbType.NChar, 30, "G_University"));
                cmd.Parameters.Add(new SqlParameter("@d32", System.Data.SqlDbType.NChar, 30, "Post_graduation"));
                cmd.Parameters.Add(new SqlParameter("@d33", System.Data.SqlDbType.NChar, 10, "PG_year_of_passing"));
                cmd.Parameters.Add(new SqlParameter("@d34", System.Data.SqlDbType.NChar, 10, "PG_percentage"));
                cmd.Parameters.Add(new SqlParameter("@d35", System.Data.SqlDbType.NChar, 30, "PG_university"));
                cmd.Parameters.Add(new SqlParameter("@d36", System.Data.SqlDbType.NChar, 30, "mother_name"));
                cmd.Parameters.Add(new SqlParameter("@d37", System.Data.SqlDbType.NChar, 30, "religion"));
                cmd.Parameters.Add(new SqlParameter("@d38", System.Data.SqlDbType.NChar, 15, "category"));
                cmd.Parameters.Add(new SqlParameter("@d39", System.Data.SqlDbType.NChar, 10, "Section"));
             
                cmd.Parameters["@d1"].Value = ScholarNo.Text.Trim();
                cmd.Parameters["@d2"].Value = StudentName.Text.Trim();
                cmd.Parameters["@d3"].Value = AdmissionNo.Text.Trim();
                cmd.Parameters["@d4"].Value = DateOfAdmission.Text.Trim();
                cmd.Parameters["@d5"].Value = EnrollmentNo.Text.Trim();
                cmd.Parameters["@d6"].Value = FatherName.Text.Trim();
                cmd.Parameters["@d7"].Value = Gender.Text.Trim();
                cmd.Parameters["@d8"].Value = DOB.Text.Trim();
                cmd.Parameters["@d9"].Value = Address.Text.Trim();
                cmd.Parameters["@d10"].Value = Session.Text.Trim();
                cmd.Parameters["@d11"].Value = ContactNo.Text.Trim();
                cmd.Parameters["@d12"].Value = Email.Text.Trim();
                cmd.Parameters["@d13"].Value = Course.Text.Trim();
                cmd.Parameters["@d14"].Value = Branch.Text.Trim();
                cmd.Parameters["@d15"].Value = DocumentSubmitted.Text.Trim();
                cmd.Parameters["@d16"].Value = Nationality.Text.Trim();
                cmd.Parameters["@d17"].Value = GuardianName.Text.Trim();
                cmd.Parameters["@d18"].Value = GuardianContactNo.Text.Trim();
                cmd.Parameters["@d19"].Value = GuardianAddress.Text.Trim();
                cmd.Parameters["@d20"].Value = HS.Text.Trim();
                cmd.Parameters["@d21"].Value = HSYOP.Text.Trim();
                cmd.Parameters["@d22"].Value = HSPercentage.Text.Trim();
                cmd.Parameters["@d23"].Value = HSBoard.Text.Trim();
                cmd.Parameters["@d24"].Value = HSS.Text.Trim();
                cmd.Parameters["@d25"].Value = HSSYOP.Text.Trim();
                cmd.Parameters["@d26"].Value = HSSPercentage.Text.Trim();
                cmd.Parameters["@d27"].Value = HSSBoard.Text.Trim();
                cmd.Parameters["@d28"].Value = UG.Text.Trim();
                cmd.Parameters["@d29"].Value = GYOP.Text.Trim();
                cmd.Parameters["@d30"].Value = GPercentage.Text.Trim();
                cmd.Parameters["@d31"].Value = GUniy.Text.Trim();
                cmd.Parameters["@d32"].Value = PG.Text.Trim();
                cmd.Parameters["@d33"].Value = PGYOP.Text.Trim();
                cmd.Parameters["@d34"].Value = PGpercentage.Text.Trim();
                cmd.Parameters["@d35"].Value = PGUniy.Text.Trim();
                cmd.Parameters["@d36"].Value = MotherName.Text.Trim();
                cmd.Parameters["@d37"].Value = Religion.Text.Trim();
                cmd.Parameters["@d38"].Value = Category.Text.Trim();
                cmd.Parameters["@d39"].Value = Section.Text.Trim();
            
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(Picture.Image);

                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d40", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_record_Click(object sender, EventArgs e)
        {
            update();
        }
        private void delete_records()
        {

            try
            {


                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct = "select ScholarNo from ScholarshipPayment where ScholarNo=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "ScholarNo"));


                cmd.Parameters["@find"].Value = ScholarNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Autocomplete();
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string cm = "select ScholarNo from FeePayment where ScholarNo=@find";


                cmd = new SqlCommand(cm);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "ScholarNo"));


                cmd.Parameters["@find"].Value = ScholarNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                    Autocomplete();
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string cz = "select ScholarNo from Attendance where ScholarNo=@find";


                cmd = new SqlCommand(cz);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "ScholarNo"));


                cmd.Parameters["@find"].Value = ScholarNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  
                    Autocomplete();
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string cz1 = "select ScholarNo from Hostelers where ScholarNo=@find";


                cmd = new SqlCommand(cz1);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "ScholarNo"));


                cmd.Parameters["@find"].Value = ScholarNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Autocomplete();
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string cz2 = "select ScholarNo from HostelFeePayment where ScholarNo=@find";


                cmd = new SqlCommand(cz2);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "ScholarNo"));


                cmd.Parameters["@find"].Value = ScholarNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Autocomplete();
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string cz3 = "select ScholarNo from BusHolders where ScholarNo=@find";


                cmd = new SqlCommand(cz3);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "ScholarNo"));


                cmd.Parameters["@find"].Value = ScholarNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Autocomplete();
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string cz4 = "select ScholarNo from BusFeePayment where ScholarNo=@find";


                cmd = new SqlCommand(cz4);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "ScholarNo"));


                cmd.Parameters["@find"].Value = ScholarNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Autocomplete();
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from student where ScholarNo=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 15, "ScholarNo"));


                cmd.Parameters["@DELETE1"].Value = ScholarNo.Text;
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    Autocomplete();
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    Autocomplete();
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

        private void Delete_Click(object sender, EventArgs e)
        {
            delete();
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
                    Course.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void ScholarNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            
            if (label11.Text == "Admin")
            {

                btnPrint.Enabled = true;
                btnDelete.Enabled = true;
               
                btnUpdate_record.Enabled = true;
                deleteToolStripMenuItem1.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
                printToolStripMenuItem.Enabled = true;
              
            }
            else
            {
                btnPrint.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate_record.Enabled = false;
             
                deleteToolStripMenuItem1.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
                printToolStripMenuItem.Enabled = true;
              
            }
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT ScholarNo,Student_name,Admission_No,DateOfAdmission,Enrollment_no,Fathers_Name,Gender,DOB,Address,Session,Contact_No,Email,Course,Branch,Submitted_Documents,Nationality,GuardianName,GuardianContactNo,GuardianAddress,High_School_name,HS_Year_of_passing,HS_Percentage,HS_Board,Higher_secondary_Name,H_year_of_passing,H_percentage,H_board,Graduation,G_year_of_passing,G_percentage,G_University,Post_graduation,PG_year_of_passing,PG_percentage,PG_university,mother_name,religion,category,Section,photo FROM Student WHERE ScholarNo = '" + ScholarNo.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    StudentName.Text = (String)rdr["Student_name"];
                    AdmissionNo.Text = (String)rdr["Admission_no"];
                    DateOfAdmission.Text = (String)rdr["DateOfAdmission"];
                    EnrollmentNo.Text = (String)rdr["Enrollment_no"];
                    FatherName.Text = (String)rdr["Fathers_name"];
                    Gender.Text = (String)rdr["Gender"];
                    DOB.Text = (String)rdr["DOB"];
                    Address.Text = (String)rdr["Address"];
                    Session.Text = (String)rdr["Session"];
                    ContactNo.Text = (String)rdr["Contact_no"];
                    Email.Text = (String)rdr["Email"];

                    Course.Text = (String)rdr["Course"];

                    Branch.Text = (String)rdr["Branch"];
                    Branch.Enabled = false;
                    
                    Section.Enabled = false;

                    DocumentSubmitted.Text = (String)rdr["Submitted_documents"];
                    Nationality.Text = (String)rdr["Nationality"];
                    GuardianName.Text = (String)rdr["GuardianName"];
                    GuardianContactNo.Text = (String)rdr["GuardianContactNo"];
                    GuardianAddress.Text = (String)rdr["GuardianAddress"];
                    HS.Text = (String)rdr["High_school_name"];

                    HSYOP.Text = (String)rdr["HS_year_of_passing"];
                    HSPercentage.Text = (String)rdr["HS_percentage"];
                    HSBoard.Text = (String)rdr["HS_board"];
                    HSS.Text = (String)rdr["Higher_secondary_name"];
                    HSSYOP.Text = (String)rdr["H_year_of_passing"];
                    HSSPercentage.Text = (String)rdr["H_percentage"];
                    HSSBoard.Text = (String)rdr["H_board"];
                    UG.Text = (String)rdr["Graduation"];
                    GYOP.Text = (String)rdr["G_year_of_passing"];
                    GPercentage.Text = (String)rdr["G_percentage"];
                    GUniy.Text = (String)rdr["G_university"];
                    PG.Text = (String)rdr["Post_Graduation"];
                    PGYOP.Text = (String)rdr["PG_year_of_passing"];
                    PGpercentage.Text = (String)rdr["PG_Percentage"];
                    PGUniy.Text = (String)rdr["PG_university"];
                    MotherName.Text = (String)rdr["Mother_name"];
                    Religion.Text = (String)rdr["GuardianAddress"];
                    Category.Text = (String)rdr["Category"];
                    Section.Text = (String)rdr["Section"];
              
                    Religion.Text = (String)rdr["Religion"];
                    MemoryStream stream = new MemoryStream();


                    byte[] image = (byte[])rdr["Photo"];
                    stream.Write(image, 0, image.Length);

                    Bitmap bitmap = new Bitmap(stream);
                    Picture.Image = bitmap;
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

        private void Browse_Click(object sender, EventArgs e)
        {

            var _with1 = openFileDialog1;

            _with1.Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif; *.ico");
            _with1.FilterIndex = 4;

            //Reset the file name
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.SelectedIndex = -1;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                for (int i = 0; i < this.listBox1.Items.Count; i++)
                {
                    this.listBox1.SelectedIndex = i;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {

                foreach (object lstbxitem in this.listBox1.SelectedItems)
                {
                    
                    DocumentSubmitted.Text += lstbxitem +"";

                }
                listBox1.Visible = false;
                ContactNo.Focus();
            }
        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course.Text = Course.Text.Trim();
            Branch.Items.Clear();
            Branch.Text = "";
            Branch.Enabled = true;
            Branch.Focus();

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(branchname) from course where coursename = '" + Course.Text + "'";

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

        private void ScholarNo_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = this.ScholarNo.SelectionStart;

            this.ScholarNo.Text = this.ScholarNo.Text.ToUpper();
            this.ScholarNo.SelectionStart = selectionStart;
        }

        private void Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu form2 = new frmMainMenu();
            form2.UserType.Text = label11.Text;
            form2.User.Text = label30.Text;
            form2.Show();
           
        }
      

        public void timer2_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer2.Enabled = false;
        }

     

        private void frmStudent_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        private void Save()
        {
            if (ScholarNo.Text == "")
            {
                MessageBox.Show("Please enter Scholar No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScholarNo.Focus();
                return;
            }
            if (AdmissionNo.Text == "")
            {
                MessageBox.Show("Please enter Admission No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AdmissionNo.Focus();
                return;
            }

          
            if (Gender.Text == "")
            {
                MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Gender.Focus();
                return;
            }
            if (Category.Text == "")
            {
                MessageBox.Show("Please select Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Category.Focus();
                return;
            }
            if (FatherName.Text == "")
            {
                MessageBox.Show("Please enter father's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FatherName.Focus();
                return;
            }
            if (Session.Text == "")
            {
                MessageBox.Show("Please enter session", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Session.Focus();
                return;
            }
            if (DOB.Text == "")
            {
                MessageBox.Show("Please enter dob", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DOB.Focus();
                return;
            }

            if (MotherName.Text == "")
            {
                MessageBox.Show("Please enter mother's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MotherName.Focus();
                return;
            }

            if (Religion.Text == "")
            {
                MessageBox.Show("Please select religion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Religion.Focus();
                return;
            }
            if (Address.Text == "")
            {
                MessageBox.Show("Please select address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Address.Focus();
                return;
            }
            if (Address.Text == "")
            {
                MessageBox.Show("Please enter address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Address.Focus();
                return;
            }
            if (ContactNo.Text == "")
            {
                MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContactNo.Focus();
                return;
            }
            if (Email.Text == "")
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Email.Focus();
                return;
            }
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
          
            if (Section.Text == "")
            {
                MessageBox.Show("Please select section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Section.Focus();
                return;
            }
            if (DocumentSubmitted.Text == "")
            {
                MessageBox.Show("Please enter submitted documents", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DocumentSubmitted.Focus();
                return;
            }
            if (Nationality.Text == "")
            {
                MessageBox.Show("Please enter nationality", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Nationality.Focus();
                return;
            }
           
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select scholarno from student where ScholarNo=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "ScholarNo"));
                cmd.Parameters["@find"].Value = ScholarNo.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Scholar No. Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ScholarNo.Text = "";



                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct1 = "select Admission_No from student where Admission_No=@find";

                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Admission_No"));
                cmd.Parameters["@find"].Value = AdmissionNo.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Admission no. already exists" + "\nstudent profile is already saved" + "\nfor this admission no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();



                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into student(ScholarNo,Student_name,Admission_No,DateOfAdmission,Enrollment_no,Fathers_Name,Gender,DOB,Address,Session,Contact_No,Email,Course,Branch,Submitted_Documents,Nationality,GuardianName,GuardianContactNo,GuardianAddress,High_School_name,HS_Year_of_passing,HS_Percentage,HS_Board,Higher_secondary_Name,H_year_of_passing,H_percentage,H_board,Graduation,G_year_of_passing,G_percentage,G_University,Post_graduation,PG_year_of_passing,PG_percentage,PG_university,mother_name,religion,category,Section,photo) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22,@d23,@d24,@d25,@d26,@d27,@d28,@d29,@d30,@d31,@d32,@d33,@d34,@d35,@d36,@d37,@d38,@d39,@d40)";


                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                if (UG.SelectedIndex == -1)
                {
                    UG.Text = "";
                }
                if (PG.SelectedIndex == -1)
                {
                    PG.Text = "";
                }

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "ScholarNo"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Student_name"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 15, "Admission_No"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 30, "DateOfAdmission"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 15, "Enrollment_no"));

                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 30, "Fathers_Name"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.NChar, 10, "Gender"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 15, "DOB"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 50, "Address"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 10, "Session"));

                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 10, "Contact_No"));

                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.NChar, 30, "Email"));

                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.NChar, 30, "Course"));

                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.NChar, 30, "Branch"));

                cmd.Parameters.Add(new SqlParameter("@d15", System.Data.SqlDbType.VarChar, 250, "Submitted_Documents"));

                cmd.Parameters.Add(new SqlParameter("@d16", System.Data.SqlDbType.NChar, 20, "Nationality"));
                cmd.Parameters.Add(new SqlParameter("@d17", System.Data.SqlDbType.NChar, 30, "GuardianName"));
                cmd.Parameters.Add(new SqlParameter("@d18", System.Data.SqlDbType.NChar, 10, "GuardianContactNo"));
                cmd.Parameters.Add(new SqlParameter("@d19", System.Data.SqlDbType.NChar, 50, "GuardianAddress"));
                cmd.Parameters.Add(new SqlParameter("@d20", System.Data.SqlDbType.NChar, 30, "High_School_name"));
                cmd.Parameters.Add(new SqlParameter("@d21", System.Data.SqlDbType.NChar, 10, "HS_Year_of_passing"));
                cmd.Parameters.Add(new SqlParameter("@d22", System.Data.SqlDbType.NChar, 10, "HS_Percentage"));
                cmd.Parameters.Add(new SqlParameter("@d23", System.Data.SqlDbType.NChar, 30, "HS_Board"));
                cmd.Parameters.Add(new SqlParameter("@d24", System.Data.SqlDbType.NChar, 30, "Higher_secondary_Name"));
                cmd.Parameters.Add(new SqlParameter("@d25", System.Data.SqlDbType.NChar, 10, "H_year_of_passing"));
                cmd.Parameters.Add(new SqlParameter("@d26", System.Data.SqlDbType.NChar, 10, "H_percentage"));
                cmd.Parameters.Add(new SqlParameter("@d27", System.Data.SqlDbType.NChar, 30, "H_board"));
                cmd.Parameters.Add(new SqlParameter("@d28", System.Data.SqlDbType.NChar, 30, "Graduation"));
                cmd.Parameters.Add(new SqlParameter("@d29", System.Data.SqlDbType.NChar, 10, "G_year_of_passing"));
                cmd.Parameters.Add(new SqlParameter("@d30", System.Data.SqlDbType.NChar, 10, "G_percentage"));
                cmd.Parameters.Add(new SqlParameter("@d31", System.Data.SqlDbType.NChar, 30, "G_University"));
                cmd.Parameters.Add(new SqlParameter("@d32", System.Data.SqlDbType.NChar, 30, "Post_graduation"));
                cmd.Parameters.Add(new SqlParameter("@d33", System.Data.SqlDbType.NChar, 10, "PG_year_of_passing"));
                cmd.Parameters.Add(new SqlParameter("@d34", System.Data.SqlDbType.NChar, 10, "PG_percentage"));
                cmd.Parameters.Add(new SqlParameter("@d35", System.Data.SqlDbType.NChar, 30, "PG_university"));
                cmd.Parameters.Add(new SqlParameter("@d36", System.Data.SqlDbType.NChar, 30, "mother_name"));
                cmd.Parameters.Add(new SqlParameter("@d37", System.Data.SqlDbType.NChar, 30, "religion"));
                cmd.Parameters.Add(new SqlParameter("@d38", System.Data.SqlDbType.NChar, 15, "category"));
                cmd.Parameters.Add(new SqlParameter("@d39", System.Data.SqlDbType.NChar, 10, "Section"));
            
                cmd.Parameters["@d1"].Value = ScholarNo.Text.Trim();
                cmd.Parameters["@d2"].Value = StudentName.Text.Trim();
                cmd.Parameters["@d3"].Value = AdmissionNo.Text.Trim();
                cmd.Parameters["@d4"].Value = DateOfAdmission.Text.Trim();
                cmd.Parameters["@d5"].Value = EnrollmentNo.Text.Trim();
                cmd.Parameters["@d6"].Value = FatherName.Text.Trim();
                cmd.Parameters["@d7"].Value = Gender.Text.Trim();
                cmd.Parameters["@d8"].Value = DOB.Text.Trim();
                cmd.Parameters["@d9"].Value = Address.Text.Trim();
                cmd.Parameters["@d10"].Value = Session.Text.Trim();
                cmd.Parameters["@d11"].Value = ContactNo.Text.Trim();
                cmd.Parameters["@d12"].Value = Email.Text.Trim();
                cmd.Parameters["@d13"].Value = Course.Text.Trim();
                cmd.Parameters["@d14"].Value = Branch.Text.Trim();
                cmd.Parameters["@d15"].Value = DocumentSubmitted.Text.Trim();
                cmd.Parameters["@d16"].Value = Nationality.Text.Trim();
                cmd.Parameters["@d17"].Value = GuardianName.Text.Trim();
                cmd.Parameters["@d18"].Value = GuardianContactNo.Text.Trim();
                cmd.Parameters["@d19"].Value = GuardianAddress.Text.Trim();
                cmd.Parameters["@d20"].Value = HS.Text.Trim();
                cmd.Parameters["@d21"].Value = HSYOP.Text.Trim();
                cmd.Parameters["@d22"].Value = HSPercentage.Text.Trim();
                cmd.Parameters["@d23"].Value = HSBoard.Text.Trim();
                cmd.Parameters["@d24"].Value = HSS.Text.Trim();
                cmd.Parameters["@d25"].Value = HSSYOP.Text.Trim();
                cmd.Parameters["@d26"].Value = HSSPercentage.Text.Trim();
                cmd.Parameters["@d27"].Value = HSSBoard.Text.Trim();
                cmd.Parameters["@d28"].Value = UG.Text.Trim();
                cmd.Parameters["@d29"].Value = GYOP.Text.Trim();
                cmd.Parameters["@d30"].Value = GPercentage.Text.Trim();
                cmd.Parameters["@d31"].Value = GUniy.Text.Trim();
                cmd.Parameters["@d32"].Value = PG.Text.Trim();
                cmd.Parameters["@d33"].Value = PGYOP.Text.Trim();
                cmd.Parameters["@d34"].Value = PGpercentage.Text.Trim();
                cmd.Parameters["@d35"].Value = PGUniy.Text.Trim();
                cmd.Parameters["@d36"].Value = MotherName.Text.Trim();
                cmd.Parameters["@d37"].Value = Religion.Text.Trim();
                cmd.Parameters["@d38"].Value = Category.Text.Trim();
                cmd.Parameters["@d39"].Value = Section.Text.Trim();
                
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(Picture.Image);

                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d40", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPrint.Enabled = true;
                printToolStripMenuItem.Enabled = true;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void delete()
        {

            if (ScholarNo.Text == "")
            {
                MessageBox.Show("Please select Scholar No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ScholarNo.Focus();
                return;
            }
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();


            }

        }
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
            btnPrint.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            deleteToolStripMenuItem1.Enabled = false;
            updateToolStripMenuItem.Enabled = false;
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            delete();   
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update();
        }

      

        private void Email_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (Email.Text.Length > 0)
            {
                if (!rEMail.IsMatch(Email.Text))
                {
                    MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void StudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void FatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void MotherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void GuardianName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void HSBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void HSSBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void GUniy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void PGUniy_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back||e.KeyChar==(char)Keys.Space);
        }

        private void PrintRecord()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer2.Enabled = true;
                frmStudentReport frm = new frmStudentReport();

                rptStudent rpt = new rptStudent();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                CMS_DBDataSet1 myDS = new CMS_DBDataSet1();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from student where scholarNo= '" + ScholarNo.Text + "'";

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "Student");
                rpt.SetDataSource(myDS);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintRecord();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset();
            frmStudentRegistrationRecord1 frm = new frmStudentRegistrationRecord1();
            frm.textBox1.Text = "";
            frm.dataGridView1.DataSource = null;
            frm.dataGridView2.DataSource = null;
            frm.dataGridView3.DataSource = null;
            frm.Course.Text = "";
            frm.Branch.Text = "";
            frm.Session.Text = "";
            frm.DateFrom.Text = DateTime.Today.ToString();
            frm.DateTo.Text = DateTime.Today.ToString();
            frm.StudentName.Text = "";
            frm.Branch.Enabled = false;
            frm.Session.Enabled = false;
            frm.label5.Text = label11.Text;
            frm.label8.Text = label30.Text;
            frm.Show();
        }

        private void HSPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void HSSPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void GPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void PGpercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void Branch_SelectedIndexChanged(object sender, EventArgs e)
        {

            Section.Items.Clear();
            Section.Text = "";
            Section.Enabled = true;
            Section.Focus();

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(SectionName) from Section where course = '" + Course.Text + "' and Branch = '" + Branch.Text + "' order by 1 ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Section.Items.Add(rdr[0]);
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
            Section.Items.Clear();
            Section.Text = "";
            Section.Enabled = true;
            Section.Focus();

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(SectionName) from Section where course = '" + Course.Text + "' and Branch = '" + Branch.Text + "' order by 1 ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Section.Items.Add(rdr[0]);
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
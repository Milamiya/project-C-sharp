using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace College_Management_System
{
   
    public partial class frmStudentRegistration : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
      
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

      
        public frmStudentRegistration()
        {
            InitializeComponent();
        }
        public void Reset()
        {
    
            AdmissionNo.Text = "";
            StudentName.Text = "";
          
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
            listBox1.Visible = false;
            Branch.Enabled = false;
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            btnSave.Enabled = true;
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars =
            "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        private void auto()
        {
            AdmissionNo.Text = "A-" + GetUniqueKey(10);
        }
        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            AutocompleCourse();
            StudentName.Focus();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
           
         
           
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
            auto();

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select Admission_No from studentRegistration where Admission_No=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "AdmissionNo"));
                cmd.Parameters["@find"].Value = AdmissionNo.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Admission No. Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdmissionNo.Text = "";



                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into studentRegistration(Student_name,Admission_No,DateOfAdmission,Fathers_Name,Gender,DOB,Address,Session,Contact_No,Email,Course,Branch,Submitted_Documents,Nationality,GuardianName,GuardianContactNo,GuardianAddress,High_School_name,HS_Year_of_passing,HS_Percentage,HS_Board,Higher_secondary_Name,H_year_of_passing,H_percentage,H_board,Graduation,G_year_of_passing,G_percentage,G_University,Post_graduation,PG_year_of_passing,PG_percentage,PG_university,mother_name,religion,category) VALUES (@d2,@d3,@d4,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22,@d23,@d24,@d25,@d26,@d27,@d28,@d29,@d30,@d31,@d32,@d33,@d34,@d35,@d36,@d37,@d38)";

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


                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Student_name"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 15, "Admission_No"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 30, "DateOfAdmission"));

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
         
                cmd.Parameters["@d2"].Value = StudentName.Text.Trim();
                cmd.Parameters["@d3"].Value = AdmissionNo.Text.Trim();
                cmd.Parameters["@d4"].Value = DateOfAdmission.Text.Trim();
               
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
             
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Resistered", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
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

                string cb = "update student set Student_name=@d2,DateOfAdmission=@d4,Fathers_Name=@d6,Gender=@d7,DOB=@d8,Address=@d9,Session=@d10,Contact_No=@d11,Email=@d12,Course=@d13,Branch=@d14,Submitted_Documents=@d15,Nationality=@d16,GuardianName=@d17,GuardianContactNo=@d18,GuardianAddress=@d19,High_School_name=@d20,HS_Year_of_passing=@d21,HS_Percentage=@d22,HS_Board=@d23,Higher_secondary_Name=@d24,H_year_of_passing=@d25,H_percentage=@d26,H_board=@d27,Graduation=@d28,G_year_of_passing=@d29,G_percentage=@d30,G_University=@d31,Post_graduation=@d32,PG_year_of_passing=@d33,PG_percentage=@d34,PG_university=@d35,mother_name=@d36,Religion=@d37,Category=@d38 where Admission_No=@d3";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

             

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Student_name"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 15, "Admission_No"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 30, "DateOfAdmission"));

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

          
                cmd.Parameters["@d2"].Value = StudentName.Text.Trim();
                cmd.Parameters["@d3"].Value = AdmissionNo.Text.Trim();
                cmd.Parameters["@d4"].Value = DateOfAdmission.Text.Trim();
              
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
             
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;
             
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
            Reset();
            frmStudentRegistrationRecord2 frm = new frmStudentRegistrationRecord2();
            frm.textBox1.Text = "";
            frm.dataGridView1.DataSource = null;
            frm.dataGridView2.DataSource = null;
            frm.dataGridView3.DataSource = null;
            frm.Course.Text = "";
            frm.Branch.Text = "";
            frm.Session.Text = "";
            frm.DateFrom.Text = DateTime.Today.ToString();
            frm.DateTo.Text = DateTime.Today.ToString();
            StudentName.Text = "";
            Branch.Enabled = false;
            Session.Enabled = false;
            frm.label5.Text = label1.Text;
            frm.label8.Text = label8.Text;
            frm.Show();
        }

        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                 
                    DocumentSubmitted.Text += lstbxitem;

                }
                listBox1.Visible = false;
                ContactNo.Focus();
            }
        }

        private void frmStudentRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.UserType.Text = label1.Text;
            frm.User.Text = label8.Text;
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
                string ct = "select Admission_No from Student where Admission_No=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "Admission_No"));


                cmd.Parameters["@find"].Value = AdmissionNo.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                
                    Reset();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
               
                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from StudentRegistration where Admission_No=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 15, "Admission_No"));


                cmd.Parameters["@DELETE1"].Value = AdmissionNo.Text;
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                  
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    
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


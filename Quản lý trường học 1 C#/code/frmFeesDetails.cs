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
    public partial class frmFeesDetails : Form
    {

        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        ConnectionString cs = new ConnectionString();
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       

        public frmFeesDetails()
        {
            InitializeComponent();
        }

        private void AutocompleCourse()
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
        private void auto()
        {
            FeeID.Text = "F-" + GetUniqueKey(5);
        }


        private void FeesDetails_Load(object sender, EventArgs e)
        {
            AutocompleCourse();
         

        }

        private void btnSave_Click(object sender, EventArgs e)
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
            if (Semester.Text == "")
            {
                MessageBox.Show("Please select semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Semester.Focus();
                return;
            }
            if (TutionFees.Text == "")
            {
                MessageBox.Show("Please enter tution fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TutionFees.Focus();
                return;
            }
            if (UDFees.Text == "")
            {
                MessageBox.Show("Please enter university development fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UDFees.Focus();
                return;
            }
            if (LibraryFees.Text == "")
            {
                MessageBox.Show("Please enter library fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LibraryFees.Focus();
                return;
            }
            if (USFees.Text == "")
            {
                MessageBox.Show("Please enter university student welfare fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                USFees.Focus();
                return;
            }
            if (OtherFees.Text == "")
            {
                MessageBox.Show("Please enter other fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OtherFees.Focus();
                return;
            }
            if (Semester.Text == "1st")
            {
                if (CautionMoney.Text == "")
                {
                    MessageBox.Show("Please enter caution money", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CautionMoney.Focus();
                    return;
                }
            }
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string ct = "select Semester,Course,Branch from FeesDetails where Semester= '" + Semester.Text + "' and Course = '" + Course.Text + "' and branch= '" + Branch.Text + "'";

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

            if (Semester.Text == "1st")
            {
                TotalFees.Text = (int.Parse(TutionFees.Text) + int.Parse(LibraryFees.Text) + int.Parse(UDFees.Text) + int.Parse(USFees.Text) + int.Parse(OtherFees.Text) + int.Parse(CautionMoney.Text)).ToString();

            }
            else
            {
                TotalFees.Text = (int.Parse(TutionFees.Text) + int.Parse(LibraryFees.Text) + int.Parse(UDFees.Text) + int.Parse(USFees.Text) + int.Parse(OtherFees.Text)).ToString();

            }
          
                auto();
          
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct1 = "select feeid from feesdetails where feeid=@find";

                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "feeid"));
                cmd.Parameters["@find"].Value = FeeID.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Fee ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FeeID.Text = "";



                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into feesdetails(FeeID,Course,Branch,Semester,TutionFees,LibraryFees,UniversityDevelopmentFees,UniversityStudentWelfareFees,CautionMoney,OtherFees,TotalFees) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;


                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "FeeId"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 20, "Course"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "Branch"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "Semester"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 10, "TutionFees"));

                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 10, "LibraryFees"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.NChar, 10, "UniversityDevelopmentFees"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 15, "UniversityStudentWelfareFees"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 10, "CautionMoney"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 10, "OtherFees"));
                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 10, "TotalFees"));

                cmd.Parameters["@d1"].Value = FeeID.Text.Trim();
                cmd.Parameters["@d2"].Value = Course.Text.Trim();
                cmd.Parameters["@d3"].Value = Branch.Text.Trim();
                cmd.Parameters["@d4"].Value = Semester.Text.Trim();
                cmd.Parameters["@d5"].Value = (TutionFees.Text);
                cmd.Parameters["@d6"].Value = (LibraryFees.Text);
                cmd.Parameters["@d7"].Value = (UDFees.Text);
                cmd.Parameters["@d8"].Value = (USFees.Text);
                if (Semester.Text == "1st")
                {
                    cmd.Parameters["@d9"].Value = (CautionMoney.Text);
                }
                else
                {
                    cmd.Parameters["@d9"].Value = 0;
                }
                cmd.Parameters["@d10"].Value = (OtherFees.Text);
                cmd.Parameters["@d11"].Value =(TotalFees.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Fees Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     



        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Branch.Items.Clear();
            Semester.Items.Clear();
            Branch.Text = "";
            Semester.Text = "";
            Branch.Enabled = true;
            Semester.Enabled = true;
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
            
                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct1 = "select distinct RTRIM(SemesterName) from Semester where course = '" + Course.Text + "' order by 1";

                cmd = new SqlCommand(ct1);
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

        private void TutionFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void UDFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void LibraryFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void USFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void OtherFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CautionMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Semester.Text == "1st")
            {
                label11.Visible = true;
                CautionMoney.Visible = true;
            }
            else
            {
                label11.Visible = false;
                CautionMoney.Visible = false;
            }


        }

        private void FeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            Delete.Enabled = true;
            Update_record.Enabled = true;

            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM feesdetails WHERE FeeID = '" + FeeID.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    Course.Text = ((String)rdr["Course"]);

                    Branch.Text = ((String)rdr["Branch"]).Trim();
                    Semester.Text = (rdr.GetString(3).Trim());
                    if (Semester.Text == "1st")
                    {
                        label11.Visible = true;
                        CautionMoney.Visible = true;
                    }
                    else
                    {
                        label11.Visible = false;
                        CautionMoney.Visible = false;
                    }
                    TutionFees.Text = (rdr.GetString(4).Trim());
                    LibraryFees.Text = (rdr.GetString(5).Trim());
                    UDFees.Text = (rdr.GetString(6).Trim());
                    USFees.Text = (rdr.GetString(7).Trim());
                    CautionMoney.Text = (rdr.GetString(8).Trim());
                    OtherFees.Text = (rdr.GetString(9).Trim());
                    TotalFees.Text = (rdr.GetString(10).Trim());



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

        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        
          
            
        }
        private void Reset()
        {
            FeeID.Text = "";
            Course.Text = "";
            Branch.Text = "";
            Semester.Text = "";
            TutionFees.Text = "";
            LibraryFees.Text = "";
            UDFees.Text = "";
            USFees.Text = "";
            CautionMoney.Text = "";
            OtherFees.Text = "";
            TotalFees.Text = "";
            Branch.Enabled = false;
            Semester.Enabled = false;
            Delete.Enabled = false;
            Update_record.Enabled = false;
            btnSave.Enabled = true;
            Course.Focus();
        }

        private void Update_record_Click(object sender, EventArgs e)
        {
            try
            {
                if (FeeID.Text == "")
                {
                    MessageBox.Show("Please select Fee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Course.Focus();
                    return;
                }
               
                if (Semester.Text == "1st")
                {
                    TotalFees.Text = (int.Parse(TutionFees.Text) + int.Parse(LibraryFees.Text) + int.Parse(UDFees.Text) + int.Parse(USFees.Text) + int.Parse(OtherFees.Text) + int.Parse(CautionMoney.Text)).ToString();

                }
                else
                {
                    TotalFees.Text = (int.Parse(TutionFees.Text) + int.Parse(LibraryFees.Text) + int.Parse(UDFees.Text) + int.Parse(USFees.Text) + int.Parse(OtherFees.Text)).ToString();

                }
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update feesdetails set Course=@d2,Branch=@d3,Semester=@d4,TutionFees=@d5,LibraryFees=@d6,UniversityDevelopmentFees=@d7,UniversityStudentWelfareFees=@d8,CautionMoney=@d9,OtherFees=@d10,TotalFees=@d11 where FeeID=@d1";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;


                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "FeeId"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 20, "Course"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "Branch"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "Semester"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 10, "TutionFees"));

                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 10, "LibraryFees"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.NChar, 10, "UniversityDevelopmentFees"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 15, "UniversityStudentWelfareFees"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 10, "CautionMoney"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 10, "OtherFees"));
                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 10, "TotalFees"));

                cmd.Parameters["@d1"].Value = FeeID.Text.Trim();
                cmd.Parameters["@d2"].Value = Course.Text.Trim();
                cmd.Parameters["@d3"].Value = Branch.Text.Trim();
                cmd.Parameters["@d4"].Value = Semester.Text.Trim();
                cmd.Parameters["@d5"].Value = (TutionFees.Text);
                cmd.Parameters["@d6"].Value = (LibraryFees.Text);
                cmd.Parameters["@d7"].Value = (UDFees.Text);
                cmd.Parameters["@d8"].Value = (USFees.Text);
                if (Semester.Text == "1st")
                {
                    cmd.Parameters["@d9"].Value = (CautionMoney.Text);
                }
                else
                {
                    cmd.Parameters["@d9"].Value = 0;
                }
                cmd.Parameters["@d10"].Value = (OtherFees.Text);
                cmd.Parameters["@d11"].Value = (TotalFees.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Fees Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Update_record.Enabled = false;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                string ct = "select FeeID from FeePayment where FeeID=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "FeeID"));


                cmd.Parameters["@find"].Value = FeeID.Text;


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


                string cq = "delete from FeesDetails where FeeID=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 20, "FeeID"));


                cmd.Parameters["@DELETE1"].Value = FeeID.Text;
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

        private void GetDetails_Click(object sender, EventArgs e)
        {
            frmFeesDetailsRecord frm = new frmFeesDetailsRecord();
            this.Hide();
            Reset();
            frm.label1.Text = label13.Text;
            frm.Show();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            frmFeesDetailsRecord frm = new frmFeesDetailsRecord();
            this.Hide();
            Reset();
            frm.label1.Text = label13.Text;
            frm.Show();
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

      
       
   
    }
      
    }


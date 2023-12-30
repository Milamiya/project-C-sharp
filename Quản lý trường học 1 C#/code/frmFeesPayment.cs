using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Security.Cryptography;
namespace College_Management_System
{
    public partial class frmFeesPayment : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        ConnectionString cs = new ConnectionString();

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       

        public frmFeesPayment()
        {
            InitializeComponent();
        }

        private void FeesPayment_Load(object sender, EventArgs e)
        {
          
            label21.Width = this.Width;
            AutocompleFeeID();
            AutocompleScholarNo();
            dataGridView1.DataSource = GetData();
           
        }
        private void AutocompleFeeID()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(FeeID) from FeesDetails ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    FeeID.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void delete_records()
        {

            try
            {


                int RowsAffected = 0;

                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from FeePayment where FeePaymentID=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 20, "FeepaymentID"));


                cmd.Parameters["@DELETE1"].Value = FeePaymentID.Text;
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


        private void AutocompleScholarNo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(ScholarNo) from student ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ScholarNo.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
             try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM feesdetails WHERE FeeID = '" + FeeID.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {



                    FDCourse.Text = rdr.GetString(1).Trim();

                    FDBranch.Text = rdr.GetString(2).Trim();
                    Semester.Text = rdr.GetString(3).Trim();
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
                    TutionFees.Text = rdr.GetString(4).Trim();
                    LibraryFees.Text = rdr.GetString(5).Trim();
                    UDFees.Text = rdr.GetString(6).Trim();
                    USFees.Text = rdr.GetString(7).Trim();
                    CautionMoney.Text = rdr.GetString(8).Trim();
                    OtherFees.Text = rdr.GetString(9).Trim();
                    TotalFees.Text = rdr.GetString(10).Trim();
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

       

        private void ScholarNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT Student_Name,Course,Branch FROM student WHERE ScholarNo = '" + ScholarNo.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    StudentName.Text = rdr.GetString(0).Trim();


                    Course.Text = rdr.GetString(1).Trim();

                    Branch.Text = rdr.GetString(2).Trim();
                 
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
            FeePaymentID.Text = "";
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
            FDBranch.Text = "";
            FDCourse.Text="";
            ScholarNo.Text = "";
            StudentName.Text = "";
            ModeOfPayment.Text = "";
            PaymentModeDetails.Text = "";
            TotalPaid.Text = "";
            Fine.Text = "";
            DueFees.Text = "";
            PaymentDate.Text = DateTime.Today.ToString();
            Delete.Enabled = false;
            Update_record.Enabled = false;
            btnSave.Enabled = true;
            Print.Enabled = false;
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
            FeePaymentID.Text = "F-" + GetUniqueKey(8);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (ScholarNo.Text == "")
                {
                    MessageBox.Show("Please select Scholar No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ScholarNo.Focus();
                    return;
                }
                if (FeeID.Text == "")
                {
                    MessageBox.Show("Please select Fee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FeeID.Focus();
                    return;
                }
               
                if (ModeOfPayment.Text == "")
                {
                    MessageBox.Show("Please select mode of payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ModeOfPayment.Focus();
                    return;
                }
                if (TotalPaid.Text == "")
                {
                    MessageBox.Show("Please enter total paid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TotalPaid.Focus();
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select FeeID,ScholarNo from FeePayment where FeeID= '" + FeeID.Text + "' and ScholarNo= '" + ScholarNo.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Student already paid fees for this semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
               
                auto();
               

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into feepayment(FeePaymentID,ScholarNo,FeeID,FDCourse,FDBranch,Semester,TutionFees,LibraryFees,UniversityDevelopmentFees,UniversityStudentWelfareFees,CautionMoney,OtherFees,TotalFees,DateOfPayment,ModeOfPayment,PaymentModeDetails,TotalPaid,Fine,DueFees) VALUES (@d1,@d2,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "FeePaymentID"));
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 15, "ScholarNo"));
                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 20, "FeeId"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.NChar, 20, "FDCourse"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 30, "FDBranch"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 10, "Semester"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.Int, 10, "TutionFees"));

                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.Int, 10, "LibraryFees"));

                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.Int, 10, "UniversityDevelopmentFees"));

                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.Int, 15, "UniversityStudentWelfareFees"));

                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.Int, 10, "CautionMoney"));

                cmd.Parameters.Add(new SqlParameter("@d15", System.Data.SqlDbType.Int, 10, "OtherFees"));
                cmd.Parameters.Add(new SqlParameter("@d16", System.Data.SqlDbType.Int, 10, "TotalFees"));
                cmd.Parameters.Add(new SqlParameter("@d17", System.Data.SqlDbType.NChar, 30, "DateOfPayment"));

                cmd.Parameters.Add(new SqlParameter("@d18", System.Data.SqlDbType.NChar, 20, "ModeOfPayment"));
                cmd.Parameters.Add(new SqlParameter("@d19", System.Data.SqlDbType.VarChar, 200, "PaymentModeDetails"));
                cmd.Parameters.Add(new SqlParameter("@d20", System.Data.SqlDbType.Int, 10, "TotalPaid"));

                cmd.Parameters.Add(new SqlParameter("@d21", System.Data.SqlDbType.Int, 10, "Fine"));
                cmd.Parameters.Add(new SqlParameter("@d22", System.Data.SqlDbType.Int, 10, "DueFees"));
                cmd.Parameters["@d1"].Value = FeePaymentID.Text.Trim();
                cmd.Parameters["@d2"].Value = ScholarNo.Text.Trim();
                cmd.Parameters["@d6"].Value = FeeID.Text.Trim();
                cmd.Parameters["@d7"].Value = FDCourse.Text.Trim();
                cmd.Parameters["@d8"].Value = FDBranch.Text.Trim();
                cmd.Parameters["@d9"].Value = Semester.Text.Trim();
                cmd.Parameters["@d10"].Value = Convert.ToInt32(TutionFees.Text);
                cmd.Parameters["@d11"].Value = Convert.ToInt32(LibraryFees.Text);
                cmd.Parameters["@d12"].Value = Convert.ToInt32(UDFees.Text);
                cmd.Parameters["@d13"].Value = Convert.ToInt32(USFees.Text);
                if (Semester.Text == "1st")
                {
                    cmd.Parameters["@d14"].Value = Convert.ToInt32(CautionMoney.Text);
                }
                else
                {
                    cmd.Parameters["@d14"].Value = 0;
                }
                cmd.Parameters["@d15"].Value = Convert.ToInt32(OtherFees.Text);
                cmd.Parameters["@d16"].Value = Convert.ToInt32(TotalFees.Text);
                cmd.Parameters["@d17"].Value = (PaymentDate.Text);
                cmd.Parameters["@d18"].Value = (ModeOfPayment.Text);
                cmd.Parameters["@d19"].Value = (PaymentModeDetails.Text);
                cmd.Parameters["@d20"].Value = Convert.ToInt32(TotalPaid.Text);
                if (Fine.Text == "")
                {
                    cmd.Parameters["@d21"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d21"].Value = Convert.ToInt32(Fine.Text);
                }
              
                cmd.Parameters["@d22"].Value = Convert.ToInt32(DueFees.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Fees Payment Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                Print.Enabled = true;
              
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

        private void Update_record_Click(object sender, EventArgs e)
        {
           try
           {
            con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb = "update feepayment set ScholarNo=@d2,FeeID=@d6,FDCourse=@d7,FDBranch=@d8,Semester=@d9,TutionFees=@d10,LibraryFees=@d11,UniversityDevelopmentFees=@d12,UniversityStudentWelfareFees=@d13,CautionMoney=@d14,OtherFees=@d15,TotalFees=@d16,DateOfPayment=@d17,ModeOfPayment=@d18,PaymentModeDetails=@d19,TotalPaid=@d20,Fine=@d21,DueFees=@d22 where FeePaymentID=@d1";
            cmd = new SqlCommand(cb);

                    cmd.Connection = con;
                    cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "FeePaymentID"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 15, "ScholarNo"));

                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 20, "FeeId"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.NChar, 20, "FDCourse"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 30, "FDBranch"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 10, "Semester"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.Int, 10, "TutionFees"));

                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.Int, 10, "LibraryFees"));

                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.Int, 10, "UniversityDevelopmentFees"));

                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.Int, 15, "UniversityStudentWelfareFees"));

                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.Int, 10, "CautionMoney"));

                cmd.Parameters.Add(new SqlParameter("@d15", System.Data.SqlDbType.Int, 10, "OtherFees"));
                cmd.Parameters.Add(new SqlParameter("@d16", System.Data.SqlDbType.Int, 10, "TotalFees"));
                cmd.Parameters.Add(new SqlParameter("@d17", System.Data.SqlDbType.NChar, 30, "DateOfPayment"));

                cmd.Parameters.Add(new SqlParameter("@d18", System.Data.SqlDbType.NChar, 20, "ModeOfPayment"));
                cmd.Parameters.Add(new SqlParameter("@d19", System.Data.SqlDbType.VarChar, 200, "PaymentModeDetails"));
                cmd.Parameters.Add(new SqlParameter("@d20", System.Data.SqlDbType.Int, 10, "TotalPaid"));

                cmd.Parameters.Add(new SqlParameter("@d21", System.Data.SqlDbType.Int, 10, "Fine"));
                cmd.Parameters.Add(new SqlParameter("@d22", System.Data.SqlDbType.Int, 10, "DueFees"));
                cmd.Parameters["@d1"].Value = FeePaymentID.Text.Trim();
                cmd.Parameters["@d2"].Value = ScholarNo.Text.Trim();
                cmd.Parameters["@d6"].Value = FeeID.Text.Trim();
                cmd.Parameters["@d7"].Value = FDCourse.Text.Trim();
                cmd.Parameters["@d8"].Value = FDBranch.Text.Trim();
                cmd.Parameters["@d9"].Value = Semester.Text.Trim();
                cmd.Parameters["@d10"].Value = Convert.ToInt32(TutionFees.Text);
                cmd.Parameters["@d11"].Value = Convert.ToInt32(LibraryFees.Text);
                cmd.Parameters["@d12"].Value = Convert.ToInt32(UDFees.Text);
                cmd.Parameters["@d13"].Value = Convert.ToInt32(USFees.Text);
                if (Semester.Text == "1st")
                {
                    cmd.Parameters["@d14"].Value = Convert.ToInt32(CautionMoney.Text);
                }
                else
                {
                    cmd.Parameters["@d14"].Value = 0;
                }
                cmd.Parameters["@d15"].Value = Convert.ToInt32(OtherFees.Text);
                cmd.Parameters["@d16"].Value = Convert.ToInt32(TotalFees.Text);
                cmd.Parameters["@d17"].Value = (PaymentDate.Text);
                cmd.Parameters["@d18"].Value = (ModeOfPayment.Text);
                cmd.Parameters["@d19"].Value = (PaymentModeDetails.Text);
                cmd.Parameters["@d20"].Value = Convert.ToInt32(TotalPaid.Text);
                if (Fine.Text == "")
                {
                    cmd.Parameters["@d21"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d21"].Value = Convert.ToInt32(Fine.Text);
                }
               
                cmd.Parameters["@d22"].Value = Convert.ToInt32(DueFees.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully updated", "Fees Payment Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Update_record.Enabled = false;
            con.Close();
 }
         catch (Exception ex)
         {
             MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
        }

       

        private void FeesPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu form2 = new frmMainMenu();
            form2.User.Text = label24.Text;
            form2.UserType.Text = label23.Text;
            form2.Show();
        }
   
        private SqlConnection Connection
        {
            get
            {
                SqlConnection ConnectionToFetch = new SqlConnection(cs.DBConn);
                ConnectionToFetch.Open();
                return ConnectionToFetch;
            }
        }
        public DataView GetData()
        {
            dynamic SelectQry = "SELECT RTRIM(FeeID)[Fee ID], RTRIM(Course)[Course], RTRIM(Semester)[Semester], RTRIM(Branch)[Branch] from FeesDetails order by course,semester ";
            DataSet SampleSource = new DataSet();
            DataView TableView = null;
            try
            {
                SqlCommand SampleCommand = new SqlCommand();
                dynamic SampleDataAdapter = new SqlDataAdapter();
                SampleCommand.CommandText = SelectQry;
                SampleCommand.Connection = Connection;
                SampleDataAdapter.SelectCommand = SampleCommand;
                SampleDataAdapter.Fill(SampleSource);
                TableView = SampleSource.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return TableView;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                frmFeePaymentReceipt frm = new frmFeePaymentReceipt();
                rptFeePaymentReceipt rpt = new rptFeePaymentReceipt();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                CMS_DBDataSet1 myDS = new CMS_DBDataSet1();
                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from feepayment,Student where student.Scholarno=FeePayment.ScholarNo and FeePaymentID= '" + FeePaymentID.Text + "'";
                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "FeePayment");
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

        private void button2_Click(object sender, EventArgs e)
        {
            frmFeePaymentRecord frm = new frmFeePaymentRecord();
            this.Hide();
            frm.dataGridView1.DataSource = null;
            frm.Course.Text = "";
            frm.Branch.Text = "";
            frm.Date_from.Text = DateTime.Today.ToString();
            frm.Date_to.Text = DateTime.Today.ToString();
            frm.ScholarNo.Text = "";
            frm.dataGridView2.DataSource = null;
            frm.dataGridView3.DataSource = null;
            frm.dataGridView4.DataSource = null;
            frm.dataGridView5.DataSource = null;
            frm.PaymentDateFrom.Text = DateTime.Today.ToString();
            frm.PaymentDateTo.Text = DateTime.Today.ToString();
            frm.DateFrom.Text = DateTime.Today.ToString();
            frm.DateTo.Text = DateTime.Today.ToString();
            frm.dateTimePicker1.Text = DateTime.Today.ToString();
            frm.dateTimePicker2.Text = DateTime.Today.ToString();
            Branch.Enabled = false;
            frm.label13.Text = label23.Text;
            frm.label14.Text = label24.Text;
            frm.Show();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try{
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            
           FeeID.Text = dr.Cells[0].Value.ToString();
            Semester.Text = dr.Cells[2].Value.ToString();
            FDCourse.Text = dr.Cells[1].Value.ToString();
            FDBranch.Text = dr.Cells[3].Value.ToString();
             con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT TutionFees,LibraryFees,UniversityDevelopmentFees,UniversityStudentWelfareFees,CautionMoney,OtherFees,TotalFees from FeesDetails WHERE FeeID = '" + dr.Cells[0].Value.ToString() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    TutionFees.Text = (String)rdr["TutionFees"];
                    OtherFees.Text = (String)rdr["OtherFees"];
                    USFees.Text = (String)rdr["UniversityStudentWelfareFees"];
                    LibraryFees.Text = (String)rdr["LibraryFees"];
                    CautionMoney.Text = (String)rdr["CautionMoney"];
                    UDFees.Text = (String)rdr["UniversityDevelopmentFees"];
                    TotalFees.Text = (String)rdr["TotalFees"];
                   
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void Fine_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void TotalPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void TotalPaid_TextChanged(object sender, EventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            int.TryParse(TotalFees.Text, out val1);
            int.TryParse(Fine.Text, out val2);
            int.TryParse(TotalPaid.Text, out val3);

            int I = ((val1 + val2) - val3);

            DueFees.Text = I.ToString();
        }

        private void TotalPaid_Validating(object sender, CancelEventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            int.TryParse(TotalFees.Text, out val1);
            int.TryParse(Fine.Text, out val2);
            int.TryParse(TotalPaid.Text, out val3);
            if (val3 > val1 + val2)
            {
                MessageBox.Show("Total Paid can not be more than Total Fees + Fine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TotalPaid.Focus();
            }
        }

      
        }

     
       
    }


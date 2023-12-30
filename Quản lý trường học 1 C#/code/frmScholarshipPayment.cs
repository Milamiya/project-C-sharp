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
    public partial class frmScholarshipPayment : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        ConnectionString cs = new ConnectionString();

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
       

        public frmScholarshipPayment()
        {
            InitializeComponent();
        }
        private void auto()
        {
            ScholarshipPaymentID.Text = "SSP-" + GetUniqueKey(6);
        }
        private void ScholarshipPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu form2 = new frmMainMenu();
            form2.UserType.Text = label5.Text;
            form2.User.Text = label6.Text;
            form2.Show();
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

        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();


        }
        private void Reset()
        {
            ScholarshipPaymentID.Text = "";
            ScholarshipID.Text = "";
            ScholarshipName.Text = "";
       
            Amount.Text = "";
            ScholarNo.Text = "";
            StudentName.Text = "";
            Course.Text = "";
            Branch.Text = "";
            ModeOfPayment.Text = "";
            PaymentModeDetails.Text = "";
            TotalPaid.Text = "";

            DuePayment.Text = "";
            PaymentDate.Text = DateTime.Today.ToString();
            Delete.Enabled = false;
            Update_record.Enabled = false;
            btnSave.Enabled = true;
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
                PaymentDate.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScholarshipID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM Scholarship WHERE Scholarshipid = '" + ScholarshipID.Text.Trim() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    ScholarshipName.Text = (rdr.GetString(1).Trim());
                 
                    Amount.Text = (rdr.GetString(3).Trim());
                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                ScholarNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PopulateScholarNo()
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

        private void frmScholarshipPayment_Load(object sender, EventArgs e)
        {
            PopulateScholarNo();
      
            PopulateScholarshipID();
                 dataGridView1.DataSource = GetData();
        }
        private void PopulateScholarshipID()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM( ScholarshipID) from  Scholarship ";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ScholarshipID.Items.Add(rdr[0]);
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
             try
            {
                   if (ScholarshipID.Text == "")
                {
                    MessageBox.Show("Please select Scholarship ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ScholarshipID.Focus();
                    return;
                }
                if (ScholarNo.Text == "")
                {
                    MessageBox.Show("Please select Scholar No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ScholarNo.Focus();
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
                if (int.Parse(TotalPaid.Text) > int.Parse(Amount.Text))
                {
                    MessageBox.Show("total paid can not be more than scholarship amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TotalPaid.Text = "";
                    TotalPaid.Focus();
                    return;
                }

                auto();
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select ScholarshipPaymentID from ScholarshipPayment where ScholarshipPaymentID=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 20, "ScholarshipPaymentID"));
                cmd.Parameters["@find"].Value = ScholarshipPaymentID.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Scholarship Payment ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  ScholarshipPaymentID.Text = "";



                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into ScholarshipPayment(ScholarshipPaymentID,Scholarshipid,amount,ScholarNo,PaymentDate,PaymentMode,PaymentModeDetails,TotalPaid,DuePayment) VALUES (@d1,@d2,@d5,@d6,@d10,@d11,@d12,@d13,@d14)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "ScholarshipPaymentID"));
                 
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.Int, 10, "ScholarshipID"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.Int, 10, "Amount"));
                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 15, "ScholarNo"));
              
                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 30, "PaymentDate"));

                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 20, "PaymentMode"));
                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.VarChar, 200, "PaymentModeDetails"));
                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.Int, 10, "TotalPaid"));
                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.Int, 10, "DueFees"));
                cmd.Parameters["@d1"].Value = ScholarshipPaymentID.Text.Trim();
                cmd.Parameters["@d2"].Value = ScholarshipID.Text.Trim();
                cmd.Parameters["@d5"].Value = Amount.Text.Trim();
                cmd.Parameters["@d6"].Value = ScholarNo.Text.Trim();
                cmd.Parameters["@d10"].Value = (PaymentDate.Text);
                cmd.Parameters["@d11"].Value = (ModeOfPayment.Text);
                cmd.Parameters["@d12"].Value = (PaymentModeDetails.Text);
                cmd.Parameters["@d13"].Value = (TotalPaid.Text);
          
                cmd.Parameters["@d14"].Value = (DuePayment.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (int.Parse(TotalPaid.Text) > int.Parse(Amount.Text))
            {
                MessageBox.Show("total paid can not be more than scholarship amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TotalPaid.Text = "";
                TotalPaid.Focus();
                return;
            }
            try{
             con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update scholarshippayment set Scholarshipid=@d2,amount=@d5,ScholarNo=@d6,PaymentDate=@d10,PaymentMode=@d11,PaymentModeDetails=@d12,TotalPaid=@d13,DuePayment=@d14 where scholarshippaymentid=@d1";     
                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "ScholarshipPaymentID"));
                 
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.Int, 10, "ScholarshipID"));
                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.Int, 10, "Amount"));
                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 15, "ScholarNo"));
                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 30, "PaymentDate"));
                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 20, "PaymentMode"));
                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.VarChar, 200, "PaymentModeDetails"));
                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.Int, 10, "TotalPaid"));
                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.Int, 10, "DueFees"));
                cmd.Parameters["@d1"].Value = ScholarshipPaymentID.Text.Trim();
                cmd.Parameters["@d2"].Value = ScholarshipID.Text.Trim();
                cmd.Parameters["@d5"].Value = Amount.Text.Trim();
                cmd.Parameters["@d6"].Value = ScholarNo.Text.Trim();
                cmd.Parameters["@d10"].Value = (PaymentDate.Text);
                cmd.Parameters["@d11"].Value = (ModeOfPayment.Text);
                cmd.Parameters["@d12"].Value = (PaymentModeDetails.Text);
                cmd.Parameters["@d13"].Value = (TotalPaid.Text);
                cmd.Parameters["@d14"].Value = (DuePayment.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
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


                string cq = "delete from ScholarshipPayment where  ScholarshipPaymentID=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 20, "ScholarshipPaymentID"));


                cmd.Parameters["@DELETE1"].Value = ScholarshipPaymentID.Text;
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
            dynamic SelectQry = "SELECT RTRIM(Scholarshipname)[Scholarship Name], RTRIM(ScholarshipID)[Scholarship ID] from scholarship order by scholarshipname ";
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

        private void ViewRecord_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];

                ScholarshipName.Text = dr.Cells[0].Value.ToString();
                ScholarshipID.Text = dr.Cells[1].Value.ToString();
               
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT amount from Scholarship WHERE ScholarshipID = '" + dr.Cells[1].Value.ToString() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    Amount.Text = (String)rdr["Amount"];
                  
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarshipPaymentRecord1 frm = new frmScholarshipPaymentRecord1();
            frm.label10.Text = label5.Text; ;
            frm.label11.Text = label6.Text;
            frm.Show();
        }

        private void TotalPaid_TextChanged(object sender, EventArgs e)
        {

            int val1 = 0;
            int val2 = 0;
            int.TryParse(Amount.Text, out val1);
            int.TryParse(TotalPaid.Text, out val2);
            int I = (val1-val2);
            DuePayment.Text = I.ToString();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                frmScholarshipPaymentReceipt frm = new frmScholarshipPaymentReceipt();

                rptScholarshipPaymentReceipt rpt = new rptScholarshipPaymentReceipt();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                CMS_DBDataSet myDS = new CMS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from ScholarshipPayment,Student,Scholarship where Student.ScholarNo=ScholarshipPayment.ScholarNo and Scholarship.ScholarshipID=ScholarshipPayment.ScholarshipID and ScholarshipPaymentID = '" + ScholarshipPaymentID.Text + "'";
                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "ScholarshipPayment");
                myDA.Fill(myDS, "Student");
                myDA.Fill(myDS, "Scholarship");
                rpt.SetDataSource(myDS);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Show();
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

      

       
        }

     
    }

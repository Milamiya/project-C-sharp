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
    public partial class frmHostelFeePayment : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();


        public frmHostelFeePayment()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            FeePaymentID.Text = "";
            ScholarNo.Text = "";
            StudentName.Text = "";
            Course.Text = "";
            Branch.Text = "";
           
            txtHostelFees.Text = "";
            txtHostelName.Text = "";
            ModeOfPayment.Text = "";
            PaymentDate.Text = DateTime.Today.ToString();
            PaymentModeDetails.Text = "";
            Fine.Text = "";
            TotalPaid.Text = "";
            DueFees.Text = "";
            btnSave.Enabled = true;
            Delete.Enabled = false;
            Update_record.Enabled = false;
            Print.Enabled = false;
            ScholarNo.Focus();
        }
        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
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
               
              
                auto();
               
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into Hostelfeepayment(HFeePaymentID,ScholarNo,HostelFees,DateOfPayment,ModeOfPayment,PaymentModeDetails,TotalPaid,Fine,DueFees) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "HFeePaymentID"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 15, "ScholarNo"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.Int, 10, "HostelFees"));
             
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 30, "DateOfPayment"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 20, "ModeOfPayment"));
                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.VarChar, 200, "PaymentModeDetails"));
                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.Int, 10, "TotalPaid"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.Int, 10, "Fine"));
                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.Int, 10, "DueFees"));
                cmd.Parameters["@d1"].Value = FeePaymentID.Text.Trim();
                cmd.Parameters["@d2"].Value = ScholarNo.Text.Trim();
                cmd.Parameters["@d3"].Value = Convert.ToInt32(txtHostelFees.Text);
                cmd.Parameters["@d4"].Value = (PaymentDate.Text);
                cmd.Parameters["@d5"].Value = (ModeOfPayment.Text);
                cmd.Parameters["@d6"].Value = (PaymentModeDetails.Text);
                cmd.Parameters["@d7"].Value = Convert.ToInt32(TotalPaid.Text);
                if (Fine.Text == "")
                {
                    cmd.Parameters["@d8"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d8"].Value = Convert.ToInt32(Fine.Text);
                }
                
                cmd.Parameters["@d9"].Value = Convert.ToInt32(DueFees.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                Print.Enabled = true;

                con.Close();
            

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            FeePaymentID.Text = "HF-" + GetUniqueKey(8);
        }
        private void frmHostelFeePayemt_Load(object sender, EventArgs e)
        {
            AutocompleScholaNo();
        }

        private void Update_record_Click(object sender, EventArgs e)
        {
            try
            {
            con = new SqlConnection(cs.DBConn);
            con.Open();

            string cb = "update Hostelfeepayment set ScholarNo=@d2,HostelFees=@d3,DateOfPayment=@d4,ModeOfPayment=@d5,PaymentModeDetails=@d6,TotalPaid=@d7,Fine=@d8,DueFees=@d9 where HFeePaymentID=@d1";

            cmd = new SqlCommand(cb);

            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 20, "HFeePaymentID"));

            cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 15, "ScholarNo"));

            cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.Int, 10, "HostelFees"));

            cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 30, "DateOfPayment"));

            cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 20, "ModeOfPayment"));
            cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.VarChar, 200, "PaymentModeDetails"));
            cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.Int, 10, "TotalPaid"));

            cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.Int, 10, "Fine"));
            cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.Int, 10, "DueFees"));
            cmd.Parameters["@d1"].Value = FeePaymentID.Text.Trim();
            cmd.Parameters["@d2"].Value = ScholarNo.Text.Trim();
            cmd.Parameters["@d3"].Value = Convert.ToInt32(txtHostelFees.Text);
            cmd.Parameters["@d4"].Value = (PaymentDate.Text);
            cmd.Parameters["@d5"].Value = (ModeOfPayment.Text);
            cmd.Parameters["@d6"].Value = (PaymentModeDetails.Text);
            cmd.Parameters["@d7"].Value = Convert.ToInt32(TotalPaid.Text);
            if (Fine.Text == "")
            {
                cmd.Parameters["@d8"].Value = 0;
            }
            else
            {
                cmd.Parameters["@d8"].Value = Convert.ToInt32(Fine.Text);
            }
           
            cmd.Parameters["@d9"].Value = Convert.ToInt32(DueFees.Text);
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


                string cq = "delete from HostelFeePayment where HFeePaymentID=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 20, "HFeepaymentID"));


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
        private void AutocompleScholaNo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(ScholarNo) from Hostelers ";

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

        private void ScholarNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT Student_Name,Course,Branch,Hostelers.Hostelname,HostelFees FROM student,Hostelers,Hostel WHERE Student.ScholarNo=Hostelers.ScholarNo and Hostelers.Hostelname=Hostel.HostelName and Student.ScholarNo = '" + ScholarNo.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {


                    StudentName.Text = rdr.GetString(0).Trim();


                    Course.Text = rdr.GetString(1).Trim();

                    Branch.Text = rdr.GetString(2).Trim();
                    txtHostelName.Text = rdr.GetString(3).Trim();
                    txtHostelFees.Text = rdr.GetInt32(4).ToString();
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

        private void TotalPaid_TextChanged(object sender, EventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            int.TryParse(txtHostelFees.Text, out val1);
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
            int.TryParse(txtHostelFees.Text, out val1);
            int.TryParse(Fine.Text, out val2);
            int.TryParse(TotalPaid.Text, out val3);
            if (val3 > val1 + val2)
            {
                MessageBox.Show("Total Paid can not be more than Hostel Fees + Fine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TotalPaid.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelFeePaymentRecord1 frm = new frmHostelFeePaymentRecord1();
            frm.label13.Text = label3.Text;
            frm.label14.Text = label4.Text;
            frm.Show();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                frmHostelPaymentReceipt frm = new frmHostelPaymentReceipt();

                rptHostelFeePaymentReceipt rpt = new rptHostelFeePaymentReceipt();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                HostelFeePayment_DBDataSet myDS = new  HostelFeePayment_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select *  from HostelFeePayment,Student,Hostel,Hostelers where Student.scholarNo=Hostelers.ScholarNo and HostelFeePayment.ScholarNo=Student.ScholarNo and Hostel.HostelName=Hostelers.Hostelname and HFeePaymentID= '" + FeePaymentID.Text + "'" ;

                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "HostelFeePayment");
                myDA.Fill(myDS, "Hostel");
                myDA.Fill(myDS, "Hostelers");
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void frmHostelFeePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            this.Hide();
            frm.UserType.Text = label3.Text;
            frm.User.Text = label4.Text;
            frm.Show();
        }
    }
}
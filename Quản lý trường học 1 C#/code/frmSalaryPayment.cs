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
    public partial class frmSalaryPayment : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

      
        public frmSalaryPayment()
        {
            InitializeComponent();
        }
        private void Reset()
        {
                txtPaymentID.Text = "";
                cmbStaffID.Text="";
                cmbModeOfPayment.Text = "";
                dtpPaymentDate.Text = DateTime.Today.ToString();
                txtBasicSalary.Text = "";
                txtDeduction.Text = "";
                txtPaymentModeDetails.Text = "";
                txtStaffName.Text = "";
                txtTotalPaid.Text = "";
                btnDelete.Enabled = false;
                btnUpdate_record.Enabled = false;
                btnSave.Enabled = true;
                btnPrint.Enabled = false;
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
            txtPaymentID.Text = "SP-" + GetUniqueKey(8);
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            Reset();
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (cmbStaffID.Text == "")
            {
                MessageBox.Show("Please select staff id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStaffID.Focus();
                return;
            }
            if (cmbModeOfPayment.Text == "")
            {
                MessageBox.Show("Please select mode of payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbModeOfPayment.Focus();
                return;
            }
       
            try
            {
               
                auto();
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into EmployeePayment(PaymentId,StaffId,basicsalary,PaymentDate,ModeOfPayment,PaymentModeDetails,Deduction,TotalPaid) VALUES (@d1,@d2,@d4,@d5,@d6,@d7,@d8,@d9)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "PaymentID"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 15, "StaffID"));
                
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.Int, 10, "BasicSalary"));
                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 30, "PaymentDate"));


                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 20, "ModeOfPayment"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 200, "PaymentModeDetails"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.Int, 10, "Deduction"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.Int, 10, "TotalPaid"));

                cmd.Parameters["@d1"].Value = txtPaymentID.Text;
                cmd.Parameters["@d2"].Value = cmbStaffID.Text;
                cmd.Parameters["@d4"].Value = Convert.ToInt32(txtBasicSalary.Text);
                cmd.Parameters["@d5"].Value = dtpPaymentDate.Text;
                cmd.Parameters["@d6"].Value = cmbModeOfPayment.Text;
                cmd.Parameters["@d7"].Value = txtPaymentModeDetails.Text;
                cmd.Parameters["@d8"].Value = Convert.ToInt32(txtDeduction.Text);
                cmd.Parameters["@d9"].Value = Convert.ToInt32(txtTotalPaid.Text);
                cmd.ExecuteReader();


                con.Close();
                MessageBox.Show("Successfully Saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPrint.Enabled = true;
                btnSave.Enabled = false;
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

                string cb = "update EmployeePayment set StaffId=@d2,basicsalary=@d4,PaymentDate=@d5,ModeOfPayment=@d6,PaymentModeDetails=@d7,Deduction=@d8,TotalPaid=@d9 where PaymentID=@d1";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "PaymentID"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 15, "StaffID"));
               
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.Int, 10, "BasicSalary"));
                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 30, "PaymentDate"));


                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.NChar, 20, "ModeOfPayment"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 200, "PaymentModeDetails"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.Int, 10, "Deduction"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.Int, 10, "TotalPaid"));

                cmd.Parameters["@d1"].Value = txtPaymentID.Text;
                cmd.Parameters["@d2"].Value = cmbStaffID.Text;
                cmd.Parameters["@d4"].Value = Convert.ToInt32(txtBasicSalary.Text);
                cmd.Parameters["@d5"].Value = dtpPaymentDate.Text;
                cmd.Parameters["@d6"].Value = cmbModeOfPayment.Text;
                cmd.Parameters["@d7"].Value = txtPaymentModeDetails.Text;
                cmd.Parameters["@d8"].Value = Convert.ToInt32(txtDeduction.Text);
                cmd.Parameters["@d9"].Value = Convert.ToInt32(txtTotalPaid.Text);
                cmd.ExecuteReader();


                con.Close();
                MessageBox.Show("Successfully Updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void PopulateStaffID()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(StaffID) FROM Employee", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbStaffID.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbStaffID.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmSalaryPayment_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
            PopulateStaffID();
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


                string cq = "delete from EmployeePayment where  PaymentID=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 15, "PaymentID"));


                cmd.Parameters["@DELETE1"].Value = txtPaymentID.Text;
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

        private void frmSalaryPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.UserType.Text = label6.Text;
            frm.User.Text = label7.Text;
            frm.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptSalarySlip rpt = new rptSalarySlip(); //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                CMS_DBDataSet myDS = new CMS_DBDataSet(); //The DataSet you created.
                FrmSalarySlip frm = new FrmSalarySlip();
                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from EmployeePayment,Employee where Employee.StaffID=EmployeePayment.StaffID and PaymentID='" + txtPaymentID.Text + "'";
                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "EmployeePayment");
                myDA.Fill(myDS, "Employee");
                rpt.SetDataSource(myDS);
                frm.crystalReportViewer1.ReportSource = rpt;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT Staffname,basicsalary from Employee WHERE StaffID = '" + cmbStaffID.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {

                    txtStaffName.Text = (rdr.GetString(0).Trim());
                    txtBasicSalary.Text = rdr.GetInt32(1).ToString();
                
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
            dynamic SelectQry = "SELECT RTRIM(StaffID)[Staff ID], RTRIM(StaffName)[Staff Name] from Employee order by Staffname ";
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

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];

                cmbStaffID.Text = dr.Cells[0].Value.ToString();
                txtStaffName.Text = dr.Cells[1].Value.ToString();

                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT basicsalary from Employee WHERE StaffID = '" + dr.Cells[0].Value.ToString() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtBasicSalary.Text = rdr.GetInt32(0).ToString();

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

        private void txtDeduction_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (int.Parse(txtDeduction.Text) > int.Parse(txtBasicSalary.Text))
                {
                    MessageBox.Show("Deduction can not be more than Basic Salary", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDeduction.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalaryPaymentRecord1 frm = new frmSalaryPaymentRecord1();
            frm.label1.Text = label6.Text;
            frm.label3.Text = label7.Text;
            frm.Show();
        }

        private void txtPaymentID_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void txtDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtDeduction_TextChanged(object sender, EventArgs e)
        {

            int val1 = 0;
            int val2 = 0;
            int.TryParse(txtBasicSalary.Text, out val1);
            int.TryParse(txtDeduction.Text, out val2);
            int I = (val1 - val2);
            txtTotalPaid.Text = I.ToString();
        }

      
      
    }
}

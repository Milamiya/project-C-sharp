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
namespace College_Management_System
{
    public partial class frmEmployeePaymentReport : Form
    {
        DataTable dtable = new DataTable();
      
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
      
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

       

        public frmEmployeePaymentReport()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;

            cmbStaffName.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

          crystalReportViewer2.ReportSource= null;
            DateFrom.Text = DateTime.Today.ToString();
            DateTo.Text = DateTime.Today.ToString();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;

            cmbStaffName.Text = "";
            crystalReportViewer2.ReportSource = null;
            DateFrom.Text = DateTime.Today.ToString();
            DateTo.Text = DateTime.Today.ToString();
        }

        private void frmEmployeePaymentReport_Load(object sender, EventArgs e)
        {
            AutocompleteStaffName();
        }

        private void cmbStaffName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptSalaryPayment rpt = new rptSalaryPayment();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                CMS_DBDataSet myDS = new CMS_DBDataSet();
                //The DataSet you created.
                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select *  from EmployeePayment,Employee where EmployeePayment.StaffID=Employee.StaffID and Staffname= '" + cmbStaffName.Text + "' order by PaymentDate";
                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "EmployeePayment");
                myDA.Fill(myDS, "Employee");
                rpt.SetDataSource(myDS);

                crystalReportViewer1.ReportSource = rpt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptSalaryPayment rpt = new rptSalaryPayment();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                CMS_DBDataSet myDS = new CMS_DBDataSet();
                //The DataSet you created.


                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select *  from EmployeePayment,Employee where Employee.StaffID=EmployeePayment.StaffID and PaymentDate between @date1 and @date2 order by PaymentDate";
                MyCommand.Parameters.Add("@date1", SqlDbType.DateTime, 30, "PaymentDate").Value = DateFrom.Value.Date;
                MyCommand.Parameters.Add("@date2", SqlDbType.DateTime, 30, "PaymentDate").Value = DateTo.Value.Date;
                MyCommand.CommandType = CommandType.Text;
                myDA.SelectCommand = MyCommand;
                myDA.Fill(myDS, "EmployeePayment");
                myDA.Fill(myDS, "Employee");
                rpt.SetDataSource(myDS);
                crystalReportViewer2.ReportSource = rpt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEmployeePaymentReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.UserType.Text = label1.Text;
            frm.User.Text = label3.Text;
            frm.Show();
        }
        private void AutocompleteStaffName()
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(StaffName) FROM EmployeePayment,Employee where Employee.staffID=EmployeePayment.StaffID", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbStaffName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbStaffName.Items.Add(drow[0].ToString());

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
    }
}

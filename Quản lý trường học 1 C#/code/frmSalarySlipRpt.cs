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
    public partial class frmSalarySlipRpt : Form
    {
        DataTable dtable = new DataTable();
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        ConnectionString cs = new ConnectionString();

        public frmSalarySlipRpt()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;
            cmbPaymentID.Text = "";
        }

        private void cmbPaymentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;
                rptSalarySlip rpt = new rptSalarySlip();
                //The report you created.
                SqlConnection myConnection = default(SqlConnection);
                SqlCommand MyCommand = new SqlCommand();
                SqlDataAdapter myDA = new SqlDataAdapter();
                CMS_DBDataSet myDS = new CMS_DBDataSet();
                //The DataSet you created.
                myConnection = new SqlConnection(cs.DBConn);
                MyCommand.Connection = myConnection;
                MyCommand.CommandText = "select * from Employeepayment,Employee where Employee.StaffID=EmployeePayment.StaffID and PaymentID= '" + cmbPaymentID.Text + "'";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }
        public void Autocomplete()
        {

            try
            {
               

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(PaymentID) FROM EmployeePayment", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbPaymentID.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbPaymentID.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmSalarySlipRpt_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }
    }
}

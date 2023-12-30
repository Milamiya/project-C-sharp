using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace College_Management_System
{
    public partial class frmLogin : Form
    {
        String cs = "Data Source=(localDB)\\v11.0; Integrated Security=True; AttachDbFilename=|DataDirectory|\\CMS_DB.mdf";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbUsertype.Text == "")
            {
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUsertype.Focus();
                return;
            }
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT UserType,Username,password FROM Users WHERE UserType = @usertype AND Username = @username AND password = @UserPassword", myConnection);
                SqlParameter uType = new SqlParameter("@usertype", SqlDbType.NChar);

                SqlParameter uName = new SqlParameter("@username", SqlDbType.NChar);

                SqlParameter uPassword = new SqlParameter("@UserPassword", SqlDbType.NChar);

                uType.Value = cmbUsertype.Text;
                uName.Value = txtUserName.Text;
                uPassword.Value = txtPassword.Text;

                myCommand.Parameters.Add(uType);
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {

                   
                        int i;
                        ProgressBar1.Visible = true;
                        ProgressBar1.Maximum = 5000;
                        ProgressBar1.Minimum = 0;
                        ProgressBar1.Value = 4;
                        ProgressBar1.Step = 1;

                        for (i = 0; i <= 5000; i++)
                        {
                            ProgressBar1.PerformStep();
                        }
                        if (cmbUsertype.Text == "Lecturer")
                    {
                        this.Hide();
                        frmMainMenu frm = new frmMainMenu();
                        frm.User.Text = txtUserName.Text;
                        frm.UserType.Text = cmbUsertype.Text;
                        frm.Show();
                        frm.registrationToolStripMenuItem2.Enabled = false;
                        frm.studentDetailsToolStripMenuItem.Enabled = false;
                        frm.internalMarksEntryToolStripMenuItem.Enabled = false;
                        frm.hostelersToolStripMenuItem.Enabled = false;
                        frm.busHoldersToolStripMenuItem.Enabled = false;
                        frm.attendanceToolStripMenuItem.Enabled = false;
                        frm.registrationFormToolStripMenuItem.Enabled = false;
                        frm.Master_entryMenu.Enabled = false;
                        frm.usersToolStripMenuItem.Enabled = false;
                        frm.studentToolStripMenuItem.Enabled = false;
                        frm.employeeToolStripMenuItem.Enabled = false;
                        frm.transactionToolStripMenuItem.Enabled = false;
                        frm.searchToolStripMenuItem.Enabled = false;
                        frm.reportToolStripMenuItem.Enabled = false;
                        frm.userRegistrationToolStripMenuItem.Enabled = false;
                        frm.studentToolStripMenuItem1.Enabled = false;
                        frm.attendanceToolStripMenuItem1.Enabled = true;
                        frm.internalMarksEntryToolStripMenuItem1.Enabled = true;
                        frm.employeeToolStripMenuItem1.Enabled = false;
                        frm.salaryPaymentToolStripMenuItem.Enabled = false;
                        frm.feePaymentToolStripMenuItem1.Enabled = false;
                        frm.busFeePaymentToolStripMenuItem2.Enabled = false;
                        frm.feePaymentToolStripMenuItem.Enabled = false;
                        frm.employeeSalaryToolStripMenuItem.Enabled = false;
                        frm.hostelFeesPaymentToolStripMenuItem.Enabled = false;
                        frm.scholarshipPaymentToolStripMenuItem.Enabled = false;
                        frm.othersTransactionToolStripMenuItem.Enabled = false;
                    }

                        if (cmbUsertype.Text == "Admin")
                        {
                            this.Hide();
                            frmMainMenu frm = new frmMainMenu();
                            frm.User.Text = txtUserName.Text;
                            frm.UserType.Text = cmbUsertype.Text;
                            frm.Show();
                            frm.registrationToolStripMenuItem2.Enabled = true;
                            frm.studentDetailsToolStripMenuItem.Enabled = true;
                            frm.internalMarksEntryToolStripMenuItem.Enabled = true;
                            frm.hostelersToolStripMenuItem.Enabled = true;
                            frm.busHoldersToolStripMenuItem.Enabled = true;
                            frm.attendanceToolStripMenuItem.Enabled = true;
                            frm.registrationFormToolStripMenuItem.Enabled = true;
                            frm.Master_entryMenu.Enabled = true;
                            frm.usersToolStripMenuItem.Enabled = true;
                            frm.studentToolStripMenuItem.Enabled = true;
                            frm.employeeToolStripMenuItem.Enabled = true;
                            frm.transactionToolStripMenuItem.Enabled = true;
                            frm.searchToolStripMenuItem.Enabled = true;
                            frm.reportToolStripMenuItem.Enabled = true;
                            frm.userRegistrationToolStripMenuItem.Enabled = true;
                            frm.studentToolStripMenuItem1.Enabled = true;
                            frm.attendanceToolStripMenuItem1.Enabled = true;
                            frm.internalMarksEntryToolStripMenuItem1.Enabled = true;
                            frm.employeeToolStripMenuItem1.Enabled = true;
                            frm.salaryPaymentToolStripMenuItem.Enabled = true;
                            frm.feePaymentToolStripMenuItem1.Enabled = true;
                            frm.busFeePaymentToolStripMenuItem2.Enabled = true;
                            frm.feePaymentToolStripMenuItem.Enabled = true;
                            frm.employeeSalaryToolStripMenuItem.Enabled = true;
                            frm.hostelFeesPaymentToolStripMenuItem.Enabled = true;
                            frm.scholarshipPaymentToolStripMenuItem.Enabled = true;
                            frm.othersTransactionToolStripMenuItem.Enabled = true;

                        }
                  
                        if (cmbUsertype.Text == "Admissions Officer")
                        {
                            this.Hide();
                            frmMainMenu frm = new frmMainMenu();
                            frm.User.Text = txtUserName.Text;
                            frm.UserType.Text = cmbUsertype.Text;
                            frm.Show();
                            frm.registrationToolStripMenuItem2.Enabled = true;
                            frm.studentDetailsToolStripMenuItem.Enabled = true;
                            frm.internalMarksEntryToolStripMenuItem.Enabled = false;
                            frm.hostelersToolStripMenuItem.Enabled = false;
                            frm.busHoldersToolStripMenuItem.Enabled = false;
                            frm.attendanceToolStripMenuItem.Enabled = false;
                            frm.registrationFormToolStripMenuItem.Enabled = true;
                            frm.Master_entryMenu.Enabled = false;
                            frm.usersToolStripMenuItem.Enabled = false;
                            frm.studentToolStripMenuItem.Enabled = true;
                            frm.employeeToolStripMenuItem.Enabled = false;
                            frm.transactionToolStripMenuItem.Enabled = false;
                            frm.searchToolStripMenuItem.Enabled = false;
                            frm.reportToolStripMenuItem.Enabled = false;
                            frm.userRegistrationToolStripMenuItem.Enabled = false;
                            frm.studentToolStripMenuItem1.Enabled = true;
                            frm.attendanceToolStripMenuItem1.Enabled = false;
                            frm.internalMarksEntryToolStripMenuItem1.Enabled = false;
                            frm.employeeToolStripMenuItem1.Enabled = false;
                            frm.salaryPaymentToolStripMenuItem.Enabled = false;
                            frm.feePaymentToolStripMenuItem1.Enabled = false;
                            frm.busFeePaymentToolStripMenuItem2.Enabled = false;
                            frm.feePaymentToolStripMenuItem.Enabled = false;
                            frm.employeeSalaryToolStripMenuItem.Enabled = false;
                            frm.hostelFeesPaymentToolStripMenuItem.Enabled = false;
                            frm.scholarshipPaymentToolStripMenuItem.Enabled = false;
                            frm.othersTransactionToolStripMenuItem.Enabled = false;
                        }
                        if (cmbUsertype.Text == "Accounts Officer")
                        {
                            this.Hide();
                            frmMainMenu frm = new frmMainMenu();
                            frm.User.Text = txtUserName.Text;
                            frm.UserType.Text = cmbUsertype.Text;
                            frm.Show();
                            frm.registrationToolStripMenuItem2.Enabled = false;
                            frm.studentDetailsToolStripMenuItem.Enabled = false;
                            frm.internalMarksEntryToolStripMenuItem.Enabled = false;
                            frm.hostelersToolStripMenuItem.Enabled = false;
                            frm.busHoldersToolStripMenuItem.Enabled = false;
                            frm.attendanceToolStripMenuItem.Enabled = false;
                            frm.registrationFormToolStripMenuItem.Enabled = false;
                            frm.Master_entryMenu.Enabled = false;
                            frm.usersToolStripMenuItem.Enabled = false;
                            frm.studentToolStripMenuItem.Enabled = false;
                            frm.employeeToolStripMenuItem.Enabled = false;
                            frm.transactionToolStripMenuItem.Enabled = true;
                            frm.searchToolStripMenuItem.Enabled = false;
                            frm.reportToolStripMenuItem.Enabled = false;
                            frm.userRegistrationToolStripMenuItem.Enabled = false;
                            frm.studentToolStripMenuItem1.Enabled = false;
                            frm.attendanceToolStripMenuItem1.Enabled = false;
                            frm.internalMarksEntryToolStripMenuItem1.Enabled = false;
                            frm.employeeToolStripMenuItem1.Enabled = false;
                            frm.salaryPaymentToolStripMenuItem.Enabled = true;
                            frm.feePaymentToolStripMenuItem1.Enabled = true;
                            frm.busFeePaymentToolStripMenuItem2.Enabled = true;
                            frm.feePaymentToolStripMenuItem.Enabled = true;
                            frm.employeeSalaryToolStripMenuItem.Enabled = true;
                            frm.hostelFeesPaymentToolStripMenuItem.Enabled = true;
                            frm.scholarshipPaymentToolStripMenuItem.Enabled = true;
                            frm.othersTransactionToolStripMenuItem.Enabled = true;
                        }
                    }
                

                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressBar1.Visible = false;
            cmbUsertype.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            return;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmChangePassword frm = new frmChangePassword();
            frm.Show();
            frm.txtUserName.Text = "";
            frm.txtNewPassword.Text = "";
            frm.txtOldPassword.Text = "";
            frm.txtConfirmPassword.Text = "";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRecoveryPassword frm = new frmRecoveryPassword();
            frm.txtEmail.Focus();
            frm.Show();
        }
    }
}

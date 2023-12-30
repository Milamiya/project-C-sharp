using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
namespace College_Management_System
{
    public partial class frmMainMenu : Form
    {
    
        public frmMainMenu()
        {
            InitializeComponent();
        }

      
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCourse frm = new frmCourse();
            if (UserType.Text == "Admin")
            {
               
                frm.label1.Text = UserType.Text;
           
                frm.Show();
            }
            else
            {
                
                frm.label1.Text = UserType.Text;
               
                frm.Show();
            }

          
        }

      

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAboutBox1 form2 = new frmAboutBox1();

            form2.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        frmContact form2 = new frmContact();
       
            form2.Show();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudent form2 = new frmStudent();
            if (UserType.Text == "Admin")
            {
              
          
                form2.label11.Text = UserType.Text;
              
                form2.Show();
            }
            else
            {
                

                form2.label11.Text = UserType.Text;
              
                form2.Show();
            }
            form2.label30.Text = User.Text;
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

      
       

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmDepartment frm = new frmDepartment();
            if (UserType.Text == "Admin")
            {
                frm.label1.Text = UserType.Text;
                frm.Show();
            }
            else
            {
                frm.label1.Text = UserType.Text;
                frm.Show();
            }
        }

        private void employeeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeeDetails form2 = new frmEmployeeDetails();
            form2.label21.Text = UserType.Text;
            form2.label23.Text = User.Text;
            form2.Show();
        }

        private void feesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
            frmFeesDetails frm = new frmFeesDetails();
            if (UserType.Text == "Admin")
            {
                frm.label13.Text = UserType.Text;
                frm.Show();
            }
            else
            {
                frm.label13.Text = UserType.Text;
                frm.Show();
            }
        }

        private void FeesMenu_Click(object sender, EventArgs e)
        {

        }

        private void feePaymentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeePaymentRecord1 form2 = new frmFeePaymentRecord1();
            form2.label13.Text = UserType.Text;
            form2.label14.Text = User.Text;
            form2.Show();
        }

        private void studentRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentRecord form2 = new frmStudentRecord();
            form2.txtStudent.Text = "";
            form2.dataGridView1.DataSource = null;
            form2.dataGridView2.DataSource = null;
            form2.dataGridView3.DataSource = null;
            form2.cmbCourse.Text = "";
            form2.cmbBranch.Text = "";
            form2.cmbSession.Text = "";
            form2.cmbSemester.Text = "";
            form2.cmbSection.Text = "";
            form2.DateFrom.Text = DateTime.Today.ToString();
            form2.DateTo.Text = DateTime.Today.ToString();
            form2.StudentName.Text = "";
            form2.cmbBranch.Enabled = false;
            form2.cmbSession.Enabled = false;
            form2.cmbSemester.Enabled = false;
            form2.cmbSection.Enabled = false;
            form2.label10.Text = UserType.Text;
            form2.label11.Text = User.Text;
            form2.Show();
        }

        private void feePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeesPayment form2 = new frmFeesPayment();
            form2.label23.Text = UserType.Text;
            form2.label24.Text = User.Text;
            form2.Show();
        }

       

        private void scholarshipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScholarship frm = new frmScholarship();
            if (UserType.Text == "Admin")
            {
                frm.label1.Text = UserType.Text;
                frm.Show();
            }
            else
            {
                frm.label1.Text = UserType.Text;
                frm.Show();
            }
        }

        private void othersTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frmOtherTransaction frm = new frmOtherTransaction();
            frm.label4.Text = UserType.Text;
            frm.Show();
        }

        private void scholarshipPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarshipPayment frm = new frmScholarshipPayment();
            frm.label5.Text = UserType.Text;
            frm.label6.Text = User.Text;
            frm.Show();
        }

        private void internalMarksEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternalMarksEntry frm = new frmInternalMarksEntry();
            this.Hide();
            frm.label5.Text = UserType.Text;
            frm.label6.Text = User.Text;
            frm.Show();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (UserType.Text == "Admin")
            {
               
                registrationToolStripMenuItem2.Enabled = true;
                studentDetailsToolStripMenuItem.Enabled = true;
                internalMarksEntryToolStripMenuItem.Enabled = true;
                hostelersToolStripMenuItem.Enabled = true;
                busHoldersToolStripMenuItem.Enabled = true;
                attendanceToolStripMenuItem.Enabled = true;
                registrationFormToolStripMenuItem.Enabled = true;
                Master_entryMenu.Enabled = true;
                usersToolStripMenuItem.Enabled = true;
                studentToolStripMenuItem.Enabled = true;
                employeeToolStripMenuItem.Enabled = true;
                transactionToolStripMenuItem.Enabled = true;
                searchToolStripMenuItem.Enabled = true;
                reportToolStripMenuItem.Enabled = true;
                userRegistrationToolStripMenuItem.Enabled = true;
                studentToolStripMenuItem1.Enabled = true;
                attendanceToolStripMenuItem1.Enabled = true;
                internalMarksEntryToolStripMenuItem1.Enabled = true;
                employeeToolStripMenuItem1.Enabled = true;
                salaryPaymentToolStripMenuItem.Enabled = true;
                feePaymentToolStripMenuItem1.Enabled = true;
                busFeePaymentToolStripMenuItem2.Enabled = true;
                feePaymentToolStripMenuItem.Enabled = true;
                employeeSalaryToolStripMenuItem.Enabled = true;
                hostelFeesPaymentToolStripMenuItem.Enabled = true;
                scholarshipPaymentToolStripMenuItem.Enabled = true;
                othersTransactionToolStripMenuItem.Enabled = true;

            }
            if (UserType.Text == "Admissions Officer")
            {
              
                registrationToolStripMenuItem2.Enabled = true;
                studentDetailsToolStripMenuItem.Enabled = true;
                internalMarksEntryToolStripMenuItem.Enabled = false;
                hostelersToolStripMenuItem.Enabled = false;
                busHoldersToolStripMenuItem.Enabled = false;
                attendanceToolStripMenuItem.Enabled = false;
                registrationFormToolStripMenuItem.Enabled = true;
                Master_entryMenu.Enabled = false;
                usersToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem.Enabled = true;
                employeeToolStripMenuItem.Enabled = false;
                transactionToolStripMenuItem.Enabled = false;
                searchToolStripMenuItem.Enabled = false;
                reportToolStripMenuItem.Enabled = false;
                userRegistrationToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem1.Enabled = true;
                attendanceToolStripMenuItem1.Enabled = false;
                internalMarksEntryToolStripMenuItem1.Enabled = false;
                employeeToolStripMenuItem1.Enabled = false;
                salaryPaymentToolStripMenuItem.Enabled = false;
                feePaymentToolStripMenuItem1.Enabled = false;
                busFeePaymentToolStripMenuItem2.Enabled = false;
                feePaymentToolStripMenuItem.Enabled = false;
                employeeSalaryToolStripMenuItem.Enabled = false;
                hostelFeesPaymentToolStripMenuItem.Enabled = false;
                scholarshipPaymentToolStripMenuItem.Enabled = false;
                othersTransactionToolStripMenuItem.Enabled = false;
            }
            if (UserType.Text == "Lecturer")
            {
              
                registrationToolStripMenuItem2.Enabled = false;
                studentDetailsToolStripMenuItem.Enabled = false;
                internalMarksEntryToolStripMenuItem.Enabled = false;
                hostelersToolStripMenuItem.Enabled = false;
                busHoldersToolStripMenuItem.Enabled = false;
                attendanceToolStripMenuItem.Enabled = false;
                registrationFormToolStripMenuItem.Enabled = false;
                Master_entryMenu.Enabled = false;
                usersToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem.Enabled = false;
                employeeToolStripMenuItem.Enabled = false;
                transactionToolStripMenuItem.Enabled = false;
                searchToolStripMenuItem.Enabled = false;
                reportToolStripMenuItem.Enabled = false;
                userRegistrationToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem1.Enabled = false;
                attendanceToolStripMenuItem1.Enabled = true;
                internalMarksEntryToolStripMenuItem1.Enabled = true;
                employeeToolStripMenuItem1.Enabled = false;
                salaryPaymentToolStripMenuItem.Enabled = false;
                feePaymentToolStripMenuItem1.Enabled = false;
                busFeePaymentToolStripMenuItem2.Enabled = false;
                feePaymentToolStripMenuItem.Enabled = false;
                employeeSalaryToolStripMenuItem.Enabled = false;
                hostelFeesPaymentToolStripMenuItem.Enabled = false;
                scholarshipPaymentToolStripMenuItem.Enabled = false;
                othersTransactionToolStripMenuItem.Enabled = false;
            }

            if (UserType.Text == "Accounts Officer")
            {
                
                registrationToolStripMenuItem2.Enabled = false;
                studentDetailsToolStripMenuItem.Enabled = false;
                internalMarksEntryToolStripMenuItem.Enabled = false;
                hostelersToolStripMenuItem.Enabled = false;
                busHoldersToolStripMenuItem.Enabled = false;
                attendanceToolStripMenuItem.Enabled = false;
                registrationFormToolStripMenuItem.Enabled = false;
                Master_entryMenu.Enabled = false;
                usersToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem.Enabled = false;
                employeeToolStripMenuItem.Enabled = false;
                transactionToolStripMenuItem.Enabled = true;
                searchToolStripMenuItem.Enabled = false;
                reportToolStripMenuItem.Enabled = false;
                userRegistrationToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem1.Enabled = false;
                attendanceToolStripMenuItem1.Enabled = false;
                internalMarksEntryToolStripMenuItem1.Enabled = false;
                employeeToolStripMenuItem1.Enabled = false;
                salaryPaymentToolStripMenuItem.Enabled = true;
                feePaymentToolStripMenuItem1.Enabled = true;
                busFeePaymentToolStripMenuItem2.Enabled = true;
                feePaymentToolStripMenuItem.Enabled = true;
                employeeSalaryToolStripMenuItem.Enabled = true;
                hostelFeesPaymentToolStripMenuItem.Enabled = true;
                scholarshipPaymentToolStripMenuItem.Enabled = true;
                othersTransactionToolStripMenuItem.Enabled = true;
            }
            Time.Text= DateTime.Now.ToString();
           
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void subjectInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectInfo frm = new frmSubjectInfo();
            if (UserType.Text == "Admin")
            {
                frm.label1.Text = UserType.Text;
                frm.Show();
            }
            else
            {
                frm.label1.Text = UserType.Text;
                frm.Show();
            }
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration frm = new frmUserRegistration();
            frm.Show();
            frm.label8.Text = UserType.Text;
            frm.label9.Text = User.Text;
            this.Hide();
        }

        private void loginDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginDetails frm = new frmLoginDetails();
            frm.Show();
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration frm = new frmUserRegistration();
            frm.Show();
            frm.label8.Text = UserType.Text;
            frm.label9.Text = User.Text;
            this.Hide();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeeDetails form2 = new frmEmployeeDetails();
            form2.label21.Text = UserType.Text;
            form2.label23.Text = User.Text;
            form2.Show();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }


     

        private void employeePaymentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalaryPaymentRecord frm = new frmSalaryPaymentRecord();
            frm.label1.Text = UserType.Text;
            frm.label3.Text = User.Text;
            frm.Show();
        }

        private void employeeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalaryPayment frm = new frmSalaryPayment();
            frm.label6.Text = UserType.Text;
            frm.label7.Text = User.Text;
            frm.Show();
        }

        private void wordpadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentDetailsReport frm = new frmStudentDetailsReport();
            frm.Course.Text = "";
            frm.Branch.Text = "";
            frm.Session.Text = "";
            frm.crystalReportViewer1.ReportSource = null;
            frm.DateFrom.Text = DateTime.Today.ToString();
            frm.DateTo.Text = DateTime.Today.ToString();
            frm.crystalReportViewer2.ReportSource = null;
            frm.label4.Text = User.Text;
            frm.label5.Text = UserType.Text;
          frm.Show();
        }

      
     

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrationReport frm = new frmRegistrationReport();
            frm.label1.Text = User.Text;
            frm.label2.Text = UserType.Text;
            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frmScholarshipPaymentReceiptRpt o1=new frmScholarshipPaymentReceiptRpt();
            o1.Hide();
            frmBusFeePaymentReceiptRpt o2 = new frmBusFeePaymentReceiptRpt();
            o1.Hide();
            frmHostelFeePaymentReceiptRpt o3 = new frmHostelFeePaymentReceiptRpt();
            o1.Hide();
            frmEventsReport o4 = new frmEventsReport();
            o1.Hide();
            frmTransportationReport o5 = new frmTransportationReport();
            o1.Hide();
            this.Hide();
            frm.cmbUsertype.Text = "";
            frm.txtUserName.Text = "";
            frm.txtPassword.Text = "";
            frm.cmbUsertype.Focus();
            frm.Show();


        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAttendance frm = new frmAttendance();
            if (UserType.Text == "Admin" || UserType.Text=="Employee")
            {


                frm.label11.Text = UserType.Text;

                frm.Show();
            }
            else
            {


                frm.label11.Text = UserType.Text;

                frm.Show();
            }
            frm.label12.Text = User.Text;
        }

        private void semesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSemester frm = new frmSemester();
            if (UserType.Text == "Admin")
            {


                frm.label1.Text = UserType.Text;

                frm.Show();
            }
            else
            {


                frm.label1.Text = UserType.Text;

                frm.Show();
            }
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSection frm = new frmSection();
            if (UserType.Text == "Admin")
            {


                frm.label1.Text = UserType.Text;

                frm.Show();
            }
            else
            {


                frm.label1.Text = UserType.Text;

                frm.Show();
            }
        }

        private void registrationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmStudentRegistration frm = new frmStudentRegistration();
          
            if (UserType.Text == "Admin")
            {


                frm.label1.Text = UserType.Text;

                frm.Show();
            }
            else
            {


                frm.label1.Text = UserType.Text;

                frm.Show();
            }
            frm.label8.Text = User.Text;
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrationForm frm = new frmRegistrationForm();
            frm.Show();
        }

        private void studentRegistrationRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentRegistrationRecord frm = new frmStudentRegistrationRecord();
            frm.label5.Text = UserType.Text;
            frm.label8.Text = User.Text;
            frm.Show();
        }

      

        private void studentAttendanceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAttendanceRecord frm = new frmAttendanceRecord();
            frm.label24.Text = UserType.Text;
            frm.label25.Text = User.Text;
            frm.Show();
        }

        private void employeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeeRecord frm = new frmEmployeeRecord();
            frm.dataGridView1.DataSource = null;
            frm.cmbEmployeeName.Text = "";
            frm.txtEmployeeName.Text = "";
            frm.dataGridView2.DataSource = null;
            frm.label1.Text = UserType.Text;
            frm.label2.Text = User.Text;
            frm.Show();
        }

        private void feePaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeesPaymentReport frm = new frmFeesPaymentReport();
            frm.label12.Text = User.Text;
            frm.label13.Text = UserType.Text;
            frm.Course.Text = "";
            frm.Branch.Text = "";
            frm.Date_from.Text = System.DateTime.Today.ToString();
            frm.Date_to.Text = System.DateTime.Today.ToString();
            frm.crystalReportViewer1.ReportSource = null;
            frm.ScholarNo.Text = "";
            frm.crystalReportViewer2.ReportSource = null;
            frm.PaymentDateFrom.Text = System.DateTime.Today.ToString();
            frm.PaymentDateTo.Text = System.DateTime.Today.ToString();
            frm.crystalReportViewer3.ReportSource = null;
            frm.DateFrom.Text = System.DateTime.Today.ToString();
            frm.DateTo.Text = System.DateTime.Today.ToString();
            frm.crystalReportViewer4.ReportSource = null;
            frm.dateTimePicker1.Text = System.DateTime.Today.ToString();
            frm.dateTimePicker2.Text = System.DateTime.Today.ToString();
            frm.crystalReportViewer5.ReportSource = null;
            frm.Show();
        }

        private void attendanceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAttendanceReport frm = new frmAttendanceReport();
            frm.label19.Text = User.Text;
            frm.label23.Text = UserType.Text;
            frm.cmbCourse.Text = "";
            frm.cmbBranch.Text = "";
            frm.cmbBranch.Enabled = false;
            frm.cmbSemester.Text = "";
            frm.cmbSemester.Enabled = false;
            frm.cmbSession.Text = "";
            frm.cmbSession.Enabled = false;
            frm.cmbSection.Text = "";
            frm.cmbSection.Enabled = false;
            frm.dateTimePicker1.Text = DateTime.Today.ToString();
            frm.dateTimePicker2.Text = DateTime.Today.ToString();
            frm.crystalReportViewer1.ReportSource = null;
            frm.cmbCourse1.Text = "";
            frm.cmbBranch1.Text = "";
            frm.cmbBranch1.Enabled = false;
            frm.cmbSemester1.Text = "";
            frm.cmbSemester1.Enabled = false;
            frm.cmbSession1.Text = "";
            frm.cmbSession1.Enabled = false;
            frm.cmbSection1.Text = "";
            frm.cmbSection1.Enabled = false;
            frm.cmbSubjectCode.Text = "";
            frm.cmbSubjectCode.Enabled = false;
            frm.txtSubjectName.Text = "";
            frm.txtSubjectName.ReadOnly = true;
            frm.dateTimePicker4.Text = DateTime.Today.ToString();
            frm.dateTimePicker3.Text = DateTime.Today.ToString();
            frm.crystalReportViewer2.ReportSource = null;
            frm.Show();
        }

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeeReport frm = new frmEmployeeReport();
            frm.label1.Text = User.Text;
            frm.label2.Text = UserType.Text;
            frm.Show();
        }

        private void otherTransactionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransactionRecord frm = new frmTransactionRecord();
            frm.label1.Text = UserType.Text;
            frm.label2.Text = User.Text;
            frm.Show();
        }

        private void othersTransactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTransactionReport frm = new frmTransactionReport();
            frm.label4.Text = User.Text;
            frm.label5.Text = UserType.Text;
            frm.DateFrom.Text = System.DateTime.Today.ToString();
            frm.DateTo.Text = System.DateTime.Today.ToString();
            frm.crystalReportViewer1.ReportSource = null;
            frm.dateTimePicker1.Text = System.DateTime.Today.ToString();
            frm.dateTimePicker2.Text = System.DateTime.Today.ToString(); ;
            frm.cmbTransactionType.Text = "";
            frm.crystalReportViewer2.ReportSource = null;
            frm.Show();
        }

        private void scholarshipPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarshipPaymentReport frm = new frmScholarshipPaymentReport();
            frm.label10.Text = User.Text;
            frm.label11.Text = UserType.Text;
            frm.Course.Text = "";
            frm.Branch.Text = "";
            frm.Date_from.Text = System.DateTime.Today.ToString();
            frm.Date_to.Text = System.DateTime.Today.ToString();
            frm.crystalReportViewer1.ReportSource = null;
            frm.ScholarNo.Text = "";
            frm.crystalReportViewer2.ReportSource = null;
            frm.PaymentDateFrom.Text = System.DateTime.Today.ToString();
            frm.PaymentDateTo.Text = System.DateTime.Today.ToString();
            frm.crystalReportViewer3.ReportSource = null;
            frm.DateFrom.Text = System.DateTime.Today.ToString();
            frm.DateTo.Text = System.DateTime.Today.ToString();
            frm.crystalReportViewer4.ReportSource = null;
            frm.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudent form2 = new frmStudent();
            if (UserType.Text == "Admin")
            {


                form2.label11.Text = UserType.Text;

                form2.Show();
            }
            else
            {


                form2.label11.Text = UserType.Text;

                form2.Show();
            }
            form2.label30.Text = User.Text;
        }

        private void studentsRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentsRegistrationReport frm = new frmStudentsRegistrationReport();
            frm.label5.Text = UserType.Text;
            frm.label8.Text = User.Text;
            frm.Show();
        }

        private void salaryPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmployeePaymentReport frm = new frmEmployeePaymentReport();
            frm.label1.Text = UserType.Text;
            frm.label3.Text = User.Text;
            frm.crystalReportViewer1.ReportSource = null;

            frm.cmbStaffName.Text = "";
            frm.crystalReportViewer2.ReportSource = null;
            frm.DateFrom.Text = DateTime.Today.ToString();
            frm.DateTo.Text = DateTime.Today.ToString();
            frm.Show();
        }

        private void internalMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternalMarksReport frm = new frmInternalMarksReport();
            this.Hide();
            frm.label6.Text = UserType.Text;
            frm.label7.Text = User.Text;
            frm.cmbCourse.Text = "";
            frm.cmbBranch.Text = "";
            frm.cmbBranch.Enabled = false;
            frm.cmbSemester.Text = "";
            frm.cmbSemester.Enabled = false;
            frm.cmbSession.Text = "";
            frm.cmbSession.Enabled = false;
            frm.cmbSection.Text = "";
            frm.cmbSection.Enabled = false;
            frm.cmbExam.Text = "";
            frm.cmbExam.Enabled = false;
            frm.crystalReportViewer1.ReportSource = null;
            frm.Show();
        }

        private void internalMarksEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInternalMarksEntry frm = new frmInternalMarksEntry();
            this.Hide();
            frm.label5.Text = UserType.Text;
            frm.label6.Text = User.Text;
            frm.Show();
        }

        private void scholarshipPaymentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScholarshipPaymentRecord frm = new frmScholarshipPaymentRecord();
            frm.label10.Text = UserType.Text;
            frm.label11.Text = User.Text;
            frm.Show();
        }

        private void feePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFeesPayment form2 = new frmFeesPayment();
            form2.label23.Text = UserType.Text;
            form2.label24.Text = User.Text;
            form2.Show();
        }

        private void attendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAttendance frm = new frmAttendance();
            if (UserType.Text == "Admin" || UserType.Text=="Employee")
            {


                frm.label11.Text = UserType.Text;

                frm.Show();
            }
            else
            {


                frm.label11.Text = UserType.Text;

                frm.Show();
            }
            frm.label12.Text = User.Text;
        }

        private void salaryPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmSalaryPayment frm = new frmSalaryPayment();
            frm.label6.Text = UserType.Text;
            frm.label7.Text = User.Text;
            frm.Show();
        }


        private void hostelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmHostel frm = new frmHostel();
            if (UserType.Text == "Admin")
            {
                frm.label1.Text = UserType.Text;
                frm.Show();
            }
            else
            {
                frm.label1.Text = UserType.Text;
                frm.Show();
            }
        }

        private void hostelFeesPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelFeePayment frm = new frmHostelFeePayment();
            frm.label3.Text = UserType.Text;
            frm.label4.Text = User.Text;
            frm.Show();
        }

      

        private void studentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDetailsRpt frm = new frmStudentDetailsRpt();
            frm.Show();
        }

        private void feeReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCourseFeePaymentReceipt frm = new frmCourseFeePaymentReceipt();
            frm.Show();
        }

        private void salarySlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalarySlipRpt frm = new frmSalarySlipRpt();
            frm.Show();
        }

        private void feesDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFeeDetailsReport frm = new frmFeeDetailsReport();
            frm.Show();
        }

        private void hostelersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHostelers frm = new frmHostelers();
          
            if (UserType.Text == "Admin")
            {
                frm.label3.Text = UserType.Text;
                frm.Show();
            }
            else
            {
                frm.label3.Text = UserType.Text;
                frm.Show();
            }
        }

        private void hostelersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelersRecord1 frm = new frmHostelersRecord1();
            frm.label5.Text = UserType.Text;
            frm.label13.Text = User.Text;
            frm.Show();
        }

        private void hostlersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelersReport frm = new frmHostelersReport();
            frm.label5.Text = UserType.Text;
            frm.label13.Text = User.Text;
            frm.Show();
        }

        private void hostelFeePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelFeePaymentRecord frm = new frmHostelFeePaymentRecord();
            frm.label13.Text = UserType.Text;
            frm.label14.Text = User.Text;
            frm.Show();
        }

        private void hostelFeePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHostelFeePaymentReport frm = new frmHostelFeePaymentReport();
            frm.label12.Text = UserType.Text;
            frm.label13.Text = User.Text;
            frm.Show();
        }

        private void scholarshipPaymentReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScholarshipPaymentReceiptRpt frm = new frmScholarshipPaymentReceiptRpt();
            frm.Show();
        }

        private void hostelFeePaymentReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHostelFeePaymentReceiptRpt frm = new frmHostelFeePaymentReceiptRpt();
            frm.Show();
        }

       

        private void transportationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransportation frm = new frmTransportation();
            if (UserType.Text == "Admin")
            {


                frm.label1.Text = UserType.Text;

                frm.Show();
            }
            else
            {


                frm.label1.Text = UserType.Text;

                frm.Show();
            }
        }

        private void transportationChargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransportationReport frm = new frmTransportationReport();
            frm.Show();
        }

        private void busHoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusHolders frm = new frmBusHolders();

            if (UserType.Text == "Admin")
            {
                frm.label3.Text = UserType.Text;
                frm.Show();
            }
            else
            {
                frm.label3.Text = UserType.Text;
                frm.Show();
            }
        }

        private void busHoldersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusHoldersRecord frm = new frmBusHoldersRecord();
            frm.label5.Text = UserType.Text;
            frm.label13.Text = User.Text;
            frm.Show();
        }

        private void busFeePaymentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusFeePayment frm = new frmBusFeePayment();
            frm.label3.Text = UserType.Text;
            frm.label4.Text = User.Text;
            frm.Show();
        }

        private void busFeePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusFeePaymentRecord frm = new frmBusFeePaymentRecord();
            frm.label13.Text = UserType.Text;
            frm.label14.Text = User.Text;
            frm.Show();
        }

        private void busHoldersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusHoldersReport frm = new frmBusHoldersReport();
            frm.label5.Text = UserType.Text;
            frm.label13.Text = User.Text;
            frm.Show();
        }

        private void busFeePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBusFeePaymentReport frm = new frmBusFeePaymentReport();
            frm.label12.Text = UserType.Text;
            frm.label13.Text = User.Text;
            frm.Show();
        }

        private void busFeePaymentReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusFeePaymentReceiptRpt frm = new frmBusFeePaymentReceiptRpt();
            frm.Show();
        }

        private void subjectInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSubjectInfoReport frm = new frmSubjectInfoReport();
            frm.Show();
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvent frm = new frmEvent();
            if (UserType.Text == "Admin")
            {

                frm.label6.Text = UserType.Text;

                frm.Show();
            }
            else
            {

                frm.label6.Text = UserType.Text;

                frm.Show();
            }

        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatch frm = new frmBatch();
            if (UserType.Text == "Admin")
            {
                frm.label6.Text = UserType.Text;
                frm.Show();
            }
            else
            {

                frm.label6.Text = UserType.Text;
                frm.Show();
            }
        }

      

        private void EventtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEventsReport frm = new frmEventsReport();
            frm.Show();
        }

       

    }
          
}

      

     

       
      

      

      

      

       

      


       

       
   


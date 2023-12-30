using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
namespace College_Management_System
{
    public partial class frmEmployeeRecord : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

       

        public frmEmployeeRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select RTrim(StaffID)[Staff ID], RTRIM(StaffName)[Staff Name], RTRIM(Department)[Department], RTRIM(Gender)[Gender],RTRIM(DOB)[DOB], RTRIM(FatherName)[Father's Name], RTRIM(PermanentAddress)[Permanent Address],RTRIM(TemporaryAddress)[Temporary Address], RTRIM(PhoneNo)[Phone No.], RTRIM(MobileNo)[Mobile No.],RTRIM(DateOfJoining)[Date Of Joining],RTRIM(Qualification)[Qualifications],RTRIM(YearOfExperience)[Year Of  Experience], RTRIM(Designation)[Designation], RTRIM(Email)[Email], RTRIM(BasicSalary)[Basic Salary], RTRIM(LIC)[LIC], RTRIM(IncomeTax)[IncomeTax], RTRIM(GroupInsurance)[Group Insurance], RTRIM(FamilyBenefitFund)[Family Benefit Fund], RTRIM(Loans)[Loans], RTRIM(OtherDeductions)[Other Deductions], (Picture)[Picture] from employee order by Staffname", con);


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Employee");

                dataGridView1.DataSource = myDataSet.Tables["Employee"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;
                xlApp.Columns[3].Cells.NumberFormat = "@";
                rowsTotal = dataGridView1.RowCount - 1;
                colsTotal = dataGridView1.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView1.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

        }

      

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select RTrim(StaffID)[Staff ID], RTRIM(StaffName)[Staff Name], RTRIM(Department)[Department], RTRIM(Gender)[Gender],RTRIM(DOB)[DOB], RTRIM(FatherName)[Father's Name], RTRIM(PermanentAddress)[Permanent Address],RTRIM(TemporaryAddress)[Temporary Address], RTRIM(PhoneNo)[Phone No.], RTRIM(MobileNo)[Mobile No.],RTRIM(DateOfJoining)[Date Of Joining],RTRIM(Qualification)[Qualifications],RTRIM(YearOfExperience)[Year Of  Experience], RTRIM(Designation)[Designation], RTRIM(Email)[Email], RTRIM(BasicSalary)[Basic Salary], RTRIM(LIC)[LIC], RTRIM(IncomeTax)[IncomeTax], RTRIM(GroupInsurance)[Group Insurance], RTRIM(FamilyBenefitFund)[Family Benefit Fund], RTRIM(Loans)[Loans], RTRIM(OtherDeductions)[Other Deductions], (Picture)[Picture] from employee where StaffName ='" + cmbEmployeeName.Text + "' order by StaffName", con);


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Employee");

                dataGridView2.DataSource = myDataSet.Tables["Employee"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.DataSource == null)
            {
                MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
            Excel.Application xlApp = new Excel.Application();

            try
            {
                Excel.Workbook excelBook = xlApp.Workbooks.Add();
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
                xlApp.Visible = true;
                xlApp.Columns[3].Cells.NumberFormat = "@";
                rowsTotal = dataGridView2.RowCount - 1;
                colsTotal = dataGridView2.Columns.Count - 1;
                var _with1 = excelWorksheet;
                _with1.Cells.Select();
                _with1.Cells.Delete();
                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _with1.Cells[1, iC + 1].Value = dataGridView2.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _with1.Cells[I + 2, j + 1].value = dataGridView2.Rows[I].Cells[j].Value;
                    }
                }
                _with1.Rows["1:1"].Font.FontStyle = "Bold";
                _with1.Rows["1:1"].Font.Size = 12;

                _with1.Cells.Columns.AutoFit();
                _with1.Cells.Select();
                _with1.Cells.EntireColumn.AutoFit();
                _with1.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //RELEASE ALLOACTED RESOURCES
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
                xlApp = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbEmployeeName.Text = "";
            txtEmployeeName.Text = "";
            dataGridView2.DataSource=null;
        }

        private void txtEmployeeName_TextChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select RTrim(StaffID)[Staff ID], RTRIM(StaffName)[Staff Name], RTRIM(Department)[Department], RTRIM(Gender)[Gender],RTRIM(DOB)[DOB], RTRIM(FatherName)[Father's Name], RTRIM(PermanentAddress)[Permanent Address],RTRIM(TemporaryAddress)[Temporary Address], RTRIM(PhoneNo)[Phone No.], RTRIM(MobileNo)[Mobile No.],RTRIM(DateOfJoining)[Date Of Joining],RTRIM(Qualification)[Qualifications],RTRIM(YearOfExperience)[Year Of  Experience], RTRIM(Designation)[Designation], RTRIM(Email)[Email], RTRIM(BasicSalary)[Basic Salary], RTRIM(LIC)[LIC], RTRIM(IncomeTax)[IncomeTax], RTRIM(GroupInsurance)[Group Insurance], RTRIM(FamilyBenefitFund)[Family Benefit Fund], RTRIM(Loans)[Loans], RTRIM(OtherDeductions)[Other Deductions], (Picture)[Picture] from employee where StaffName like '" + cmbEmployeeName.Text + "%' order by StaffName", con);


                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "Employee");

                dataGridView2.DataSource = myDataSet.Tables["Employee"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            cmbEmployeeName.Text = "";
            txtEmployeeName.Text = "";
            dataGridView2.DataSource = null;
        }
        private void AutocompleteStaffName()
        {

            try
            {
              
                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(StaffName) FROM Employee", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbEmployeeName.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbEmployeeName.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmEmployeeRecord_Load(object sender, EventArgs e)
        {
            AutocompleteStaffName();
        }

     

        private void frmEmployeeRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu frm = new frmMainMenu();
            this.Hide();
            frm.UserType.Text = label1.Text;
            frm.User.Text = label2.Text;
            frm.Show();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView2.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView2.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

      

        
    }
}

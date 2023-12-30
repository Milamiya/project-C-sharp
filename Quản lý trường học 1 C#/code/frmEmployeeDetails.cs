using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
namespace College_Management_System
{
    public partial class frmEmployeeDetails : Form
    {

        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();



        public frmEmployeeDetails()
        {
            InitializeComponent();
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
            txtStaffID.Text = "E-" + GetUniqueKey(6);
        }
        private void delete_records()
        {

            try
            {


                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct = "select StaffID from Attendance where StaffID=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "StaffID"));


                cmd.Parameters["@find"].Value = txtStaffID.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string cm = "select StaffID from EmployeePayment where StaffID=@find";


                cmd = new SqlCommand(cm);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 15, "StaffID"));


                cmd.Parameters["@find"].Value = txtStaffID.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
              
                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from Employee where StaffID=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.NChar, 15, "StaffID"));


                cmd.Parameters["@DELETE1"].Value = txtStaffID.Text;
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                    clear();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    clear();

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
        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

            try
            {

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(departmentname) FROM department", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                lbDepartment.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    lbDepartment.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EmployeeDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmMainMenu form2 = new frmMainMenu();
            form2.UserType.Text = label21.Text;
            form2.User.Text = label23.Text;
            form2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbDepartment.Visible = true;
            lbDepartment.SelectedIndex = -1;
        }

        private void Department_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                for (int i = 0; i < this.lbDepartment.Items.Count; i++)
                {
                    this.lbDepartment.SelectedIndex = i;
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                lbDepartment.Text = "";
                foreach (object lstbxitem in this.lbDepartment.SelectedItems)
                {

                    txtDepartment.Text += lstbxitem + "" + ",";

                }
                lbDepartment.Visible = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
            if (txtStaffName.Text == "")
            {
                MessageBox.Show("Please enter staff name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStaffName.Focus();
                return;
            }
            if (cmbGender.Text == "")
            {
                MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbGender.Focus();
                return;
            }
            if (DOB.Text == "")
            {
                MessageBox.Show("Please enter DOB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DOB.Focus();
                return;
            }
            if (txtFatherName.Text == "")
            {
                MessageBox.Show("Please enter father's name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFatherName.Focus();
                return;
            }
            if (txtPAddress.Text == "")
            {
                MessageBox.Show("Please enter permanent address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPAddress.Focus();
                return;
            }
            if (txtTAddress.Text == "")
            {
                MessageBox.Show("Please enter temporary address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTAddress.Focus();
                return;
            }
            if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Please enter phone no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }
            if (txtMobileNo.Text == "")
            {
                MessageBox.Show("Please enter mobile no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMobileNo.Focus();
                return;
            }
          
            if (txtDepartment.Text == "")
            {
                MessageBox.Show("Please select department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartment.Focus();
                return;
            }
            if (txtQualifications.Text == "")
            {
                MessageBox.Show("Please enter qualifications", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQualifications.Focus();
                return;
            }
            if (txtYOP.Text == "")
            {
                MessageBox.Show("Please enter year of experience", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYOP.Focus();
                return;
            }
            if (txtDesignation.Text == "")
            {
                MessageBox.Show("Please enter staff designation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesignation.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (txtBasicSalary.Text == "")
            {
                MessageBox.Show("Please enter basic salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBasicSalary.Focus();
                return;
            }
          
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please browse & select photo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Browse.Focus();
                return;
            }


                auto();
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into Employee(Staffid,staffname,department,gender,fathername,permanentaddress,temporaryaddress,phoneno,mobileno,dateofjoining,qualification,yearofexperience,designation,email,Basicsalary,lic,groupinsurance,familybenefitfund,loans,otherdeductions,IncomeTax,picture,DOB) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13,@d14,@d15,@d16,@d17,@d18,@d19,@d20,@d21,@d22,@d23)";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "Staffid"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Staffname"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.VarChar, 100, "department"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "gender"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 30, "fathername"));

                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.VarChar, 100, "permanentaddress"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 100, "temporaryaddress"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 10, "Phoneno"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 10, "mobileno"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 30, "dateofjoining"));

                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 70, "qualiication"));

                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.Int, 10, "yearofexperience"));

                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.VarChar, 100, "designation"));

                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.NChar, 30, "email"));

                cmd.Parameters.Add(new SqlParameter("@d15", System.Data.SqlDbType.Int, 10, "basicsalary"));

                cmd.Parameters.Add(new SqlParameter("@d16", System.Data.SqlDbType.Int, 10, "lic"));
                cmd.Parameters.Add(new SqlParameter("@d17", System.Data.SqlDbType.Int, 10, "groupinsurance"));
                cmd.Parameters.Add(new SqlParameter("@d18", System.Data.SqlDbType.Int, 10, "familybenefitfund"));
                cmd.Parameters.Add(new SqlParameter("@d19", System.Data.SqlDbType.Int, 10, "loans"));
                cmd.Parameters.Add(new SqlParameter("@d20", System.Data.SqlDbType.Int, 10, "otherdeductions"));
                cmd.Parameters.Add(new SqlParameter("@d21", System.Data.SqlDbType.Int, 10, "incometax"));
                cmd.Parameters.Add(new SqlParameter("@d23", System.Data.SqlDbType.NChar, 20, "DOB"));

                cmd.Parameters["@d1"].Value = txtStaffID.Text;
                cmd.Parameters["@d2"].Value = txtStaffName.Text;
                cmd.Parameters["@d3"].Value = txtDepartment.Text;
                cmd.Parameters["@d4"].Value = cmbGender.Text;
                cmd.Parameters["@d5"].Value = txtFatherName.Text;
                cmd.Parameters["@d6"].Value = txtPAddress.Text;
                cmd.Parameters["@d7"].Value = txtTAddress.Text;
                cmd.Parameters["@d8"].Value =  txtPhoneNo.Text;
                cmd.Parameters["@d9"].Value =  txtMobileNo.Text;
                cmd.Parameters["@d10"].Value = dtpDateOfJoining.Text;
                cmd.Parameters["@d11"].Value = txtQualifications.Text;
                cmd.Parameters["@d12"].Value = Convert.ToInt16(txtYOP.Text);
                cmd.Parameters["@d13"].Value = txtDesignation.Text;
                cmd.Parameters["@d14"].Value = txtEmail.Text;
                cmd.Parameters["@d15"].Value =  Convert.ToInt32(txtBasicSalary.Text);
                if (txtLIC.Text == "")
                {
                    cmd.Parameters["@d16"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d16"].Value = Convert.ToInt32(txtLIC.Text);
                
                }
                if (txtGrpInsurance.Text == "")
                {
                    cmd.Parameters["@d17"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d17"].Value = Convert.ToInt32(txtGrpInsurance.Text);
                }
                if (txtFamilyBenefitFund.Text == "")
                {
                    cmd.Parameters["@d18"].Value = 0;
                }
                else
                {
                cmd.Parameters["@d18"].Value = Convert.ToInt32(txtFamilyBenefitFund.Text);
                }
                if (txtLoans.Text == "")
                {
                    cmd.Parameters["@d19"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d19"].Value = Convert.ToInt32(txtLoans.Text);
                }
                if (txtOtherDeductions.Text == "")
                {
                    cmd.Parameters["@d20"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d20"].Value = Convert.ToInt32(txtOtherDeductions.Text);
                }
                if (txtIncomeTax.Text == "")
                {
                    cmd.Parameters["@d21"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d21"].Value = Convert.ToInt32(txtIncomeTax.Text);
                }
                cmd.Parameters["@d23"].Value = DOB.Text;
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);

                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d22", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                btnSave.Enabled = false;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void clear()
        {
            txtBasicSalary.Text = "";
            txtDepartment.Text = "";
            txtDesignation.Text = "";
            txtEmail.Text = "";
            cmbGender.Text = "";
            txtFamilyBenefitFund.Text = "";
            txtFatherName.Text = "";
            txtGrpInsurance.Text = "";
            txtIncomeTax.Text = "";
            txtLIC.Text = "";
            txtLoans.Text = "";
            txtMobileNo.Text = "";
            txtOtherDeductions.Text = "";
            txtPAddress.Text = "";
            txtPhoneNo.Text = "";
            txtQualifications.Text = "";
            txtStaffName.Text = "";
            txtTAddress.Text = "";
            txtYOP.Text = "";
            DOB.Text = "";
            txtStaffID.Text = "";
            dtpDateOfJoining.Text = System.DateTime.Today.ToString();
            lbDepartment.Visible = false;
            pictureBox1.Image = Properties.Resources.photo;
            btnSave.Enabled = true;
            Delete.Enabled = false;
            Update_record.Enabled = false;
           
        }
        private void NewRecord_Click(object sender, EventArgs e)
        {
            clear();
          
        }

        private void Update_record_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update Employee set staffname=@d2,department=@d3,gender=@d4,fathername=@d5,permanentaddress=@d6,temporaryaddress=@d7,phoneno=@d8,mobileno=@d9,dateofjoining=@d10,qualification=@d11,yearofexperience=@d12,designation=@d13,email=@d14,Basicsalary=@d15,lic=@d16,groupinsurance=@d17,familybenefitfund=@d18,loans=@d19,otherdeductions=@d20,IncomeTax=@d21,picture=@d22,DOB=@d23 where staffid=@d1";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 15, "Staffid"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Staffname"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.VarChar, 100, "department"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "gender"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.NChar, 30, "fathername"));

                cmd.Parameters.Add(new SqlParameter("@d6", System.Data.SqlDbType.VarChar, 100, "permanentaddress"));

                cmd.Parameters.Add(new SqlParameter("@d7", System.Data.SqlDbType.VarChar, 100, "temporaryaddress"));

                cmd.Parameters.Add(new SqlParameter("@d8", System.Data.SqlDbType.NChar, 10, "Phoneno"));

                cmd.Parameters.Add(new SqlParameter("@d9", System.Data.SqlDbType.NChar, 10, "mobileno"));

                cmd.Parameters.Add(new SqlParameter("@d10", System.Data.SqlDbType.NChar, 30, "dateofjoining"));

                cmd.Parameters.Add(new SqlParameter("@d11", System.Data.SqlDbType.NChar, 70, "qualiication"));

                cmd.Parameters.Add(new SqlParameter("@d12", System.Data.SqlDbType.Int, 10, "yearofexperience"));

                cmd.Parameters.Add(new SqlParameter("@d13", System.Data.SqlDbType.VarChar, 100, "designation"));

                cmd.Parameters.Add(new SqlParameter("@d14", System.Data.SqlDbType.NChar, 30, "email"));

                cmd.Parameters.Add(new SqlParameter("@d15", System.Data.SqlDbType.Int, 10, "basicsalary"));

                cmd.Parameters.Add(new SqlParameter("@d16", System.Data.SqlDbType.Int, 10, "lic"));
                cmd.Parameters.Add(new SqlParameter("@d17", System.Data.SqlDbType.Int, 10, "groupinsurance"));
                cmd.Parameters.Add(new SqlParameter("@d18", System.Data.SqlDbType.Int, 10, "familybenefitfund"));
                cmd.Parameters.Add(new SqlParameter("@d19", System.Data.SqlDbType.Int, 10, "loans"));
                cmd.Parameters.Add(new SqlParameter("@d20", System.Data.SqlDbType.Int, 10, "otherdeductions"));
                cmd.Parameters.Add(new SqlParameter("@d21", System.Data.SqlDbType.Int, 10, "incometax"));
                cmd.Parameters.Add(new SqlParameter("@d23", System.Data.SqlDbType.NChar, 20, "DOB"));

                cmd.Parameters["@d1"].Value = txtStaffID.Text;
                cmd.Parameters["@d2"].Value = txtStaffName.Text;
                cmd.Parameters["@d3"].Value = txtDepartment.Text;
                cmd.Parameters["@d4"].Value = cmbGender.Text;
                cmd.Parameters["@d5"].Value = txtFatherName.Text;
                cmd.Parameters["@d6"].Value = txtPAddress.Text;
                cmd.Parameters["@d7"].Value = txtTAddress.Text;
                cmd.Parameters["@d8"].Value = txtPhoneNo.Text;
                cmd.Parameters["@d9"].Value = txtMobileNo.Text;
                cmd.Parameters["@d10"].Value = dtpDateOfJoining.Text;
                cmd.Parameters["@d11"].Value = txtQualifications.Text;
                cmd.Parameters["@d12"].Value = Convert.ToInt16(txtYOP.Text);
                cmd.Parameters["@d13"].Value = txtDesignation.Text;
                cmd.Parameters["@d14"].Value = txtEmail.Text;
                cmd.Parameters["@d15"].Value = Convert.ToInt32(txtBasicSalary.Text);
                if (txtLIC.Text == "")
                {
                    cmd.Parameters["@d16"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d16"].Value = Convert.ToInt32(txtLIC.Text);

                }
                if (txtGrpInsurance.Text == "")
                {
                    cmd.Parameters["@d17"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d17"].Value = Convert.ToInt32(txtGrpInsurance.Text);
                }
                if (txtFamilyBenefitFund.Text == "")
                {
                    cmd.Parameters["@d18"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d18"].Value = Convert.ToInt32(txtFamilyBenefitFund.Text);
                }
                if (txtLoans.Text == "")
                {
                    cmd.Parameters["@d19"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d19"].Value = Convert.ToInt32(txtLoans.Text);
                }
                if (txtOtherDeductions.Text == "")
                {
                    cmd.Parameters["@d20"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d20"].Value = Convert.ToInt32(txtOtherDeductions.Text);
                }
                if (txtIncomeTax.Text == "")
                {
                    cmd.Parameters["@d21"].Value = 0;
                }
                else
                {
                    cmd.Parameters["@d21"].Value = Convert.ToInt32(txtIncomeTax.Text);
                }
                cmd.Parameters["@d23"].Value = DOB.Text;
                MemoryStream ms = new MemoryStream();
                Bitmap bmpImage = new Bitmap(pictureBox1.Image);

                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                byte[] data = ms.GetBuffer();
                SqlParameter p = new SqlParameter("@d22", SqlDbType.Image);
                p.Value = data;
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated", "Employee Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Update_record.Enabled = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbDepartment.Visible = true;
            lbDepartment.SelectedIndex = -1;
        }

        private void Browse_Click(object sender, EventArgs e)
        {

            var _with1 = openFileDialog1;

            _with1.Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif; *.ico");
            _with1.FilterIndex = 4;

            //Clear the file name
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void txtStaffName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void cmbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        private void txtYOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.clear();
            frmEmployeeRecord1 frm = new frmEmployeeRecord1();
            frm.dataGridView1.DataSource = null;
            frm.cmbEmployeeName.Text = "";
            frm.txtEmployeeName.Text = "";
            frm.dataGridView2.DataSource = null;
            frm.label1.Text = label21.Text;
            frm.label2.Text = label23.Text;
            frm.Show();
        }

        private void txtBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtLIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtIncomeTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtGrpInsurance_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtFamilyBenefitFund_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtLoans_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtOtherDeductions_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

      
        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();


            }
        }
      
    }
}
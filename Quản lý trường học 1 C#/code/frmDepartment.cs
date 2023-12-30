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
    public partial class frmDepartment : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;

        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();


        public frmDepartment()
        {
            InitializeComponent();
        }

      

        private void NewRecord_Click(object sender, EventArgs e)
        {
            txtDepartmentID.Text = "";
            txtDepartmentName.Text = "";
          
            txtDepartmentID.Focus();
         
            btnDelete.Enabled = false;
            btnUpdate_record.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (txtDepartmentName.Text == "")
            {
                MessageBox.Show("Please enter department name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartmentName.Focus();
                return;
            }
           
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select DepartmentName from Department where DepartmentName= '"+ txtDepartmentName.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
              
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Department Name Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDepartmentName.Text = "";
                    txtDepartmentName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into department(departmentname) VALUES (@d2)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

              
                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "departmentname"));




                cmd.Parameters["@d2"].Value = txtDepartmentName.Text.Trim();
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
              private void Autocomplete()
           {
                  try{

            con = new SqlConnection(cs.DBConn);
            con.Open();


            SqlCommand cmd = new SqlCommand("SELECT  distinct departmentname FROM department", con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Department");


            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            int i = 0;
            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                col.Add(ds.Tables[0].Rows[i]["departmentname"].ToString());

            }
             txtDepartmentName.AutoCompleteSource = AutoCompleteSource.CustomSource;
             txtDepartmentName.AutoCompleteCustomSource = col;
             txtDepartmentName.AutoCompleteMode = AutoCompleteMode.Suggest;

            con.Close();
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

              private void frmDepartment_Load(object sender, EventArgs e)
              {
                  Autocomplete();
              }

           
              private void GetDetails_Click(object sender, EventArgs e)
              {
                  this.Hide();
                  frmDepartmentRecord frm = new frmDepartmentRecord();
                  frm.label1.Text = label1.Text;
                  frm.Show();

              }

              private void Delete_Click(object sender, EventArgs e)
              {
                    
            if (txtDepartmentID.Text == "")
            {
                MessageBox.Show("Please enter department id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartmentID.Focus();
                return;
            }
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();


            }
        }
        private void delete_records()
        {

            try
            {

                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct = "select Department from Employee where Department=@find";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "Department"));


                cmd.Parameters["@find"].Value = txtDepartmentName.Text;


                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDepartmentID.Text = "";
                    txtDepartmentName.Text = "";

                    txtDepartmentID.Focus();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                int RowsAffected = 0;

                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from department where departmentid=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "departmentid"));


                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(txtDepartmentID.Text);
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDepartmentID.Text = "";
                     txtDepartmentName.Text = "";
          
                     txtDepartmentID.Focus();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtDepartmentID.Text = "";
                    txtDepartmentName.Text = "";

                    txtDepartmentID.Focus();
                    btnDelete.Enabled = false;
                    btnUpdate_record.Enabled = false;
                    Autocomplete();
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

        private void Update_record_Click(object sender, EventArgs e)
        {
            try{
              con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update department set departmentname=@d2 where departmentid=@d1";
                    

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "departmentid"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "departmentname"));




                cmd.Parameters["@d1"].Value = Convert.ToInt32(txtDepartmentID.Text);
                cmd.Parameters["@d2"].Value = txtDepartmentName.Text.Trim();
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate_record.Enabled = false;
                Autocomplete();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DepartmentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDepartmentRecord frm = new frmDepartmentRecord();
            frm.label1.Text = label1.Text;
            frm.Show();

        }

        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {
            txtDepartmentName.Text = txtDepartmentName.Text.Trim();
        
        }

     }
  }
   


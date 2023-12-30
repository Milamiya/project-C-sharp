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
    public partial class frmSection : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

      
        public frmSection()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            txtSectionID.Text = "";
            txtSectionName.Text = "";
            cmbCourse.Text = "";
            cmbBranch.Text = "";
            cmbBranch.Enabled = false;
            txtSectionName.Focus();
        }
        public void AutocompleteCourse()
        {

            try
            {
               
                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Coursename) FROM course", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                cmbCourse.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    cmbCourse.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmSection_Load(object sender, EventArgs e)
        {
            Autocomplete();
            AutocompleteCourse();
        }
        private void Autocomplete()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();


                SqlCommand cmd = new SqlCommand("SELECT Sectionname FROM Section", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Section");


                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["Sectionname"].ToString());

                }
                txtSectionName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtSectionName.AutoCompleteCustomSource = col;
                txtSectionName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (txtSectionName.Text == "")
            {
                MessageBox.Show("Please enter section name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSectionName.Focus();
                return;
            }
            if (cmbCourse.Text == "")
            {
                MessageBox.Show("Please select course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCourse.Focus();
                return;
            }
            if (cmbBranch.Text == "")
            {
                MessageBox.Show("Please select branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBranch.Focus();
                return;
            }
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select SectionName,Course,Branch from Section where SectionName= '" + txtSectionName.Text + "' and Course = '" + cmbCourse.Text + "' and branch= '" + cmbBranch.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Record Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSectionName.Text = "";
                    cmbCourse.Text = "";
                    cmbBranch.Text = "";
                    cmbBranch.Enabled = false;
                    txtSectionName.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into section(sectionname,course,branch) VALUES (@d2,@d3,@d4)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

  

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 10, "sectionname"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 20, "course"));
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 30, "branch"));

                cmd.Parameters["@d2"].Value = txtSectionName.Text.Trim();
                cmd.Parameters["@d3"].Value = cmbCourse.Text.Trim();
                cmd.Parameters["@d4"].Value = cmbBranch.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Autocomplete();
                con.Close();
                btnSave.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            cmbBranch.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
               
                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update section set sectionname=@d2,course=@d3,branch=@d4 where sectionid=@d1";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "sectionid"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 10, "sectionname"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 20, "course"));
                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 30, "branch"));

                cmd.Parameters["@d1"].Value = Convert.ToInt32(txtSectionID.Text);
                cmd.Parameters["@d2"].Value = txtSectionName.Text.Trim();
                cmd.Parameters["@d3"].Value = cmbCourse.Text.Trim();
                cmd.Parameters["@d4"].Value = cmbBranch.Text.Trim();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Autocomplete();
                con.Close();
                btnUpdate.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSectionID.Text == "")
            {
                MessageBox.Show("Please enter section id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSectionID.Focus();
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


                int RowsAffected = 0;
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct = "select section from Student where section= '" + txtSectionName.Text + "'";


                cmd = new SqlCommand(ct);

                cmd.Connection = con;
               rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(cs.DBConn);

                con.Open();
                string ct1 = "select section from Attendance where Section= '" + txtSectionName.Text + "'";


                cmd = new SqlCommand(ct1);

                cmd.Connection = con;
               

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Unable to delete..Already in use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Reset();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }

                con = new SqlConnection(cs.DBConn);

                con.Open();


                string cq = "delete from section where sectionid=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "SectionID"));


                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(txtSectionID.Text);
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    Autocomplete();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Reset();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
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

        private void btnGetData_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSectionRecord frm = new frmSectionRecord();
            frm.label1.Text = label1.Text;
            frm.Show();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBranch.Items.Clear();
            cmbBranch.Text = "";
            cmbBranch.Enabled = true;
            cmbBranch.Focus();

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(branchname) from course where coursename = '" + cmbCourse.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbBranch.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSectionRecord frm = new frmSectionRecord();
            frm.label1.Text = label1.Text;
            frm.Show();
        }

        private void txtSectionName_TextChanged(object sender, EventArgs e)
        {
            txtSectionName.Text = txtSectionName.Text.Trim();
        }
    }
}

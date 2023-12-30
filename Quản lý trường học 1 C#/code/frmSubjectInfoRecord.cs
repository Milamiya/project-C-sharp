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
namespace College_Management_System
{
    public partial class frmSubjectInfoRecord : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        SqlDataAdapter adp;
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

       

        public frmSubjectInfoRecord()
        {
            InitializeComponent();
        }

        private void frmSubjectInfoRecord_Load(object sender, EventArgs e)
        {
            AutocompleteCourse();
            AutocompleteSemester();
            AutocompleteBranchName();
        }
        private void AutocompleteCourse()
        {

            try
            {


                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(CourseName) FROM SubjectInfo", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                Course.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    Course.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AutocompleteSemester()
        {

            try
            {
               

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(Semester) FROM SubjectInfo", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                Semester.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    Semester.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AutocompleteBranchName()
        {

            try
            {
               

                SqlConnection CN = new SqlConnection(cs.DBConn);

                CN.Open();
                adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand("SELECT distinct RTRIM(branch) FROM Subjectinfo", CN);
                ds = new DataSet("ds");

                adp.Fill(ds);
                dtable = ds.Tables[0];
                Branch.Items.Clear();

                foreach (DataRow drow in dtable.Rows)
                {
                    Branch.Items.Add(drow[0].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Branch.Items.Clear();
            Branch.Text = "";
            Branch.Enabled = true;

            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();


                string ct = "select distinct RTRIM(branch) from Subjectinfo where coursename= '" + Course.Text + "'";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;

                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Branch.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Semester.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (Course.Text == "")
                {
                    MessageBox.Show("Please select course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Course.Focus();
                    return;
                }
                if (Branch.Text == "")
                {
                    MessageBox.Show("Please select branch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Branch.Focus();
                    return;
                }
                if (Semester.Text == "")
                {
                    MessageBox.Show("Please select semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Semester.Focus();
                    return;
                }
               
                var _with1 = listView1;
                _with1.Clear();
                _with1.Columns.Add("Subject Code", 100, HorizontalAlignment.Left);
                _with1.Columns.Add("Subject Name", 500, HorizontalAlignment.Center);
              
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("select RTrim(SubjectCode)[Subject Code], RTRIM(SubjectName)[Subject Name] from subjectinfo where  CourseName= '" + Course.Text + "'and branch='" + Branch.Text + "'and Semester='" + Semester.Text + "'", con);
                
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    var item = new ListViewItem();
                    item.Text = rdr[0].ToString();
                    item.SubItems.Add(rdr[1].ToString());
                    listView1.Items.Add(item);
                }
                con.Close();
                

              
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Course.Text = "";
            Branch.Text = "";
            Semester.Text = "";
            listView1.Items.Clear();
            Branch.Enabled = false;
            Semester.Enabled = false;
            Course.Focus();
        }

     
    }
}

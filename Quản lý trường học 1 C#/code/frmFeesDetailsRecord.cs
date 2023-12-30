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
    public partial class frmFeesDetailsRecord : Form
    {
        ConnectionString cs = new ConnectionString();
        public frmFeesDetailsRecord()
        {
            InitializeComponent();
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
            dynamic SelectQry = "SELECT RTRIM(FeeID)[Fee ID], RTRIM(Course)[Course], RTRIM(Branch)[Branch], RTRIM(Semester)[Semester], RTRIM(TutionFees)[Tution Fees], RTRIM(LibraryFees)[Library Fees], RTRIM(UniversityDevelopmentFees)[University Development Fees], RTRIM(UniversityStudentWelfareFees)[University Student Welfare Fees], RTRIM(CautionMoney)[Caution Money], RTRIM(OtherFees)[Other Fees], RTRIM(TotalFees)[Total Fees] from FeesDetails order by Course,Semester ";
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
        private void FeesDetailsRecord_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                this.Hide();
                frmFeesDetails frm = new frmFeesDetails();
                frm.Show();
                frm.FeeID.Text = dr.Cells[0].Value.ToString();
                frm.Course.Text = dr.Cells[1].Value.ToString();
                frm.Branch.Text = dr.Cells[2].Value.ToString();
                frm.Semester.Text = dr.Cells[3].Value.ToString();
                frm.TutionFees.Text = dr.Cells[4].Value.ToString();
                frm.LibraryFees.Text = dr.Cells[5].Value.ToString();
                frm.UDFees.Text = dr.Cells[6].Value.ToString();
                frm.USFees.Text = dr.Cells[7].Value.ToString();
                frm.CautionMoney.Text = dr.Cells[8].Value.ToString();
                frm.OtherFees.Text = dr.Cells[9].Value.ToString();
                frm.TotalFees.Text = dr.Cells[10].Value.ToString();
                if (label1.Text == "Admin")
                {
                    frm.Delete.Enabled = true;
                    frm.Update_record.Enabled = true;
                    frm.btnSave.Enabled = false;
                    frm.label13.Text = label1.Text;
                }
                else
                {
                    frm.Delete.Enabled = false;
                    frm.Update_record.Enabled = false;
                    frm.btnSave.Enabled = false;
                    frm.label13.Text = label1.Text;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmFeesDetailsRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmFeesDetails frm = new frmFeesDetails();
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
      
    
    }
}

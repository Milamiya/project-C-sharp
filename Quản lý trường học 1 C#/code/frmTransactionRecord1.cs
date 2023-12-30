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
    public partial class frmTransactionRecord1 : Form
    {
        
        DataTable dtable = new DataTable();
        SqlConnection con = null;
      
        DataSet ds = new DataSet();
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();

      
        public frmTransactionRecord1()
        {
            InitializeComponent();
        }

        private void frmTransactionRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmOtherTransaction frm = new frmOtherTransaction();
            frm.Show();
        }
   

      

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            this.Hide();
            frmOtherTransaction frm = new frmOtherTransaction();
            // or simply use column name instead of index
            //dr.Cells["id"].Value.ToString();
            frm.Show();
            frm.txtTransactionID.Text = dr.Cells[0].Value.ToString();
            frm.dtp.Text = dr.Cells[2].Value.ToString();
            if (dr.Cells[1].Value.ToString() == "Debit")
            {
                frm.rbdebit.Checked= true;
            }
            else
            {
                frm.rbcredit.Checked = true;
            }
            frm.txtamt.Text = dr.Cells[3].Value.ToString();
            frm.txtdes.Text = dr.Cells[4].Value.ToString();

            if (label1.Text == "Admin")
            {
                frm.Delete.Enabled = true;
                frm.Update_record.Enabled = true;
                frm.btnSave.Enabled = false;
                frm.label4.Text = label1.Text;
            }
            else
            {
                frm.Delete.Enabled = false;
                frm.Update_record.Enabled = false;
                frm.btnSave.Enabled = false;
                frm.label4.Text = label1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = new SqlCommand("SELECT RTRIM(Transactionid)[Transaction ID],RTRIM(TransactionType)[Transaction Type],RTRIM(Date)[Transaction Date],RTRIM(Amount)[Amount],RTRIM(Description)[Description] FROM othertransaction where date between @date1 and @date2 order by date", con);
                cmd.Parameters.Add("@date1", SqlDbType.DateTime, 30, " Date").Value = DateFrom.Value.Date;
                cmd.Parameters.Add("@date2", SqlDbType.DateTime, 30, " Date").Value = DateTo.Value.Date;

                SqlDataAdapter myDA = new SqlDataAdapter(cmd);

                DataSet myDataSet = new DataSet();

                myDA.Fill(myDataSet, "OtherTransaction");

                dataGridView1.DataSource = myDataSet.Tables["OtherTransaction"].DefaultView;




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateFrom.Text= System.DateTime.Today.ToString();
            DateTo.Text = System.DateTime.Today.ToString();
            dataGridView1.DataSource = null;
        }

        private void frmTransactionRecord1_Load(object sender, EventArgs e)
        {

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


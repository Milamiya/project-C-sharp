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
    public partial class frmOtherTransaction : Form
    {
        DataTable dtable = new DataTable();
        SqlConnection con = null;
        public String str;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        ConnectionString cs = new ConnectionString();


        public frmOtherTransaction()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtTransactionID.Text = "";
            txtdes.Text = "";
            txtamt.Text="";
            dtp.Text = DateTime.Today.ToString();
            rbcredit.Checked = false;
            rbdebit.Checked = false;
            btnSave.Enabled = true;
            Delete.Enabled = false;
            Update_record.Enabled = false;

        }

        private void NewRecord_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmOtherTransaction_Load(object sender, EventArgs e)
        {
            rbcredit.Checked = false;
            rbdebit.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            if (txtamt.Text == "")
            {
                MessageBox.Show("Please enter amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtamt.Focus();
                return;
            }


            try
            {
                if (rbdebit.Checked)
                {
                    str = rbdebit.Text;
                }
                if (rbcredit.Checked)
                {
                    str = rbcredit.Text;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "insert into OtherTransaction(TransactionType,Date,Amount,Description) VALUES (@d1,@d2,@d3,@d4)";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.NChar, 10, "TransactionType"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 30, "Date"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 10, "Amount"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.VarChar, 200, "Description"));


                cmd.Parameters["@d1"].Value = str;
                cmd.Parameters["@d2"].Value = dtp.Text;


                cmd.Parameters["@d3"].Value = txtamt.Text;
                cmd.Parameters["@d4"].Value = txtdes.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = false;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
           
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


                string cq = "delete from othertransaction where transactionid=@DELETE1;";


                cmd = new SqlCommand(cq);

                cmd.Connection = con;

                cmd.Parameters.Add(new SqlParameter("@DELETE1", System.Data.SqlDbType.Int, 10, "TransactionID"));


                cmd.Parameters["@DELETE1"].Value = Convert.ToInt32(txtTransactionID.Text);
                RowsAffected = cmd.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
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
            try
            {
                if (rbdebit.Checked)
                {
                    str = rbdebit.Text;
                }
                if (rbcredit.Checked)
                {
                    str = rbcredit.Text;
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();

                string cb = "update OtherTransaction set TransactionType=@d2,Date=@d3,Amount=@d4,Description=@d5 where TransactionID=@d1 ";

                cmd = new SqlCommand(cb);

                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@d1", System.Data.SqlDbType.Int, 10, "TransactionID"));

                cmd.Parameters.Add(new SqlParameter("@d2", System.Data.SqlDbType.NChar, 10, "TransactionType"));

                cmd.Parameters.Add(new SqlParameter("@d3", System.Data.SqlDbType.NChar, 30, "Date"));

                cmd.Parameters.Add(new SqlParameter("@d4", System.Data.SqlDbType.NChar, 10, "Amount"));

                cmd.Parameters.Add(new SqlParameter("@d5", System.Data.SqlDbType.VarChar, 200, "Description"));

                cmd.Parameters["@d1"].Value = txtTransactionID.Text ;
                cmd.Parameters["@d2"].Value = str;
                cmd.Parameters["@d3"].Value = dtp.Text;


                cmd.Parameters["@d4"].Value = txtamt.Text;
                cmd.Parameters["@d5"].Value = txtdes.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Update_record.Enabled = false;
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
            frmTransactionRecord1 frm = new frmTransactionRecord1();
            frm.label1.Text = label4.Text;
            frm.Show();
        }

        private void txtamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void rbcredit_CheckedChanged(object sender, EventArgs e)
        {

        }
        }
    }


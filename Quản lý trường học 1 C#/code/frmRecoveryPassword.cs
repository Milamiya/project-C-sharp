using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
namespace College_Management_System
{
    public partial class frmRecoveryPassword : Form
    {
        ConnectionString cs = new ConnectionString();

        public frmRecoveryPassword()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            try
            {
                 Cursor = Cursors.WaitCursor;
                 timer1.Enabled = true;
                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(cs.DBConn);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM User_Registration Where Email = '" + txtEmail.Text + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress("abcd@gmail.com");
                    // Recipient e-mail address.
                    Msg.To.Add("abcd@gmail.com");
                    Msg.Subject = "Your Password Details";
                    Msg.Body = "Your Password: " + Convert.ToString(ds.Tables[0].Rows[0]["Password"]) + "";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("abcd@gmail.com", "abcd");
                    smtp.EnableSsl = true;
                    smtp.Send(Msg);
                    MessageBox.Show(("Password Successfully sent " + ("\r\n" + "Please check your mail")), "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Hide();
                    frmLogin LoginForm1 = new frmLogin();
                    LoginForm1.Show();
                    LoginForm1.txtUserName.Text = "";
                    LoginForm1.txtPassword.Text = "";
                    LoginForm1.cmbUsertype.Text = "";
                    LoginForm1.ProgressBar1.Visible = false;

                    LoginForm1.cmbUsertype.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecoveryPassword_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void RecoveryPassword_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Hide();
            frmLogin frm = new frmLogin();
            frm.cmbUsertype.Text = "";
            frm.txtUserName.Text = "";
            frm.txtPassword.Text = "";
            frm.cmbUsertype.Focus();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
           timer1.Enabled = false;
        }

       
    }
}

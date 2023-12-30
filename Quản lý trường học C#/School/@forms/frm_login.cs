using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace School._forms
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        _class.clsODBC cls_ODBC=new School._class.clsODBC() ;
        _forms.MDIParent mdi_Parent = new MDIParent();


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            this.com_uName.Focus();
            index_Load();
            setUserName();
            
        }
        #region <=== Index Region ====>
        private void index_Load()
        {
            this.com_uName.TabIndex = 0;
            this.txtPass.TabIndex = 1;
            this.btn_Login.TabIndex = 2;
            this.button2.TabIndex = 3;
            
        }
        #endregion

        #region <=== Add Users in ComboBox ===>
        private void setUserName()
        {

            try
            {
                if (cls_ODBC.cn.State == ConnectionState.Open)
                {
                    cls_ODBC.cn.Close();
                   
                }
                
                cls_ODBC.cn.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter("select u_id from user_", cls_ODBC.cn);
                da.Fill(ds, "user_");                
                this.com_uName.DataSource = ds.Tables["user_"];                
                this.com_uName.DisplayMember = "u_id";
                this.com_uName.ValueMember = "u_id";
                cls_ODBC.cn.Close();
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message );
            }
        }
        #endregion

        
        #region <=== Check Valid User ===>
private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand  cmdlogin = new OleDbCommand("select * from user_ where u_id='" + this.com_uName .SelectedValue + "' and pw='" + this.txtPass .Text.Trim() + "'", this.cls_ODBC .cn);
                if (cls_ODBC.cn.State == ConnectionState.Open)
                {
                    cls_ODBC.cn.Close();
                }
                cls_ODBC.cn.Open();
               OleDbDataReader  drpassword = cmdlogin.ExecuteReader();
                if (drpassword.Read())
                {
                    cls_ODBC.cn.Close();
                    drpassword.Close();
                    cmdlogin.Dispose();
                    this.Dispose(true);

                    mdi_Parent.Show();

                }
                else
                {
                    MessageBox.Show("User Name or Password is no Valid ", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message );
            }
        }


        #endregion
    }
    }

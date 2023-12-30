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
    public partial class frmExp : Form
    {
        public frmExp()
        {
            InitializeComponent();
        }
        public string str = "";//get the value for form what do Modify/Add
       
        OleDbCommand cmdForm = new OleDbCommand();
        _class.clsODBC clsCon = new School._class.clsODBC();
        _class.cls_myFunctions clsmyFunction = new School._class.cls_myFunctions();
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExp_Load(object sender, EventArgs e)
        {
            if (str == "Adding")
            {
                this.lbl_Mode.Text = str;
                btn_Edit.Visible = false;
                btn_Delete.Visible = false;
                side2.Visible = false;
                side3.Visible = false;
                exp_ID();
            }
            else
            {
                if (str == "Modifying")
                {
                    this.lbl_Mode.Text = str;
                    btn_Add.Visible = false;
                    side1.Visible = false;
                }
            }
            
            list_Data();
        }

        private void tab_Index()
        {
            txtEid.TabIndex = 0;
            txtEname.TabIndex = 1;
        }

        private void exp_ID()
        {
            try
            {

                int myID;
                clsCon.connCheck();
                OleDbCommand cmddr = new OleDbCommand("select max(exp_id) as ids from exp_head", clsCon.cn);
                OleDbDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {
                    string strid = dr["ids"].ToString();
                    if (strid == "")
                    {
                       this.txtEid.Text  = "01";
                    }
                    else
                    {

                        myID = Convert.ToInt32(dr["ids"]) + 1;
                        if (myID >= 1 && myID <= 9)
                        {
                            txtEid.Text = "0" + myID.ToString();
                        }
                        else
                        {
                            if (myID >= 10)
                            {
                                txtEid.Text = myID.ToString();
                            }
                        }
                    }

                }
                dr.Close();
                clsCon.cn.Close();
                cmddr.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void list_Data()
        {
            clsCon.list_DataView("select exp_id,exp_name from exp_head order by exp_head.exp_id", this.lstv_Exp);
        }
        private void text_Clear()
        {
            txtEid.Text = "";
            txtEname.Text = "";
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            save_Exp();
            text_Clear();
            list_Data();
            exp_ID();
        }
        private void save_Exp()
        {
            if (txtEid.Text =="" || txtEname.Text =="")
            {
                MessageBox.Show("Some required Data is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into exp_head(exp_id,exp_name) values (?,?)";
                    cmdForm.Parameters.Add("@exp_id", OleDbType.Char).Value = txtEid.Text.Trim();
                    cmdForm.Parameters.Add("@exp_name", OleDbType.Char).Value = this.txtEname.Text.Trim();
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Data Save Successfuly", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }
            }
        }

        private void lstv_Exp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            txtEid.Text = (this.lstv_Exp.Items[lstv_Exp.FocusedItem.Index].SubItems[0].Text.Trim());
            txtEname.Text = (lstv_Exp.Items[lstv_Exp.FocusedItem.Index].SubItems[1].Text.Trim());
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txtEid.Text == "" || txtEname.Text == "")
            {
                MessageBox.Show("Some required Data is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "update exp_head set exp_name=? where exp_id=?";
                    cmdForm.Parameters.Add("@exp_name", OleDbType.Char).Value = txtEname.Text;
                    cmdForm.Parameters.Add("@exp_id", OleDbType.Char).Value = txtEid.Text;
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Data Edit Successfuly", 1);
                    text_Clear();


                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }
                list_Data();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtEid.Text == "" || txtEname.Text == "")
            {
                MessageBox.Show("Select a Record to Delete From List!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                 DialogResult ret;
            ret = MessageBox.Show("Are you sure to delete record!", "Delete".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "delete * from exp_head where exp_id=?";
                    cmdForm.Parameters.Add("@exp_id", OleDbType.Char).Value = txtEid.Text;
                    clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Data Deleted Successfuly", 1);
                    text_Clear();


                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    clsCon.cn.Close();
                }
                list_Data();
            }
            else
            {
                return;
            }
            }
        }

        private void txtEname_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding" && e.KeyCode  == Keys.Enter)
            {
                this.btn_Add_Click(sender, e);
            }
            else
            {
                return;
            }
        }

        
        }
    }

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
    public partial class frmAttEmp : Form
    {
        public frmAttEmp()
        {
            InitializeComponent();
        }
        public string str = "";//get the value for form what do Modify/Add
        string strEditID, strEditDate;// for Delete & Edit
        OleDbCommand cmdForm = new OleDbCommand();
        _class.clsODBC clsCon = new School._class.clsODBC();
        _class.cls_myFunctions clsmyFunction = new School._class.cls_myFunctions();

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAttEmp_Load(object sender, EventArgs e)
        {
            if (str == "Adding")
            {
                this.lbl_Mode.Text = str;
                btn_Edit.Visible = false;
                btn_Delete.Visible = false;
                side2.Visible = false;
                side3.Visible = false;
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
            tab_Index();
            combo_Emp();
            this.comStatus.Items.Add("A");
            this.comStatus.Items.Add("L");
            this.comStatus.Items.Add("P");
            this.comStatus.SelectedIndex = 2;
            this.txtTime.Text = DateTime.Now .ToShortTimeString ();
            list_Data();
        }

        private void tab_Index()
        {
            comEname.TabIndex = 0;
            btnLink.TabIndex = 1;
            comStatus.TabIndex = 2;
            dpAe.TabIndex = 3;
            txtTime.TabIndex = 4;
            txtRemarks.TabIndex = 5;
        }
        private void combo_Emp()
        {
            clsCon.comboFill(this.comEname , "select emp_id,emp_name from employee where active=true", "employee", "emp_name", "emp_id");
           
        }
        private void list_Data()
        {
            clsCon.list_DataView("select emp_id,emp_name,att_status,att_date,att_time,remarks from view_attemp where att_date=#" + this.dpAe.Value.Date + "#", lstv_AttEmp);

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            save_EmpAtt();
            list_Data();
            text_Clear();
        }
        private void save_EmpAtt()
        {
        if  (this.comEname.SelectedIndex == -1 || this.comStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Class Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into att_emp(emp_id,att_date,att_status,att_time,remarks) values (?,?,?,?,?)";
                    cmdForm.Parameters.Add("@emp_id", OleDbType.Char ).Value = this.comEname.SelectedValue ;
                    cmdForm.Parameters.Add("@att_date", OleDbType.Date).Value = dpAe.Value.Date ;
                    cmdForm.Parameters.Add("@att_status", OleDbType.Char).Value = this.comStatus.Text;
                    cmdForm.Parameters.Add("@att_time", OleDbType.Char).Value = this.txtTime.Text;
                    cmdForm.Parameters.Add("@remarks", OleDbType.Char).Value = this.txtRemarks.Text; clsCon.cmdClose(cmdForm);
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.comEname .DropDownStyle == ComboBoxStyle.Simple && this.comStatus.DropDownStyle == ComboBoxStyle .Simple )
            {
                this.comEname.DropDownStyle = ComboBoxStyle.DropDownList;
                this.comStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            }
            DialogResult ret;
            ret = MessageBox.Show("Are you sure to delete record!", "Delete".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {

               
                    try
                    {
                        clsCon.cmdOpen(cmdForm);
                        cmdForm.CommandText = "delete * from att_emp where emp_id=? and att_date=?";

                        cmdForm.Parameters.Add("@emp_id", OleDbType.Char ).Value = this.strEditID;
                        cmdForm.Parameters.Add("@att_date", OleDbType.Date).Value  = this.dpAe.Value.Date ;
                        clsCon.cmdClose(cmdForm);
                        clsmyFunction.setMessageBox("Data Deleted Successfuly", 1);
                       


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

                text_Clear();
            }
          

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            edit_AttEmp();
            list_Data();
            text_Clear();
        }

        private void edit_AttEmp()
        {
            if (this.comEname.SelectedIndex == -1 || this.comStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Employess Name is required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
            if (this.comEname.DropDownStyle == ComboBoxStyle.Simple && this.comStatus.DropDownStyle == ComboBoxStyle.Simple)
            {
                this.comEname.DropDownStyle = ComboBoxStyle.DropDownList;
                this.comStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            }



            try
            {
                clsCon.cmdOpen(cmdForm);
                cmdForm.CommandText = "delete * from att_emp where emp_id=? and att_date=?";

                cmdForm.Parameters.Add("@emp_id", OleDbType.Char).Value = this.strEditID;
                cmdForm.Parameters.Add("@att_date", OleDbType.Date).Value = this.dpAe.Value.Date;
                clsCon.cmdClose(cmdForm);

            }
            catch (Exception exp)
            {
                clsmyFunction.setCreateError(exp.Message);

            }
            finally
            {
                clsCon.cn.Close();
            }


            //=======================================================

            
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into att_emp(emp_id,att_date,att_status,att_time,remarks) values (?,?,?,?,?)";
                    cmdForm.Parameters.Add("@emp_id", OleDbType.Char).Value = this.comEname.SelectedValue;
                    cmdForm.Parameters.Add("@att_date", OleDbType.Date).Value = dpAe.Value.Date;
                    cmdForm.Parameters.Add("@att_status", OleDbType.Char).Value = this.comStatus.Text;
                    cmdForm.Parameters.Add("@att_time", OleDbType.Char).Value = this.txtTime.Text;
                    cmdForm.Parameters.Add("@remarks", OleDbType.Char).Value = this.txtRemarks.Text; clsCon.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Data Edited Successfuly", 1);

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



        


        private void lstv_AttEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (str == "Modifying")
            {
                this.comEname .SelectedIndex = -1;
                this.comStatus .SelectedIndex = -1;
                this.comEname.Text = "";
                this.comStatus.Text = "";
                this.comEname.DropDownStyle = ComboBoxStyle.Simple;
                this.comStatus.DropDownStyle = ComboBoxStyle.Simple;
               
               clsCon  .connCheck();
             //   OleDbCommand cmd = new OleDbCommand("select * from  view_attemp where emp_id='" + (this.lstv_AttEmp.Items[lstv_AttEmp.FocusedItem.Index].SubItems[0].Text.Trim()) + "' and att_date=#" + Convert .ToDateTime (this.lstv_AttEmp.Items[lstv_AttEmp.FocusedItem.Index].SubItems[3].Text) + "#",clsCon .cn);
              // OleDbCommand cmd = new OleDbCommand("select * from  view_attemp where emp_id='" + (this.lstv_AttEmp.Items[lstv_AttEmp.FocusedItem.Index].SubItems[0].Text.Trim()) + "'", clsCon.cn);
               OleDbCommand cmd = new OleDbCommand("select * from  view_attemp where emp_id='" + (this.lstv_AttEmp.Items[lstv_AttEmp.FocusedItem.Index].SubItems[0].Text.Trim()) + "' and att_date=#" + dpAe.Value.Date   + "#", clsCon.cn);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    strEditID = dr["emp_id"].ToString();
                   // strEditDate = Convert.ToDateTime(dr["att_date"]);
                    this.comEname .SelectedText = dr["emp_name"].ToString();                  
                    
                    this.dpAe .Value = Convert.ToDateTime(dr["att_date"]);
                    this.comStatus .SelectedText = dr["att_status"].ToString();
                    this.txtTime .Text = dr["att_time"].ToString();
                    this.txtRemarks.Text = dr["remarks"].ToString();
                    

                }
                clsCon .cn.Close();
                dr.Close();
                cmd.Dispose();
            }
            else
            {
                return;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            list_Data();
            lstv_AttEmp.Refresh();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            text_Clear();
            list_Data();
        }
        private void text_Clear()
        {
            this.comEname.SelectedIndex = -1;
            this.comStatus.SelectedIndex = -1;
            this.txtTime.Text = "";
            this.txtRemarks.Text = "";
        }

        private void comEname_Enter(object sender, EventArgs e)
        {
            if (str == "Modifying")
            {
                this.comEname .DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                return;
            }
        }

        private void comStatus_Enter(object sender, EventArgs e)
        {
            if (str == "Modifying")
            {
                this.comStatus .DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                return;
            }
        }

        private void comEname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        
       
    }
}
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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        int myID,editID;//For New ID also used in Save Process
        public string str, strEdit;
        _class.clsODBC cls_Con = new School._class.clsODBC();
        OleDbCommand cmdForm = new OleDbCommand();
        _class.cls_myFunctions clsmyFunction = new School._class.cls_myFunctions();

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            tab_Index();
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
            emp_ID();
            list_Data();
        }
        private void list_Data()
        {
            this.cls_Con.list_DataView("select emp_id,emp_name,age,address,nic,qua,j_date,contact_no,salery,remarks from employee order by employee.emp_id", this.lstv_Employee);
        }
        private void tab_Index()
        {
            txteId.TabIndex = 0;
            this.txtEname.TabIndex = 1;
            txtAge.TabIndex = 2;
            txtAddress.TabIndex = 3;
            txtNic.TabIndex = 4;
            txtQua.TabIndex = 5;
            dp_Emp.TabIndex = 6;
            txtContact.TabIndex = 7;
            txtSalery.TabIndex = 8;
            chk_Active.TabIndex = 9;
            chkTeacher.TabIndex = 10;
            txtComment.TabIndex = 11;
        }
        private void text_Clear()
        {
            txteId.Text = "";
            this.txtEname.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtNic.Text = "";
            txtQua.Text = "";

            txtContact.Text = "";
            txtSalery.Text = "";
            chk_Active.Checked = false ;
            txtComment.Text  = "";
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            save_Employee();
            text_Clear();
            emp_ID();
        }
        private void save_Employee()
        {
            if (this.txteId.Text == "" || this.txtEname.Text == "")
            {


                MessageBox.Show("Some required Fields are Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool val,val_teacher;
                val = this.chk_Active.Checked;
                val_teacher = this.chkTeacher.Checked;
                try
                {
                    this.cls_Con.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into employee(emp_id,emp_name,age,address,nic,j_date,qua,salery,contact_no,remarks,active,is_teacher,n_id) values (?,?,?,?,?,?,?,?,?,?,?,?,?)";
                    cmdForm.Parameters.Add("@emp_id", OleDbType.Char).Value = this.txteId.Text.Trim().ToUpper();
                    cmdForm.Parameters.Add("@emp_name", OleDbType.Char).Value = this.txtEname.Text;
                    cmdForm.Parameters.Add("@age", OleDbType.Char).Value = txtAge.Text.Trim();
                    cmdForm.Parameters.Add("@address", OleDbType.Char).Value = txtAddress.Text;
                    cmdForm.Parameters.Add("@nic", OleDbType.Char).Value = this.txtNic.Text.Trim();
                    cmdForm.Parameters.Add("@j_date", OleDbType.Date).Value = this.dp_Emp.Value.Date;
                    cmdForm.Parameters.Add("@qua", OleDbType.Char).Value = this.txtQua.Text;
                    cmdForm.Parameters.Add("@salery", OleDbType.Numeric).Value = this.txtSalery.Text;
                    cmdForm.Parameters.Add("@contact_no", OleDbType.Char).Value = this.txtContact.Text;
                    cmdForm.Parameters.Add("@remarks", OleDbType.Char).Value = this.txtComment.Text;

                    cmdForm.Parameters.Add("@active", OleDbType.Boolean).Value = val;
                    cmdForm.Parameters.Add("@is_teacher", OleDbType.Boolean).Value = val_teacher;
                    cmdForm.Parameters.Add("@n_id", OleDbType.Numeric).Value = this.myID;


                    cls_Con.cmdClose(cmdForm);
                    clsmyFunction.setMessageBox("Data Save Successfuly", 1);

                }
                catch (Exception exp)
                {
                    clsmyFunction.setCreateError(exp.Message);

                }
                finally
                {
                    this.cls_Con.cn.Close();
                }
            }
        }

        private void emp_ID()
        {
            if (this.lbl_Mode.Text != "Adding")
            {
                return;
            }
            else
            {

                try
                {


                    cls_Con.connCheck();
                    OleDbCommand cmddr = new OleDbCommand("select max(n_id) as ids from employee ", cls_Con.cn);
                    OleDbDataReader dr = cmddr.ExecuteReader();

                    while (dr.Read())
                    {
                        string strid = dr["ids"].ToString();
                        if (strid == "")
                        {
                            this.txteId.Text = "EMP-" + "1";
                        }
                        else
                        {
                            myID = Convert.ToInt32(dr["ids"]) + 1;
                            this.txteId.Text = "EMP-" + myID.ToString();
                        }

                    }
                    dr.Close();
                    cls_Con.cn.Close();
                    cmddr.Dispose();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void txtSalery_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            edit_Employee();
            list_Data();
            text_Clear();

        }
        private void edit_Employee()
        {

            OleDbTransaction tran;
            if (this.txteId.Text == "" || this.txtEname.Text == "")
            {


                MessageBox.Show("Some required Fields are Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //First delete the old record

                cls_Con.cn.Open();
                tran = cls_Con.cn.BeginTransaction();

                OleDbCommand cmdDelete = new OleDbCommand();
                cmdDelete.Connection = cls_Con.cn;

                cmdDelete.CommandText = "delete * from employee where emp_id=?";
                cmdDelete.Transaction = tran;
                cmdDelete.Parameters.Add("@emp_id", OleDbType.Char).Value = this.txteId.Text.Trim();
                cmdDelete.ExecuteNonQuery();
                cmdDelete.Parameters.Clear();
                cmdDelete.Dispose();

                //Now Adding new one
                bool val,val_teacher;
                val = this.chk_Active.Checked;
                val_teacher = chkTeacher.Checked;

                try
                {
                    OleDbCommand cmdSave = new OleDbCommand();
                    cmdSave.Connection = cls_Con.cn;
                    cmdSave.CommandText = "insert into employee(emp_id,emp_name,age,address,nic,j_date,qua,salery,contact_no,remarks,active,is_teacher,n_id) values (?,?,?,?,?,?,?,?,?,?,?,?,?)";
                    cmdSave.Transaction = tran;
                    cmdSave.Parameters.Add("@emp_id", OleDbType.Char).Value = this.txteId.Text.Trim();
                    cmdSave.Parameters.Add("@emp_name", OleDbType.Char).Value = this.txtEname.Text;
                    cmdSave.Parameters.Add("@age", OleDbType.Char).Value = this.txtAge.Text.Trim();
                    cmdSave.Parameters.Add("@address", OleDbType.Char).Value = txtAddress.Text;
                    cmdSave.Parameters.Add("@nic", OleDbType.Char).Value = this.txtNic.Text.Trim();
                    cmdSave.Parameters.Add("@j_date", OleDbType.Date).Value = this.dp_Emp.Value.Date;
                    cmdSave.Parameters.Add("@qua", OleDbType.Char).Value = this.txtQua.Text;
                    cmdSave.Parameters.Add("@salery", OleDbType.Numeric).Value = this.txtSalery.Text;
                    cmdSave.Parameters.Add("@contact_no", OleDbType.Char).Value = this.txtContact.Text;
                    cmdSave.Parameters.Add("@remarks", OleDbType.Char).Value = this.txtComment.Text;
                    cmdSave.Parameters.Add("@active", OleDbType.Boolean).Value = val;
                    cmdSave.Parameters.Add("@is_teacher", OleDbType.Boolean).Value = val_teacher;
                    cmdSave.Parameters.Add("@n_id", OleDbType.Numeric).Value = editID;

                    cmdSave.ExecuteNonQuery();
                    cmdSave.Parameters.Clear();
                    cmdSave.Dispose();
                    tran.Commit();
                    clsmyFunction.setMessageBox("Data Edited Successfuly", 1);

                }
                catch (Exception exp)
                {
                    tran.Rollback();
                    clsmyFunction.setCreateError(exp.Message);
                }

                finally
                {
                    if (this.cls_Con.cn != null) this.cls_Con.cn.Close();
                }
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            employee_Delete();
            list_Data();
            text_Clear();
            this.txteId.Focus();
        }
        private void employee_Delete()
        {
             DialogResult ret;
            ret = MessageBox.Show("Are you sure to delete record!", "Delete".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {
                if (this.txteId.Text == "" || this.txtEname.Text == "")
                {


                    MessageBox.Show("Some required Fields are Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {


                    try
                    {
                        this.cls_Con.cmdOpen(cmdForm);
                        cmdForm.CommandText = "delete * from employee where emp_id=?";


                        cmdForm.Parameters.Add("@emp_id", OleDbType.Char).Value = this.txteId.Text;


                        cls_Con.cmdClose(cmdForm);
                        clsmyFunction.setMessageBox("Data Deleted Successfuly", 1);

                    }
                    catch (Exception exp)
                    {
                        clsmyFunction.setCreateError(exp.Message);

                    }
                    finally
                    {
                        this.cls_Con.cn.Close();
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void lstv_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbl_Mode.Text == "Modifying")
            {

                cls_Con.connCheck();
                OleDbCommand cmd = new OleDbCommand("select * from employee where emp_id='" + (this.lstv_Employee.Items[lstv_Employee.FocusedItem.Index].SubItems[0].Text.Trim()) + "'"
                    , cls_Con.cn);
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.txteId.Text = dr["emp_id"].ToString();
                    this.txtEname.Text = dr["emp_name"].ToString();
                    this.txtAge.Text = dr["age"].ToString();
                    this.txtNic.Text = dr["nic"].ToString();
                    this.dp_Emp.Value = Convert.ToDateTime(dr["j_date"]);
                    this.txtQua.Text = dr["qua"].ToString();
                    this.txtSalery.Text = dr["salery"].ToString();
                    this.txtContact.Text = dr["contact_no"].ToString();
                    this.txtComment.Text = dr["remarks"].ToString();
                    this.chk_Active.Checked = Convert.ToBoolean(dr["active"]);
                    editID = Convert.ToInt32 (dr["n_id"]);
                }
                cls_Con.cn.Close();
                cmd.Dispose();
                dr.Close();
            }
            else
            {
                return;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            list_Data();
            lstv_Employee.Refresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            this.txt_Find.Focus();
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            if (this.rdo_id.Checked == true)
            {
                this.cls_Con.list_DataView("select emp_id,emp_name,age,address,nic,qua,j_date,contact_no,salery,remarks from employee where emp_id like'" + this.txt_Find.Text.Trim() + "%'  order by employee.emp_id", this.lstv_Employee);
            }
            else
                if (this.rdo_Name.Checked == true)
                {
                    this.cls_Con.list_DataView("select emp_id,emp_name,age,address,nic,qua,j_date,contact_no,salery,remarks from employee where emp_name like'" + this.txt_Find.Text.Trim() + "%'  order by employee.emp_id", this.lstv_Employee);
                }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            text_Clear();
            list_Data();
        }

        
    }


}

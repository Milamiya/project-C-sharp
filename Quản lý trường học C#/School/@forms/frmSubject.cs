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
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }
        public string str, strEdit;
        _class.clsODBC cls_Con = new School._class.clsODBC();
        OleDbCommand cmdForm = new OleDbCommand();
        _class.cls_myFunctions clsmyFunction = new School._class.cls_myFunctions();
        private void frmSubject_Load(object sender, EventArgs e)
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

            frmStudent frm_Student = new frmStudent();

            // =========================================
            panel5.Visible = false;
            text_Clear();
            set_TabIndex();
            class_Combo();
            teacher_Combo();
            list_Data();
        }
        private void list_Data()
        {
            cls_Con.list_DataView("select sub_id,sub_name,c_name,emp_name,sub_marks,remarks,is_active,is_teacher from view_subject where is_teacher=true and is_active=true", this.lstv_Subject);

        }
        private void text_Clear()
        {
            com_Cname.SelectedIndex  = -1;
            txt_Sid.Text = "";
            txt_sName.Text = "";
            com_Teacher.SelectedIndex = -1;
            txtMarks.Text = "";
            txt_Remarks.Text = "";
            chkActive1.Checked = false;
        }
        private void class_Combo()
        {
            cls_Con.comboFill(this.com_Cname, "select * from class", "class", "c_name", "c_id");
            // For Search
            cls_Con.comboFill(com_Sclass, "select * from class", "class", "c_name", "c_id");
        }
        private void teacher_Combo()
        {
            cls_Con.comboFill(this.com_Teacher, "select * from employee where is_teacher=true and active=true order by employee.emp_name", "employee", "emp_name", "emp_id");
        }
        private void set_TabIndex()
        {
            com_Cname.TabIndex = 0;
            btn_Link.TabIndex = 1;
            txt_Sid.TabIndex = 2;
            txt_sName.TabIndex = 3;
            com_Teacher.TabIndex = 4;
            txtMarks.TabIndex = 5;
            txt_Remarks.TabIndex = 6;
            groupboxform.TabIndex = 7;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Link_Click(object sender, EventArgs e)
        {
            if (this.lbl_Mode.Text == "Adding")
            {
                frmClass frm_Class = new frmClass();
                frm_Class.str = "Adding";
                frm_Class.Show();
            }
            else
            {
                MessageBox.Show("This option you can use with Adding Process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            class_Combo();
            lstv_Subject.Refresh();
            teacher_Combo();

        }

        private void txtMarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            save_Subject();
            list_Data();
        }

        private void save_Subject()
        {
            if (this.com_Cname.SelectedIndex == -1 || this.txt_Sid.Text == "" || this.txt_sName.Text == "" || this.com_Teacher.SelectedIndex == -1 || this.txtMarks.Text == "")
            {


                MessageBox.Show("Some required Fields are Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool val;
                val = this.chkActive1.Checked;
                try
                {
                    this.cls_Con.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into subject(c_id,sub_id,sub_name,emp_id,sub_marks,remarks,is_active) values (?,?,?,?,?,?,?)";
                    cmdForm.Parameters.Add("@c_id", OleDbType.Numeric).Value = this.com_Cname.SelectedValue;
                    cmdForm.Parameters.Add("@sub_id", OleDbType.Char).Value = this.txt_Sid.Text.Trim();

                    cmdForm.Parameters.Add("@sub_name", OleDbType.Char).Value = this.txt_sName.Text;
                    cmdForm.Parameters.Add("@emp_id", OleDbType.Char).Value = this.com_Teacher.SelectedValue;
                    cmdForm.Parameters.Add("@sub_marks", OleDbType.Numeric).Value = Convert.ToInt16(this.txtMarks.Text);
                    cmdForm.Parameters.Add("@remarks", OleDbType.Char).Value = this.txt_Remarks.Text;

                    cmdForm.Parameters.Add("@is_active", OleDbType.Boolean).Value = val;


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

        private void rdo_All_Click(object sender, EventArgs e)
        {
            if (rdo_All.Checked == true)
            {
                list_Data();
            }
            else
            {
                return;
            }
        }

        private void rdo_Class_Click(object sender, EventArgs e)
        {
            if (rdo_Class.Checked == true)
            {
                cls_Con.list_DataView("select sub_id,sub_name,c_name,emp_name,sub_marks,remarks,is_active,is_teacher from view_subject where is_teacher=true and is_active=true and c_id=" + this.com_Sclass.SelectedValue + "", this.lstv_Subject);
            }
        }

        private void com_Sclass_SelectedValueChanged(object sender, EventArgs e)
        {
            rdo_Class_Click(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            txt_Find.Focus();
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            if (this.rdo_All.Checked == false && rdo_Class.Checked == false)
            {
                MessageBox.Show("Select any one Condition for Search", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (this.rdo_All.Checked == true)
                {
                    cls_Con.list_DataView("select sub_id,sub_name,c_name,emp_name,sub_marks,remarks,is_active,is_teacher from view_subject where is_teacher=true and is_active=true and sub_name like'" + this.txt_Find.Text.Trim() + "%'", this.lstv_Subject);

                }
                else
                {
                    cls_Con.list_DataView("select sub_id,sub_name,c_name,emp_name,sub_marks,remarks,is_active,is_teacher from view_subject where is_teacher=true and is_active=true and c_id=" + this.com_Sclass.SelectedValue + " and sub_name like'" + this.txt_Find.Text.Trim() + "%'", this.lstv_Subject);
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            delete_Subject();
            text_Clear();
            list_Data();
        }
        private void delete_Subject()
        {
            DialogResult ret;
            ret = MessageBox.Show("Are you sure to delete record!", "Delete".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {

                if ( this.txt_Sid.Text == "" || this.txt_sName.Text == ""  || this.txtMarks.Text == "")
                {
                    clsmyFunction.setCreateError("Select a Record for Delete");
                    return;
                }
                else
                {
                    try
                    {
                       
                      this.cls_Con  .cmdOpen(cmdForm);
                        cmdForm.CommandText = "delete * from subject where sub_id=?";

                        cmdForm.Parameters.Add("@sub_id", OleDbType.Char).Value = this.txt_Sid.Text.Trim();
                        this.cls_Con.cmdClose(cmdForm);
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
        }

        private void lstv_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* this.editID = (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[0].Text.Trim());
            this.txt_Cname.Text = (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[1].Text.Trim());*/


            if (str == "Modifying")
            {
                this.com_Cname .SelectedIndex  = -1;
                this.com_Teacher.SelectedIndex = -1;
                this.com_Cname.Text = "";
                this.com_Teacher.Text = "";
                this.com_Cname.DropDownStyle = ComboBoxStyle.Simple;
                this.com_Teacher.DropDownStyle = ComboBoxStyle.Simple;

                cls_Con.connCheck();
                OleDbCommand cmd = new OleDbCommand("select * from  view_subject where sub_id='" + (this.lstv_Subject .Items[lstv_Subject.FocusedItem.Index].SubItems[0].Text.Trim()) + "'", cls_Con.cn);

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    strEdit = dr["sub_id"].ToString();
                    
                    com_Cname .SelectedText  = dr["c_name"].ToString();
                    txt_Sid .Text = dr["sub_id"].ToString();
                    this.txt_sName.Text  = dr["sub_name"].ToString().Trim ();
                    this.com_Teacher .SelectedText  = dr["emp_name"].ToString();
                    this.txtMarks.Text  = dr["sub_marks"].ToString();
                    this.txt_Remarks.Text  = dr["remarks"].ToString();
                    this.chkActive1.Checked =Convert.ToBoolean (dr["is_active"]);
                    
                   

                }
                cls_Con.cn.Close();
                dr.Close();
                cmd.Dispose();
            }
            else
            {
                return;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            edit_Subject();
            list_Data();
        }
        private void edit_Subject()
        {
            if (this.com_Cname .DropDownStyle == ComboBoxStyle.Simple && com_Teacher .DropDownStyle ==ComboBoxStyle.Simple  )
            {
                MessageBox.Show("You Should Select a Class Name For Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                OleDbTransaction tran;
                if (this.com_Cname.SelectedIndex == -1 || this.txt_Sid.Text == "" || this.txt_sName.Text == "" || this.com_Teacher.SelectedIndex == -1 || this.txtMarks.Text == "")
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

                    cmdDelete.CommandText = "delete * from subject where sub_id=?";
                    cmdDelete.Transaction = tran;
                    cmdDelete.Parameters.Add("@sub_id", OleDbType.Char).Value = this.strEdit.Trim();
                    cmdDelete.ExecuteNonQuery();
                    cmdDelete.Parameters.Clear();
                    cmdDelete.Dispose();

                    //Now Adding new one
                    bool val;
                    val = this.chkActive1.Checked;


                    try
                    {
                        OleDbCommand cmdSave = new OleDbCommand();
                        cmdSave.Connection = cls_Con.cn;
                        cmdSave.CommandText = "insert into subject(c_id,sub_id,sub_name,emp_id,sub_marks,remarks,is_active) values (?,?,?,?,?,?,?)";
                        cmdSave.Transaction = tran;
                        cmdSave.Parameters.Add("@c_id", OleDbType.Numeric).Value = this.com_Cname.SelectedValue;
                        cmdSave.Parameters.Add("@sub_id", OleDbType.Char).Value = this.txt_Sid.Text.Trim();

                        cmdSave.Parameters.Add("@sub_name", OleDbType.Char).Value = this.txt_sName.Text;
                        cmdSave.Parameters.Add("@emp_id", OleDbType.Char).Value = this.com_Teacher.SelectedValue;
                        cmdSave.Parameters.Add("@sub_marks", OleDbType.Numeric).Value = Convert.ToInt16(this.txtMarks.Text);
                        cmdSave.Parameters.Add("@remarks", OleDbType.Char).Value = this.txt_Remarks.Text;

                        cmdSave.Parameters.Add("@is_active", OleDbType.Boolean).Value = val;



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

        }

        private void com_Cname_Enter(object sender, EventArgs e)
        {
            if (str == "Modifying")
            {
                this.com_Cname .DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                return;
            }
        }

        private void com_Teacher_Enter(object sender, EventArgs e)
        {
            if (str == "Modifying")
            {
                this.com_Teacher .DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                return;
            }
        }


        }
    }

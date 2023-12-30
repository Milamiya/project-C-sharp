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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }
        public string str, strEdit;
        _class.clsODBC cls_Con = new School._class.clsODBC();
        OleDbCommand cmdForm = new OleDbCommand();
        _class.cls_myFunctions clsmyFunction = new School._class.cls_myFunctions();
        private void frmStudent_Load(object sender, EventArgs e)
        {
            this.panel3.Visible = false;// hide the search panel 
            // =============== Load Tools ==================
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
            // =========================================

            tab_Index();
            this.com_Sex.Items.Add("Male");
            this.com_Sex.Items.Add("Female");
            this.com_Sex.SelectedIndex = 0;
            this.dp_Student.Value = DateTime.Now;
            comboClass_Load();
            list_Load();
            this.rdo_All.Checked = true;
        }
        private void list_Load()
        {
            cls_Con.list_DataView("select s_id,roll_no,s_name,c_name,address,contact_no,f_name,age,d_birth,sex,remarks from view_student ORDER BY student.roll_no", this.lstv_Student);
        }
        private void tab_Index()
        {
            this.btn_Link.TabIndex = 0;
            this.com_cName.TabIndex = 1;
            this.txt_Rollno.TabIndex = 2;
            this.txt_Sname.TabIndex = 3;
            this.txt_Fname.TabIndex = 4;
            this.txtAge.TabIndex = 5;
            this.dp_Student.TabIndex = 6;
            this.com_Sex.TabIndex = 7;
            this.txtAddress.TabIndex = 8;
            this.txtContact.TabIndex = 9;
            this.txtRemarks.TabIndex = 10;
            this.txt_Mfee.TabIndex = 11;
            this.chk_Active.TabIndex = 12;
        }

        private void btn_Link_Click(object sender, EventArgs e)
        {
            frmClass frm_Class = new frmClass();
            frm_Class.Show();
        }

        private void comboClass_Load()
        {
            this.cls_Con.comboFill(this.com_cName, "select * from class", "class", "c_name", "c_id");
            cls_Con.comboFill(this.com_Sclass, "select * from class", "class", "c_name", "c_id");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            comboClass_Load();
            list_Load();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            save_Student();
        }
        private void save_Student()
        {
            if (this.com_cName.SelectedIndex == -1 || this.txt_Rollno.Text == "" || this.txt_Sname.Text == "" || this.txt_Mfee.Text == "")
            {


                MessageBox.Show("Some required Fields are Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool val;
                val = this.chk_Active.Checked;
                 try
                 {
                this.cls_Con.cmdOpen(cmdForm);
                cmdForm.CommandText = "insert into student(c_id,roll_no,s_id,s_name,f_name,age,d_birth,sex,remarks,contact_no,address,active,m_fee) values (?,?,?,?,?,?,?,?,?,?,?,?,?)";
                cmdForm.Parameters.Add("@c_id", OleDbType.Numeric).Value = this.com_cName.SelectedValue;
                cmdForm.Parameters.Add("@roll_no", OleDbType.Char).Value = this.txt_Rollno.Text.Trim();
                cmdForm.Parameters.Add("@s_id", OleDbType.Char).Value = this.com_cName.SelectedValue.ToString() + "-" + this.txt_Rollno.Text.Trim();
                cmdForm.Parameters.Add("@s_name", OleDbType.Char).Value = this.txt_Sname.Text;
                cmdForm.Parameters.Add("@f_name", OleDbType.Char).Value = this.txt_Fname.Text;
                cmdForm.Parameters.Add("@age", OleDbType.Char).Value = this.txtAge.Text.Trim();
                cmdForm.Parameters.Add("@d_birth", OleDbType.Date).Value = this.dp_Student.Value.Date;
                cmdForm.Parameters.Add("@sex", OleDbType.Char).Value = this.com_Sex.Text.Trim();
                cmdForm.Parameters.Add("@remarks", OleDbType.Char).Value = this.txtRemarks.Text;
                cmdForm.Parameters.Add("@contact_no", OleDbType.Char).Value = this.txtContact.Text;
                cmdForm.Parameters.Add("@address", OleDbType.Char).Value = this.txtAddress.Text;
                cmdForm.Parameters.Add("@active", OleDbType.Boolean).Value = val;
                cmdForm.Parameters.Add("@m_fee", OleDbType.Numeric).Value = this.txt_Mfee.Text.Trim();

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

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            save_Student();
            list_Load();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            clearText();
            list_Load();
        }
        private void clearText()
        {
            
            this.com_cName.SelectedIndex  = -1;
            this.txt_Rollno.Text ="";
            this.txt_Sname.Text  = "";
            this.txt_Fname.Text  = "";
            this.txtAge.Text = "";
            this.dp_Student.Text  = "";
            this.com_Sex.SelectedIndex  = -1;
            this.txtAddress.Text  = "";
            this.txtContact.Text  = "";
            this.txtRemarks.Text = "";
            this.txt_Mfee.Text  = "";
            this.chk_Active.Checked = false;
        }



        private void com_cName_Enter(object sender, EventArgs e)
        {
            if (str == "Modifying")
            {
                this.com_cName.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                return;
            }
        }

        private void com_cName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Disable typing on combo Box
            e.Handled = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = true;
            this.txt_Find.Focus();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.panel3.Visible = false;
        }


        private void student_ID()
        {
            if (this.com_cName.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                try
                {

                    int myID;
                    cls_Con.connCheck();
                    OleDbCommand cmddr = new OleDbCommand("select max(roll_no) as ids from student where c_id=" + this.com_cName.SelectedValue + "", cls_Con.cn);
                    OleDbDataReader dr = cmddr.ExecuteReader();

                    while (dr.Read())
                    {
                        string strid = dr["ids"].ToString();
                        if (strid == "")
                        {
                            this.txt_Rollno.Text = "1";
                        }
                        else
                        {
                            myID = Convert.ToInt32(dr["ids"]) + 1;
                            this.txt_Rollno.Text = myID.ToString();
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

        private void com_cName_Leave(object sender, EventArgs e)
        {
            if (this.str == "Adding")
            {
                student_ID();
            }
            else
            {
                return;
            }
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            list_Load();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            edit_Student();
            list_Load();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.com_cName.DropDownStyle == ComboBoxStyle.Simple)
            {
                this.com_cName.DropDownStyle = ComboBoxStyle.DropDownList;

            }

            student_Delete();
            list_Load();
        }
        private void student_Delete()
        {
             DialogResult ret;
            ret = MessageBox.Show("Are you sure to delete record!", "Delete".ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (ret == DialogResult.Yes)
            {
                if (this.txt_Rollno.Text == "" || this.txt_Sname.Text == "" || this.txt_Mfee.Text == "")
                {


                    MessageBox.Show("Some required Fields are Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {


                    try
                    {
                        this.cls_Con.cmdOpen(cmdForm);
                        cmdForm.CommandText = "delete * from student where s_id=?";


                        cmdForm.Parameters.Add("@s_id", OleDbType.Char).Value = this.strEdit;


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
           


        private void rdo_All_Click(object sender, EventArgs e)
        {
            if (this.rdo_All.Checked == true)
                this.list_Load();
            else
            {
                return;
            }
        }

        private void rdo_Class_Click(object sender, EventArgs e)
        {
            this.cls_Con.list_DataView("select s_id,roll_no,s_name,c_name,address,contact_no,f_name,age,d_birth,sex,remarks from view_student where c_id=" + this.com_Sclass.SelectedValue + " ORDER BY student.roll_no", this.lstv_Student);
        }

        private void com_Sclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.rdo_Class.Checked == true)
            {
                this.rdo_Class_Click(sender, e);
            }
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            if (this.rdo_Class.Checked == true)
            {
                this.cls_Con.list_DataView("select s_id,roll_no,s_name,c_name,address,contact_no,f_name,age,d_birth,sex,remarks from view_student where c_id=" + this.com_Sclass.SelectedValue + " and s_name like'" + this.txt_Find.Text.Trim() + "%'  ORDER BY student.roll_no", this.lstv_Student);
            }
            else
            {
                if (this.rdo_All.Checked == true)
                {
                    this.cls_Con.list_DataView("select s_id,roll_no,s_name,c_name,address,contact_no,f_name,age,d_birth,sex,remarks from view_student where  s_name like'" + this.txt_Find.Text.Trim() + "%'  ORDER BY student.roll_no", this.lstv_Student);
                }
            }
            }

        private void lstv_Student_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            
                 this.txt_Rollno.Text = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[1].Text.Trim());
                 this.txt_Sname.Text = (this.lstv_Student .Items [lstv_Student .FocusedItem .Index ].SubItems [2].Text.Trim ());

                 this.com_cName.SelectedText = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[3].Text.Trim());
                 this.txtAddress .Text = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[4].Text.Trim());
                 this.txtContact.Text  = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[5].Text.Trim());
                 this.txt_Fname .Text  = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[6].Text.Trim());
                 this.txtAge .Text = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[7].Text.Trim());
                 dp_Student.Value  = Convert.ToDateTime (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[8].Text.Trim());
                 this.com_Sex .Text = (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[9].Text.Trim());
                 this.txtRemarks.Text =  (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[10].Text.Trim());*/

            if (str == "Modifying")
            {
                this.com_cName.SelectedIndex = -1;
                this.com_Sex.SelectedIndex = -1;
                this.com_cName.Text = "";
                this.com_Sex.Text = "";
                this.com_cName.DropDownStyle = ComboBoxStyle.Simple;
                this.com_Sex.DropDownStyle = ComboBoxStyle.Simple;

                cls_Con.connCheck();
                OleDbCommand cmd = new OleDbCommand("select * from  view_student where s_id='" + (this.lstv_Student.Items[lstv_Student.FocusedItem.Index].SubItems[0].Text.Trim()) + "'", cls_Con.cn);

                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    strEdit = dr["s_id"].ToString();
                    txt_Rollno.Text = dr["roll_no"].ToString();
                    txt_Sname.Text = dr["s_name"].ToString();
                    this.com_cName.SelectedText = dr["c_name"].ToString();
                    this.txtAddress.Text = dr["address"].ToString();
                    this.txtContact.Text = dr["contact_no"].ToString();
                    this.txt_Fname.Text = dr["f_name"].ToString();
                    this.txtAge.Text = dr["age"].ToString();
                    this.dp_Student.Value = Convert.ToDateTime(dr["d_birth"]);
                    this.com_Sex.SelectedText = dr["sex"].ToString();
                    this.txtRemarks.Text = dr["remarks"].ToString();
                    this.txt_Mfee.Text = dr["m_fee"].ToString();
                    this.chk_Active.Checked = Convert.ToBoolean(dr["active"]);

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

        private void com_Sex_Enter(object sender, EventArgs e)
        {
            if (str == "Modifying")
            {
                this.com_Sex.DropDownStyle = ComboBoxStyle.DropDown;
            }
            else
            {
                return;
            }
        }

        private void com_Sex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void edit_Student()
        {
            if (this.com_cName.DropDownStyle == ComboBoxStyle.Simple)
            {
                MessageBox.Show("You Should Select a Class Name For Edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                OleDbTransaction tran;
                if (this.txt_Rollno.Text == "" || this.txt_Sname.Text == "" || this.txt_Mfee.Text == "")
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

                    cmdDelete.CommandText = "delete * from student where s_id=?";
                    cmdDelete.Transaction = tran;
                    cmdDelete.Parameters.Add("@s_id", OleDbType.Char).Value = this.strEdit;
                    cmdDelete.ExecuteNonQuery();
                    cmdDelete.Parameters.Clear();
                    cmdDelete.Dispose();

                    //Now Adding new one
                    bool val;
                    val = this.chk_Active.Checked;
                    try
                    {
                        OleDbCommand cmdSave = new OleDbCommand();
                        cmdSave.Connection = cls_Con.cn;
                        cmdSave.CommandText = "insert into student(c_id,roll_no,s_id,s_name,f_name,age,d_birth,sex,remarks,contact_no,address,active,m_fee) values (?,?,?,?,?,?,?,?,?,?,?,?,?)";
                        cmdSave.Transaction = tran;
                        cmdSave.Parameters.Add("@c_id", OleDbType.Numeric).Value = this.com_cName.SelectedValue;
                        cmdSave.Parameters.Add("@roll_no", OleDbType.Char).Value = this.txt_Rollno.Text.Trim();
                        cmdSave.Parameters.Add("@s_id", OleDbType.Char).Value = this.com_cName.SelectedValue.ToString() + "-" + this.txt_Rollno.Text.Trim();
                        cmdSave.Parameters.Add("@s_name", OleDbType.Char).Value = this.txt_Sname.Text;
                        cmdSave.Parameters.Add("@f_name", OleDbType.Char).Value = this.txt_Fname.Text;
                        cmdSave.Parameters.Add("@age", OleDbType.Char).Value = this.txtAge.Text.Trim();
                        cmdSave.Parameters.Add("@d_birth", OleDbType.Date).Value = this.dp_Student.Value.Date;
                        cmdSave.Parameters.Add("@sex", OleDbType.Char).Value = this.com_Sex.Text.Trim();
                        cmdSave.Parameters.Add("@remarks", OleDbType.Char).Value = this.txtRemarks.Text;
                        cmdSave.Parameters.Add("@contact_no", OleDbType.Char).Value = this.txtContact.Text;
                        cmdSave.Parameters.Add("@address", OleDbType.Char).Value = this.txtAddress.Text;
                        cmdSave.Parameters.Add("@active", OleDbType.Boolean).Value = val;
                        cmdSave.Parameters.Add("@m_fee", OleDbType.Numeric).Value = this.txt_Mfee.Text.Trim();

                        cmdSave.ExecuteNonQuery();
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

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void txt_Mfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        }
    }

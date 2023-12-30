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
    public partial class frmExpDetail : Form
    {
        public frmExpDetail()
        {
            InitializeComponent();
        }
        public string str = "";//get the value for form what do Modify/Add
       int idVal,editVal;
        DateTime editDate;
        OleDbCommand cmdForm = new OleDbCommand();
        _class.clsODBC clsCon = new School._class.clsODBC();
        _class.cls_myFunctions clsmyFunction = new School._class.cls_myFunctions();
        private void frmExpDetail_Load(object sender, EventArgs e)
        {
            if (str == "Adding")
            {
                this.lbl_Mode.Text = str;
                btn_Edit.Visible = false;
                btn_Delete.Visible = false;
                side2.Visible = false;
                side3.Visible = false;
                //exp_ID();
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
            list_Data();

        }
        private void list_Data()
        {
            clsCon.list_DataView("select sr_no,e_date,exp_name,e_paid,e_des from view_expdetail where e_date=#" + this.dp_expDetail.Value.Date + "# order by exp_detail.sr_no", this.lstv_ExpDetail);
        }
        private void tab_Index()
        {
            txtEid.TabIndex = 0;
            btnLink.TabIndex = 1;
            txtEname.TabIndex = 2;
            dp_expDetail.TabIndex = 3;
            txtAmtPaid.TabIndex = 4;
            txtDes.TabIndex = 5;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            list_Data();
            text_Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void txtEid_Leave(object sender, EventArgs e)
        {
            try 
            {
                
            clsCon.connCheck();
            OleDbCommand cmd = new OleDbCommand("select * from exp_head where exp_id='" + this.txtEid.Text.Trim() + "'", clsCon.cn);
            OleDbDataReader dr=cmd.ExecuteReader ();
            while (dr.Read ())
            {
                
                
                    this.txtEname.Text = dr["exp_name"].ToString();
               
            }
            
            clsCon.cn.Close ();
            dr.Close ();
            cmd.Dispose();
            }
            catch (Exception exp)
            {
                MessageBox.Show (exp.Message );
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            
            frmFindExp frm_FindExp = new frmFindExp();
            frm_FindExp.str_Find = lbl_Mode.Text.Trim();
            this.Close();
            frm_FindExp.Show();
        }

        private void txtAmtPaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            serial_NO();
            save_ExpDetail();
            list_Data();
            text_Clear();
        }
        private void text_Clear()
        {
            txtEid.Text = "";
            txtEname.Text = "";
            txtAmtPaid.Text = "";
            txtDes.Text = "";
            txtEid.Focus();
        }
        private void save_ExpDetail()
        {
            if (txtEid.Text == "" || txtEname.Text == ""||txtAmtPaid .Text =="")
            {
                MessageBox.Show("Some required Data is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    clsCon.cmdOpen(cmdForm);
                    cmdForm.CommandText = "insert into exp_detail(e_id,e_date,e_paid,e_des,sr_no) values (?,?,?,?,?)";
                    cmdForm.Parameters.Add("@e_id", OleDbType.Char).Value = txtEid.Text.Trim();
                    cmdForm.Parameters.Add("@e_date", OleDbType.Date).Value = this.dp_expDetail.Value.Date;
                    cmdForm.Parameters.Add("@e_paid", OleDbType.Numeric).Value = txtAmtPaid.Text;
                    cmdForm.Parameters.Add("@e_des", OleDbType.Char).Value = txtDes.Text;
                    cmdForm.Parameters.Add("@sr_no", OleDbType.Numeric).Value = this.idVal;
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

        private void serial_NO()
        {
            try
            {

                
                clsCon.connCheck();
                OleDbCommand cmddr = new OleDbCommand("select max(sr_no) as ids from exp_detail where e_date=#" + this.dp_expDetail.Value.Date  + "#", clsCon.cn);
                OleDbDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {
                    string strid = dr["ids"].ToString();
                    if (strid == "")
                    {
                       idVal  = 1;
                    }
                    else
                    {
                        idVal  = Convert.ToInt32(dr["ids"]) + 1;
                       /// newID = myID.ToString();
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

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.lstv_ExpDetail.Refresh();
            list_Data();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            serial_NO();
            edit_ExpDetail();
            list_Data();
        }
        private void edit_ExpDetail()
        {

            OleDbTransaction tran;
            if (this.txtEid .Text == "" || this.txtEname.Text == "" || this.txtAmtPaid.Text =="")
            {


                MessageBox.Show("Some required Fields are Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //First delete the old record

                clsCon.connCheck();
                tran = clsCon.cn.BeginTransaction();

                OleDbCommand cmdDelete = new OleDbCommand();
                cmdDelete.Connection = clsCon.cn;
                cmdDelete.Transaction = tran;
                cmdDelete.CommandText = "delete *  from exp_detail where sr_no=" + editVal + " and e_date=#" + editDate + "#";

                
               // cmdDelete.Parameters.Add("@emp_id", OleDbType.Char).Value = this.txteId.Text.Trim();
                cmdDelete.ExecuteNonQuery();
                //cmdDelete.Parameters.Clear();
                cmdDelete.Dispose();

                //Now Adding new one
                

                try
                {
                    OleDbCommand cmdSave = new OleDbCommand();
                    cmdSave.Connection = clsCon.cn;
                    cmdSave.Transaction = tran;    
                cmdSave.CommandText = "insert into exp_detail(e_id,e_date,e_paid,e_des,sr_no) values (?,?,?,?,?)";
                    cmdSave.Parameters.Add("@e_id", OleDbType.Char).Value = txtEid.Text.Trim();
                    cmdSave.Parameters.Add("@e_date", OleDbType.Date).Value = this.dp_expDetail.Value.Date;
                    cmdSave.Parameters.Add("@e_paid", OleDbType.Numeric).Value = txtAmtPaid.Text;
                    cmdSave.Parameters.Add("@e_des", OleDbType.Char).Value = txtDes.Text;
                    cmdSave.Parameters.Add("@sr_no", OleDbType.Numeric).Value = this.idVal;

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
                    if (this.clsCon.cn != null) this.clsCon.cn.Close();
                }
            }

        }

        private void lstv_Exp_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  this.editID = (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[0].Text.Trim());
            this.txt_Cname.Text = (this.lstv_Class.Items[lstv_Class.FocusedItem.Index].SubItems[1].Text.Trim());*/
          
            try
            {


                clsCon.connCheck();
                OleDbCommand cmddr = new OleDbCommand("select e_id,exp_name,e_date,e_paid,e_des,sr_no from view_expdetail where e_date=#" 
                    + Convert.ToDateTime(this.lstv_ExpDetail.Items[lstv_ExpDetail.FocusedItem.Index].SubItems[1].Text) 
                    + "# and sr_no=" +  (this.lstv_ExpDetail.Items [lstv_ExpDetail .FocusedItem.Index ].SubItems [0].Text .Trim ()), clsCon.cn);
                OleDbDataReader dr = cmddr.ExecuteReader();

                while (dr.Read())
                {

                    txtEid.Text = dr["e_id"].ToString();
                    txtEname.Text = dr["exp_name"].ToString();
                    dp_expDetail.Value = Convert.ToDateTime(dr["e_date"].ToString ());
                    txtAmtPaid.Text = dr["e_paid"].ToString ();
                    txtDes.Text = dr["e_des"].ToString();
                     //Sending Value to Variables For Edit & Delete Process

                    editDate = Convert.ToDateTime(dr["e_date"].ToString());
                    editVal = Convert.ToInt16 (dr["sr_no"]);
                    //=====================================================
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            delete_ExpDetail();
            list_Data();
            text_Clear();
        }

        private void delete_ExpDetail()
        {
            if (txtEid.Text == "" || txtEname.Text == "" || txtAmtPaid.Text == "")
            {
                MessageBox.Show("Some required Data is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    cmdForm.CommandText = "delete *  from exp_detail where sr_no=" + editVal + " and e_date=#" + editDate + "#";


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
            }
            else
            {
                return;
            }
            }
        }
        
    }
}
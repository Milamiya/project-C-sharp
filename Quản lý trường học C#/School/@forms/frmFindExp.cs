using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School._forms
{
    public partial class frmFindExp : Form
    {
        public frmFindExp()
        {
            InitializeComponent();
        }
        public string str_Find;
        _class.clsODBC cls_Con = new School._class.clsODBC();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFindExp_Load(object sender, EventArgs e)
        {
            rdoName.TabIndex = 0;
            rdoID.TabIndex = 1;
            txt_Find.TabIndex = 2;
            this.rdoName.Checked = true;

            cls_Con.list_DataView("select exp_id,exp_name from exp_head order by exp_head.exp_id", lstv_Findexp);

        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {
            if (this.rdoID.Checked == true)
            {
                cls_Con.list_DataView("select exp_id,exp_name from exp_head where exp_id like'" + this.txt_Find.Text.Trim() + "%'  order by exp_head.exp_id", this.lstv_Findexp);
            }
            else
            {
                if (this.rdoName.Checked == true)
                {

                    cls_Con.list_DataView("select exp_id,exp_name from exp_head where exp_name like'" + this.txt_Find.Text.Trim() + "%'  order by exp_head.exp_id", this.lstv_Findexp);
                }
            }
        }

        private void lstv_Findexp_DoubleClick(object sender, EventArgs e)
        {
           
           
            _forms.frmExpDetail frm_Expdetail = new frmExpDetail();
            frm_Expdetail.Refresh();
            frm_Expdetail.txtEid.Text = (this.lstv_Findexp.Items[lstv_Findexp.FocusedItem.Index].SubItems[0].Text.Trim());
            frm_Expdetail.txtEname.Text = (this.lstv_Findexp.Items[lstv_Findexp.FocusedItem.Index].SubItems[1].Text.Trim());
            switch (str_Find.ToString())
            {
                case "Adding":
                    frm_Expdetail.str = "Adding";
                    this.Close();
                    frm_Expdetail.Show();
                    
                    break;
                case "Modifying":
                    frm_Expdetail.str = "Modifying";
                    frm_Expdetail.Show();
                    this.Close();
                    break;


            }
            
            
        }

        private void lstv_Findexp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
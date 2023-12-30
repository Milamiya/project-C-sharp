using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class GiaoDien_SuaxoaLSP : System.Web.UI.Page
{
    DataClassesDataContext db = new DataClassesDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        Bindata();
    }
    void Bindata()
    {
        var c = from a in db.ProductGroups select a;
        rptFirm.DataSource = c;
        rptFirm.DataBind();
    }

    protected void rptFirm_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        RepeaterItem item = e.Item;

        Label lbFId = (Label)item.FindControl("lbMaLSP");

        Label lbFName = (Label)item.FindControl("lbTenLSP");
        TextBox txtFName = (TextBox)item.FindControl("txtTenLSP");

        LinkButton lbtnEdit = (LinkButton)item.FindControl("lbtnEdit");
        LinkButton lbtnCancel = (LinkButton)item.FindControl("lbtnCancel");
        LinkButton lbtnSave = (LinkButton)item.FindControl("lbtnSave");

        if (e.CommandName == "EditThis")
        {
            lbFName.Visible = false;

            lbtnEdit.Visible = false;
      

            txtFName.Visible = true;
           
            lbtnCancel.Visible = true;
            lbtnSave.Visible = true;
        }
        else if (e.CommandName == "CancelThis")
        {
            lbFName.Visible = true;
           

            lbtnEdit.Visible = true;

            txtFName.Visible = false;
           

            lbtnCancel.Visible = false;
            lbtnSave.Visible = false;
        }
        else if (e.CommandName == "SaveThis")
        {
           
            lbFName.Visible = true;
            lbtnEdit.Visible = true;

            txtFName.Visible = false;
            lbtnCancel.Visible = false;
            lbtnSave.Visible = false;
            ProductGroup P = db.ProductGroups.SingleOrDefault(c => c.ProductGroupID == int.Parse(lbFId.Text));
            P.ProductGroupName = txtFName.Text;
            db.SubmitChanges();

        }



    }
    void ck_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox ck = (CheckBox)rptFirm.FindControl("ckCheckAll");
        if (ck.Checked)
        {
            foreach (RepeaterItem item in rptFirm.Items)
            {
                ((CheckBox)item.FindControl("ckCheck")).Checked = true;
            }
        }
        else
        {

        }

    }
    protected void ibtnDelte_Click(object sender, ImageClickEventArgs e)
    {
        foreach (RepeaterItem it in rptFirm.Items)
        {
            if ((it.FindControl("ckCkeck") as CheckBox).Checked)
            {
                string id = (it.FindControl("lbFID") as Label).Text;
                ProductGroup P=db.ProductGroups.SingleOrDefault(C=>C.ProductGroupID==int.Parse(id));
                db.ProductGroups.DeleteOnSubmit(P);
                db.SubmitChanges();
            }
        }
    }
}

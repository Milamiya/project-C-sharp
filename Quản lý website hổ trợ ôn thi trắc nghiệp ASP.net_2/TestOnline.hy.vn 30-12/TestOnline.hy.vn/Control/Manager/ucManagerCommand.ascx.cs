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

namespace TestOnline.hy.vn.Control.Manager
{
    public partial class ucManagerCommand : System.Web.UI.UserControl
    {
        TestOnlineDataContext db = new TestOnlineDataContext();
        void LoadGridview()
        {
            var cl = from c in db.tblCommands
                     orderby c.CreateDate descending
                     select c;
            grvCommand.DataSource = cl;
            grvCommand.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridview();
            }
        }
        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {
            int record = 0;
            TestOnlineDataContext db = new TestOnlineDataContext();
            foreach (GridViewRow row in grvCommand.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("chkSelect");
                if (chk != null)
                {
                    if (chk.Checked)
                    {

                        LinkButton link = (LinkButton)row.FindControl("btnXoa");
                        tblCommand at = db.tblCommands.SingleOrDefault(c => c.CommandID.ToString() == link.CommandArgument.ToString());
                        if (at != null)
                        {
                            // delete file when xoa

                            db.tblCommands.DeleteOnSubmit(at);
                            db.SubmitChanges();
                            record++;
                        }
                    }
                }
            }
            if (record > 0)
            {

                LoadGridview();
                // when will announciment

                lblThongBao.Text = "Bạn vừa xóa thành công " + record.ToString() + " bản ghi!";
                lblThongBao.Visible = true;

            }
            else
            {
                lblThongBao.Text = "Không có bản ghi nào được chọn !";
                lblThongBao.Visible = true;
            }

        }

        protected void grvCommand_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int pageIndex = e.NewPageIndex;
            LoadGridview();
            grvCommand.PageIndex = pageIndex;
            grvCommand.DataBind();
        }

        protected void grvCommand_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            //Xóa 1 hàng trong gridview
            if (e.CommandName == "Delete")
            {
                tblCommand doc = db.tblCommands.SingleOrDefault(d => d.CommandID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    db.tblCommands.DeleteOnSubmit(doc);
                    db.SubmitChanges();
                    LoadGridview();
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Bạn đã xóa thành công";
                }

            }
        }
        protected void grvCommand_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#D7EBFF'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }
        }

        protected void grvCommand_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //Find the checkbox control in header and add an attribute
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript:SelectAll('" +
                        ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "','" + grvCommand.ClientID + "')");

            }
        }
        protected void grvCommand_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGridview();
        }
    }
}
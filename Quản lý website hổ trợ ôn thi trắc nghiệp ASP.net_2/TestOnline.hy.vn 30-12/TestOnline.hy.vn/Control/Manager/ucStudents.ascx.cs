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
    public partial class ucStudents : System.Web.UI.UserControl
    {
        void LoadGrid()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            grvStudent.DataSource = db.tblStudents;
            grvStudent.DataBind();
             
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGrid();
        }

        protected void grvStudent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            int page = e.NewPageIndex;
            LoadGrid();
            grvStudent.PageIndex = page;
            grvStudent.DataBind();

        }

        protected void grvStudent_RowCommand(object sender, GridViewCommandEventArgs e)
        {
         
            TestOnlineDataContext db = new TestOnlineDataContext();
            //Xóa 1 hàng trong gridview
            if (e.CommandName == "Delete")
            {
                tblStudent doc = db.tblStudents.SingleOrDefault(d => d.StudentID.ToString().Trim() == e.CommandArgument.ToString().Trim());
                if (doc != null)
                {
                    db.tblStudents.DeleteOnSubmit(doc);
                    db.SubmitChanges();
                    LoadGrid();
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Bạn đã xóa thành công";
                }

            }
        }

        protected void grvStudent_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //Find the checkbox control in header and add an attribute
                ((CheckBox)e.Row.FindControl("cbSelectAll")).Attributes.Add("onclick", "javascript:SelectAll('" +
                        ((CheckBox)e.Row.FindControl("cbSelectAll")).ClientID + "','" + grvStudent.ClientID + "')");

            }

        }

        protected void grvStudent_RowCreated(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onmouseover", "this.originalstyle=this.style.backgroundColor;this.style.backgroundColor='#D7EBFF'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=this.originalstyle;");
            }

        }

        protected void grvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LoadGrid();
        }

        protected void btnDeleteAll_Click(object sender, EventArgs e)
        {
            int record = 0;
            TestOnlineDataContext db = new TestOnlineDataContext();
            foreach (GridViewRow row in grvStudent.Rows)
            {
                CheckBox chk = (CheckBox)row.FindControl("chkSelect");
                if (chk != null)
                {
                    if (chk.Checked)
                    {

                        LinkButton link = (LinkButton)row.FindControl("btnXoa");
                        tblStudent at = db.tblStudents.SingleOrDefault(c => c.StudentID.ToString() == link.CommandArgument.ToString());
                        if (at != null)
                        {
                            // delete file when xoa

                            db.tblStudents.DeleteOnSubmit(at);
                            db.SubmitChanges();
                            record++;
                        }
                    }
                }
            }
            if (record > 0)
            {

                LoadGrid();
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
    }
}
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

namespace TestOnline.hy.vn.Control
{
    public partial class ucQuestionStudent : System.Web.UI.UserControl
    {
        void LoadComment()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            rptTile1.DataSource = from c in db.tblCommands
                                  orderby c.CreateDate
                                  select new {c.CreateDate,c.CommandName,c.CommandID,c.StudentID,c.tblStudent.StudentName};
            rptTile1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["login"].ToString() == "0")
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                //Download source code tai Sharecode.vn
                if (!IsPostBack)
                {
                    LoadComment();
                }
            }
        }
        protected void btnSend_Click1(object sender, EventArgs e)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            if (txtContent.Text != "")
            {
                tblCommand tbl = new tblCommand();
                tbl.CommandName = txtContent.Text;
                tbl.StudentID = Session.Contents["AcountID"].ToString();
                tbl.CreateDate = DateTime.Now;
                db.tblCommands.InsertOnSubmit(tbl);

                db.SubmitChanges();
                lblThongBao.Text = "Bạn đã gửi thành công";
                lblThongBao.Text = "";
                LoadComment();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";
        }

        protected void rptTile1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        { TestOnlineDataContext db=new TestOnlineDataContext();
            HiddenField id = (HiddenField)e.Item.FindControl("hdfid");
            Repeater rpt = (Repeater)e.Item.FindControl("rptRespon");
            var cl = from c in db.tblRespons
                     where c.CommandID.ToString() == id.Value.ToString()
                     select c;
            rpt.DataSource = cl;
            rpt.DataBind();
        }
    }
}
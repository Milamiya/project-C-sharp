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

namespace TestOnline.hy.vn
{
    public partial class ThreadUniversity : System.Web.UI.Page
    {
        /// <summary>
        /// Load môn học
        /// </summary>
        void LoadSubject()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            ddlSubject.DataSource = db.tblSubjects;
            ddlSubject.DataBind();
            ddlSubject.Items.Add("-- Chọn môn thi --");
        }
        void LoadThread(string subjectID)
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            var cl = from c in db.tblThreads
                     where c.Status == 4 && c.SubjectID.ToLower().ToString() == subjectID.ToLower()
                     select new { c.ThreadsID, c.TheadName };
            ddlThread.DataSource = cl;
            ddlThread.DataBind();
            ddlThread.Items.Add("-- Chọn đề thi --");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["login"].ToString() == "0")
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                this.Title = "Đề thi đại học và cao đẳng";
                if (!IsPostBack)
                {

                    TestOnlineDataContext db = new TestOnlineDataContext();
                    LoadSubject();
                    LoadThread(ddlSubject.SelectedValue.ToString());
                    lblThongBao.Text = "Chọn đề thi để tiến hành thi";
                    ddlSubject.SelectedIndex = ddlSubject.Items.Count - 1;
                    ddlThread.SelectedIndex = ddlThread.Items.Count - 1;

                }
            }

        }

        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThread(ddlSubject.SelectedValue.ToString());
        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            if (ddlThread.SelectedIndex != ddlThread.Items.Count - 1)
            {
                Response.Redirect("HomeTest.aspx?threadid=" + ddlThread.SelectedValue.ToString());
            }
            else
            {
                lblThongBao.Text="Bạn chưa chọn đề đi";
            }
        }
    }
}

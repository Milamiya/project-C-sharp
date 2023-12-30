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
    public partial class ucBangXepHang : System.Web.UI.UserControl
    {
        void Loadgridview(string threadID)
        {
            TestOnlineDataContext db=new TestOnlineDataContext();
            var cl =( from c in db.tblResultsIDs
                          orderby c.Score descending
                     where c.ThreadsID == threadID && c.tblThread.Status==3
                     select new { c.Score, c.StudentID, c.tblStudent.StudentName, c.tblStudent.RegistrationDate, c.tblStudent.Email, c.tblStudent.City, c.tblStudent.Birthday }).Distinct();
            grvStudent.DataSource = cl;
            grvStudent.DataBind();
        }
        void LoadComboboxSelect()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            ddlSelect.DataSource = from c in db.tblThreads
                                   where c.Status==3 && c.SubjectID.ToString()==ddlSubject.SelectedValue.ToString()
                                   orderby c.ThreadsID descending
                                   select new { c.ThreadsID, c.TheadName };
            ddlSelect.DataBind();
            //Download source code tai Sharecode.vn
        }
        void LoadSubject()
        {
            TestOnlineDataContext db = new TestOnlineDataContext();
            ddlSubject.DataSource = db.tblSubjects;
            ddlSubject.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                LoadSubject();
                LoadComboboxSelect();
                string threadID = Request.QueryString["threadID"];
                if (threadID != null && threadID != "")
                {
                   
                    Loadgridview(threadID);
                    ddlSelect.SelectedValue = threadID;
                }
            }
        }

        protected void ddlSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadgridview(ddlSelect.SelectedValue.ToString());
        }

        protected void ddlSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboboxSelect();
            Loadgridview(ddlSelect.SelectedValue.ToString());
        }
    }
}
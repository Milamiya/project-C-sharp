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
    public partial class ucListThread : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            TestOnlineDataContext db = new TestOnlineDataContext();
            string subjectID = Request.QueryString["SubjectID"];
            string status = Request.QueryString["Status"];
            if (status == "2")
            {
                bool kt = false;
                var cl = db.tblThreads.Where(c => c.SubjectID.ToString() == subjectID && c.Status == 2 && c.Hour.ToString() !=""  && c.Minute.ToString() !="");
              
                    foreach (var item in cl)
                    {
                        kt = true;
                        Response.Redirect("HomeTest.aspx?threadid=" + item.ThreadsID.ToString()); break;
                    }
                if(kt==false)
                { Response.Redirect("TestThread.aspx"); }
                //Response.Redirect("TestThread.aspx");
               
                ////tblThread tbl = db.tblThreads.SingleOrDefault( && c.Hour.ToString()!="" && c.Minute.ToString()!="" && c.DateTest.Date == DateTime.Now.Date && ((double.Parse(c.Hour) * 60 + double.Parse(c.Minute)) <= double.Parse((DateTime.Now.Hour * 60 + DateTime.Now.Minute).ToString())) && (((double.Parse(c.Hour) * 60 + double.Parse(c.Minute)) + 90) >= double.Parse((DateTime.Now.Hour * 60 + DateTime.Now.Minute).ToString()) && c.Status == 2));
                //if (cl != null)
                //{
                    
                //        Response.Redirect("TestThread.aspx");
                //        //Response.Redirect("HomeTest.aspx?threadid=" + item.ThreadsID.ToString());
                    
                //}
                //else
                //{
                //    Response.Redirect("TestThread.aspx");
                //}
                //Response.Redirect("TestThread.aspx");
            }
            else
            {
                if (status == "3")
                {
                    Response.Redirect("DeDaThi.aspx?SubjectID="+subjectID);
                }
                else
                {
                    if (!IsPostBack)
                    {//Download source code tai Sharecode.vn
                        var cl = (from c in db.tblThreads
                                  orderby c.CreateDate descending
                                  where c.Level == 1 && c.SubjectID.ToString() == subjectID && c.Status.ToString() == status
                                  select new { c.ThreadsID, c.TheadName, c.CreateDate }).Skip(0).Take(18);
                        rpt1.DataSource = cl;
                        rpt1.DataBind();

                        var cl2 = (from c in db.tblThreads
                                   orderby c.CreateDate descending
                                   where c.Level == 2 && c.SubjectID.ToString() == subjectID && c.Status.ToString() == status
                                   select new { c.ThreadsID, c.TheadName, c.CreateDate }).Skip(0).Take(18);
                        rpt2.DataSource = cl2;
                        rpt2.DataBind();

                        var cl3 = (from c in db.tblThreads
                                   orderby c.CreateDate descending
                                   where c.Level == 3 && c.SubjectID.ToString() == subjectID && c.Status.ToString() == status
                                   select new { c.ThreadsID, c.TheadName, c.CreateDate }).Skip(0).Take(18);
                        rpt3.DataSource = cl3;
                        rpt3.DataBind();
                    }
                }
            }
        }
    }
}
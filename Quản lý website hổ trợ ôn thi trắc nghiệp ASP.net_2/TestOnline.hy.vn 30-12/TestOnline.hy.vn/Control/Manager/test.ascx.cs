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
using System.Collections.Generic;

namespace TestOnline.hy.vn.Control.Manager
{
    public partial class test : System.Web.UI.UserControl
    {
        TestOnlineDataContext dc;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Contents["login"].ToString() == "0")
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    dc = new TestOnlineDataContext();
                    string threadID = ""; threadID = Request.QueryString["threadid"];
                    string subjectID = Request.QueryString["subjectID"];
                    threadID = threadID.Replace("'", "");
                    loadcauhoi(threadID);
                    tblThread th = dc.tblThreads.SingleOrDefault(c => c.ThreadsID.ToString() == threadID);
                    if (th != null)
                    {
                        lblThread.Text = th.TheadName;
                        lblSubject.Text = th.tblSubject.SubjectName;
                        if (th.HitCount.ToString() == "")
                        { th.HitCount = 1; }
                        else th.HitCount=th.HitCount+1;
                        if (th.Status == 2)
                        {
                            DateTime t = DateTime.Now;
                            DateTime t1 = Convert.ToDateTime(th.DateTest);
                            DateTime t2 = t1.AddMinutes(90);
                            TimeSpan t3 = t2 - t;
                            string s1 = t3.Minutes.ToString();
                            Label2.Text = "<input name='thoigian' type='hidden' value='" + s1 + "'>";
                        }
                    }
                    dc.SubmitChanges();
                    lblFullName.Text = Session.Contents["FullName"].ToString();

                }
            }
        }
        void loadcauhoi(string threadID)
        {
            dc = new TestOnlineDataContext();
            var a = from c in dc.tblThreadQuestions where c.ThreadsID == threadID select new { c.tblQuestion.Answer, c.tblQuestion.ChocieA, c.tblQuestion.ChocieB, c.tblQuestion.ChocieC, c.tblQuestion.ChocieD, c.tblQuestion.Content };
            string html = "<table style='width:100%'>";
            int i = 0;
            foreach (var item in a)
            {
                i++;
                html += "<tr><td>" + "<input name='dapan' type='hidden' value='" + item.Answer + "'>" + " </td></tr>";
                html += "<tr><td>" + "Câu hỏi : " + i + " </td></tr>";
                html += "<tr><td >" + item.Content.ToString() + " </td></tr>";
                html += "<tr><td name='phuongan" + i + "'>" + "<input name='" + i + "' type='radio' value='" + item.ChocieA.ToString() + "' />" + item.ChocieA.ToString() + " </td></tr>";
                html += "<tr><td name='phuongan" + i + "'>" + "<input name='" + i + "' type='radio' value='" + item.ChocieB.ToString() + "' />" + item.ChocieB.ToString() + " </td></tr>";
                html += "<tr><td name='phuongan" + i + "'>" + "<input name='" + i + "' type='radio' value='" + item.ChocieC.ToString() + "' />" + item.ChocieC.ToString() + " </td></tr>";
                html += "<tr><td name='phuongan" + i + "'>" + "<input name='" + i + "' type='radio' value='" + item.ChocieD.ToString() + "' />" + item.ChocieD.ToString() + " </td></tr>";
            }
            html += "</table>";
            html += "<input id='socau' type='hidden' value='" + i + "'>";
            Label1.Text = html;
        }
    }
}
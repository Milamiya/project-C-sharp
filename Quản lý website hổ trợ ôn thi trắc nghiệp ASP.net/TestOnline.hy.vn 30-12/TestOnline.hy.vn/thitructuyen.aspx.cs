using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

namespace TestOnline.hy.vn
{
    public partial class thitructuyen : System.Web.UI.Page
    {
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
                    LinkButton1.Visible = false;
                    string SubjectID = Request.QueryString["SubjectID"];
                    loadngaythi(SubjectID);
                }
            }
        }
        TestOnlineDataContext dc;
        void loadngaythi(string SubjectID)
        {
            dc = new TestOnlineDataContext();
            string s="";
            tblThread a = dc.tblThreads.SingleOrDefault(p => p.SubjectID == SubjectID && p.Status==2);
            if (a == null)
            {
                 s = "<div>Hiện tại không có cuộc thi trắc nghiệm online nào</div>";
            }
            else
            {
                DateTime t = DateTime.Now;
                DateTime t1 =Convert.ToDateTime(a.DateTest);
                DateTime t2 = t1.AddMinutes(90);
                int tmp = DateTime.Compare(t, t1);
                int tmp2 = DateTime.Compare(t2, t);
                    if (tmp>=0)
                    {
                        if (tmp2 == 1)
                        {
                            LinkButton1.Visible = true;
                            string threadID = a.ThreadsID.ToString();
                            s = "<div>Nhấn nút Enter để vào thi  </div>";
                            LinkButton1.PostBackUrl = "~/HomeTest.aspx?threadid=" + threadID;
                        }
                        if (tmp2 <= 0)
                        {
                            s = "<div>Qúa giờ thi</div>";
                        }
                    }
                    else
                        s = "<div>Chưa đến giờ thi </div>";
            }
            Label1.Text = s;
        }
    }
}

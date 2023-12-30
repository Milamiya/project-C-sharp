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
    public partial class ParentPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadchonmon();
                loadsoluongcauhoi();
            }
        }
        TestOnlineDataContext db = new TestOnlineDataContext();
        void loadsoluongcauhoi()
        {

            ddlsoluongcauhoi.Items.Add("4");
            ddlsoluongcauhoi.Items.Add("5");
            ddlsoluongcauhoi.Items.Add("6");
        }
        void loadchonmon()
        {
            var cl = from c in db.tblSubjects
                     select new { c.SubjectID, c.SubjectName };
            foreach (var item in cl)
            {
                ddlchonmon.Items.Add(item.SubjectName);
            }
        }
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
       
        protected void Accept_Click(object sender, EventArgs e)
        {

                int mucdo = 0;
                if (rdbmucdo.SelectedItem.Text == "Khó")
                {
                    mucdo = 1;
                } if (rdbmucdo.SelectedItem.Text == "Trung bình")
                {
                    mucdo = 2;
                } if (rdbmucdo.SelectedItem.Text == "Dễ")
                {
                    mucdo = 3;
                }
                var cl = from c in db.tblThreads where c.Level == mucdo && c.NumberQuestions == int.Parse(ddlsoluongcauhoi.Text) && c.tblSubject.SubjectName == ddlchonmon.Text select new { c.ThreadsID };
                foreach (var item in cl)
                {
                    ddlchonde.Items.Add(item.ThreadsID);
                }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnStart_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("test/Hometest.aspx?threadid='"+ddlchonde.SelectedValue.ToString()+"'");
        }
    }
}

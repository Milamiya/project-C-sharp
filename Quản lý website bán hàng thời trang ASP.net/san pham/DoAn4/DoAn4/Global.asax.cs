using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace DoAn4
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["songuoionline"] = 0;
            // Code that runs on application startup
            Application.Lock();
            System.IO.StreamReader sr = new System.IO.StreamReader(Server.MapPath("SL.txt"));
            String s = sr.ReadLine();

            int so = Convert.ToInt32(s);
            sr.Close();

            Application.UnLock();
            Application.Add("soluottruycap", so);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application["songuoionline"] = int.Parse(Application["songuoionline"].ToString()) + 1;
            Application.Contents["soluottruycap"] = int.Parse(Application.Contents["soluottruycap"].ToString()) + 1;
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Server.MapPath("SL.txt"));
            sw.Write(Application.Contents["soluottruycap"].ToString());
            sw.Close();

            GioHang gh = new GioHang();
            Session["giohang"] = gh;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application["songuoionline"] = int.Parse(Application["songuoionline"].ToString()) - 1;
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}
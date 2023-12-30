using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;

namespace TestOnline.hy.vn
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Add("login", "0");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session.Add("login", "0");
            Session.Add("FullName", "0");
            Session.Add("loginManager", "0");
            Session.Add("AcountID", "0");
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
            Session.Add("login", "0");
            Session.Add("FullName", "0");
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}
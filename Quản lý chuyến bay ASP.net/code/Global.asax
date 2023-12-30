<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

        Application["skv"] = 0;
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        Session["tendn"] = "";
        AccessDataSource vd2 = new AccessDataSource();
        vd2.DataFile = Server.MapPath(".") + "//App_Data/db1.mdb";
        vd2.UpdateCommandType = SqlDataSourceCommandType.Text;
        vd2.UpdateCommand = "UPDATE demtruycap SET [Count] = [Count] + 1";
        vd2.Update();
        // Code that runs when a new session is started
        Application["skv"] = (int)Application["skv"] + 1;
    }

    void Session_End(object sender, EventArgs e) 
    {
        Application["songuoionline"] = (int)Application["songuoionline"] - 1;
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>

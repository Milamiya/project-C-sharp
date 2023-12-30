<%@ Application Language="C#" %>

<script runat="server">
    string s;
    int sltructuyen = 0;
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        Application.Lock();
        System.IO.StreamReader sr;
        sr = new System.IO.StreamReader(Server.MapPath("App_Data/sl.txt"));
        s = sr.ReadLine();
        sr.Close();
        //sr1 = new System.IO.StreamReader(Server.MapPath("App_Data/tt.txt"));
        //s1 = sr1.ReadLine();
        Application.UnLock();
        Application.Add("sltruycap", s);
        Application.Add("sltructuyen", sltructuyen);
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
        Application.Contents["sltructuyen"] = 0;
        //System.IO.StreamWriter sw3;
        //sw3 = new System.IO.StreamWriter(Server.MapPath("App_Data/tt.txt"));
        //sw3.Write(Application.Contents["sltructuyen"].ToString());
        //sw3.Close();
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
       
    }

    void Session_Start(object sender, EventArgs e) 
    {
        
        // Code that runs when a new session is started
        Application.Contents["sltruycap"] = int.Parse(Application.Contents["sltruycap"].ToString()) + 1;
        sltructuyen =int.Parse( Application.Contents["sltructuyen"].ToString())+1;
        System.IO.StreamWriter sw;
        sw = new System.IO.StreamWriter(Server.MapPath("App_Data/sl.txt"));
        sw.Write(Application.Contents["sltruycap"].ToString());
        Application.Contents["sltructuyen"] = sltructuyen;
        //sw1 = new System.IO.StreamWriter(Server.MapPath("App_Data/tt.txt"));
        //sw1.Write(Application.Contents["sltructuyen"].ToString());
        sw.Close();
        //sw1.Close();
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
       sltructuyen=int.Parse(Application.Contents["sltructuyen"].ToString())- 1;
       Application.Contents["sltructuyen"] = sltructuyen;
    }
       
</script>

<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        Application.Add("dem", 0);
        Application["count_visit"] = 0;

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown    
        Application.Remove("dem");                  
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started 
        Session.Add("Login", "");
        Session.Add("Newsid", "");
        int so = int.Parse(Application.Get("dem").ToString());
        so++;
        Application.Set("dem", so);
        int count_visit = 0;
        if (System.IO.File.Exists(Server.MapPath("count_visit.txt")) == false)
        {
            count_visit = 1;
        }
        else
        {
            System.IO.StreamReader read = new System.IO.StreamReader(Server.MapPath("count_visit.txt"));
            count_visit = int.Parse(read.ReadLine());
            
            count_visit++;
            read.Close();
        }
        //Application.Lock();
        Application["count_visit"] = count_visit;
        //Application.UnLock();
        System.IO.StreamWriter writer = new System.IO.StreamWriter(Server.MapPath("count_visit.txt"));
        writer.WriteLine(count_visit);
        writer.Close();

    }
    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.
        int so = int.Parse(Application.Get("dem").ToString());
        so--;
        Application.Set("dem", so);
    }
       
</script>

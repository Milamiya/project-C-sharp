<%@ Application Language="C#" %>

<script RunAt="server">

    void Application_Start(object sender, EventArgs e)
    {
        if (System.IO.File.Exists(Server.MapPath("count_visit.txt")) == false)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(Server.MapPath("count_visit.txt"));
            sw.Write("1");
            sw.Close();
        }

    }

    void Application_End(object sender, EventArgs e)
    {
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Server.MapPath("count_visit.txt"));
        sw.Write("0#0");
        sw.Close();
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {

        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e)
    {
        // Code that runs when a new session is started
        System.IO.StreamReader sr = new System.IO.StreamReader(Server.MapPath("count_visit.txt"));
        string[] s = sr.ReadLine().Split('#');
        string s1 = s[0].ToString();
        string s2 = s[1].ToString();
        int i = int.Parse(s1.ToString()) + 1;
        int i2 = int.Parse(s2.ToString()) + 1;
        sr.Close();
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Server.MapPath("count_visit.txt"));
        sw.Write(i.ToString() + "#" + i2.ToString());
        sw.Close();

    }

    void Session_End(object sender, EventArgs e)
    {
        System.IO.StreamReader sr = new System.IO.StreamReader(Server.MapPath("count_visit.txt"));
        string[] s = sr.ReadLine().Split('#');
        string s2 = s[1].ToString();
        int i2 = int.Parse(s2.ToString()) - 1;
        sr.Close();
        System.IO.StreamWriter sw = new System.IO.StreamWriter(Server.MapPath("count_visit.txt"));
        sw.Write(s[0].ToString() + "#" + i2.ToString());
        sw.Close();
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>


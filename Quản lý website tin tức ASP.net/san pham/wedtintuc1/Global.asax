<%@ Application Language="C#" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Data" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        Application["HomNay"] = 0;
        Application["HomQua"] = 0;
        Application["TuanNay"] = 0;
        Application["TuanTruoc"] = 0;
        Application["ThangNay"] = 0;
        Application["ThangTruoc"] = 0;
        Application["TatCa"] = 0;
        Application["Online"] = 0;

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
        Session.Timeout = 150;
        Application.Lock();
        Application["Online"] = Convert.ToInt32(Application["Online"]) + 1;
        Application.UnLock();
        try
        {
            ThongKe tk = new ThongKe();
            DataTable dtb = tk.BangThongKe();
            if (dtb.Rows.Count > 0)
            {
                Application["HomNay"] = long.Parse("0" + dtb.Rows[0]["HomNay"]).ToString("#,###");
                Application["HomQua"] = long.Parse("0" + dtb.Rows[0]["HomQua"]).ToString("#,###");
                Application["TuanNay"] = long.Parse("0" + dtb.Rows[0]["TuanNay"]).ToString("#,###");
                Application["TuanTruoc"] = long.Parse("0" + dtb.Rows[0]["TuanTruoc"]).ToString("#,###");
                Application["ThangNay"] = long.Parse("0" + dtb.Rows[0]["ThangNay"]).ToString("#,###");
                Application["ThangTruoc"] = long.Parse("0" + dtb.Rows[0]["ThangTruoc"]).ToString("#,###");
                Application["TatCa"] = long.Parse("0" + dtb.Rows[0]["TatCa"]).ToString("#,###");
            }
            dtb.Dispose();
            tk = null;
        }
        catch { }
    }

    void Session_End(object sender, EventArgs e) 
    {
        Application.Lock();
        Application["Online"] = Convert.ToUInt32(Application["Online"]) - 1;
        Application.UnLock();
    }
       
</script>

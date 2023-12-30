﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class control_TopMusic : System.Web.UI.UserControl
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SVR"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "select top 10 * from Music ORDER BY LuotXem Desc";
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(sql, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        TopMusic__.DataSource = ds;
        TopMusic__.DataBind();
        con.Close();
    }
}
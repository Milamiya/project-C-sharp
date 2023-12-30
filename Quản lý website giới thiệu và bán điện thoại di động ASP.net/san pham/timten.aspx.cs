using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;
public partial class Default3 : System.Web.UI.Page
{
    HyperLink hplThongTin;
    //OleDbConnection con;  
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
            Label8.Text += Session["TuKhoa"];
            if (Session["KQTimKiem"] != null)
            {
                DataTable dt = (DataTable)Session["KQTimKiem"];
                
                GridView1.DataSource =  dt;
                GridView1.DataBind();
                foreach (GridViewRow gr in GridView1.Rows)
                {
                    hplThongTin = (HyperLink)gr.FindControl("hplThongTin");
                    hplThongTin.NavigateUrl = "~/chitiet.aspx?tensp=" + gr.Cells[1].Text ;
                }
                //Download source code tại Sharecode.vn
            }           
        } 
        
  
   }
}

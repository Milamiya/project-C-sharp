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
using System.Data.SqlClient;
using System.Net.Mail;
using System.Threading;
using System.Globalization;
public partial class Trangchu : System.Web.UI.MasterPage
{
    clsDatabase cls = new clsDatabase();
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt;
        if (Session["GioHang"] == null)
        {
            dt = cls.GetDataTable();
        }
        else
        {
            dt = (DataTable)Session["GioHang"];
        }
        int dem = 0;
        dem = dt.Rows.Count;
        lbGioHang.Text = dem.ToString();
        //lbMax.Text = SPmax();
        DataTable tb = cls.LoadDuLieuPKN("SELECT top(3)ProductID, ImageURL, ProductName, Manufacturer, SoLuong FROM SPbanchay WHERE (SoLuong >= ANY(SELECT SoLuong AS Expr1 FROM SPbanchay AS SPbanchay_1 GROUP BY SoLuong))");
        string chuoi = "";
        string img = "";
        foreach (DataRow dr in tb.Rows)
        {            
            chuoi = "<div class='panelTable'>";
            chuoi += "<div style='text-align:center;height:110px'>";
            chuoi += "<img src='"+ dr[1].ToString() + "' Height='120px' Width='140px' />";            
            chuoi += "</div>";
            chuoi += "<div class='menu' style='width:auto;text-align:center;background-color:white;height:60px;'>";
            chuoi += "<a href='ProductDetails.aspx?ProductID=" + dr[0].ToString() + "' style='color:#0066FF;font-weight:bold; width:190px'>";
            chuoi += dr[2].ToString();
            chuoi += "</a>";
            chuoi += "</div>";
            chuoi += "</div>";
            Show1.AddHtmlPanel(chuoi);
        }
    }
    //public string SPmax()
    //{
        //DataTable tb;
        //string chuoi = "";
        ////tb = cls.LoadDuLieuPKN("SELECT top(3) ProductID, ImageURL, ProductName, Manufacturer, SoLuong FROM SPbanchay WHERE (SoLuong = (SELECT MAX(SoLuong) AS Expr1 FROM SPbanchay AS SPbanchay_1))");
        //tb = cls.LoadDuLieuPKN("select * from tbProduct");
        //chuoi = "<marquee width=\"190px\" scrollamount=\"2\" scrolldelay=\"1\" direction=\"up\" loop=\"infinite\">";
        //foreach (DataRow dr in tb.Rows)
        //{
        //    chuoi += "<asp:Label id='lb1' runnat='server'>'"+dr[1].ToString()+"'</asp:Label>";
        //}
        //chuoi += "</marquee>";
        //return chuoi;        
    //}
    protected void btGui_Click(object sender, EventArgs e)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            
            mail.From = new MailAddress("truongnt90@gmail.com");            
            mail.To.Add("truongnt90@gmail.com");
            mail.Subject = txtChuDe.Text;
            mail.Body = txtNoiDung.Text;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("truongnt90@gmail.com", "truongit");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);            
        }
        catch (Exception ex)
        {
            
        }   
    }
    public void SearchCase(Page searchPage)
    {
        //string chungloai = (DropDownList)searchPage.FindControl("DDLChungLoai");
        //string chuoi = (TextBox)searchPage.FindControl("txtQueryString");
    }
    protected void btTim_Click(object sender, EventArgs e)
    {        
        string chungloai = DDLChungLoai.SelectedValue;        
        string chuoi = txtQueryString.Text;
        Response.Redirect("Search.aspx?chungloai=" + chungloai + "&tukhoa=" + chuoi);                
    }    
}

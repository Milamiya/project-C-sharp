using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    DataTable tb; string s; System.IO.StreamReader sr1; System.IO.StreamWriter sw1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((Session["diachi"] != null) && (Session["hoten"] != null))
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            tb = (DataTable)Session["hangmua"];
            GridView1.DataSource = tb;
            GridView1.DataBind();
            lbtien.Text = Session["tong"].ToString() + "VND";
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void imdangnhap_Click(object sender, ImageClickEventArgs e)
    {
        Session["dn"] = "kk";
        Response.Redirect("dangnhap.aspx", true);
    }


    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if(Session["email"]!=null)
        {
            Panel3.Visible = true;     
        ado.ketNoi();
        string ngay = System.DateTime.Now.ToString();
        ngay = ngay.Substring(0, ngay.IndexOf(" "));
        string sql = "insert into tbldondathang(email,dcgiaohang,htgiaohang,htthanhtoan,ngaydat,ngaygiao) values('"+Session["email"].ToString()+"','"+txtdcgiaohang.Text+"','"+txtgiaohang.Text+"','"+DropDownList1.Text+"','"+ngay+"','"+txtngaygiao.Text+"')";
        OleDbCommand cmd = new OleDbCommand(sql,ado.con);
        cmd.ExecuteNonQuery();
        
        sr1 = new System.IO.StreamReader(Server.MapPath("App_Data/thanhtoan.txt"));       
      s = sr1.ReadLine();
      int t = int.Parse(s.ToString()) + 1;
      sr1.Close();
     
        foreach (DataRow r in tb.Rows)
        {
            
            string sql1 = "insert into tblhoadontt(maddh,masp,soluong,gia) values('" + t.ToString() + "','" + r[0].ToString() + "','" + r[1].ToString() + "','" + r[2].ToString() + "')";
            OleDbCommand cmd1 = new OleDbCommand(sql1, ado.con);
            cmd1.ExecuteNonQuery();          
            
        }
       
        sw1 = new System.IO.StreamWriter(Server.MapPath("App_Data/thanhtoan.txt"));
        sw1.Write(t.ToString());
        sw1.Close();
       

        }
    }
}

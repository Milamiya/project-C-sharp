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
public partial class giohang : System.Web.UI.Page
{
    GioHangData gh; HyperLink hplThongTin;   
    void nap()
    {
        GridView1.PageSize = 10;

        if (!IsPostBack)
        {
            if (Session["GioHang"] != null)
            {
                DataTable dt = (DataTable)Session["GioHang"];

                if (dt.Rows.Count == 0)
                {
                    Panel2.Visible = true;
                    Panel3.Visible = false;
                }
                else
                {
                    Panel3.Visible = true;
                    tinhtien(dt);
                    Panel2.Visible = false;
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    foreach (GridViewRow gr in GridView1.Rows)
                    {
                        hplThongTin = (HyperLink)gr.FindControl("hplthongtin");
                        hplThongTin.NavigateUrl = "chitiet.aspx?tensp=" + gr.Cells[1].Text;
                    }

                }

            }
            else
            {
                Panel2.Visible = true;
                Panel3.Visible = false;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //Download source code tại Sharecode.vn
        GridView1.PageSize = 10;
        
        if (!IsPostBack)
        {
            if (Session["GioHang"] != null)
            {
                DataTable dt = (DataTable)Session["GioHang"];
                
                if (dt.Rows.Count == 0)
                {
                    Panel2.Visible = true;
                    Panel3.Visible = false;
                }
                else
                {
                    Panel3.Visible = true;
                    tinhtien(dt);
                    Panel2.Visible = false;
                    GridView1.DataSource = dt;
                    GridView1.DataBind();                    
                    foreach (GridViewRow gr in GridView1.Rows)
                    {
                        hplThongTin = (HyperLink)gr.FindControl("hplthongtin");
                        hplThongTin.NavigateUrl = "chitiet.aspx?tensp=" + gr.Cells[1].Text;
                    }
                    
                }
                
            }
            else
            {
                Panel2.Visible = true;
                Panel3.Visible = false;
            }
        }
    }
    protected void btnmuatiep_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.aspx");
    }
    private void tinhtien(DataTable tb)
    {
        double tien = 0;
        foreach (DataRow dr in tb.Rows)
        {
            tien = tien + double.Parse(dr[4].ToString());
        }
        lbtongtien.Text = "Tổng giá trị đơn hàng: " + tien.ToString();
    }   
    protected void btnsuagiohang_Click(object sender, EventArgs e)
    {
        gh = new GioHangData();
        DataTable dt = (DataTable)Session["GioHang"];       
        foreach (GridViewRow gr in GridView1.Rows)
        {
            TextBox txtsl = (TextBox)gr.FindControl("txtsoluong");
            if (Convert.ToInt32(txtsl.Text) > 0)
                dt = gh.capNhatlai(dt, double.Parse(txtsl.Text), gr.Cells[1].Text);
            else
            {
                dt = gh.xoaDong(dt, gr.Cells[1].Text);
                if (dt.Rows.Count == 0)
                {
                    Panel2.Visible = true;
                    Panel3.Visible = false;
                }
            }
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
        tinhtien(dt);
        Session["GioHang"] = dt;
        
    }
    protected void btnguidon_Click(object sender, EventArgs e)
    {
      
        DataTable tb = new DataTable();
       
            tb.Columns.Add("TenSP");
            tb.Columns.Add("SoLuong");
            tb.Columns.Add("Gia");
            tb.Columns.Add("TongGia");
          
            foreach (GridViewRow row in GridView1.Rows)
            {
                string s = row.Cells[1].Text;
                HyperLink hp = (HyperLink)row.FindControl("hplthongtin");
                TextBox soluong = (TextBox)row.FindControl("txtsoluong");
                Label lbdongia = (Label)row.FindControl("lbdongia");
                Label lbtonggia = (Label)row.FindControl("lbtonggia");
                string sl = soluong.Text;
                string dongia = lbdongia.Text;
                string tonggia = lbtonggia.Text;
                object[] dl = new  object[4];
                dl[0] = s;
                dl[1] = sl;
                dl[2] = dongia;
                dl[3] = tonggia;               
                tb.Rows.Add(dl);
            }
            Session["hangmua"] = tb;
            Session["tong"] = lbtongtien.Text;
            Response.Redirect("kiemtragiohang.aspx");          
       
        
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        gh = new GioHangData();
        DataTable tb = (DataTable)Session["GioHang"];       
        tb = gh.xoaDong(tb, GridView1.Rows[e.RowIndex].Cells[1].Text);
        GridView1.DataSource = tb;
        GridView1.DataBind();
        Session["GioHang"] = tb;
        if (Session["GioHang"] != null)
        {
            DataTable dt = (DataTable)Session["GioHang"];
            if (dt.Rows.Count == 0)
            {
                Panel2.Visible = true;
                Panel3.Visible = false;
            }
        }        
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        nap();
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName)
        { 
            case "capnhat":
                gh = new GioHangData();
                DataTable dt = (DataTable)Session["GioHang"];
                foreach (GridViewRow gr in GridView1.Rows)
                {
                    TextBox txtsl = (TextBox)gr.FindControl("txtsoluong");
                    if (Convert.ToInt32(txtsl.Text) > 0)
                        dt = gh.capNhatlai(dt, double.Parse(txtsl.Text), gr.Cells[1].Text);
                    else
                    {
                        dt = gh.xoaDong(dt, gr.Cells[1].Text);
                        if (dt.Rows.Count == 0)
                        {
                            Panel2.Visible = true;
                            Panel3.Visible = false;
                        }
                    }
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
                tinhtien(dt);
                Session["GioHang"] = dt;
                break;
        }

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}
